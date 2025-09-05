namespace Italbytz.AI.Search.Continuous
{
    public interface ILPSolver
    {
        public ILPSolution Solve(ILPModel model);
        public ILPSolution Solve(string model, LPFileFormat format);
        public ILPSolution SolveFile(string filename, LPFileFormat format);
    }
}