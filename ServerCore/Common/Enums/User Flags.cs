﻿// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - ServerCore - User Flags.cs
// Last Edit: 2016/11/23 07:57
// Created: 2016/11/23 07:50

using System;

namespace Core.Common.Enums
{
    [Flags]
    public enum Effect0 : ulong
    {
        NONE = 0UL,
        BLUE_NAME = 1UL << 0,
        POISONED = 1UL << 1,
        FULL_INVIS = 1UL << 2,
        FADE = 1UL << 3,
        START_XP = 1UL << 4,
        GHOST = 1UL << 5,
        TEAM_LEADER = 1UL << 6,
        STAR_OF_ACCURACY = 1UL << 7,
        SHIELD = 1UL << 8,
        STIG = 1UL << 9,
        DEAD = 1UL << 10,
        INVISIBLE = 1UL << 11,
        UNKNOWN12 = 1UL << 12,
        UNKNOWN13 = 1UL << 13,
        RED_NAME = 1UL << 14,
        BLACK_NAME = 1UL << 15,
        UNKNOWN16 = 1UL << 16,
        UNKNOWN17 = 1UL << 17,
        SUPERMAN = 1UL << 18,
        REFLECTTYPE_THING = 1UL << 19,
        DIF_REFLECT_THING = 1UL << 20,
        UNKNOWN21 = 1UL << 21,
        PARTIALLY_INVISIBLE = 1UL << 22,
        CYCLONE = 1UL << 23,
        UNKNOWN24 = 1UL << 24,
        UNKNOWN25 = 1UL << 25,
        UNKNOWN26 = 1UL << 26,
        FLY = 1UL << 27,
        UNKNOWN28 = 1UL << 28,
        UNKNOWN29 = 1UL << 29,
        LUCKY_TIME = 1UL << 30,
        PRAY = 1UL << 31,
        CURSED = 1UL << 32,
        HEAVEN_BLESS = 1UL << 33,
        TOP_GUILD = 1UL << 34,
        TOP_DEP = 1UL << 35,
        MONTH_PK = 1UL << 36,
        WEEK_PK = 1UL << 37,
        TOP_WARRIOR = 1UL << 38,
        TOP_TRO = 1UL << 39,
        TOP_ARCHER = 1UL << 40,
        TOP_WATER = 1UL << 41,
        TOP_FIRE = 1UL << 42,
        TOP_NINJA = 1UL << 43,
        UNKNOWN44 = 1UL << 44,
        POISON_STAR = 1UL << 45,
        VORTEX = 1UL << 46,
        FATAL_STRIKE = 1UL << 47,
        ORANGE_HALO_GLOW = 1UL << 48,
        UNKNOWN49 = 1UL << 49,
        LOW_VIGOR_UNABLE_TO_JUMP = 1UL << 50,
        RIDING = 1UL << 50,
        TOP_SPOUSE = 1UL << 51,
        SPARKLE_HALO = 1UL << 52,
        NO_POTION = 1UL << 53,
        DAZED = 1UL << 54,
        BLUE_RESTORE_AURA = 1UL << 55,
        MOVE_SPEED_RECOVERED = 1UL << 56,
        SUPER_SHIELD_HALO = 1UL << 57,
        HUGE_DAZED = 1UL << 58,
        ICE_BLOCK = 1UL << 59,
        CONFUSED = 1UL << 60,
        UNKNOWN61 = 1UL << 61,
        UNKNOWN62 = 1UL << 62,
        UNKNOWN63 = 1UL << 63
    }

