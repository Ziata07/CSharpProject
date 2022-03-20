using System;
using System.IO;
using System.Collections.Generic;

namespace Read_Write_Files
{
    class Test_ReadFile
    {
        static void Main()
        {            
            List<Ingredient> listOfIngredients = new List<Ingredient>();         

            using (StreamReader streamReader = new StreamReader(@"F:\LearningProgramming\LearningCSharp\Read_Write_Files\NotepadFolder\ListOfFood.TXT"))
            {
                string x;
                while ((x = streamReader.ReadLine()) != null)//While each line we read is NOT done
                {
                    string[] lines = x.Split('|');                   
                    try
                    {
                        Console.WriteLine(lines[1]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("-----NEW SECTION----");
                        continue;
                    }
                    foreach (string line in lines)
                    {
                        if (line.Contains("Beverage"))
                        {
                            Ingredient organizeList = new Ingredient();
                            organizeList.p_category = lines[0];
                            listOfIngredients.Add(organizeList);
                        }
                    }
                }
            }   
        }
    }
}