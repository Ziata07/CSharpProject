using System;
using System.IO;

namespace Read_Write_Files
{
    class Program
    {
        static void Main_0(string[] args)
        {
            String line;
            int x;
            try
            {
                //Pass the file path and file name to the StreamReader/StreamWriter constructor
                StreamReader sr = new StreamReader("F:\\LearningProgramming\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\ReadFromThis.txt");
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

            try
            {   //Creating a file, writing to it, then closing the file. File path shoes WHERE file will be
                StreamWriter sw = new StreamWriter("F:\\LearningProgramming\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\NewWrittenFile.txt");
                sw.WriteLine("This is another test! Using the WriteLine method.");
                sw.WriteLine("This is from the StreamWriter class");
                sw.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(" Exception line: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing the finally block");
            }

            try
            {   //There are many different constructors for StreamWriter class
                StreamWriter anotherFile = new StreamWriter("F:\\LearningProgramming\\LearningCSharp\\Read_Write_Files\\NotepadFolder\\ThisFileWillRefresh.txt", false, System.Text.Encoding.UTF8);
                for (x = 0; x < 10; x++)
                {
                    anotherFile.Write(x + "\n");
                }

                anotherFile.Close();
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
