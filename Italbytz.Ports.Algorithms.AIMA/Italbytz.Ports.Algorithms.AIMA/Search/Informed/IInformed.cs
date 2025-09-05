// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;

namespace Italbytz.AI.Search.Informed
{
    /// <summary>
    /// Search algorithms which make use of heuristics to guide the search
    /// are expected to implement this interface.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public interface IInformed<TState, TAction>
    {
        public Func<INode<TState, TAction>, double> HeuristicFn { get; set; }
    }
}