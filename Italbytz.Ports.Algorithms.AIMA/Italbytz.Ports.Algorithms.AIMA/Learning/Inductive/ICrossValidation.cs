namespace Italbytz.AI.Learning.Inductive;

/// <summary>
///     Interface for performing cross-validation on a parameterized learner.
/// </summary>
public interface ICrossValidation
{
    /// <summary>
    ///     Wraps a parameterized learner with cross-validation logic.
    /// </summary>
    /// <param name="learner">The parameterized learner to be wrapped.</param>
    /// <param name="k">The number of folds for cross-validation.</param>
    /// <param name="examples">The dataset to be used for cross-validation.</param>
    /// <returns>A parameterized learner with cross-validation applied.</returns>
    public IParameterizedLearner CrossValidationWrapper(
        IParameterizedLearner learner, int k,
        IDataSet examples);
}