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
            string S1, S2;
            int Min, Max, rvalue;
            bool CaseSensitive;

            Console.Write("Please enter a value: ");
            string Prompt = Console.ReadLine();

            int value = GetInt();

            Console.WriteLine(value);
            
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

            Random rnd = new Random();
            int num = rnd.Next(Min, Max);

            while (!Int32.TryParse(Console.ReadLine(), out value))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write(Prompt);
                }

            }
            return value;
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
            Double dblvalue;

            Random rnd = new Random();
            int num = rnd.Next(Min, Max);

            while (!Double.TryParse(Console.ReadLine(), out dblvalue))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write(Prompt);
                }

            }
            return dblvalue;
        }


        ///* This method will validate the user’s input against two choices(S1 or S2). This method takes a string prompt that is used to ask the user for a double.*/
        //public static string GetChoiceString(string Prompt, string S1, string S2)
        //{
        //    double value;

        //    while (!Double.TryParse(Console.ReadLine(), out value))
        //    {
        //        {
        //            Console.WriteLine("\n");
        //            Console.Write("Try again! Please enter an integer: ");
        //        }

        //    }
        //    double value;
        //}


        ///* This method will validate the user’s input against two choices (S1 or S2). This method takes a string prompt that is used to ask the user for a double. You can choose to have the comparison case sensitive or not.*/
        //public static string GetChoiceString(string Prompt, string S1, string S2, bool CaseSensitive)
        //{

        //}
    }
}
