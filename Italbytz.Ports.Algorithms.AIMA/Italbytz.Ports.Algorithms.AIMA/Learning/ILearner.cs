// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

namespace Italbytz.AI.Learning;

/// <summary>
/// Represents a machine learning algorithm that can train on a dataset,
/// make predictions on examples or datasets, and evaluate its performance.
/// </summary>
/// <remarks>
/// ILearner is the core interface for supervised learning algorithms.
/// Implementations of this interface should be able to:
/// - Train on a labeled dataset
/// - Predict outcomes for new examples
/// - Evaluate prediction accuracy on test data
/// </remarks>
public interface ILearner
{
    void Train(IDataSet ds);
    /// <summary>
    /// Returns the outcome predicted for the specified data set
    /// </summary>
    /// <param name="ds">a data set</param>
    /// <returns>the outcome predicted for the specified data set</returns>
    string[] Predict(IDataSet ds);
    /// <summary>
    /// Returns the outcome predicted for the specified example
    /// </summary>
    /// <param name="e">an example</param>
    /// <returns>the outcome predicted for the specified example</returns>
    string Predict(IExample e);
    /// <summary>
    /// Returns the accuracy of the hypothesis on the specified set of examples
    /// </summary>
    /// <param name="ds">the test data set.</param>
    /// <returns>the accuracy of the hypothesis on the specified set of examples</returns>
    int[] Test(IDataSet ds);
}