    public enum Effect1 : ulong
    {
        NONE = 0UL,
        WEEKLY_TOP8_PK = 1UL << 0,
        WEEKLY_TOP2_PK_GOLD = 1UL << 1,
        WEEKLY_TOP2_PK_BLUE = 1UL << 2,
        MONTHLY_TOP8_PK = 1UL << 3,
        MONTLY_TOP2_PK = 1UL << 4,
        MONTLY_TOP3_PK = 1UL << 5,
        TOP8_FIRE = 1UL << 6,
        TOP2_FIRE = 1UL << 7,
        TOP3_FIRE = 1UL << 8,
        TOP8_WATER = 1UL << 9,
        TOP2_WATER = 1UL << 10,
        TOP3_WATER = 1UL << 11,
        TOP8_NINJA = 1UL << 12,
        TOP2_NINJA = 1UL << 13,
        TOP3_NINJA = 1UL << 14,
        TOP8_WARRIOR = 1UL << 15,
        TOP2_WARRIOR = 1UL << 16,
        TOP3_WARRIOR = 1UL << 17,
        TOP8_TROJAN = 1UL << 18,
        TOP2_TROJAN = 1UL << 19,
        TOP3_TROJAN = 1UL << 20,
        TOP8_ARCHER = 1UL << 21,
        TOP2_ARCHER = 1UL << 22,
        TOP3_ARCHER = 1UL << 23,
        TOP3_SPOUSE_BLUE = 1UL << 24,
        TOP2_SPOUSE_BLUE = 1UL << 25,
        TOP3_SPOUSE_YELLOW = 1UL << 26,
        CONTESTANT = 1UL << 27,
        CHAIN_BOLT_ACTIVE = 1UL << 28,
        AZURE_SHIELD = 1UL << 29,
        AZURE_SHIELD_FADE = 1UL << 30,
        CARYING_FLAG = 1UL << 31,
        UNKNOWN32 = 1UL << 32,
        UNKNOWN33 = 1UL << 33,
        TYRANT_AURA = 1UL << 34,
        UNKNOWN35 = 1UL << 35,
        FEND_AURA = 1UL << 36,
        UNKNOWN37 = 1UL << 37,
        METAL_AURA = 1UL << 38,
        UNKNOWN39 = 1UL << 39,
        WOOD_AURA = 1UL << 40,
        UNKNOWN41 = 1UL << 41,
        WATER_AURA = 1UL << 42,
        UNKNOWN43 = 1UL << 43,
        FIRE_AURA = 1UL << 44,
        UNKNOWN45 = 1UL << 45,
        EARTH_AURA = 1UL << 46,
        SHACKLED = 1UL << 47,
        OBLIVION = 1UL << 48,
        UNKNOWN49 = 1UL << 49,
        TOP_MONK = 1UL << 50,
        TOP8_MONK = 1UL << 51,
        TOP2_MONK = 1UL << 52,
        TOP3_MONK = 1UL << 53,
        UNKNOWN54 = 1UL << 54,
        UNKNOWN55 = 1UL << 55,
        UNKNOWN56 = 1UL << 56,
        UNKNOWN57 = 1UL << 57,
        UNKNOWN58 = 1UL << 58,
        UNKNOWN59 = 1UL << 59,
        UNKNOWN60 = 1UL << 60,
        UNKNOWN61 = 1UL << 61,
        UNKNOWN62 = 1UL << 62,
        UNKNOWN63 = 1UL << 63
    }

