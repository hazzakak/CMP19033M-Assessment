using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1

        //Method: manualTextInput
        //Arguments: none
        //Returns: String List
        //Gets text input from the keyboard
        public List<string> manualTextInput()
        {
            char final_char = '1';
            List<string> list = new List<string>();
            Console.WriteLine("Please input your sentences and press ENTER. Once finished, attach a '*' to the end of your last sentence.");
            while (final_char != '*')
            {
                string input_text = Console.ReadLine();
                list.Add(input_text);
                final_char = input_text[input_text.Length-1];
            }
            return list;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: list
        //Gets text input from a .txt file
        public List<string> fileTextInput(string path)
        {;
            if (File.Exists(path))
            {
                // 1. Get all the text from the file.
                // 2. Remove anything after the *
                // 3. Split it by sentences
                // 4. Add each sentence in to a list rather than an array.
                string file_text = File.ReadAllText(path);
                string[] clean_text = file_text.Split('*');
                string[] sentences = clean_text[0].Split(". ");
                List<string> lines = new List<string>();
                foreach (string line in sentences)
                {
                    lines.Add(line);
                }
                return lines;
            }
            else {
                List<string> lines = new List<string>();
                return lines;
            }
        }

    }
}
