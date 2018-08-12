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

            else if (operation == "subtract")
            {
                Console.WriteLine(Subtraction(Input1, Input2));         
            }

            else if (operation == "multiply")
            {
                Console.WriteLine(Multiply(Input1, Input2));
            }

            else if (operation == "divide")
            {
                Console.WriteLine(Divide(Input1, Input2));
            }


            //Code written to make sure code worked prior to adding function methods
            //int z = Input1 + Input2;
            //Console.WriteLine(z);


            Console.ReadLine();


        }/// <summary>
        /// This method is to add the user inputed integers
        /// </summary>
        /// <param name="input1- number 1-100"></param>
        /// <param name="input2 - number 1-100"></param>
        /// <returns>Adds input1 to input2 and outputs total
        /// </returns>
        
        public static int Addition(int input1, int input2)
        {
            return input1 + input2;
            
        }

        /// <summary>
        /// This method is to subtract the user inputed integers 
        /// </summary>
        /// <param name="input1 - number 1-100"></param>
        /// <param name="input2 - number 1-100"></param>
        /// <returns>Subtracts input1 from input2 and outputs the difference
        /// </returns>

        public static int Subtraction(int input1, int input2)
        {
            return input1 - input2;
        }


        public static int Multiply(int input1, int input2)
        {
            return input1 * input2;
        }


        public static int Divide(int input1, int input2)
        {
            return input1 / input2;
        }
    }

}
