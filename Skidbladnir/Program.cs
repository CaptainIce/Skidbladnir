using System;
using System.Linq;

namespace Skidbladnir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weclome to Skidbladnir.");
            Console.WriteLine("");
            Console.WriteLine("Please enter your number: ");
            int Number = Convert.ToInt16
                (Console.ReadLine());

            Console.WriteLine("");

            int[] NumberArray = Number.ToString().ToCharArray().Select(x => (int) char.GetNumericValue(x)).ToArray();
            int NumberArrayLength = NumberArray.Length;

            for (int i = 0; i < NumberArrayLength; i++)
                Console.WriteLine(NumberArray[i]);

            Console.ReadLine();

        }
    }
}
