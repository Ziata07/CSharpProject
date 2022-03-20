using System.Collections.Generic;
using System.Windows;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Fair_Dice
{
	/// <summary>
	/// Looking to make this dynamic, depending on how many players and spots are on the dice.
	/// User will choose how many players, then each player will choose how many spots are on dice. 
	/// Program should clearly display who's turn it is and how many spots are being rolled. 
	/// 
	/// For a MORE effecient program, have a global variable that tracks the current player number
	/// </summary>
	/// 
	public partial class MainWindow : Window
	{
		List<New_Dice> p_list = new List<New_Dice>();
		int currentPlayerNum = 0;
		public MainWindow()
		{
			InitializeComponent();
		}
		#region Initiate Button_Click Functions
		private void confirmPlayersButton_Click(object sender, RoutedEventArgs e)
		{
			if (ValidatePlayers())
			{
				int num = int.Parse(totalPlayersTextBox.Text);
				UpdateColumns(num);
				DisplayTurnSingle(p_list[currentPlayerNum]);
			}
			else
			{
				MessageBox.Show("Number of players are not valid");
			}
		}
		public void PlayTurn()
		{//When a turn happens, what do I want to happen?		 
			if (!ValidatePlayers())
			{
				MessageBox.Show("You cannot roll dice without players");
			}
			else if (ValidateDiceList())
			{
				MessageBox.Show("Press the Clear Rolls button to empty the dice list");
			}
			else
			{
				if (!CheckIfRolled(p_list[currentPlayerNum]))  
				{
					AddRollToList(p_list[currentPlayerNum]);
					p_list[currentPlayerNum].checkIfRolled = true;
					++currentPlayerNum; 
					if (!CheckIfLastPlayer())//a check here to see if the currentplayernum is at "max"
					{
						DisplayTurnSingle(p_list[currentPlayerNum]);
					}
					else
					{
						ResetCurrentPlayerNum();
						DisplayTurnSingle(p_list[currentPlayerNum]);
					}
				}
			}
		}
		public bool CheckIfLastPlayer()
		{
			if (currentPlayerNum == p_list.Count)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void rollDieButton_Click(object sender, RoutedEventArgs e)
		{
			PlayTurn();
		}
		private void rollClearButton_Click(object sender, RoutedEventArgs e)
		{
			if (!ValidatePlayers())
			{
				MessageBox.Show("Cannot clear empty dice roll list");
			}
			else if (ValidateDiceList())
			{
				ResetDiceList();
				DisplayTurnSingle(p_list[currentPlayerNum]);
				MessageBox.Show("Dice List is Empty");
			}
			else
			{
				MessageBox.Show("Not all players have rolled yet");
			}
		}
		#endregion
		#region Initiate Player Functions
		private void InputPlayerName(New_Dice v_newPlayer)
		{
			string x = Interaction.InputBox("Please input player name.", "Player Name", "New Player");
			while (!ValidatePlayerName(x))
			{
				MessageBox.Show("Please re-enter a new name");
				x = Interaction.InputBox("Please input player name.", "Player Name", "New Player");
			}
			v_newPlayer.SetPlayerName(x);
		}
		public bool ValidatePlayers()
		{
			int num;
			if (int.TryParse(totalPlayersTextBox.Text, out num))
			{
				if (num <= 0 || num > 5)
				{
					return false;
				}
			}
			else
			{
				return false;
			}
			return true;
		}
		public bool ValidatePlayerName(string name)
		{
			string expression = @"[0-9]";
			MatchCollection mc = Regex.Matches(name, expression);
			foreach (Match x in mc)
			{
				return false;
			}
			return true;
		}
		public void AddPlayersToSet(int x)//Made a new function to ADD players to p_list
		{
			for (int i = 0; i < x; i++)
			{
				New_Dice player = new New_Dice();
				p_list.Add(player);
			}
		}
		public void UpdateColumns(int numOfPlayers)
		{
			ClearLists();
			AddPlayersToSet(numOfPlayers); //foreach
			foreach (New_Dice x in p_list)
			{
				InputPlayerName(x);
				InputDiceSides(x);
				PlayerList.Items.Add(x.GetPlayerName());
				DiceSidesList.Items.Add(x.GetDiceSides());
			}
		}
		#endregion
		#region Initiate Dice Functions
		private void InputDiceSides(New_Dice v_newPlayer)
		{
			string x = Interaction.InputBox("Please enter number of sides your dice will have", "Dice Sides", "6");
			while (!ValidateDiceSides(x))
			{
				MessageBox.Show("Please enter a number between 1 and 20");
				x = Interaction.InputBox("Please enter number of sides your dice will have", "Dice Sides", "6");
			}
			int diceSides = int.Parse(x);
			v_newPlayer.SetDiceSides(diceSides);
		}
		private bool ValidateDiceSides(string x)
		{
			bool convert = uint.TryParse(x, out uint i);
			if (convert)
			{
				if (i > 20 || i < 1)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			else
			{
				return false;
			}
		}
		public bool ValidateDiceList()
		{
			foreach (New_Dice player in p_list)
			{
				if (player.checkIfRolled == false)
				{
					return false;
				}
			}
			return true;
		}
		public void AddRollToList(New_Dice x)
		{
			int roll = x.ReturnRoll();
			DiceRollList.Items.Add(roll);
		}
		public void ResetDiceList()
		{
			DiceRollList.Items.Clear();
			foreach (New_Dice player in p_list)
			{
				player.checkIfRolled = false;
			}
		}
		#endregion

		public void ResetCurrentPlayerNum()
		{
			currentPlayerNum = 0;
		}
		public void ClearLists()
		{
			p_list.Clear();
			PlayerList.Items.Clear();
			DiceSidesList.Items.Clear();
			DiceRollList.Items.Clear();
		}
		public bool CheckIfRolled(New_Dice x)
		{
			if (x.checkIfRolled == false)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public void DisplayTurnSingle(New_Dice x)
		{
			{
				resultsLabel.Content = $"It is player {x.GetPlayerName()}'s turn";
			}
		}
	}
}