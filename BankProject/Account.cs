using System;
using System.IO;
using System.Text.Json;

namespace BankProject
{
	class Account
	{
		private StreamWriter text = new StreamWriter(@"F:\LearningProgramming\LearningCSharp\Read_Write_Files\NotepadFolder\NewBankAccountsTest.txt");
		private float balanceValue;
		public string AccountName { get; set; }
		public string UserAddress { get; set; }
		private string accountID;
		public string UserName { get; set; }

		public void SetAccountBalanceValue()
		{
			Random num = new Random();
			balanceValue = num.Next(0, 1000);
		}

		private void SetAccountID()
		{
			Guid x = Guid.NewGuid();//creates a new Guid
			string newId = x.ToString("N");
			accountID = newId;
		}

		public Account()//Constructor
		{
			AccountName = "Checking Account";
			UserAddress = "123 Test St";
			UserName = "User";
			SetAccountID();
		}

		public Account(string userName)//Constructor
		{
			UserName = userName;
		}
		public Account(string name, string address, string userName) : this(userName) //Constructor
		{
			AccountName = name;
			UserAddress = address;
		}

		public void DisplayAccountInfo()
		{
			Console.WriteLine($"Account Name: {AccountName}\nAccount Number: {accountID}\nAccount Address: {UserAddress}\nAccount Balance: {balanceValue.ToString("C")}\n");
		}

		public void DisplayAccountBalance()
		{
			Console.WriteLine($"Account Balance: {balanceValue.ToString("C")}");
		}

		public void SaveAccountInfo()
		{
			using (text)//new variable made for SW
			{
				//string jsonString = JsonSerializer.Serialize(AccountName);
				//text.Write(jsonString);
				text.Write($" This account belongs to: {UserName}\nAccount Name: {AccountName}\nAccount Address {UserAddress}\nAccount Balance: {balanceValue.ToString("C")}");
			}
		}
	}
}