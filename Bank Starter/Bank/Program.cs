using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sample bank code for 08120 Week 31 Lab work
// Manages account and bank details
// Rob Miles February 2014

namespace Bank
{
    class Account
    {
        // TODO: Need to add a ToString method and an Equals method to this class

        private string name;
        private string address;
        private decimal balance;
        private int accountNumber;

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public bool Save(System.IO.TextWriter textOut)
        {
            try
            {
                textOut.WriteLine(accountNumber);
                textOut.WriteLine(name);
                textOut.WriteLine(address);
                textOut.WriteLine(balance);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Save(string filename)
        {
            System.IO.TextWriter textOut = null;
            try
            {
                textOut = new System.IO.StreamWriter(filename);
                Save(textOut);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (textOut != null) textOut.Close();
            }
        }

        public static Account Load(System.IO.TextReader textIn)
        {
            int accountNumber = int.Parse(textIn.ReadLine());
            string nameText = textIn.ReadLine();
            string addressText = textIn.ReadLine();
            string balanceText = textIn.ReadLine();
            decimal balanceValue = decimal.Parse(balanceText);
            return new Account(nameText, addressText, balanceValue, accountNumber);
        }

        public static Account Load(string filename)
        {
            Account result;
            System.IO.TextReader textIn = null;
            try
            {
                textIn = new System.IO.StreamReader(filename);
                result = Load(textIn);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (textIn != null) textIn.Close();
            }
            return result;
        }

        public Account(string inName, string inAddress, decimal inBalance, int inAccountNumber)
        {
            name = inName;
            address = inAddress;
            balance = inBalance;
            accountNumber = inAccountNumber;
        }

    }

    class Bank
    {
        // TODO: Need to add a ToString method and an Equals method to this class

        private string bankName;

        public string BankName
        {
            get
            {
                return bankName;
            }
        }

        private List<Account> bankAccounts;
        static int newAccountNumber = 1;

        public Bank(string newBankName)
        {
            bankName = newBankName;
            bankAccounts = new List<Account>();
        }

        public Account AddAccount(string inName, string inAddress, decimal inBalance)
        {
            Account result = new Account(inName, inAddress, inBalance, newAccountNumber);
            bankAccounts.Add(result);
            newAccountNumber = newAccountNumber + 1;
            return result;
        }
        public Account FindAccount(int searchNumber)
        {
            foreach (Account a in bankAccounts)
            {
                if (a.AccountNumber == searchNumber)
                    return a;
            }
            return null;
        }

        public bool DeleteAccount(int deleteNumber)
        {
            Account del = FindAccount(deleteNumber);
            if (del != null)
            {
                bankAccounts.Remove(del);
                return true;
            }
            return false;
        }

        public void Save(System.IO.TextWriter textOut)
        {
            textOut.WriteLine(bankName);
            textOut.WriteLine(newAccountNumber);
            textOut.WriteLine(bankAccounts.Count);
            foreach (Account a in bankAccounts)
            {
                if (a != null)
                {
                    a.Save(textOut);
                }
            }
        }

        public void Save(string filename)
        {
            System.IO.TextWriter textOut = null;

            try
            {
                textOut = new System.IO.StreamWriter(filename);
                Save(textOut);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (textOut != null) textOut.Close();
            }
        }

        public static Bank Load(System.IO.TextReader textIn)
        {
            string bankName = textIn.ReadLine();
            Bank result = new Bank(bankName);
            newAccountNumber = int.Parse(textIn.ReadLine());
            int numberOfAccounts = int.Parse(textIn.ReadLine());
            for (int i = 0; i < numberOfAccounts; i++)
            {
                Account a = Account.Load(textIn);
                result.bankAccounts.Add(a);
            }
            return result;
        }

        public static Bank Load(string filename)
        {
            Bank result;
            System.IO.TextReader textIn = null;
            try
            {
                textIn = new System.IO.StreamReader(filename);
                result = Load(textIn);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (textIn != null) textIn.Close();
            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bank friendlyBank = new Bank("The Friendly Bank");

            // TODO: Need to add some code that will create a large number of "fake" accounts

            Account rob = friendlyBank.AddAccount("Rob", "Hull", 100);
            Console.WriteLine("Account created with account number: " + rob.AccountNumber);
            friendlyBank.Save("test.txt");

            // TODO: Need to compare the loaded bank with the original to make sure they are the same

            Bank loadedBank = Bank.Load("test.txt");
        }
    }
}
