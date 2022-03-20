using System;
using System.IO;
using System.Collections.Generic;

namespace BankProject
{
	class Bank
	{
		private string bankName = "Town Bank";
		public List<Account> accountList = new List<Account>();		

		public void RunBank(Bank x)
		{
			x.DisplayBankInfo();
			x.AcceptSelectionInput();
			x.SaveBankInfo();
			x.DisplayAccountsInBank();
		}
		public string GetUserSelectionInput()
		{
			string input;

			if (accountList.Count > 0)
			{
				Console.WriteLine("Would you like to create a another account?");
			}
			else
			{
				Console.WriteLine("Would you like to create a new account?");
			}
			do
			{
				Console.WriteLine("Type Y or N");
				input = Console.ReadLine();
			} while (!ValidateSelectionInput(input));
			return input;
		}

		private bool ValidateSelectionInput(string text)
		{
			bool v = text.ToLower() == "y" || text.ToLower() == "n" ? true : false;
			return v;
		}

		public void AcceptSelectionInput()
		{
			while (GetUserSelectionInput() == "y")
			{
				CreateAccount();
			}

			DisplayBankInfo();
		}
		public void CreateAccount()
		{//make an account, add it to the account list
			Account x = new Account();
			GetDetailsNewAccount(x);
			x.SetAccountBalanceValue();
			x.SetAccountNumber();
			AddAccountToBank(x);
		}
		public void GetDetailsNewAccount(Account x)
		{//find a way to implement constructors?
			Console.WriteLine("Please create a username for your account");
			x.UserName = Console.ReadLine();
			Console.WriteLine("What would you like to call this account? Enter Below:");
			x.AccountName = Console.ReadLine();
			Console.WriteLine("Please Enter your address");
			x.AccountAddress = Console.ReadLine();
		}
		private void AddAccountToBank(Account x)
		{
			accountList.Add(x);
		}
		public void DisplayBankInfo()
		{
			//Display name of Bank(s) and how many accounts are in banks
			Console.WriteLine($"Welcome to {bankName}\nThere are {accountList.Count} account(s) in the bank.");
		}
		public void DisplayAccountsInBank()
		{
			//Display the info of the Accounts in specified Bank
			foreach (Account x in accountList)
			{
				x.DisplayAccountInfo();
			}
		}
		public void SaveBankInfo()
		{   //saving accounts here to notepad document
			foreach (Account x in accountList)
			{
				x.SaveAccountInfo();
			}
		}
	}
}