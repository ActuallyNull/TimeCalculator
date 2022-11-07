using System;

namespace TimeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int UTC = -5;
            var dt = DateTime.Now;
            var dttime = dt.ToString("H:mm");
            var dtinttime = dt.ToUniversalTime();
            var dtinttime2 = dt.AddHours(-5);
            Console.WriteLine(dt);
            Console.WriteLine(dttime);
            Console.WriteLine(dtinttime);
            Console.WriteLine(dtinttime2);

        }
    }
}