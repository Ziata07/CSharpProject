using System;
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
			x.BeginAccountCreation();
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
			return text.ToLower() == "y" || text.ToLower() == "n"; //this will return a true or false without creating a bool.
		}

		public void BeginAccountCreation()
		{
			while (GetUserSelectionInput() == "y")
			{
				CreateAccount();
			}
		}

		public void CreateAccount()
		{//make an account, add it to the account list
			Account newAccount = new Account();
			GetDetailsNewAccount(newAccount);
			newAccount.SetAccountBalanceValue();
			//x.SetAccountNumber();
			AddAccountToBank(newAccount);
		}
		public void GetDetailsNewAccount(Account x)
		{//find a way to implement constructors?
			Console.WriteLine("Please create a username for your account");
			x.UserName = Console.ReadLine();
			Console.WriteLine("What would you like to call this account? Enter Below:");
			x.AccountName = Console.ReadLine();
			Console.WriteLine("Please Enter your address");
			x.UserAddress = Console.ReadLine();
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