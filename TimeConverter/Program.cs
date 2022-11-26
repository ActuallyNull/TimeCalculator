using System;
using Figgle;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TimeCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            FullScreenTest.DeezNutz();
            // function to make it fullscreen i dont care i called it deeznutz
            Start();
            }

        static void Start() 
            {
                Intro.IntroCard();
                Console.WriteLine(
                                FiggleFonts.Standard.Render("Which operation would you like ?"));
                Console.WriteLine("1: Addition of Hours");
                Console.WriteLine("2: Addition of Minutes");
                Console.WriteLine("3: Addition of Seconds");
                Console.WriteLine("4: Substraction of Hours");
                Console.WriteLine("5: Substraction of Minutes");
                Console.WriteLine("6: Substraction of Seconds");
                Console.WriteLine("7. Converting to Coordinated Universal Time (UTC)");

                string choice = Console.ReadLine();
                switch (choice)
                {
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
                    case "7":
                    Thread.Sleep(500);
                        Methods.UTC();
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;


                }
            Thread.Sleep(1000);
            Console.WriteLine("Would you like to restart? Y/N");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Y":
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.Beep();
                    Start();
                    break;
                case "y":
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.Beep();
                    Start();
                    break;
                case "N":
                    Thread.Sleep(500);
                    break;
                case "n":
                    Thread.Sleep(1000);
                    break;



            }
            // function testing here


            // bank functions here

        }
    }
}