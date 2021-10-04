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
            foreach (char char_ in input)
            {
                if (char_ >= '0' && char_ <= '9')
                {
                    output += char_;
                }
            }

            bool ouputNoInt = true;
            foreach (char char_ in output)
            {
                ouputNoInt = false;
                break;
            }

            if (ouputNoInt)
                Console.WriteLine($"The output doesn't have any integer.");
            else
                Console.WriteLine($"The output should be {output} in integer.");
        }
    }
}
