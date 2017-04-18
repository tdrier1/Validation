using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            double S1 = 1;
            double S2 = 2;
            string S3 = "Test1";
            string S4 = "Test2";
            int Min = 1;
            int Max = 100;
            double value;
            bool CaseSensitive = true;

            Console.Write("Please enter a value: ");
            string Prompt = Console.ReadLine();

            GetInt();
            GetIntWithinRange(Prompt, Min, Max);
            GetDouble(Prompt);
            GetDoubleWithinRange(Prompt, Min, Max);
            GetChoiceStringOne(Prompt, S1, S2);
            GetChoiceStringTwo(Prompt, S3, S4, CaseSensitive);
        }

        /* This method will return a valid integer. This method takes a string prompt that is used to ask the user for an integer.*/
        public static int GetInt()
        {
            int value;

            while(!Int32.TryParse(Console.ReadLine(), out value))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write("Try again! Please enter an integer: ");
                }

            }return value;
        }

        public static int GetInt(string Prompt)
        {
            int value;

            while (!Int32.TryParse(Console.ReadLine(), out value))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write(Prompt);
                }
            }
            return value;
        }

        /* This method will return a valid integer that is within a certain range(min and max). This method also takes a string prompt that is used to ask the user for an integer.*/
        public static int GetIntWithinRange(string Prompt, int Min, int Max)
        {
            int value;
            while(true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    {
                        Console.WriteLine("\n");
                        Console.Write("Please enter a valid input:");
                    }
                }
                if (value < Min || value > Max)
                {
                    {
                        Console.WriteLine("\n");
                        Console.Write("Please enter a valid input:");
                        continue;
                    }
                }
                return value;
            }
        }

        /* This method will return a valid double. This method takes a string prompt that is used to ask the user for a double.*/
        public static double GetDouble(string Prompt)
        {
            double dblvalue;

            while (!Double.TryParse(Console.ReadLine(), out dblvalue))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write("Try again! Please enter an integer: ");
                }
            }
            return dblvalue;
        }

        /* This method will return a valid integer that is within a certain range(min and max). This method also takes a string prompt that is used to ask the user for an integer.*/
        public static double GetDoubleWithinRange(string Prompt, int Min, int Max)
        {
            double value;

            while (true)
            {
                if (!Double.TryParse(Console.ReadLine(), out value))
                {
                    {
                        Console.WriteLine("\n");
                        Console.Write("Please enter a valid input:");
                    }
                }
                if (value < Min || value > Max)
                {
                    {
                        Console.WriteLine("\n");
                        Console.Write("Please enter a valid input:");
                        continue;
                    }
                }
                return value;
            }
        }

        /* This method will validate the user’s input against two choices(S1 or S2). This method takes a string prompt that is used to ask the user for a double.*/
        public static double GetChoiceStringOne(string Prompt, double S1, double S2)
        {
            double value;
            bool run = true;

           
                if (!Double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n");
                    Console.Write("Try again! Please enter an integer: ");
                }
                if  (value != S2 || value != S1)
                {
                    Console.WriteLine("Please try again!");
                }
                if (value == S1 || value == S2)
                {
                    run = false;
                }
            
            return value;
        }

        /* This method will validate the user’s input against two choices (S1 or S2). This method takes a string prompt that is used to ask the user for a double. You can choose to have the comparison case sensitive or not.*/
        public static string GetChoiceStringTwo(string Prompt, string S3, string S4, bool CaseSensitive)
        {
            string value;
            bool run = true;
            
            Console.WriteLine("Please enter a string: ");

            while (true)
            {
                value = Console.ReadLine();
                
                if (value != S3 || value != S4)
                {
                    Console.WriteLine("Please try again!");
                }

                if (value == S3 || value == S4)
                {
                    run = false;
                }
                return value;
            }
            
        }
    }
}
