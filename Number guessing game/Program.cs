using System;
class New
{
    static void Main(String[] args)
    {
        Random rand = new Random();
        int secret = rand.Next(1, 101);
        int attempts = 5;
        bool guessed = false;




        Console.WriteLine("Number Guessing Game");
        Console.WriteLine("Guess a nummber in between 1 to 100(YOu have 5 chances)");
        for (int i = 1; i <= attempts; i++)
        {
            Console.WriteLine($"Attempt no= {i}");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == secret)
            {
                Console.WriteLine("Congratulation u guessed it right");
                guessed = true;
                break;

            }
            else if (guess < secret)
            {
                Console.WriteLine("You were too closed");
            }
            else if (guess > secret)
            {
                Console.WriteLine("Too low");
            }
           
        }
            if (!guessed)
            {
                Console.WriteLine($"yOu losed and ran out of attempts the number was {secret}");
            }
        
    }
}
