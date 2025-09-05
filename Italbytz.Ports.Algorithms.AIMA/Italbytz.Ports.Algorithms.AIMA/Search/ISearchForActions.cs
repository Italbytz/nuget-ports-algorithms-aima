// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using System.Collections.Generic;
using Italbytz.AI.Problem;

namespace Italbytz.AI.Search
{
    /// <summary>
    /// Interface for all search algorithms which store at least a part of the
    /// exploration history as search tree and return a list of actions leading from
    /// the initial state to a goal state.This search framework expects all search
    /// algorithms to provide some metrics and to actually explore the search space
    /// by expanding nodes.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface ISearchForActions<TState, TAction>
    {
        public IMetrics Metrics { get; }

        /// <summary>
        /// Returns a list of actions leading to a goal state if a goal was found,
        /// otherwise empty.Note that the list can be empty which means that the
        /// initial state is a goal state.
        /// </summary>
        /// <param name="problem">the search problem</param>
        /// <returns>a (possibly empty) list of actions or empty</returns>
        public IEnumerable<TAction>? FindActions(IProblem<TState, TAction> problem);

    }
}

