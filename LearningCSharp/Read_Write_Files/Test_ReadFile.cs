using System;
using System.IO;

namespace Read_Write_Files
{
    class Test_ReadFile
    {
        static void Main()
        {
           string[] ar;

            ar = System.IO.File.ReadAllLines("F:\\LearningProgramming\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\Even_Odd_File.txt");
            string x;
            int y;
          
            StreamReader streamReader = new StreamReader("F:\\LearningProgramming\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\Even_Odd_File.txt");
            x = streamReader.ReadLine();
            int.TryParse(x, out y);

            do
            {
                if (y % 2 != 0)
                {
                    Console.WriteLine(x);
                }
                x = streamReader.ReadLine();

            } while (int.TryParse(x, out y));          
        }
    }
}
