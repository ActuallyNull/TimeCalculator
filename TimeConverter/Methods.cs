using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    public class Methods
    {
        

        public void UTC()
        {
            
            var datetime = DateTime.Now;
            datetime.ToString("H:mm");
            // ToUniversalTime = UTC (coordinated universal time)
            Console.WriteLine(datetime.ToUniversalTime);

        }
        public static void WhichDay()
        {
            var datetime = DateTime.Now;
            Console.Write(datetime.DayOfWeek + " the ");
            // switches between day numbers
            switch (datetime.Day) 
            {
                case 1:
                    Console.Write(datetime.Day + "rst");
                    break;
                case 2:
                    Console.Write(datetime.Day + "nd");
                    break;
                case 3:
                    Console.Write(datetime.Day + "rd");
                    break;
                default:
                    Console.Write(datetime.Day + "th");
                    break;
            
            }
        
        
        }

        public static void AddwithSub() 
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Would you like to add or substract?");
            // yoinks answer
            string answer = Console.ReadLine();
            if (answer == "add")
            {
                // insert method to be added later for addition of hours, seconds, minutes, milliseconds and others

            } 
            else if (answer == "substract")
            { 
                // insert method to be added later for substractions of hours, seconds, minutes milliseconds and others

            }     
        }
        public static void addition()
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
            Console.WriteLine(dtadded.ToString("H:mm")) ;
           
        }

        public static void substraction()
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

        
    }
}
