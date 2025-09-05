using System;
using System.Collections.Generic;
using Italbytz.AI.Problem;

namespace Italbytz.AI.Search
{
    /// <summary>
    /// Implementations of this interface are responsible for node creation and successor generation. They
    /// compute path costs, and support progress tracking.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">Type which is used to represent actions</typeparam>
    public interface INodeFactory<TState, TAction>
    {
        /// <summary>
        /// Factory method, which computes the path cost for getting from
        /// the initial state via the parent node state to the specified
        /// state, creates a new node for the specified state,
        /// adds it as child of the provided parent, and returns it.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public INode<TState, TAction> CreateNode(TState state);

        /// <summary>
        /// Returns the children obtained from expanding the specified node in the specified problem.
        /// </summary>
        /// <param name="node">the node to expand</param>
        /// <param name="problem">the problem the specified node is within.</param>
        /// <returns>the children obtained from expanding the specified node in the specified problem.</returns>
        public List<INode<TState, TAction>> GetSuccessors(INode<TState, TAction> node, IProblem<TState, TAction> problem);

        public bool UseParentLinks { get; set; }

        /// <summary>
        /// Adds a listener to the list of node listeners. It is informed whenever a
        /// node is expanded during search.
        /// </summary>
        /// <param name="listener"></param>
        public void AddNodeListener(Action<INode<TState, TAction>> listener);

    }
}

