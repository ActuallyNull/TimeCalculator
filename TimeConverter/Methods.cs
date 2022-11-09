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
            // ToUniversalTime = UTC (universal coordin)
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
    }
}
