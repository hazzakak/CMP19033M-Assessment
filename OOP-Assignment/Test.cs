using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Test
    {
        // DATA ABSTRACTION used in the following class to prevent #program using
        private List<int> preset_values = new List<int>();

        private void initiate_values()
        {
            // Sentences: 6
            // Total Characters: 506
            // Vowels: 189
            // Upper Case:9
            // Lower Case: 497
            preset_values.Add(6);
            preset_values.Add(189);
            preset_values.Add(317);
            preset_values.Add(9);
            preset_values.Add(497);
        }

        public void test(List<int> values)
        {
            initiate_values();

            Console.WriteLine("\nTESTING FUNCTION\nVariable 0: Sentence\nVariable 1: Vowels\nVariable 2: Consonants\nVariable 3: Upper Case\nVariable 4: Lower Case");
            for (int i = 0; i < 5; i++)
            {
                if (values[i] == preset_values[i]) { Console.WriteLine($"Variable {i} is correct"); }
                else { Console.WriteLine($"Variable {i} is incorrect"); }
            }
        }
    }
}
