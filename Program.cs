using System;

namespace Instructions
{
    class Program
    {
        static void Declarations()
        {
            int a; // empty value
            int b = 2, c = 3;
            const int d = 4; // it is a constant! can't change
            a = 1; // addressing a value to a
            Console.WriteLine(a + b + c + d); // 10
        }
        static void InstructionIf(string[] args)
        {
            if (args.Length == 0) // conditional works like any onther language
            {
                Console.WriteLine("There are no arguments!");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("One argument");
            }
            else
            {
                Console.WriteLine($"{args.Length} arguments"); // string interpolation, very similar to JS's template literals 
            }
        }
        static void InstructionSwitch(string[] args)
        {
            int argumentsQuantity = args.Length;
            switch (argumentsQuantity)
            {
                case 0:
                    Console.WriteLine("There are no arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                default:
                    Console.WriteLine($"{argumentsQuantity} arguments");
                    break;
            }
        }
        static void InstructionWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        static void InstructionDo(string[] args)
        {

        }
        static void InstructionFor(string[] args)
        {

        }
        static void InstructionForeach(string[] args)
        {

        }
    }
}