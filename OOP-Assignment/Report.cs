using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void outputConsole(List<int> values)
        {
            Console.WriteLine($"Sentences: {values[0]}\nVowels: {values[1]}\nConsonants: {values[2]}\nUpper Case Letters: {values[3]}\nLower Case Letters: {values[4]}");
        }

        public void outputToFile(List<int> values, string path)
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Create a new file     
                using (FileStream fs = File.Create(path))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes($"Sentences: {values[0]}\nVowels: {values[1]}\nConsonants: {values[2]}\nUpper Case Letters: {values[3]}\nLower Case Letters: {values[4]}");
                    fs.Write(title, 0, title.Length);
                }
                Console.WriteLine($"{path} has been created.");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
