using System;
namespace Italbytz.AI.Search
{
    /// <summary>
    /// Nodes are the data structures from which the search tree is
    /// constructed. Each has a parent, a state, and various bookkeeping fields.
    /// Arrows point from child to parent.
    ///
    /// Search algorithms require a data structure to keep track of the search tree
    /// that is being constructed. For each node n of the tree, we have a structure
    /// that contains four components:
    ///
    /// <list>
    /// <item>
    /// <term>n.STATE</term> 
    /// <description>the state in the state space to which the node corresponds;</description>
    /// </item>
    /// <item>
    /// <term>n.PARENT</term> 
    /// <description>the node in the search tree that generated this node;</description>
    /// </item>
    /// <item>
    /// <term>n.ACTION</term> 
    /// <description>the action that was applied to the parent to generate the node;</description>
    /// </item>
    /// <item>
    /// <term>n.PATH-COST</term> 
    /// <description>the cost, traditionally denoted by g(n), of the path from the initial state to the node, as indicated by the parent pointers.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public interface INode<TState, TAction>
    {
        public TState State { get; }
        public double PathCost { get; }
        public int Depth { get; }
        public TAction Action { get; }
        public INode<TState, TAction> Parent { get; }
        public bool IsRootNode();
    }
}

