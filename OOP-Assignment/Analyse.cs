using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        // Additional method as well as use of encapsulation to prevent other classes using this method.
        private void createFile(List<String> sentences)
        {
            List<String> long_words = new List<string>();
            foreach (string sentence in sentences)
            {
                string clean_sentence = Regex.Replace(sentence, "[^A-Za-z0-9 ]", "");
                string[] words = clean_sentence.Split(' ');
                foreach (string word in words) { if (word.Count() >= 7) { long_words.Add(word); } }
            }
            string fileName = System.AppContext.BaseDirectory + "long_words.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file
                    foreach (string long_word in long_words)
                    {
                        Byte[] title = new UTF8Encoding(true).GetBytes(long_word+", ");
                        fs.Write(title, 0, title.Length);
                    }
                }
                Console.WriteLine($"{fileName} has been created.");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(List<String> input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }
            // Count vowels, consonants, upper case letters, lower case letters.
            string vowels = "aeiouAEIOU";
            string consonants = "bcdfghjklnmpqrstvwxyzBCDFGHJKLNMPQRSTVWXYZ";
            // Iterates through sentence list.
            foreach (string sentence in input)
            {
                // Iterates through characters in each sentence
                foreach (char ch in sentence)
                {
                    // Checks whether the character is in the vowels string.
                    if (vowels.Contains(ch.ToString()))
                    {
                        values[1]++;
                    } else if (consonants.Contains(ch.ToString()))
                    {
                        values[2]++;
                    }
                    if (Char.IsUpper(ch))
                    {
                        values[3]++;
                    }
                    else if (Char.IsLower(ch))
                    {
                        values[4]++;
                    }
                }
            }

            createFile(input);

            // Count the amount of items in the list
            values[0] = input.Count;

            return values;
        }
    }
}
