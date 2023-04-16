﻿// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - ServerCore - Contestant.cs
// Last Edit: 2016/11/23 07:58
// Created: 2016/11/23 07:51

using System.Diagnostics;

namespace ServerCore.TournamentStructure
{
    [DebuggerDisplay("[Team {this.TeamId} @ {this.Rating}]")]
    public sealed class Contestant
    {
        private readonly uint m_dwIdentity;

        public Contestant(uint idCont, int? rating)
        {
            m_dwIdentity = idCont;
            Rating = rating;
        }

        public uint Identity { get { return m_dwIdentity; } }

        public int? Rating { get; set; }
    }
}