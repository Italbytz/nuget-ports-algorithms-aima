// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using Italbytz.AI.Logic.Fol.Parsing.Ast;

namespace Italbytz.AI.Logic.Fol.Kb.Data;

/// <summary>
/// A literal is either an atomic sentence (a positive literal) or a 
/// negated atomic sentence (a negative literal). 
/// </summary>
public interface ILiteral : IEquatable<ILiteral>
{
    public bool NegativeLiteral { get; }

    public bool PositiveLiteral { get; }
    public IAtomicSentence Atom { get; }
    ILiteral GetComplementaryLiteral();
}