using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
//using System.Windows.Forms;


namespace Fair_Dice
{
	/// <summary>
	/// Looking to make this dynamic, depending on how many players and spots are on the dice.
	/// User will choose how many players, then each player will choose how many spots are on dice. 
	/// Program should clearly display who's turn it is and how many spots are being rolled. 
	/// </summary>
	/// 
	public partial class MainWindow : Window
	{
		List<New_Dice> p_list = new List<New_Dice>();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void confirmPlayersButton_Click(object sender, RoutedEventArgs e)
		{
			if (ValidatePlayers())
			{
				int num = int.Parse(totalPlayersTextBox.Text);
				UpdateList(num);
			}
			else
			{
				MessageBox.Show("false");
			}
		}

		private void rollDieButton_Click(object sender, RoutedEventArgs e)
		{

		}
		public void UpdateList(int numOfPlayers)
		{
			p_list.Clear();
			PlayerList.Items.Clear();

			for (int i = 0; i < numOfPlayers; i++)
			{
				New_Dice newPlayer = new New_Dice();
				p_list.Add(newPlayer);
				PlayerList.Items.Add(p_list[i].GetPlayerName());
			}
		}
		private string SetPlayerName(New_Dice v_newPlayer)
		{
			
			return null;
		}
		public bool ValidatePlayers()
		{
			int num;
			if (int.TryParse(totalPlayersTextBox.Text, out num))
			{
				if (num <= 0 || num > 10)
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
	}
}