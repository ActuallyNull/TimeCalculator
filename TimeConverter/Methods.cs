using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    public class Methods
    {
        

        public static void UTC()
        {
            
            var datetime = DateTime.UtcNow;
            datetime.ToString("H:mm");
            // ToUniversalTime = UTC (coordinated universal time)
            Console.WriteLine(datetime);

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

        
     

        
    }
}
