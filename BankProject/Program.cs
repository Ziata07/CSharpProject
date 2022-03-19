using System;
using System.IO;

namespace BankProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Bank test = new Bank();
			test.RunBank(test);
		}
	}
}