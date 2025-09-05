// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;

namespace Italbytz.AI.Search.Local
{
    /// <summary>
    /// A state in a genetic algorithm is represented as an individual from the
    /// population.
    /// </summary>
    /// <typeparam name="TAlphabet">the type of the alphabet used in the representation of the individuals in the population (this is to provide flexibility in terms of how a problem can be encoded)</typeparam>
    public interface IIndividual<TAlphabet>
    {
        public List<TAlphabet> Representation { get; }
        public int Descendants { get; set; }
    }
}