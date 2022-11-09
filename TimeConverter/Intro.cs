using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// use pm to import figgle its very cool for ascii console art
// ctrl c + v NuGet\Install-Package Figgle -Version 0.4.1 in package manager console. big thanks to the man himself
using Figgle;

namespace TimeConverter
{
    internal class Intro
    {

        public static void IntroCard()
        {
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");
            Console.WriteLine(
                        FiggleFonts.Ogre.Render("Time Converter!"));
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");



        }


    }
}
