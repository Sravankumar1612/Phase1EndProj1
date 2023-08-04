using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerid);
        Player GetPlayerById(int playerid);
        Player GetPlayerByName(string playername);
        List<Player> GetAllPlayers();
    }
}