using System;
using System.IO;

namespace Read_Write_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader/StreamWriter constructor
                StreamReader sr = new StreamReader("F:\\CSharpProject\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\ReadFromThis.txt");
                StreamWriter sw = new StreamWriter("F:\\CSharpProject\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\NewWrittenFile.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
