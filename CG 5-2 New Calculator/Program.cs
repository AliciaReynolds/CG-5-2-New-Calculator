using System;

namespace CG_5_2_New_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This part of the code asks the user for the data that will be used
            to make the calculations throughout the program*/

            Console.WriteLine("Welcome! Let's do some calculations, shall we?");
            Console.WriteLine("Please enter two numbers, each between 1 and 100.");

            
            int Input1 = int.Parse(Console.ReadLine());
            int Input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please pick one of the following functions to perform:");
            Console.WriteLine("Add, Subtract, Multiply, Divide");

            var operation = Console.ReadLine();

            if (operation == "add")
            {
                Console.WriteLine(Addition(Input1, Input2));
            }


            //int z = Input1 + Input2;
            //Console.WriteLine(z);


            Console.ReadLine();


        }
        public static int Addition(int input1, int input2)
        {
            return input1 + input2;
            
        }
    }
}