    public class FlagInt
    {
        public const int NONE = 0,
            BLUE_NAME = 1,
            POISONED = 2,
            FULL_INVIS = 3,
            FADE = 4,
            START_XP = 5,
            GHOST = 6,
            TEAM_LEADER = 7,
            STAR_OF_ACCURACY = 8,
            SHIELD = 9,
            STIG = 10,
            DEAD = 11,
            INVISIBLE = 12,
            UNKNOWN13 = 13,
            UNKNOWN14 = 14,
            RED_NAME = 15,
            BLACK_NAME = 16,
            UNKNOWN17 = 17,
            UNKNOWN18 = 18,
            SUPERMAN = 19,
            REFLECTTYPE_THING = 20,
            DIF_REFLECT_THING = 21,
            UNKNOWN22 = 22,
            PARTIALLY_INVISIBLE = 23,
            CYCLONE = 24,
            UNKNOWN25 = 25,
            UNKNOWN26 = 26,
            DODGE = 27,
            FLY = 28,
            INTENSIFY = 29,
            UNKNOWN30 = 30,
            LUCKY_DIFFUSE = 31,
            LUCKY_ABSORB = 32,
            CURSED = 33,
            HEAVEN_BLESS = 34,
            TOP_GUILD = 35,
            TOP_DEP = 36,
            MONTH_PK = 37,
            WEEK_PK = 38,
            TOP_WARRIOR = 39,
            TOP_TRO = 40,
            TOP_ARCHER = 41,
            TOP_WATER = 42,
            TOP_FIRE = 43,
            TOP_NINJA = 44,
            POISON_STAR = 45,
            TOXIC_FOG = 46,
            VORTEX = 47,
            FATAL_STRIKE = 48,
            ORANGE_HALO_GLOW = 49,
            UNKNOWN50 = 50,
            LOW_VIGOR_UNABLE_TO_JUMP = 51,
            RIDING = 51,
            TOP_SPOUSE = 52,
            SPARKLE_HALO = 53,
            NO_POTION = 54,
            DAZED = 55,
            BLUE_RESTORE_AURA = 56,
            MOVE_SPEED_RECOVERED = 57,
            SUPER_SHIELD_HALO = 58,
            HUGE_DAZED = 59,
            ICE_BLOCK = 60,
            CONFUSED = 61,
            UNKNOWN62 = 62,
            UNKNOWN63 = 63,
            UNKNOWN64 = 64,
            WEEKLY_TOP8_PK = 65,
            WEEKLY_TOP2_PK_GOLD = 66,
            WEEKLY_TOP2_PK_BLUE = 67,
            MONTHLY_TOP8_PK = 68,
            MONTLY_TOP2_PK = 69,
            MONTLY_TOP3_PK = 70,
            TOP8_FIRE = 71,
            TOP2_FIRE = 72,
            TOP3_FIRE = 73,
            TOP8_WATER = 74,
            TOP2_WATER = 75,
            TOP3_WATER = 76,
            TOP8_NINJA = 77,
            TOP2_NINJA = 78,
            TOP3_NINJA = 79,
            TOP8_WARRIOR = 80,
            TOP2_WARRIOR = 81,
            TOP3_WARRIOR = 82,
            TOP8_TROJAN = 83,
            TOP2_TROJAN = 84,
            TOP3_TROJAN = 85,
            TOP8_ARCHER = 86,
            TOP2_ARCHER = 87,
            TOP3_ARCHER = 88,
            TOP3_SPOUSE_BLUE = 89,
            TOP2_SPOUSE_BLUE = 90,
            TOP3_SPOUSE_YELLOW = 91,
            CONTESTANT = 92,
            CHAIN_BOLT_ACTIVE = 93,
            AZURE_SHIELD = 94,
            AZURE_SHIELD_FADE = 95,
            CARYING_FLAG = 96,
            UNKNOWN97 = 97,
            UNKNOWN98 = 98,
            TYRANT_AURA = 99,
            UNKNOWN100 = 100,
            FEND_AURA = 101,
            UNKNOWN102 = 102,
            METAL_AURA = 103,
            UNKNOWN104 = 104,
            WOOD_AURA = 105,
            UNKNOWN106 = 106,
            WATER_AURA = 107,
            UNKNOWN108 = 108,
            FIRE_AURA = 109,
            UNKNOWN110 = 110,
            EARTH_AURA = 111,
            SHACKLED = 112,
            OBLIVION = 113,
            UNKNOWN114 = 114,
            TOP_MONK = 115,
            TOP8_MONK = 116,
            TOP2_MONK = 117,
            TOP3_MONK = 118,
            CTF_FLAG = 119,
            UNKNOWN120 = 120,
            UNKNOWN121 = 121,
            UNKNOWN122 = 122,
            UNKNOWN123 = 123,
            UNKNOWN124 = 124,
            UNKNOWN125 = 125,
            UNKNOWN126 = 126,
            UNKNOWN127 = 127,
            UNKNOWN128 = 128;
    }
}