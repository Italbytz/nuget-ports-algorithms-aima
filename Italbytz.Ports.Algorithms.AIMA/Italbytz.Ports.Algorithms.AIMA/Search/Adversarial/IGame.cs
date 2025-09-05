// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using System.Collections.Generic;

namespace Italbytz.AI.Search.Adversarial
{
    /// <summary>
    /// A game can be formally defined as a kind of search problem with the following elements:
    /// <list>
    /// <item>
    /// <term>S0</term> 
    /// <description>The initial state, which specifies how the game is set up at the start.</description>
    /// </item>
    /// <item>
    /// <term>PLAYER(s)</term> 
    /// <description>Defines which player has the move in a state.</description>
    /// </item>
    /// <item>
    /// <term>ACTIONS(s)</term> 
    /// <description>Returns the set of legal moves in a state.</description>
    /// </item>
    /// <item>
    /// <term>RESULT(s, a)</term> 
    /// <description>The transition model, which defines the result of a move.</description>
    /// </item>
    /// <item>
    /// <term>TERMINAL-TEST(s)</term> 
    /// <description>A terminal test, which is true when the game is over and false TERMINAL STATES otherwise. States where the game has ended are called terminal states.</description>
    /// </item>
    /// <item>
    /// <term>UTILITY(s, p)</term> 
    /// <description>A utility function (also called an objective function or payoff function), defines the final numeric value for a game that ends in terminal state s for a player p.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <typeparam name="TState">Type which is used for states in the game.</typeparam>
    /// <typeparam name="TAction">Type which is used for actions in the game.</typeparam>
    /// <typeparam name="TPlayer">Type which is used for players in the game.</typeparam>
    public interface IGame<TState, TAction,TPlayer>
    {
        public TState InitialState { get; }
        public TPlayer[] Players { get; }
        
        public Func<TState, TPlayer> Player { get; }
        public Func<TState, List<TAction>> Actions { get; }
        public Func<TState, TAction, TState> Result { get; }
        public Func<TState, bool> Terminal { get; }
        public Func<TState, TPlayer, double> Utility { get; }
    }
}
