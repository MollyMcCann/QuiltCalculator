using System;
using System.Runtime.CompilerServices;

namespace QuiltCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quilt Calculator.\n");
            Console.ReadKey();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            
        }
        private static bool MainMenu()
        {
         
            Console.WriteLine("What would you like to do?");
            //calculate how many squares (of different demnsions per various sizes of quilt 
            Console.WriteLine("1) Calculate number of squares needed");
            Console.WriteLine("2) Fabric Measurement Convertor");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    SquareCount();
                    return true;
                case "2":
                    MeasureConvert();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
         
        }

        private static void SquareCount()
        {
            Console.Clear();

            Console.WriteLine("how many squares ...");
        }
        private static void MeasureConvert()
        {
            Console.Clear();
            Console.WriteLine("lets convert a measurement");
        }
    }
}
