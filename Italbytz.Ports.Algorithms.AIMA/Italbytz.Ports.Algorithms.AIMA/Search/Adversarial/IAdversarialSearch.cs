// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

namespace Italbytz.AI.Search.Adversarial
{
    /// <summary>
    /// Variant of the search interface. Since players can only control the next
    /// move, method makeDecision returns only one action, not a
    /// sequence of actions.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface IAdversarialSearch<TState,TAction>
    {
        /// <summary>
        /// Returns the action which appears to be the best at the given state.
        /// </summary>
        /// <param name="state">Given state</param>
        /// <returns>Returned action</returns>
        public TAction MakeDecision(TState state);
        
        public IMetrics Metrics { get; }
    }
}