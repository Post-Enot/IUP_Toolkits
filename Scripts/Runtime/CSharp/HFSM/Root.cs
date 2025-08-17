using System;

namespace IUP.Toolkits.HFSM
{
    public sealed class Root<TContext> : State<TContext>
    {
        public override void OnEnter() => throw new InvalidOperationException();

        public override void OnUpdate() => throw new InvalidOperationException();

        public override void OnExit() => throw new InvalidOperationException();
    }
}
