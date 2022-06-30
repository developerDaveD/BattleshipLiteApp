﻿using System;
namespace BattleshipLiteLibrary.Models
{
    // 0 = placed, 1 = ship, 2 = miss, 3 = hit, 4 = sunk
    public enum GridSpotStatus
    {
        Empty,
        Ship,
        Miss,
        Hit,
        Sunk
    }

}

