using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string: ");

            string input = Console.ReadLine();
            Console.WriteLine($"Given input is \"{input}\"");

            string output = string.Empty;
            foreach (char char_ in input) //function for check characters in input(string)
            {
                if (char_ >= '0' && char_ <= '9')
                {
                    output += char_;
                }
            }

            bool ouputNoInt = true;
            foreach (char char_ in output) //function for check int, not need if can use "output.Length" 
            {
                ouputNoInt = false;
                break;
            }

            if (ouputNoInt) //check int, can use (output.Length == 0) 
                Console.WriteLine($"The output doesn't have any integer.");
            else
                Console.WriteLine($"The output should be {output} in integer.");
        }
    }
}
