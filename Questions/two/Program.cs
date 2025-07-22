using System;
class Two
{
    static void Main(string[] args)
    {
       
       
             System.Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                System.Console.WriteLine("The number is positive");
            }
            else if (num < 0)
            {
                System.Console.WriteLine("The number is negative");
            }
            else
            {
                System.Console.WriteLine("The number is zero");
            }
        }
    }

