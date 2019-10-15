namespace ConsoleApp
{
    using System;

    internal class Ex01
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");

            string firstNumberAsString = Console.ReadLine();
            int firstNumber = int.Parse(firstNumberAsString);

            Console.Write("Enter second number: ");

            string secondNumberAsString = Console.ReadLine();
            int secondNumber = int.Parse(secondNumberAsString);

            // Mul
            int mulResult = firstNumber * secondNumber;
            Console.WriteLine("Mul result: " + mulResult);


            // Div
            if (secondNumber == 0)
            {
                Console.WriteLine("Div not possible");
            }
            else
            {
                int divResult = firstNumber / secondNumber;

                Console.WriteLine("Div result: " + divResult);
            }


            // Min and max
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("First number equal with second number!");
            }
            else
            {
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine("Min is first number: " + firstNumber);
                    Console.WriteLine("Max is second number: " + secondNumber);
                }
                else
                {
                    Console.WriteLine("Min is second number: " + secondNumber);
                    Console.WriteLine("Max is first number: " + firstNumber);
                }
            }
        }
    }
}