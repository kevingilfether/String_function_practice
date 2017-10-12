using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_function_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("adva"));
        }
        public static bool IsUnique(string input)
        {
            char[] inputArray = input.ToCharArray();
            char temp;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (j == i)
                        continue;
                    else if (inputArray[i] == inputArray[j])
                        return false;                       
                }
            }
            return true;
        }

    }
}
