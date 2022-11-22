using System;
using Figgle;

namespace TimeConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // intro menu with signature here
            Intro.IntroCard();
            // switch function for different methods
            
            Console.WriteLine(
                                FiggleFonts.Standard.Render("Which operation would you like ?"));
            Console.WriteLine("1: Addition of Hours");
            Console.WriteLine("2: Addition of Minutes");
            Console.WriteLine("3: Addition of Seconds");
            Console.WriteLine("4: Substraction of Hours");
            Console.WriteLine("5: Substraction of Minutes");
            Console.WriteLine("6: Substraction of Seconds");

            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    AdditionAndSubstraction.additionHours();
                    break;
                case "2":
                    AdditionAndSubstraction.AdditionMinutes();
                    break;
                case "3":
                    AdditionAndSubstraction.AdditionSeconds();
                    break;
                case "4":
                    AdditionAndSubstraction.substractionHours();
                    break;
                case "5":
                    AdditionAndSubstraction.SubstractionMinutes();
                    break;
                case "6":
                    AdditionAndSubstraction.SubstractionSeconds();
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }

            // function testing here



            // bank functions here

        }
    }
}