using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Game
{
    public enum mast { chervi, kresti, bubi, piki}
    public enum nominal { six=6, seven=7, eight=8, nine=9, ten=10, valet=11, dama=12, korol=13, tuz=14}
    public class Kart
    {
        public mast Mast { get; set; }
        public nominal Nominal { get; set; }
        public void PrintInfo()
        {
            Console.Write("{0} {1}\t", Nominal, Mast);
        }
    }
  
}
