using System;

namespace Classes.Methods
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y) // ref -> reference
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Interver()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}"); // write "2 1"
        }
    }
}