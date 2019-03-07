using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Game
{
    public class Game:Coloda
    {
        public Game()
        {
            base.karts = new List<Kart>();
            base.Create();
        }
        public List<Player> players;

        public void CreatePlayers(int count=2)
        {
            if (count < 2)
            {
                throw new Exception("Колличество игроков не должно быть меньше 2");
            }
            players = new List<Player>();
            for (int i = 0; i < count; i++)
            {
                Player pl = new Player();
                pl.Id = i;
                pl.Name = "Player " + i;
                players.Add(pl);
            }
        }
        public void Razdacha()
        {
            int p = players.Count-1;
            int k = 0;
            foreach (Kart item in karts)
            {
                if (k > p) k = 0;
                players[k++].pKarts.Push(item);
            }
        }
        public Player StartGame()
        {
            CreatePlayers();
            Shuffle();
            Razdacha();

            Player winner = null;
            int maxCart=0;

            Dictionary<Player, Kart> table = new Dictionary<Player, Kart>();
            while(!players.Any(x=>x.pKarts.Count==36))
            {
                foreach (Player item in players)
                {
                    item.pKarts.Peek().PrintInfo();
                    table.Add(item, item.pKarts.Pop());
                }
                Console.WriteLine("");

                foreach (var item in table)
                {
                    if((int)item.Value.Nominal>maxCart)
                    {
                        maxCart = (int)item.Value.Nominal;
                        winner = item.Key;
                    }
                }
                winner.PrintInfo();
                foreach (var item in table)
                {
                    players[winner.Id].pKarts.Push(item.Value);
                }

                winner = null;
                maxCart = 0;
                table = new Dictionary<Player, Kart>();
            }

            return players.FirstOrDefault(x => x.pKarts.Count == 36);
        }
    }
}
