/*Gog Ionela-Maria
 * Text strip problem
*/

using System;

namespace TextStrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "apples, pears # and bananas\ngrapes\nbananas !apples";
            char[] array1 = {'#', '!'};

            StripText var = new StripText();
            string result = var.Text(text,array1);

            Console.Write(result);
        }
    }
}
