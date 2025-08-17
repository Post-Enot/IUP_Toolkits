using System;
using UnityEngine;

namespace IUP.Toolkits.HFSM
{
    public sealed class HFSM<TContext>
    {
        private State<TContext> _state;
        private int _transitState;

        public void Update() => Update(_state, _state);
        
        private void Update(State<TContext> activeState, State<TContext> updatedState)
        {
            if (updatedState.Parent is not Root<TContext>)
            {
                Update(activeState, updatedState.Parent);
            }
            if (_state == activeState)
            {
                updatedState.OnUpdate();
            }
        }

        internal void SetState(State<TContext> state)
        {
            _transitState += 1;
            #if UNITY_EDITOR
            if (_transitState == -1)
            {
                throw new InvalidOperationException(
                    $"switching in the {nameof(State<TContext>.OnEnter)} and " +
                    $"{nameof(State<TContext>.OnExit)} methods is prohibited: " +
                    $"use {nameof(State<TContext>.DelegateTransit)} instead.");
            }
            if (_transitState == int.MaxValue)
            {
                throw new InvalidOperationException($"FSM infinite loop detected. " +
                    $"{_state} -> {state}");
            }
            #endif
            if (_state == state)
            {
                return;
            }
            try
            {
                int transitCount = _transitState;
                state.DelegateTransit();
                if (_transitState != transitCount)
                {
                    return;
                }
                State<TContext> lca = FSM_Utility.LCA(_state, state);
                _transitState = -1;
                FSM_Utility.ExitLCA(_state, lca);
                _state = state;
                FSM_Utility.EnterLCA(_state, lca);
                _transitState = 0;
            }
            catch (InvalidOperationException exception)
            {
                Debug.LogException(exception);
            }
        }

        public static HFSM<TContext> Instantiate<TState>(TContext context)
            where TState : State<TContext>, new()
        {
            if (typeof(TState) == typeof(Root<TContext>))
            {
                throw new InvalidOperationException();
            }
            HFSM<TContext> fsm = new();
            StateController<TContext> stateController = new(context, fsm);
            fsm._state = State<TContext>.Instantiate<TState>(context, stateController);
            FSM_Utility.EnterRoot(fsm._state);
            fsm._state.DelegateTransit();
            return fsm;
        }
    }
}
