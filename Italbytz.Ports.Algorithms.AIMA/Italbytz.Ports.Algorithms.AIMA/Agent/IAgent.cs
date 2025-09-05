// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

namespace Italbytz.AI.Agent
{
    /// <summary>
    /// Agents interact with environments through sensors and actuators.
    /// </summary>
    /// <typeparam name="TPercept">Type which is used to represent percepts</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public interface IAgent<in TPercept, out TAction>
    {
        /// <summary>
        /// Life-cycle indicator as to the liveness of an Agent.
        /// </summary>
        public bool Alive { get; }
        
        /// <summary>
        /// Call the Agent's program, which maps any given percept sequences to an
        /// action.
        /// </summary>
        /// <param name="percept">The current percept of a sequence perceived by the Agent.</param>
        /// <returns>The Action to be taken in response to the currently perceived percept. Empty replaces NoOp in earlier implementations.</returns>
        TAction? Act(TPercept? percept);
    }
}

