using System;

namespace nicks_burner
{
    class Program
    {
        private const bool V = true;

        static void Main(string[] args)
        {
            string swearWord = "fiddlesticks";
            int funnyNum;
            funnyNum = 420;
            bool hot = true ;

            //variables need to be declared by type first (string, int, ect...), then named. Value can be given after that.
            //int variables don't need quotation marks
            //number variables with decimals are classified as float, double, or decimal

            //EOD TASKS 
                //get an if/else statemnet going based on static data
                //get if/else statement going for user inputted data
                //code in some math examples that c# can handle

            Console.WriteLine("Hello World!"); //Basic string
            Console.WriteLine("Noice! not " + swearWord); //string + var
            Console.WriteLine("Can I do this in real time? or just at " + funnyNum + "?"); //string + var + string
            Console.WriteLine("No, I need to to stop running program to add data. You run by clicking on 'run' tab and run without debugging."); // explanation
            Console.WriteLine("Is Nick hot? " + hot);//using the boolean var
            if(hot == true)
            {
                Console.WriteLine("Boolean and if else worked.");
            }
            else
            {
                Console.WriteLine("Wack.");
            }
            Console.ReadLine();

        }
    }
}