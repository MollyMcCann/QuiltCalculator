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
            Console.Clear();
           Console.Write("Yards or Meters?  ");


            string userInput = GetUserInput();
            try
            {
                ConvertUserInput(userInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Show error message

                userInput = GetUserInput(); // Get user input again
                ConvertUserInput(userInput);
            }

            static string GetUserInput()
            {
                Console.Write("Enter either yd or m:");

                string userInput = Console.ReadLine();
                return userInput;
            }
            static void ConvertUserInput(string userInput)
            {
                // Guard for throwing an error when the user enters another value
                if (!IsValidUserInput(userInput))
                    throw new ArgumentException("Input value is not yd or m");

                if (ConvertFromYardstoMeters(userInput)) // where the error occurs
                {
                    var Y = new ConvertNumber();
                    Y.ConvertM();
                }
                else
                {
                    var l = new ConvertNumber();
                    l.ConvertYD();
                }
            }

            static bool IsValidUserInput(string userInput)
            {
                return ConvertFromYardstoMeters(userInput) || (ConvertFromMetersToYards(userInput));
            }

           static bool ConvertFromMetersToYards(string userInput)
            {
                return userInput == Yd;
            }

            static bool ConvertFromYardstoMeters(string userInput)
            {
                return userInput == M;
            }


            Console.ReadLine();
        }

        //string answer = "";
        //Console.ReadLine();
        //if (answer == "yards" ||answer == "Yards" )
        //{
        //    answer.ToString();
        //    Console.WriteLine("how many yards do you have?");

        //}
        //Console.ReadLine();                
        //if (answer == "meters" || answer == "Meters")
        //{
        //    Console.WriteLine("how many Meters do you have?");
        //    Console.ReadKey();
        //}
        //else
        //{
        //    Console.WriteLine("only enter Yards or meters");
        //    Console.ReadLine();
        //}



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
            //i must find out how to do the calculation for the amount of squares
        }

    }

 }

