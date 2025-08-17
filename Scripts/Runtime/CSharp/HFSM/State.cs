namespace IUP.Toolkits.HFSM
{
    public abstract class State<TContext>
    {
        public TContext Context { get; private set; }

        internal virtual State<TContext> Parent => _stateController.GetState<Root<TContext>>();

        internal StateController<TContext> _stateController;

        /// <summary>
        /// Вызывается единожды после инициализации контекста, но до первого вызова 
        /// метода <see cref="OnEnter"/>. Недопустимо осуществлять переходы в данном методе;
        /// используйте <see cref="DelegateTransit"/>.
        /// </summary>
        protected virtual void OnInit() {}

        /// <summary>
        /// Вызывается каждый раз при явном переходе в данное состояние до вызова 
        /// <see cref="OnEnter"/>.
        /// </summary>
        public virtual void DelegateTransit() {}

        /// <summary>
        /// Вызывается при входе в данное состояние. Недопустимо осуществлять переходы в данном 
        /// методе; используйте <see cref="DelegateTransit"/>.
        /// </summary>
        public virtual void OnEnter() {}

        /// <summary>
        /// Вызывается при выходе из данного состояния. Недопустимо осуществлять переходы в данном
        /// методе; используйте <see cref="DelegateTransit"/>
        /// </summary>
        public virtual void OnExit() {}

        /// <summary>
        /// Вызывается для каждого активного состояния каждый тик. Допустимо осуществлять переходы
        /// в данном методе.
        /// </summary>
        public virtual void OnUpdate() {}

        /// <summary>
        /// Немедленный переход в состояние <typeparamref name="TState"/>.
        /// </summary>
        /// <typeparam name="TState">Тип состояния, в который осуществляется переход.</typeparam>
        public void SetState<TState>() where TState : State<TContext>, new()
            => _stateController.SetState<TState>();

        internal static State<TContext> Instantiate<TState>(
            TContext context,
            StateController<TContext> stateController) where TState : State<TContext>, new()
        {
            TState state = new()
            {
                Context = context,
            };
            state.OnInit();
            state._stateController = stateController;
            return state;
        }
    }
}
