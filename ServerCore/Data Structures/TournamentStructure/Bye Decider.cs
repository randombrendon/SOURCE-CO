﻿// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - ServerCore - Bye Decider.cs
// Last Edit: 2016/11/23 07:58
// Created: 2016/11/23 07:51

using System;
using System.Collections.Generic;

namespace ServerCore.TournamentStructure
{
    public class ByeDecider : EliminationDecider
    {
        public ByeDecider()
        {
            Lock();
        }

        public override bool IsDecided
        {
            get
            {
                return true;
            }
        }

        public override Contestant GetWinner()
        {
            return null;
        }

        public override Contestant GetLoser()
        {
            throw new InvalidOperationException("Cannot determine a loser from a bye entry.");
        }

        public override bool ApplyPairing(TournamentPairing pairing)
        {
            if (pairing == null)
            {
                throw new ArgumentNullException("pairing");
            }

            return false;
        }

        public override IEnumerable<TournamentPairing> FindUndecided()
        {
            yield break;
        }

        public override IEnumerable<EliminationNode> FindNodes(Func<EliminationNode, bool> filter)
        {
            yield break;
        }

        public override IEnumerable<EliminationDecider> FindDeciders(Func<EliminationDecider, bool> filter)
        {
            if (filter.Invoke(this))
            {
                yield return this;
            }
        }
    }
}
