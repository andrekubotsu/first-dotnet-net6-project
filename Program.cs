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
            string text;
            do
            {
                text = Console.ReadLine(); // to read something
                Console.WriteLine(text);
            } while (!string.IsNullOrEmpty(text));
        }
        static void InstructionFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        static void InstructionForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }
        static void InstructionBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }
                Console.WriteLine(s);
            }
        }
        static void InstructionContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                Console.WriteLine(args[i]);
            }
        }
        static void InstructionReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }
        static void InstructionTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Inform two numbers!");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e) // specific catch - InvalidOperationException
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // generic catch - Exception
            {
                Console.WriteLine($"Generic error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("See you soon!");
            }
        }
        static void InstructionUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("test.txt")) // using do automatic dispose
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}