namespace ToolboxH1
{
    internal class DIexample
    {

// Define the public enum for choices
public enum Choice
    {
        Stone,
        Scissors,
        Paper
    }

    // Define the interface
    public interface IPlayer
    {
        Choice GetChoice();
    }

    // Implement the interface
    public class RandomPlayer : IPlayer
    {
        private readonly Random _random;

        public RandomPlayer()
        {
            _random = new Random();
        }

        public Choice GetChoice()
        {
            // Generate a random number between 0 and 2
            int randomNumber = _random.Next(0, 3);

            // Map the random number to a Choice
            switch (randomNumber)
            {
                case 0:
                    return Choice.Stone;
                case 1:
                    return Choice.Scissors;
                case 2:
                    return Choice.Paper;
                default:
                    throw new InvalidOperationException("Unexpected random number generated.");
            }
        }
    }

    public class GameController
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public GameController(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void PlayGame()
        {
            // Get choices from players
            Choice player1Choice = _player1.GetChoice();
            Choice player2Choice = _player2.GetChoice();

            // Output choices
            Console.WriteLine($"Player 1 choice: {player1Choice}");
            Console.WriteLine($"Player 2 choice: {player2Choice}");

            // Determine the winner
            DetermineWinner(player1Choice, player2Choice);
        }

        private void DetermineWinner(Choice choice1, Choice choice2)
        {
            // Implement logic to determine the winner based on choices
            // This is just a simple example, you can replace it with your own logic
            if (choice1 == choice2)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((choice1 == Choice.Stone && choice2 == Choice.Scissors) ||
                     (choice1 == Choice.Scissors && choice2 == Choice.Paper) ||
                     (choice1 == Choice.Paper && choice2 == Choice.Stone))
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
        }
    }

    public class Program
    {
        public static void StartMain(string[] args)
        {
            // Create instances of players
            IPlayer player1 = new RandomPlayer();
            IPlayer player2 = new RandomPlayer();

            // Create an instance of the game controller
            GameController gameController = new GameController(player1, player2);

            // Play the game
            gameController.PlayGame();
        }
    }

}
}
