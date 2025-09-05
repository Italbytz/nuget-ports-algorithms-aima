// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using Italbytz.AI.Search;

namespace Italbytz.AI.Problem
{
    /// <summary>
    /// A formal problem definition.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface IProblem<TState, TAction> : IOnlineSearchProblem<TState, TAction>
    {
        /// <summary>
        /// Description of what each action does.
        /// </summary>
        Func<TState, TAction, TState> Result { get; }

        /// <summary>
        /// Tests whether a node represents an acceptable solution. The default implementation
        /// delegates the check to the goal test. Other implementations could make use of the additional
        /// information given by the node (e.g. the sequence of actions leading to the node). To compute
        /// all or the five best solutions (not just the best), tester implementations could return false
        /// and internally collect the paths of all nodes whose state passes the goal test until enough
        /// solutions have been collected.
        /// Search implementations should always access the goal test via this method to support
        /// solution acceptance testing.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        bool TestSolution(INode<TState, TAction> node);
    }
}
