using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExcersize1
{
    internal class Methods
    {
        public static void Name()
            {
            Console.WriteLine("Hello What is your name?");
            }
        
        public static string ResultSentence(string firstname, string fruit, int amount, string classmate, int amount2  )
        {
            return $"{firstname} picked {amount} of {fruit}'s and gave {amount2} of them to {classmate}";       
        }
         
    }
}
