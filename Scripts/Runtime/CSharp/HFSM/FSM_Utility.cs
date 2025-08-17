using System;

namespace IUP.Toolkits.HFSM
{
    internal static class FSM_Utility
    {
        internal static void EnterLCA<TContext>(State<TContext> to, State<TContext> lca)
        {
            if (to.Parent != lca)
            {
                EnterLCA(to.Parent, lca);
            }
            to.OnEnter();
        }

        internal static void EnterRoot<TContext>(State<TContext> to)
        {
            if (to.Parent is not Root<TContext>)
            {
                EnterRoot(to.Parent);
            }
            to.OnEnter();
        }

        internal static void ExitLCA<TContext>(State<TContext> from, State<TContext> lca)
        {
            do
            {
                from.OnExit();
                from = from.Parent;
            }
            while (from != lca);
        }

        internal static State<TContext> LCA<TContext>(State<TContext> a, State<TContext> b)
        {
            #if UNITY_EDITOR
            int iterCount = 0;
            #endif
            State<TContext> ptrA = a;
            State<TContext> ptrB = b;
            while (ptrA != ptrB)
            {
                ptrA = ptrA is Root<TContext> ? b : ptrA.Parent;
                ptrB = ptrB is Root<TContext> ? a : ptrB.Parent;
                #if UNITY_EDITOR
                iterCount += 1;
                if (iterCount == int.MaxValue)
                {
                    throw new InvalidOperationException($"FSM infinite loop detected. {a} -> {b}");
                }
                #endif
            }
            return ptrA;
        }
    }
}
