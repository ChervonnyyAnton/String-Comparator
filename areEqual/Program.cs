using System;
namespace areEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = false;
            string answer = "NO";

            do
            {
                Interactions.Say("Hello, user!");
                Interactions.Say("Enter the first text");
                string firstText = Interactions.ReadLine();
                Interactions.Say("Enter the second text");
                string secondText = Interactions.ReadLine();
                Interactions.Say("Here is result:");
                Console.Write("\n \n \n");
                Interactions.Say(Service.CheckStrings(firstText, secondText));
                Console.Write("\n \n \n");
                do
                {
                    if (answer == "AGAIN")
                    {
                        Interactions.Say("Try again with Y or N !");
                    }
                    else
                    {
                        Interactions.Say("Would you like to continue?");
                        Interactions.Say("Type Y or N");
                    }

                    answer = Interactions.Ask();

                    switch (answer)
                    {
                        case "YES":
                            status = true;
                            break;

                        case "NO":
                            status = false;
                            break;

                        default:
                            answer = "AGAIN";
                            break;
                    }
                }
                while (answer == "AGAIN");
                
            }
            while (status);
        }
    }
}
