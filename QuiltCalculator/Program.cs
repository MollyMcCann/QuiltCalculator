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

            int userInput = 0;
            do
            {
                userInput = MainMenu();
            } while (userInput != 5);

            //bool showMenu = true;
            //while (showMenu)
            //{
            //    showMenu = MainMenu();
            //}
            //Let's try something else

        }
       static public int MainMenu()
        {
         
            Console.WriteLine("What would you like to do?");
            //calculate how many squares (of different demnsions per various sizes of quilt 
            Console.WriteLine("1) Calculate number of squares needed");
            Console.WriteLine("2) Fabric Measurement Convertor");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);


            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        SquareCount();
            //        return true;
            //    case "2": 
            //        MeasureConvert();
            //        return true;
            //    case "3":
            //        return false;
            //    default:
            //        return true;
            //}

           

        }

        private static void SquareCount()
        {
            Console.Clear();

            Console.WriteLine("how many squares ...");
        }
        private static void MeasureConvert()
        {
            
            Console.WriteLine("lets convert a measurement");

        }
    }
}
// issue is the bool, something about this is going to make i so we wretun to the main menu each time it is called
