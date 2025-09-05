namespace Italbytz.AI.Search.Continuous
{
    public interface ILPSolution
    {
        public double Objective { get; set; }
        public double[] Solution { get; set; }
    }
}