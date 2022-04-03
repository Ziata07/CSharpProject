using System;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader xr = new StreamReader(@"F:\LearningProgramming\LearningCSharp\AdventOfCode\NumberList.txt"))
			{
				List<int> firstList = new List<int> { };
				List<int> secondList = new List<int> { };

				string text;
				int tally = 0;
				int num = 0;
				int result = 0;


				while ((text = xr.ReadLine()) != null)
				{
					int getNums = int.Parse(text);
					firstList.Add(getNums);
				}

				for (int i = 0; i < firstList.Count; i++)
				{
					if (!CheckIfOutOfBoundsFirstList(tally+2))
					{
						int x = firstList[tally] + firstList[tally + 1] + firstList[tally + 2];
						secondList.Add(x);
						tally++;
					}
											
				}
				foreach (int item in secondList)
				{
					if (!CheckIfOutOfBoundsSecondList(num + 1) && secondList[num] < secondList[num + 1])
					{
						result++;
					}
					num++;
				}
				Console.WriteLine(result);
				
				//check if +2 is out of bounds
				bool CheckIfOutOfBoundsFirstList(int y) 
				{
					if (y < firstList.Count)
					{
						return false;
					}
					else
					{
						return true;
					}
				}

				bool CheckIfOutOfBoundsSecondList(int y) //check if we are out of bounds in list
				{
					if (y < secondList.Count)
					{
						return false;
					}
					else
					{
						return true;
					}
				}
			}
		}
	}
}
