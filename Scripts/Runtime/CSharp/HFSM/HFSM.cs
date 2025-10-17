using System;
using UnityEngine;

namespace IUP.Toolkits.HFSM
{
    /// <summary>
    /// Иерархический конечный автомат для управления состояниями с общим контекстом.
    /// </summary>
    /// <typeparam name="TContext">Тип контекста, разделяемого между всеми состояниями.</typeparam>
    public sealed class HFSM<TContext>
    {
        private HFSM() {}

        private State<TContext> _state;
        private int _transitState;

        /// <summary>
        /// Обновляет логику активного состояния и всех его родительских состояний в порядке от родителя к потомку.
        /// </summary>
        public void Update() => Update(_state, _state);

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

        /// <summary>
        /// Создает и инициализирует новый экземпляр иерархического конечного автомата.
        /// </summary>
        /// <typeparam name="TState">Начальное состояние автомата. Не может быть наследником <see cref="Root{TContext}"/>.</typeparam>
        /// <param name="context">Контекст, разделяемый между всеми состояниями автомата.</param>
        /// <returns>Инициализированный экземпляр HFSM.</returns>
        /// <exception cref="InvalidOperationException">
        /// Если <typeparamref name="TState"/> является наследником <see cref="Root{TContext}"/>.
        /// </exception>
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
