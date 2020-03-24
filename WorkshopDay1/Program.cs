using System;

namespace Workshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result = Add(3,2);
            bool IsMod = IsModOfTwo(result);
            
            Console.WriteLine(result);
            Console.WriteLine(IsMod);
        }

         public static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

         public static bool IsModOfTwo(int value)
        {
             return value % 2 == 0;
        }
    }
}
