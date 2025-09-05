// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using System.Collections.Generic;

namespace Italbytz.AI.Problem
{
    /// <summary>
    /// An online search problem.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface IOnlineSearchProblem<TState, TAction>
    {
        /// <summary>
        /// The initial state of the agent.
        /// </summary>
        public TState InitialState { get; }
        
        /// <summary>
        /// The description of the possible actions available to the agent
        /// </summary>
        public Func<TState, List<TAction>> Actions { get; }
        
        /// <summary>
        /// Determines whether a given state is a goal state.
        /// </summary>
        public Func<TState, bool> GoalTest { get; }
        
        /// <summary>
        /// The step cost of taking a given action in an given state to reach a given state.
        /// </summary>
        public Func<TState, TAction, TState, double> StepCosts { get; }

    }
}

