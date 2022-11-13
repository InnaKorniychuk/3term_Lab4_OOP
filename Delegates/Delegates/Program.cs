using Microsoft.Win32.SafeHandles;
using System;
using System.Globalization;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] nums = new int[2, 3];
            System.Console.WriteLine("You have an array 2x3 of integers, write 6 numbers to fill it: ");
            for (int i = 0; i <2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Write: ");
                    nums[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            int choice = 0;int index = 0;
            while (choice < 2)
            {
                
                Console.WriteLine("Chose an option: ");
                Console.WriteLine("1.Anonymous function");
                Console.WriteLine("2.Lambda expression");
                index= Convert.ToInt16(Console.ReadLine());
                switch (index)
                {
                    case 1:
                    Console.WriteLine("Anonymous function\n Sum: " + LambdaAnonymous.CountAnonymousFunction(nums));
                        break;
                    case 2:
                        Console.WriteLine("Lambda expression\n Sum: " + LambdaAnonymous.CountLambda(nums));
                        break;
                       default:
                        Environment.Exit(0);
                        break;

                }
                choice++;
               
            }
            choice = 0;
            Console.WriteLine("-------------------------------");
            int firstOperand = 2147483647,
                secondOperand = 2;
            Arithmetic operationsOverflow = new Arithmetic(firstOperand, secondOperand);
            operationsOverflow.Calculate();
            Console.WriteLine($"Results for {firstOperand} and {secondOperand}");
            while (choice < 20)
            {
                Console.WriteLine("Chose an option: \n 1.Adding\n 2.Substracting\n 3.Miltiplying\n 4.Dividing\n 5.Exit" );
                index = Convert.ToInt16(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Console.WriteLine("Adding: "+ operationsOverflow.AddingResult);
                        break;
                    case 2:
                        Console.WriteLine("Subtracting: "+operationsOverflow.SubtractingnResult);
                        break;

                    case 3:
                        Console.WriteLine("Multiplying: " + operationsOverflow.MultiplyingResult);
                        break;
                    case 4:
                        Console.WriteLine(" Dividing: "+operationsOverflow.DividingResult);
                        break;
                    case 5:
                        choice = 20;
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                }
                choice++;

               
            }
            choice = 0;
            Console.WriteLine("-------------------------------");
            firstOperand = 8;
            secondOperand = 2;
            Console.WriteLine($"Result for {firstOperand} and {secondOperand}");
            Arithmetic operations = new Arithmetic(firstOperand, secondOperand);
            operations.Calculate();
            while (choice < 20)
            {
                Console.WriteLine("Chose an option: \n 1.Adding\n 2.Substracting\n 3.Miltiplying\n 4.Dividing\n 5.Exit");
                index = Convert.ToInt16(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Console.WriteLine("Adding: " + operations.AddingResult);
                        break;
                    case 2:
                        Console.WriteLine("Subtracting: " + operations.SubtractingnResult);
                        break;

                    case 3:
                        Console.WriteLine("Multiplying: " + operations.MultiplyingResult);
                        break;
                    case 4:
                        Console.WriteLine(" Dividing: " + operations.DividingResult);
                        break;
                    case 5:
                        choice = 20;
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                }
                choice++;

                
            }
            //Console.WriteLine($"Result for {firstOperand} && {secondOperand}:\n Adding: {operations.AddingResult}\n" +
            //    $" Subtracting: {operations.SubtractingnResult}\n Multiplying: {operations.MultiplyingResult}\n" +
            //    $" Dividing: {operations.DividingResult}");

            //Console.ReadLine();
        }
    }
}
