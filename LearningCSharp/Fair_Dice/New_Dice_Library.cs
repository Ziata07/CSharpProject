using System;
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
		private Random rollResult = new Random();
		private int diceSides;
		public bool checkIfRolled { get; set; }

		public New_Dice()
		{
			playerName = "Player";
			roll = 0;
			checkIfRolled = false;			
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
		internal void SetPlayerName(string x)
		{
			this.playerName = x;
		}

		internal int GetRoll()
		{
			return roll;
		}
		internal void SetDiceSides(int x)
		{
			this.diceSides = x;
		}
		internal int GetDiceSides()
		{
			return diceSides;
		}
		public int ReturnRoll()
		{
			return roll = rollResult.Next(1, diceSides);
		}
	}
}