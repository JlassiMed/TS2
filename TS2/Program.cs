using System;

namespace TS2
{
    class Program
    {

        public static void checksub(int[] mainArr, int[] subArr, string condition)
        {
            int i, pos = 0;
            bool adj = true;
            for (i = 0; i < mainArr.Length && pos < subArr.Length; i++)
            {
                if (mainArr[i] == subArr[pos])
                    pos++;
                else
                    adj = false;
            }
            if (condition == "adjacent")
            {
                if (pos == subArr.Length && adj)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
            else
            {
                if (pos == subArr.Length)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");

            }
        }
        public static void Main(string[] args)
        {

            int[] mainArr = { 1, 2, 3, 4 };
            int[] subArr = { 1,2,3 };

            checksub(mainArr, subArr, "adjacent");

        }
    }
}
