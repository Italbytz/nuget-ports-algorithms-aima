// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;
using Italbytz.AI.Logic.Fol.Kb.Data;

namespace Italbytz.AI.Logic.Planning;

/// <summary>
/// A set of action schemas serves as a definition of a planning domain. A 
/// specific problem within the domain is defined with the addition of an 
/// initial state and a goal. The initial state is a conjunction of ground 
/// atoms.
/// The goal is just like a precondition: a conjunction of literals 
/// (positive or negative) that may contain variables, such as 
/// At(p, SFO) ∧ Plane(p). Any variables are treated as existentially 
/// quantified, so this goal is to have any plane at SFO. The problem is solved 
/// when we can find a sequence of actions that end in a state s that entails 
/// the goal.
/// </summary>
public interface IPlanningProblem
{
    public IList<ILiteral> Goal { get; }
    public IState InitialState { get; }
    IEnumerable<IActionSchema> GetPropositionalisedActions();
}