using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Game
{
    public abstract class Coloda
    {
        protected List<Kart> karts;

        public virtual void Create()
        {
            foreach (mast m in (mast[])Enum.GetValues(typeof(mast)))
            {
                foreach (var n in (nominal[])Enum.GetValues(typeof(nominal)))
                {
                    karts.Add(new Kart() { Mast = m, Nominal = n });
                }
            }
        }

        public virtual void Shuffle ()
        {
            Random rnd = new Random();
            karts.OrderBy(x => rnd.NextDouble()).ToList();
        }

        public void Print()
        {
            foreach (Kart item in karts)
            {
                Console.WriteLine("{0} {1}", item.Nominal, item.Mast);
            }
        }
    }
}
