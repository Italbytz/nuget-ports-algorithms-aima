namespace Italbytz.AI.Search.Continuous
{
    public enum ConstraintType
    {
        /// <summary>Free. A free constraint will act as if the constraint is not there. The lower bound is -Infinity and the upper bound is +Infinity.
        /// This can be used to temporary disable a constraint without having to delete it from the model. Note that the already set RHS and range on this constraint is overruled with Infinity by this.</summary>
        FR = 0,
        /// <summary>Less than or equal (&lt;=)</summary>
        LE = 1,
        /// <summary>Greater than or equal (&gt;=)</summary>
        GE = 2,
        /// <summary>Equal (=)</summary>
        EQ = 3,
        /// <summary>Objective Function. This is not an operator to use but a marker for the function to optimize.</summary>
        OF = 4,
    }
}