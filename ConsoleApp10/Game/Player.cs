using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Game
{
    public class Player
    {
        public Player()
        {
            pKarts = new Stack<Kart>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public Stack<Kart> pKarts;

        public void PrintInfo()
        {
            Console.WriteLine("-> {0}", Name);
        }
    }
}
