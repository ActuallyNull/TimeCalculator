using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
{
    internal class AdditionAndSubstraction
    {

        public static void additionHours()

        {

            DateTime dt = DateTime.Now;
            Console.WriteLine("How many hours would you like to add to your local time?");
            int add = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calculating.");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            var dtadded = dt.AddHours(add);
            Console.WriteLine(dtadded.ToString("H:mm"));

            
        }

        public static void substractionHours()
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine("How many hours would you like to substract to your local time?");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating.");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            int substract = add * -1;
            var dtsubstracted = dt.AddHours(substract);
            Console.WriteLine(dtsubstracted.ToString("H:mm"));
        }

        public static void AdditionMinutes()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("How many minutes would you like to add to your local time?");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating.");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            var dtadded = dt.AddMinutes(add);
            Console.WriteLine(dtadded.ToString("H:mm"));


        }

        public static void AdditionSeconds()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("How many seconds would you like to add to your local time?");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating.");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            var dtadded = dt.AddSeconds(add);
            Console.WriteLine(dtadded.ToString("H:mm:ss"));


        }
        public static void SubstractionMinutes()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("How many minutes would you like to substract to your local time?");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating.");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            int substract = add * -1;
            var dtadded = dt.AddMinutes(substract);
            Console.WriteLine(dtadded.ToString("H:mm"));


        }

        public static void SubstractionSeconds()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("How many seconds would you like to substract to your local time?");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating.");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            int substract = add * -1;
            var dtadded = dt.AddSeconds(substract);
            Console.WriteLine(dtadded.ToString("H:mm:ss"));


        }
        

    }
}
