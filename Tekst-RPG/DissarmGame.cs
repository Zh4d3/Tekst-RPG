using System;

namespace Tekst_RPG
{
    internal class DissarmGame
    {
        public bool Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool gameIsCompleted = false;
            Game game = new Game();

            void DissarmMessage()
            {
                Console.WriteLine("Welcome to MI6" +
                    "\nWe are trained in many different scenarios and are happy to have you recruited." +
                    "\n\nWe have just received a serious report of a new terrorist attack taking place in the Hampton Court Maze." +
                    "\nThe attack is estimated to be very dangerous as various C4 bombs have been placed throughout the maze." +
                    "\n\nWe need your help to hack through the maze and disarm the bombs before it is too late.");

                Console.Write("\nType \"Start\" if you are ready to hack and start the timer. Else type \"Back\": ");
                string startSignal = Console.ReadLine().ToLower();
                if (startSignal == "start")
                {
                    Console.Clear();
                    MazeGame();
                }
                else if (startSignal == "back")
                {
                    Console.Clear();
                    game.Start();
                }
                else if (startSignal == "quit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    DissarmMessage();
                }
            }

            void MazeGame()
            {
                Console.WriteLine("" +
                    "\n   ╔═══════════════════╦═══════════════╦═══╦═══╗" +
                    "\n   ║                   ║               ║   ║ X ║" +
                    "\n   ╚═══════════╣   ╦   ╩   ╔═══════════╝   ║   ║" +
                    "\n O                 ║       ║               ║   ║" +
                    "\n   ╔═══════╣   ╦   ╚═══════╬═══╣   ╠═══╗   ║   ║" +
                    "\n   ║           ║           ║           ║   ║   ║" +
                    "\n   ║   ╠═══╗   ╠═══╦═══════╝   ╔═══╗   ╠═══╝   ║" +
                    "\n   ║       ║   ║   ║           ║   ║   ║       ║" +
                    "\n   ║   ╔═══╝   ╩   ║   ╔═══╦═══╝   ╩   ╩   ╔═══╣" +
                    "\n   ║   ║           ║   ║   ║               ║   ║                 Up               Disarm" +
                    "\n   ║   ║   ╔═══════╝   ╩   ║   ╦   ╠═══╗   ║   ║" +
                    "\n   ║   ║   ║               ║   ║       ║   ║   ║                 W" +
                    "\n   ╠═══╝   ║   ╔═══════╗   ║   ╠═══╗   ╚═══╝   ║         Left  A S D  Right         C" +
                    "\n   ║       ║   ║ X     ║   ║   ║   ║           ║" +
                    "\n   ║   ╦   ║   ╚═══╗   ╠═══╝   ╩   ╠═══════════║                Down" +
                    "\n   ║   ║   ║       ║   ║           ║           ║" +
                    "\n   ║   ║   ╚═══╣   ║   ║   ╔═══╦═══╝   ╔═══╣   ║" +
                    "\n   ║   ║           ║   ║   ║   ║       ║       ║" +
                    "\n   ║   ║   ╔═══════╣   ╩   ║   ╩   ╠═══╩═══════╣" +
                    "\n   ║   ║   ║       ║       ║                   ║" +
                    "\n   ║   ║   ╩   ╔═══╩═══╣   ╚═══╣   ╦   ╠═══════╣" +
                    "\n   ║   ║       ║                   ║         X ║" +
                    "\n   ╚═══╩═══════╩═══════════════════╩═══════════╝" +
                    "\n\nYou now need to navigate through the maze." +
                    "\nThis is possible by writing the right path." +
                    "\nTo do this type (all after each other) the correct path, that also disarms every bomb. *BE AWARE THAT YOU HAVE TO FIND THE FASTEST PATH*" +
                    "\nDown below you can see the maze, in which the bombs are located, indicated by the letter \"B\" and your position is indicated by the letter \"O\"." +
                    "\nAn example is: WWDDCA, which moves forward twice, then twice to the right, followed up by disarming a bomb and finally moves to the left." +
                    "\nWhen you believe you have typed the correct path that disarms every bomb, hit enter.");

                string guessedPath = Console.ReadLine().ToLower();
                if (guessedPath == "dddsssassssddwawwddwwddwddssdwdwwwcsssasaaasssassawwwacdsssdsddwdsddc")
                {
                    Console.WriteLine("You have successfully disarmed every bomb in the maze.");
                    gameIsCompleted = true;
                }
                else
                {
                    gameIsCompleted = false;
                }
            }

            DissarmMessage();

            if (gameIsCompleted)
            {
                Console.WriteLine("YIPII");
                return true;
                game.Start();
            }
            else
            {
                Console.WriteLine("Sadly, that wasn't the correct path. Type \"Start\" to try again, or type \"Back\" to go back to the missions tab.");
                string tryAgain;
                tryAgain = Console.ReadLine().ToLower();
                if (tryAgain == "start") {
                    return false;
                    Console.Clear();
                    DissarmMessage();
                } else if (tryAgain == "back") {
                    return false;
                    Console.Clear();
                    game.Start();
                } else if (tryAgain == "quit") {
                    return false;
                    Environment.Exit(0);
                } else {
                    return false;
                    Console.Clear();
                    DissarmMessage();
                }
            }


        }
    }
}
