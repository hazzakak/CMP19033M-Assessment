//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        private static string text;

        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            
            // Ask what they would like to do. Option 1: text input Option 2: file input
            Console.WriteLine("What would you like to do:\n1 - Do you want to enter the text via the keyboard?\n2 - Do you want to read in the text from a file?");
            string option = Console.ReadLine();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input inp = new Input();

            if (option == "1")
            {
                text = inp.manualTextInput();
            }
            else if (option == "2")
            {
                Console.WriteLine("What is the name of the file. Ensure it is in the current directory.");
                string file_name = Console.ReadLine();
                text = inp.fileTextInput(fileName: file_name);
            } else //ensure that only 1 or 2 is put not anything else or null.
            {
                Console.WriteLine("You must enter only 1 or 2. Please run the program again");
                return; // Exit out if it is an unnaceptable input.
            }

            Console.WriteLine(text);


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
