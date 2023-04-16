﻿// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - ServerCore - Pk Modes Type.cs
// Last Edit: 2016/11/23 07:57
// Created: 2016/11/23 07:50
namespace ServerCore.Common.Enums
{
    /// <summary>
    /// This enumeration type defines the possible PK modes for a character in Conquer Online, defined by the
    /// client GUI.
    /// </summary>
    public enum PkModeType : byte
    {
        PK_MODE = 0,
        CAPTURE = 3,
        PEACE = 1,
        TEAM = 2
    }
}
