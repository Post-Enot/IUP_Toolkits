using System;
using System.Collections.Generic;

namespace IUP.Toolkits.HFSM
{
    internal sealed class StateController<TContext>
    {
        internal StateController(TContext context, HFSM<TContext> fsm)
        {
            _context = context;
            _fsm = fsm;
        }

        private readonly Dictionary<Type, State<TContext>> _states = new();
        private readonly HFSM<TContext> _fsm;
        private readonly TContext _context;

        internal State<TContext> GetState<TState>() where TState : State<TContext>, new()
        {
            Type type = typeof(TState);
            if (!_states.TryGetValue(type, out State<TContext> state))
            {
                state = State<TContext>.Instantiate<TState>(_context, this);
                _states.Add(type, state);
            }
            return state;
        }

        internal void SetState<TState>() where TState : State<TContext>, new()
        {
            State<TContext> state = GetState<TState>();
            _fsm.SetState(state);
        }
    }
}
