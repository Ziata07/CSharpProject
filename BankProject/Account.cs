using System;
using System.IO;

namespace BankProject
{
	class Account
	{
		 private float balanceValue;
		public string AccountName { get; set; }
		public string AccountAddress { get; set; }
		private int accountNumber;
		public string UserName { get; set; }
		public void SetAccountBalanceValue()
		{
			Random num = new Random();
			balanceValue = num.Next(0, 1000);
		}

		public void SetAccountNumber()
		{
			Random num = new Random();
			accountNumber = num.Next(0000001, 9999999);
		}
		public Account()//Constructor
		{
			AccountName = "Checking Account";
			AccountAddress = "123 Test St";
			UserName = "User";
		}
		public Account(string userName)//Constructor
		{
			UserName = userName;
		}
		public Account(string name, string address, string userName)//Constructor
		{
			AccountName = name;
			AccountAddress = address;
			UserName = userName;
		} 

		public void DisplayAccountInfo()
		{			
			Console.WriteLine($"Account Name: {AccountName}\nAccount Number: {accountNumber}\nAccount Address {AccountAddress}\nAccount Balance: {balanceValue.ToString("C")}\n");
			//.toString("C") = currency
		}
		public void DisplayAccountBalance()
		{
			Console.WriteLine($"Account Balance: {balanceValue.ToString("C")}");
		}

		public void SaveAccountInfo()
		{
			using (StreamWriter sw = new StreamWriter(@"F:\LearningProgramming\LearningCSharp\Read_Write_Files\NotepadFolder\NewBankAccountsTest.txt"))
			{
				sw.Write($"Account Name: {AccountName}\nAccount Address {AccountAddress}\nAccount Balance: {balanceValue.ToString("C")}");
			}
		}
	}
}