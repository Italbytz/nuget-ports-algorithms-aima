// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using System.Collections.Generic;
using Italbytz.AI.Logic.Fol.Kb.Data;
using Italbytz.AI.Logic.Fol.Parsing.Ast;

namespace Italbytz.AI.Logic.Planning;

/// <summary>
/// Actions are described by a set of action schemas that implicitly define the 
/// ACTIONS (s) and RESULT (s, a) functions needed to do a problem-solving 
/// search.
/// The schema consists of the action name, a list of all the variables used in the schema, a precondition and an effect.
/// </summary>
public interface IActionSchema : IEquatable<IActionSchema>
{
    public List<ITerm> Variables { get; }
    public IList<ILiteral> Precondition { get; }

    public IList<ILiteral> Effect { get; }

    public string Name { get; }
}