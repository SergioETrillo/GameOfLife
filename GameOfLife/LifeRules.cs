﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class LifeRules
    {
        public static bool CellSurvives(int num, bool state = false)
        {
            return num == 3;
        }
    }
}
