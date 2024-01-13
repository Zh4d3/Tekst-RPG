using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_RPG 
{
    internal class Game 
    {
            public void Start() 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Go to fullscreen and type \"Start\" to continue: ");
                string inputStart = Console.ReadLine().ToLower();
                if (inputStart == "start") {
                    Console.Clear();
                    /*MatrixRain matrixRain = new MatrixRain();          //BENYT HVIS VI BRUGER MatrixRain.
                    matrixRain.Run();*/
                    Console.Clear();
                    MainMenuScreen();
                } else if (inputStart == "quit")
                {
                    Environment.Exit(0);
                } else 
                {
                    Console.Clear();
                    Start();
                }
            }

            public void MainMenuScreen() 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("" +
                "\n                                                                                    HACKMASTER\n\n" +
                "\n                                                                                     `-:/+/:-`" +
                "\n                                                                                 `:ohmmmmmmmmmdy+-" +
                "\n                                                                               `/hmmmmmmmmmmmmmmmmh+." +
                "\n                                                                              `smmmmmmmmmmmmmmmmmmmmms." +
                "\n                                                                             `ymmmmy/..+dmmmmmmmmmmmmmd:" +
                "\n                                                                            `ommmh:     -dmmmmmmmmmmmmmm-" +
                "\n                                                                            -dmmy.       +mmmmmy+/odmmmmy`" +
                "\n                                                                           `ommy`        :mmm+`    .dmmmm`" +
                "\n                                                                           `hmm+        `smd-      `ommmm." +
                "\n                                                                           `hmmmyo/-..-/ymms        /mmy`" +
                "\n                                                                            -shdmmmmmmmmmmmd.       /mmm:" +
                "\n                                                                              ```.:dmmmmmmmmmo.    `ommo" +
                "\n                                                                                  `smmmmmmmmmmmdo/-+mmo`" +
                "\n                                                                                  :mmmmmmmmmmsoshmmmh/" +
                "\n                                                                                 `smmmmmmmmm/    ``.``" +
                "\n                                                                                  `-:y+mmdmm." +
                "\n                                                                                       ...+:\n" +
                "\n                                                                         *** Welcome to hacker terminal ***" +
                "\n                                                                           Type 'Start', to start hacking." +
                "\n                                                                        Type 'Quit' to exit terminal anytime.");
                Console.Write("\n                                                                                        ");
                string inputMenu = Console.ReadLine().ToLower();
                if (inputMenu == "start") {
                    SideSelect();
                } else if (inputMenu == "quit")
                {
                    Environment.Exit(0);
                } else
                {
                    Console.Clear();
                    MainMenuScreen();
                }
            }

            public void SideSelect() 
            {
                Console.Clear();
                Console.WriteLine("Here you choose if you want to hack against the terroists (working as the MI6)\nOr if you want to work with the terroists (working against the MI6)\n");
                Console.Write("Type \"MI6\", or \"Terroist\" corresponding with whoever you want to work WITH: ");

                Console.WriteLine("\n\n\n<- Type \"Back\" to go back");

                string inputSelect = Console.ReadLine().ToLower();
                if (inputSelect == "mi6") 
                {
                    Console.WriteLine("Now working for the MI6");
                    Mi6Missions();
                } else if (inputSelect == "terroist")
                {
                    Console.WriteLine("Now working for the terroists");
                    TerroistMissions();
                } else if (inputSelect == "back")
                {
                    Console.Clear();
                    MainMenuScreen();
                } else if (inputSelect == "quit")
                {
                    Environment.Exit(0);
                } else 
                {
                    Console.Clear();
                    SideSelect();
                }
            }

            public void Mi6Missions() 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n   ███╗   ███╗██╗ ██████╗ \r\n   ████╗ ████║██║██╔════╝ \r\n   ██╔████╔██║██║███████╗ \r\n   ██║╚██╔╝██║██║██╔═══██╗\r\n   ██║ ╚═╝ ██║██║╚██████╔╝\r\n   ╚═╝     ╚═╝╚═╝ ╚═════╝ \r\n                          ");
                Console.ForegroundColor = ConsoleColor.Green;

                DissarmGame disarmGame = new DissarmGame();
                /*bool isDisarmUnlocked = false;
                if (isDisarmUnlocked = true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;*/
                    Console.WriteLine("1. Disarm Terroist Attack    - (type \"Disarm\" to hack)");
                /*} else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Disarm Terroist Attack (type \"Disarm\" to hack");
                }*/


                /*if (isUnlocked = true) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;*/
                    Console.WriteLine("2. Dice                      - (type \"Dice\" to hack)");
                /*} else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2. Dice - (type \"Dice\" to hack");
                }*/


                /*if (isUnlocked = true) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;*/
                    Console.WriteLine("3. Fingerprint Blueprint     - (type \"Fingerprint\" to hack)");
                /*} else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3. Fingerprint Blueprint - (type \"Fingerprint\" to hack");
                }*/

                Console.WriteLine("\n\n<- Type \"Back\" to go back");

                string chosenMi6Mission = Console.ReadLine().ToLower();
                if (chosenMi6Mission == "disarm") 
                {
                    Console.Clear();
                    /*isDisarmUnlocked = */disarmGame.Play();
                } else if (chosenMi6Mission == "dice")
                {
                    //Dice();
                } else if (chosenMi6Mission == "fingerprint")
                {
                    //Fingerprint();
                } else if (chosenMi6Mission == "back")
                {
                    SideSelect();
                } else
                {
                    Console.Clear();
                    Mi6Missions();
                }
            }

            public void TerroistMissions() 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n   ████████╗███████╗██████╗ ██████╗  ██████╗ ██╗███████╗████████╗\r\n   ╚══██╔══╝██╔════╝██╔══██╗██╔══██╗██╔═══██╗██║██╔════╝╚══██╔══╝\r\n      ██║   █████╗  ██████╔╝██████╔╝██║   ██║██║███████╗   ██║   \r\n      ██║   ██╔══╝  ██╔══██╗██╔══██╗██║   ██║██║╚════██║   ██║   \r\n      ██║   ███████╗██║  ██║██║  ██║╚██████╔╝██║███████║   ██║   \r\n      ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝╚══════╝   ╚═╝   \r\n                                                                 ");
                Console.ForegroundColor = ConsoleColor.Green;

                TerminalGame terminalGame = new TerminalGame();

                /*if (isUnlocked = true) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;*/
                    Console.WriteLine("1. Riddle              - (type \"Riddle\" to hack)");
                /*} else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Riddle (type \"Riddle\" to hack");
                }*/


                /*if (isUnlocked = true) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;*/
                    Console.WriteLine("2. Terminal Hacking    - (type \"Terminal\" to hack)");
                /*} else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2. Terminal Hacking (type \"Terminal\" to hack");
                }*/


                /*if (isUnlocked = true) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;*/
                    Console.WriteLine("3. Key Blueprint       - (type \"Key\" to hack)");
                /*} else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3. Key Blueprint - (type \"Key\" to hack");
                }*/

                Console.WriteLine("\n\n<- Type \"Back\" to go back");

                string chosenTerroistMission = Console.ReadLine().ToLower().ToLower();
                if (chosenTerroistMission == "riddle") 
                {
                    //Riddle();
                } else if (chosenTerroistMission == "terminal")
                {
                    Console.Clear();
                    terminalGame.Play();
            } else if (chosenTerroistMission == "Key")
                {
                    //Key();
                } else if (chosenTerroistMission == "back")
                {
                    SideSelect();
                } else
                {
                    Console.Clear();
                    TerroistMissions();
                }
            }
    }
}