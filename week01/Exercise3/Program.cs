Random random = new Random();

string playAgain;

do
{
    int magicNumber = random.Next(1, 101);

    int guess = -1;
    int guesses = 0;

    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        guesses++;

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

    Console.WriteLine($"You guessed it in {guesses} tries.");

    Console.Write("Do you want to play again? (yes/no): ");
    playAgain = Console.ReadLine().ToLower();

} while (playAgain == "yes");