using System;

namespace Tekst_RPG
{
    internal class DissarmGame
    {
        //Lucas: Dette var det første spil vi lavede og vi eksperimenterede dermed med hvordan vi kunne få farven i "Game" klassen til at skifte. Dermed lavede vi metoden til en bool, med variablen "isDisarmCompleted" som skulle bruges til at vurdere farven på teksten i "Game" klassen.
        public bool Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool isDisarmCompleted = false;
            Game game = new Game();

            //Lucas: Metode til at udskrive introduktionen.
            void DissarmMessage()
            {
                Console.WriteLine("Welcome to MI6" +
                    "\nWe are trained in many different scenarios and are happy to have you recruited." +
                    "\n\nWe have just received a serious report of a new terrorist attack taking place in the Hampton Court Maze." +
                    "\nThe attack is estimated to be very dangerous as various C4 bombs have been placed throughout the maze." +
                    "\n\nWe need your help to hack through the maze and disarm the bombs before it is too late.");

                Console.Write("\nType \"Start\" if you are ready to hack and start the timer. Else type \"Back\": ");
                //Lucas: Læser inputet og kører metoden "MazeGame" hvis man skriver "start".
                string startSignal = Console.ReadLine().ToLower();
                if (startSignal == "start")
                {
                    Console.Clear();
                    MazeGame();
                }
                else if (startSignal == "back")
                {
                    Console.Clear();
                    game.Mi6Missions();
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
                //Lucas: Udskriver selve spillet og dets tekst.
                Console.WriteLine("" +
                    "\n\nYou now need to navigate through the maze." +
                    "\nThis is possible by writing the right path." +
                    "\nTo do this type (all after each other) the correct path, that also disarms every bomb. *BE AWARE THAT YOU HAVE TO FIND THE FASTEST PATH*" +
                    "\nDown below you can see the maze, in which the bombs are located, indicated by the letter \"B\" and your position is indicated by the letter \"O\"." +
                    "\nAn example is: WWDDCA, which moves forward twice, then twice to the right, followed up by disarming a bomb and finally moves to the left." +
                    "\nWhen you believe you have typed the correct path that disarms every bomb, hit enter." +
                    "\n\n   ╔═══════════════════╦═══════════════╦═══╦═══╗" +
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
                    "\n   ╚═══╩═══════╩═══════════════════╩═══════════╝");

                //Lucas: Tjekker om man har skrevet denne korrekte vej. Hvis man har sættet variablen "isDisarmCompleted" til "true". Ellers har man ike vundet og den sættes til "false".
                string guessedPath = Console.ReadLine().ToLower();

                if (guessedPath == "dddsssassssddwawwddwwddwddssdwdwwwcsssasaaasssassawwwacdsssdsddwdsddc")
                {
                    isDisarmCompleted = true;
                }
                else
                {
                    isDisarmCompleted = false;
                }
            }

            
            DissarmMessage();

            //Lucas: Hvis spillet er vundet skrives tillykke. Derefter går der 2 sekunder før man sendes tilbage til missions-menuen i "Game" klassen. Hvis man ikke vandt læses der om man har skrevet "start" for at prøve igen.
            if (isDisarmCompleted)
            {
                Console.WriteLine("Congratz. You have successfully disarmed every bomb in the maze.");
                Thread.Sleep(2000);
                Console.Clear();
                game.Mi6Missions();
            }
            else
            {
                Console.WriteLine("Sadly, you failed. Type \"Start\" to try again, or type \"Back\" to go back to the missions tab.");
                string tryAgain;
                tryAgain = Console.ReadLine().ToLower();
                if (tryAgain == "start") {
                    Console.Clear();
                    DissarmMessage();
                } else if (tryAgain == "back") {
                    Console.Clear();
                    game.Mi6Missions();
                } else if (tryAgain == "quit") {
                    Environment.Exit(0);
                } else {
                    Console.Clear();
                    DissarmMessage();
                }
            }

            return isDisarmCompleted;
        }
    }
}
