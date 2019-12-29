using System;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking a string 
            String str = "Geeks, For Geeks";

            char[] separator = { ',', ' ' };
            Int32 count = 2;

            // Using the Method 
            String[] strlist = str.Split(separator,
                   count, StringSplitOptions.None);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
