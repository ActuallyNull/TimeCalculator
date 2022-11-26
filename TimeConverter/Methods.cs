using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
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
    }
}
