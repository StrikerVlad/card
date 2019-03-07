using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Game g = new Game.Game();
            
           var p = g.StartGame();
            Console.WriteLine("Winner:");
            p.PrintInfo();
        }
    }
}
