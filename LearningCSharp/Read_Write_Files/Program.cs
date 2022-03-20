using System;
using System.IO;

namespace Read_Write_Files
{ //https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/read-write-text-file
    class Program
    {
        static void Main11(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"F:\LearningProgramming\LearningCSharp\Read_Write_Files\NotepadFolder\ReadFromThis.txt")) //with USING, the file will be opened, then closed once this code block is complete!
            {
                string row;
                while ((row = sr.ReadLine()) != null)
                {
                    string[] columns = row.Split(',');
                    Console.WriteLine("This is: " + row);
                    foreach (string column in columns)
                    {
                        if (column.Contains("Column"))
                        {
                            Console.WriteLine(column);
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
