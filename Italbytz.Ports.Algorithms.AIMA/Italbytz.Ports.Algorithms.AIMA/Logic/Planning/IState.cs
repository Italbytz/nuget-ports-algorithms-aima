// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;
using Italbytz.AI.Logic.Fol.Kb.Data;

namespace Italbytz.AI.Logic.Planning;

/// <summary>
/// Each state is represented as a conjunction of fluents that are ground, functionless atoms.
/// For example, Poor ∧ Unknown might represent the state of a hapless agent, 
/// and a state in a package delivery problem might be 
/// At(Truck1 , Melbourne) ∧ At(Truck2 , Sydney).
/// </summary>
public interface IState
{
    public IList<ILiteral> Fluents { get; }
    /// <summary>
    /// Returns the state obtained by the application of an applicable action to
    /// the current state.
    /// </summary>
    /// <param name="actions">The applicable action.</param>
    /// <returns>The new state.</returns>
    IState Result(List<IActionSchema> actions);
    public bool IsApplicable(IActionSchema action);
}