
namespace Italbytz.AI.Learning.Inductive;

/// <summary>
/// Represents a parameterized machine learning algorithm that can be trained on data.
/// </summary>
public interface IParameterizedLearner : ILearner
{
    /// <summary>
    /// Gets or sets the size of the parameter for the learning algorithm.
    /// </summary>
    public int ParameterSize { get; set; }
    
    /// <summary>
    /// Trains the learning algorithm on the provided dataset with a specified parameter size.
    /// </summary>
    /// <param name="size">The size to use for parameterization during training.</param>
    /// <param name="dataSet">The dataset to train the algorithm on.</param>
    public void Train(int size, IDataSet dataSet);
}