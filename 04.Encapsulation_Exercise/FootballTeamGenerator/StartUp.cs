﻿using FootballTeamGenerator.Core;
using System;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}
