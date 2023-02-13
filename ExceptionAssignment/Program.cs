using System;
using System.Collections.Generic;


namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 2, 4, 8, 16, 32, 64, 128 };
                Console.WriteLine("Please type in number");

                int divNum = Convert.ToInt32(Console.ReadLine());



                foreach (int number in numbers)
                {
                    Console.WriteLine("Dividing " + number + " by " + divNum + "...");
                    int result = Convert.ToInt32(number) / Convert.ToInt32(divNum);
                    Console.WriteLine(result);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("You can't use that value!");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!!!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}