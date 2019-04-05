﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest.Model
{
    public enum AIOption
    {
        /// <summary>
        ///     ''' Easy, total random shooting
        ///     ''' </summary>
        Easy,

        /// <summary>
        ///     ''' Medium, marks squares around hits
        ///     ''' </summary>
        Medium,

        /// <summary>
        ///     ''' As medium, but removes shots once it misses
        ///     ''' </summary>
        Hard
    }
}
