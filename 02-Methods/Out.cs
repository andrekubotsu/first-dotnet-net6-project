using System;

namespace Classes.Methods
{
    public class Out
    {
        static void Divide(int x, int y, out int result, out int module)
        {
            result = x / y;
            module = x % y;
        }
        public static void Divide()
        {
            Divide(10, 3, out int result, out int module);
            System.Console.WriteLine($"{0} {1}", result, module); // 3, 1
        }
    }
}