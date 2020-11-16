﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex02
{
    /** This class is responsible for creating a new game and calling the runGame method*/
    public class Program
    {
        public static void Main(String[] args)
        {
            BullsAndCowsGame game = new BullsAndCowsGame();
            game.RunGame();

            Console.Write("Please enter to exit..");
            Console.Read();
            
        }
    }
}
