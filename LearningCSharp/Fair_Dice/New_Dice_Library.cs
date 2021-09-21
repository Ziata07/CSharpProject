using System;
using System.Collections.Generic;
using System.Text;

//Make Dice object
namespace Fair_Dice
{
    class New_Dice
    {
        private string playerName;
        private uint spots;
        private uint roll;
        private List<New_Dice> totalPlayers = new List<New_Dice>();
        public New_Dice()
        {
            playerName = "default";
            spots = 0;
            roll = 0;
        }

        protected string Add_Player(string playerName)
        {
            Console.Write("Player name is: " + playerName);
            totalPlayers.Add(new New_Dice() { playerName = this.playerName});
            return playerName;
        }

        public void Clear_Players()
        {
            totalPlayers.Clear();
        }

        public uint IntSpots()
        {
            return 6;
        }

        public void NextPlayerRoll(out string playerName, out int spots)
        {

        }
        public string PlayerRoll()
        {

        }
        public string SetPlayer(string player)
        {
            
            this.playerName = player;
            return player;
        }
        public uint Roll()
        {

        }
    }
}
