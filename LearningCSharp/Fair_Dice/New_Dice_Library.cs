using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Make a new, FAIR dice that players can roll. Let the player have a name 
/// </summary>
//Make Dice object
namespace Fair_Dice
{
	public class New_Dice
	{
		private string playerName;
		private int roll;
		private Random rollResult = new Random(1);

		//private List<New_Dice> totalPlayers = new List<New_Dice>();
		public New_Dice()
		{
			playerName = "default";
			roll = 0;
		}
		public New_Dice(string playerName, int roll)
		{
			this.playerName = playerName;
			this.roll = roll;
		}

		internal string GetPlayerName()
		{
			return playerName;
		}
		//internal string Add_Player(string playerName)
		//{
		//    Console.Write("Player name is: " + playerName);

		//    totalPlayers.Add(new New_Dice() { playerName = this.playerName });
		//    return playerName;
		//}

		//public void Clear_Players()
		//{
		//    totalPlayers.Clear();
		//}

		protected int ReturnRoll()
		{
			return roll = rollResult.Next(1, 6);
		}

	}
}
