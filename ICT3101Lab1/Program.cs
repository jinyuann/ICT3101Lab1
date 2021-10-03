using System;

namespace ICT3101Lab1
{   /*Epic
    Allow users to perform their quality metric calculations via the calculator program*
    
    1.As a user i want to use the defect density formula so that i can calculate the new total SSI in the second release of the system
    2.As a user i want to use the Musa logarithmic model so that i can calculate the failure intensity and the number of expected failures
    */
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Calculator _calculator = new Calculator();
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";
                string numInput4 = "";
                double result = 0;
                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }
                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }
                // Ask the user to type the third number.
                Console.Write("Type another number, and then press Enter: ");
                numInput3 = Console.ReadLine();
                double cleanNum3 = 0;
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput3 = Console.ReadLine();
                }
                Console.Write("Type another number, and then press Enter: ");
                numInput4 = Console.ReadLine();
                double cleanNum4 = 0;
                while (!double.TryParse(numInput4, out cleanNum4))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput3 = Console.ReadLine();
                }
                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta -Add");
                Console.WriteLine("\ts -Subtract");
                Console.WriteLine("\tm -Multiply");
                Console.WriteLine("\td -Divide");
                Console.WriteLine("\tf -Factorial of the first number entered");
                Console.WriteLine("\tt -Area of triangle first number height second length");
                Console.WriteLine("\tc -Area of circle first number radius");
                Console.WriteLine("\tp -Permuatations");
                Console.WriteLine("\tC -Combinations");
                Console.WriteLine("\tM -MTBF");
                Console.WriteLine("\tA -AVAILABILITY");
                Console.WriteLine("\tDD -Defect Desnity first number defect second number size");
                Console.WriteLine("\tSSI -Shipped source instruction first number 1st release second number 2nd release third number duplicates,errors,etc");
                Console.WriteLine("\tFIL -Failure intensity logarithmic first number beta second number experienced failure third numer initial failure");
                Console.WriteLine("\tNFL -Number of expected failure logarithmic first number beta second number initial failure third numer time");
                Console.WriteLine("\tFIB -Failure intensity basic first number failureinifinite, second number experiencedfailure, third number faillurecpuhour");
                Console.WriteLine("\tNFB -Number of expected failure basic first number failureinifinite, second number faillurecpuhour,third time");
                Console.WriteLine("\t1 -Logarithmic single command 1st:beta 2nd:failurecpuhour 3rd:time 4th experiencedfailure ");
                Console.Write("Your option? ");
                string op = Console.ReadLine();
                try
                {
                    result = _calculator.DoOperation(cleanNum1, cleanNum2, cleanNum3,cleanNum4, op);
                    if (double.IsNaN(result))
                    { Console.WriteLine("This operation will result in a mathematical error.\n"); }
                    else if (result == 0)
                    {
                        Console.WriteLine(" ");
                    }
                    else
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                { Console.WriteLine("Oh no! An exception occurred trying math.\n -Details: " + e.Message); }
                Console.WriteLine("------------------------\n");
                // Wait for the user to respond before closing.
                Console.Write("Press 'q' and Enter to quitthe app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
                Console.WriteLine("\n");
                // Friendly linespacing.
            }
            return;
        }
    }
}
