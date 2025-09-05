// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;

namespace Italbytz.AI.Learning;


/// <summary>
/// Represents a dataset containing examples for machine learning algorithms.
/// </summary>
public interface IDataSet : IEnumerable<IExample>
{
    /// <summary>
    /// Gets the list of examples in the dataset.
    /// </summary>
    public List<IExample> Examples { get; }

    /// <summary>
    /// Gets or sets the specification for this dataset.
    /// </summary>
    public IDataSetSpecification Specification { get; set; }

    /// <summary>
    /// Gets all attribute names in the dataset except for the target attribute.
    /// </summary>
    /// <returns>An enumerable collection of non-target attribute names.</returns>
    IEnumerable<string> GetNonTargetAttributes();

    /// <summary>
    /// Gets all possible values for a specific attribute in the dataset.
    /// </summary>
    /// <param name="attributeName">The name of the attribute to get values for.</param>
    /// <returns>An enumerable collection of possible values for the specified attribute.</returns>
    IEnumerable<string> GetPossibleAttributeValues(string attributeName);

    /// <summary>
    /// Creates a new empty dataset with the same specification as this dataset.
    /// </summary>
    /// <returns>An empty dataset.</returns>
    IDataSet EmptyDataSet();

    /// <summary>
    /// Calculates the information gain for a specific attribute.
    /// </summary>
    /// <param name="parameterName">The name of the attribute to calculate gain for.</param>
    /// <returns>The information gain value for the specified attribute.</returns>
    double CalculateGainFor(string parameterName);

    /// <summary>
    /// Creates a subset of this dataset where the specified attribute has the given value.
    /// </summary>
    /// <param name="attributeName">The attribute name to match on.</param>
    /// <param name="attributeValue">The attribute value to match.</param>
    /// <returns>A dataset containing only examples where the specified attribute matches the given value.</returns>
    IDataSet MatchingDataSet(string attributeName, string attributeValue);

    /// <summary>
    /// Calculates the information content (entropy) of the dataset.
    /// </summary>
    /// <returns>The information/entropy value of the dataset.</returns>
    public double GetInformationFor();
}