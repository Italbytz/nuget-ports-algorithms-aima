// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using Italbytz.AI.Problem;

namespace Italbytz.AI.Search
{
    /// <summary>
    /// Interface for all search algorithms which forget the exploration history and
    /// return just a single state which is hopefully a goal state.This search framework expects
    /// all search algorithms to provide some metrics and to actually explore the search space
    /// by expanding nodes.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface ISearchForStates<TState, TAction>
    {
        /// <summary>
        /// Returns a state which might be, but not necessarily is a goal state of
        /// the problem, or empty.
        /// </summary>
        /// <param name="problem">the search problem</param>
        /// <returns>a state or empty.</returns>
        public TState? FindState(IProblem<TState, TAction> problem);
    }
}

