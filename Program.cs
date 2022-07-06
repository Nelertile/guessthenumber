using utils;

public class Program
{
    public static int guesses = 0;
    public static int maxGuesses;

    public static int points;
    public static int number;

    public static void Main(string[] args)
    {
        utils.print.ascii("Welcome To... Guess That Number!");
        utils.input.contKey(true);
        utils.print.str("Please chose a difficulty level: (0) 100% Win (1) Easy (2) Medium (3) Hard");
        string difficulty = utils.input.key();
        switch (difficulty)
        {
            case "1":
                maxGuesses = 50;
                break;
            case "2":
                maxGuesses = 25;
                break;
            case "3":
                maxGuesses = 5;
                break;
            default:
                maxGuesses = 100;
                break;
        }
        utils.print.nl();
        utils.input.contKey(true);
        utils.print.str("I'm thinking of a number between 1 and 100.");
        utils.input.contKey(false);
        utils.print.str("Try to guess it in as few attempts as possible.");
        GameLoop();
    }


    public static void GameLoop()
    {
        number = new Random().Next(1, 101);
        guesses = 0;

        while (guesses < maxGuesses)
        {
            utils.print.str("Guess a number between 1 and 100: ");
            string guess = utils.input.line();
            int guessInt;
            int.TryParse(guess, out guessInt);
            guesses++;
            if (guessInt == number)
            {
                utils.print.str("You got it right! It took you " + guesses + " guesses.");
                points += (maxGuesses - guesses);
                playAgain();
                return;
            }
            else if (guessInt < number)
            {
                utils.print.str("Your guess is too low.");
            }
            else
            {
                utils.print.str("Your guess is too high.");
            }
        }

        if (guesses >= maxGuesses)
        {
            utils.print.str("You lose! The number was " + number + ".");
            points -= guesses;
        }
        playAgain();

        void playAgain()
        {
            utils.input.contKey(true);
            utils.print.str("Would you like to play again? (Y/n)");
            string playAgain;
            playAgain = utils.input.key();
            playAgain.ToLower();
            if (playAgain == "y")
            {
                utils.general.clear();
                GameLoop();
            }
            else if (playAgain == "n")
            {
                utils.general.clear();
                utils.print.str("Thanks for playing!");
                utils.print.str("Your final score was " + points + ".");
                utils.input.contKey(false);
                return;
            }
            else
            {
                utils.general.clear();
                GameLoop();
            }
        }
    }
}