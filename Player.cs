using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Player
    {
        private int _playerid;
        private string _playername;
        private int _playerage;
        public int PlayerId
        {
            get { return _playerid; }
            set { _playerid = value; }
        }
        public string PlayerName
        {
            get { return _playername; }
            set { _playername = value; }
        }
        public int PlayerAge
        {
            get { return _playerage; }
            set { _playerage = value; }
        }
    }
}
