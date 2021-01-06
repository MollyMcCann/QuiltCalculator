using System;
using System.Runtime.CompilerServices;

namespace QuiltCalculator
{
    class Program
    {
        public const string Yd = "yd"; //User options as constants
        public const string M = "m";
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

            Console.ReadLine();

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

                if (userInput == "yd")
                {
                    ConvertYD();
                }
                else if (userInput == "m")
                {
                    ConvertM();
                }
                else
                {
                    Console.WriteLine("Your input was neither lb nor kg");
                }

                //if (ConvertFromYardstoMeters(userInput)) // where the error occurs
                //{
                //    var y = new ConvertNumber();
                //    y.ConvertM();
                //}
                //else
                //{
                //    var l = new ConvertNumber();
                //    l.ConvertYD();
                //}
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
            static void ConvertYD()
            {
                //changes for yards

                Console.Write("Enter a the amount of Yards you need to convert to Meters:");
                double yards = Convert.ToDouble(Console.ReadLine());
                
                //set up exception handling here... talk to jonathan




                double meters = yards/ 0.9144;
                Console.WriteLine(yards + " yards is" + meters + " Meters " );
                 

            }
            static void ConvertM()
            {

                //changes for meters
                Console.Write("Enter the amount of Meters you need to convert to Yards: n/");
                double meters = Convert.ToDouble(Console.ReadLine());

                double yards = meters * 1.09361;
                Console.WriteLine( yards + " Yards is " + meters + " Meters ");



                Console.ReadLine(); 
            }
        }

       




        public static void CalculateSquares()
        {
            Console.Clear();
            Console.WriteLine(" Lets calculate how many squares");
            Console.WriteLine("What is the desired length of you quilt in inches? ");
            decimal lengthSide = decimal.Parse(Console.ReadLine());
            Console.Write("what is the desired width the width of your quilt in inches: ");
            decimal widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthSide * widthSide;
            Console.WriteLine("The area of your quilt is: {0}", area);
            Console.WriteLine("What are the finished demensions of your squares in inches? ");
            decimal squareSide1 = decimal.Parse(Console.ReadLine());  decimal squareSide2 = decimal.Parse(Console.ReadLine());
            decimal amountofSquares = area/(squareSide1 * squareSide2);
            Console.WriteLine(" the amount of squares you need is: {0}", amountofSquares);

            Console.ReadLine();
          
        }

    }

      
    }

