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

            /*This chunk of code converts inputed numbers the user provides and converts
            them to integers that will be used in the calculations.*/
            int Input1 = int.Parse(Console.ReadLine());
            int Input2 = int.Parse(Console.ReadLine());

            /*This line of code is asking the user to decide on what function the calculator
            needs to perform on the integers*/
            Console.WriteLine("Please pick one of the following functions to perform:");
            Console.WriteLine("Add, Subtract, Multiply, Divide");

            /*This variable is taking the inputed function from the user and making it 
            accessible for the if statement that will be doing the calculations*/
            var operation = Console.ReadLine();

            //if statements used to decide what function to use and then outputing that answer

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

            else
            {
                Console.WriteLine("Sorry.  I did not understand what you entered.")
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

        /// <summary>
        /// This method is to multiply the user inputed integers
        /// </summary>
        /// <param name="input1 - number 1-100"></param>
        /// <param name="input2 - number 1-100"></param>
        /// <returns>Multiplies input1 to input2 and outputs the product.
        /// </returns>        
        public static int Multiply(int input1, int input2)
        {
            return input1 * input2;
        }

        /// <summary>
        /// This method divides the user inputed integers
        /// </summary>
        /// <param name="input1 - number 1-100"></param>
        /// <param name="input2 - number 1-100"></param>
        /// <returns>Divides input1 by input2 and outputs the quotient.
        /// </returns>
        public static double Divide(double input1, double input2)
        {
            //Code used to try and get decimals to show in answer - did not work
            //var Answer = Convert.ToDouble(input1 / input2);
            //return Answer;
            return input1 / input2;
        }
    }

}
