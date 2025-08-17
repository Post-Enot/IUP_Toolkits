namespace IUP.Toolkits.HFSM
{
    public abstract class State<TContext, TParentState> : State<TContext>
        where TParentState : State<TContext>, new()
    {
        internal sealed override State<TContext> Parent
            => _stateController.GetState<TParentState>();
    }
}
