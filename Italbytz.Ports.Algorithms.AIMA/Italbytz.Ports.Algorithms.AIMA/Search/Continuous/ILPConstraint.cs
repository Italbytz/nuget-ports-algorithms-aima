namespace Italbytz.AI.Search.Continuous
{
    public interface ILPConstraint
    {
        public double[] Coefficients { get; set; }
        public ConstraintType ConstraintType { get; set; }
        public double RHS { get; set; }
    }
}