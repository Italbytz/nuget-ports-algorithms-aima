namespace Italbytz.AI.Search.CSP.Solver;

public interface ICspSolver<TVar,TVal> where TVar : IVariable
{
    public IAssignment<TVar,TVal>? Solve(ICSP<TVar,TVal> csp);
}