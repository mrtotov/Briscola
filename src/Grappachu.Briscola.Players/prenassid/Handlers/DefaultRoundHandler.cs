﻿using System.Linq;
using Grappachu.Briscola.Interfaces;
using Grappachu.Briscola.Model;

namespace Grappachu.Briscola.Players.prenassid.Handlers
{
    public class DefaultRoundHandler : RoundHandler
    {
        protected override Card OnHandle(IPlayer myself, GameState state, Watcher watcher)
        {
            return myself.HandCards.First();
        }

        protected override bool OnCanHandle(IPlayer myself, GameState state)
        {
            return true;
        }
    }
}