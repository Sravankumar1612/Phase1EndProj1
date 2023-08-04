using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class OneDayTeam : Player, ITeam
    {
        public static List<Player> Oneday = new List<Player>();
        public OneDayTeam()
        {
            Oneday.Capacity = 11;


        }
        public void Add(Player player)
        {
            Oneday.Add(player);
        }

        public List<Player> GetAllPlayers()
        {
            return Oneday;
        }

        public Player GetPlayerById(int playerid)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.PlayerId == playerid)
                {
                    player = item;

                    break;
                }
            }
            return player;

        }

        public Player GetPlayerByName(string playername)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.PlayerName == playername)
                {
                    player = item;

                    break;
                }
            }
            return player;


        }

        public void Remove(int playerid)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.PlayerId == playerid)
                {
                    Console.WriteLine("Player Removed successfully");
                    player = item;
                }
            }
            Oneday.Remove(player);
        }
    }
}
