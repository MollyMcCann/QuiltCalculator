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

            bool userInput = true;
            while (userInput)
            {
                userInput = DisplayMenu();
            }
            

            
        }

        private static bool DisplayMenu()
        {


            Console.Clear();
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("1) Calculate number of squares needed");
            Console.WriteLine("2) Fabric Measurement Convertor");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
           // var result = Console.ReadLine();


            switch (Console.ReadLine())
            {
                case "1":
                    CalculateSquares();
                    return true;
                case "2":
                    FabricMeasurement();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void FabricMeasurement()
        {
            throw new NotImplementedException();
        }

        public static void CalculateSquares()
        {
            Console.Clear();
            Console.WriteLine(" Lets calculate how many squares");
            Console.WriteLine("What is the desired length of you quilt? ");
            decimal lengthSide = decimal.Parse(Console.ReadLine());
            Console.Write("what is the desires width the width of your quilt: ");
            decimal widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthSide * widthSide;
            Console.WriteLine("The area of your quilt is: {0}", area);
            Console.ReadLine();
        }

    }

 }

