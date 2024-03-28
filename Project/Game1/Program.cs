using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inGame = true;
            while (inGame)
            {
                Random getRandomNumber = new Random(); // Create a new instance of the Random class to generate random numbers
                int secretNumber = getRandomNumber.Next(1, 10001); // Generate a random number between 1 and 10000
                int playerAttempts = 0; // Initialize the player's attempt count to 0
                int playerMaxAttempts = 15; // Initialize the maximum number of attempts for the player to 15
                bool playerHasWon = false; // Initialize the variable indicating whether the player has won to false

                Console.WriteLine("Welcome to the guessing game.... Guess the secret number to win a Kinder ;) Good luck!!"); // Display a welcome message to the player
                Console.WriteLine("You have 15 attempts to find the secret number"); // Display the number of attempts the player has

                while (!playerHasWon && playerAttempts < playerMaxAttempts) // Continue the game until the player wins or runs out of attempts
                {
                    Console.WriteLine("Enter a number between 1 and 10000: "); // Prompt the player to enter a number
                    string playerInput = Console.ReadLine(); // Read the player's input from the console

                    if (playerInput == "q") // Check if the player wants to quit the game
                    {
                        Console.WriteLine("Oh no! You're leaving so soon. Don't rage quit!"); // Display a message to the player
                        inGame = false; // Set the inGame variable to false to exit the game loop
                    }

                    playerAttempts++; // Increment the player's attempt count
                    int playerGuessedNumber;  // Declare a variable to store the player's guessed number

                    if (int.TryParse(playerInput, out playerGuessedNumber)) // Check if the player's input can be parsed as an integer
                    {
                        if (playerGuessedNumber > 10000) // Check if the player's number is larger than the maximum possible number
                        {
                            Console.WriteLine("Error: Your number is larger than the maximum possible number. This costs you 2 attempts!"); // Display an error message to the player
                            playerAttempts += 1; // Increment the player's attempt count by 2
                        }
                        else if (playerGuessedNumber < 1) // Check if the player's number is smaller than the minimum possible number
                        {
                            Console.WriteLine("Error: Your number is smaller than the minimum possible number. This costs you 2 attempts!"); // Display an error message to the player
                            playerAttempts += 1; // Increment the player's attempt count by 2
                        }
                        else if (playerGuessedNumber == secretNumber) // Check if the player's guessed number matches the secret number
                        {
                            playerHasWon = true; // Set the playerHasWon variable to true
                            Console.WriteLine("Congratulations! You found the secret number in " + playerAttempts + " attempts"); // Display a congratulatory message to the player
                            inGame = false; // Set the inGame variable to false to exit the game loop
                        }
                        else if (playerGuessedNumber < secretNumber) // Check if the player's guessed number is smaller than the secret number
                        {
                            Console.WriteLine("The secret number is larger than " + playerGuessedNumber); // Display a message to the player
                            Console.WriteLine("You have " + (playerMaxAttempts - playerAttempts) + " attempts left"); // Display the number of attempts the player has left
                        }
                        else // If none of the above conditions are met, the player's guessed number is larger than the secret number
                        {
                            Console.WriteLine("The secret number is smaller than " + playerGuessedNumber); // Display a message to the player
                            Console.WriteLine("You have " + (playerMaxAttempts - playerAttempts) + " attempts left"); // Display the number of attempts the player has left
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid number between 1 and 10000. This costs you 4 attempts!"); // Display an error message to the player
                        playerAttempts += 3; // Increment the player's attempt count by 4
                        Console.WriteLine("You have " + (playerMaxAttempts - playerAttempts) + " attempts left"); // Display the number of attempts the player has left
                    }
                    if (playerAttempts == playerMaxAttempts)  // Check if the player has reached the maximum number of attempts
                    {
                        Console.WriteLine("You have reached the maximum number of attempts. You lost."); // Display a message to the player
                        inGame = false; // Set the inGame variable to false to exit the game loop
                    }
                }
                Console.WriteLine("Thanks for playing! See you soon!"); // Display a message to the player
                Console.WriteLine("Do you want to play again? (y/n)"); // Ask the player if they want to play again
                string replay = Console.ReadLine(); // Read the player's response from the console
                if (replay.ToLower() != "y") // Check if the player's response is not 'y'
                {
                    inGame = false; // Set the inGame variable to false to exit the game loop
                }
            }
        }
    }
}