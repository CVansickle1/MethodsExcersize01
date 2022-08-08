using System;

namespace MethodsExcersize1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Methods.Name();
            string firstName = Console.ReadLine();

            Console.WriteLine("Name a Fruit");
            
             string color = Console.ReadLine();

            Console.WriteLine("Please pick a number");
             var amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Please pick another number");
             var amount2 = int.Parse(Console.ReadLine());

            while (amount2 > amount)
            {
                Console.WriteLine($"Please Pick a number below {amount}.");
                 amount2 = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("Pick one of your classmates and write their name");
            string classmate = Console.ReadLine();

            Console.WriteLine(Methods.ResultSentence(firstName, color , amount, classmate, amount2));

        }
    }
}
