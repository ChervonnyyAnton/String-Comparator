using System;
namespace areEqual
{
    public static class Interactions
    {
        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void Say (string text)
        {
            Console.WriteLine(text);
        }

        public static string Ask()
        {
            string answer = ReadLine();
            if (answer == "Y" || answer == "y")
            {
                return "YES";
            }
            else if (answer == "N" || answer == "n")
            {
                return "NO";
            }
            else
            {
                return "AGAIN";
            }
        }
    }
}
