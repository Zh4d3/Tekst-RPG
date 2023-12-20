using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_RPG {
    internal class Game {

        public void Play() 
            {

            Console.ForegroundColor = ConsoleColor.Green;
            Start();

            static void Start() 
            {
                Console.WriteLine("Go to fullscreen and type \"Start\" to continue.");
                string input = Console.ReadLine();
                if (input == "Start") {
                    Console.Clear();
                    MatrixRain matrixRain = new MatrixRain();          //BENYT HVIS VI BRUGER MatrixRain.
                    matrixRain.Run();
                    Console.Clear();
                    MainMenuScreen();
                } else 
                {
                    Console.Clear();
                    Start();
                }
            }

            static void MainMenuScreen() 
            {
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
                "\n                                                                           Type 'start', to start hacking." +
                "\n                                                                        Type 'quit' to exit terminal anytime.");
                string input = Console.ReadLine();
                if (input == "start") 
                {
                    LevelSelect();
                } else if (input == "quit") 
                {
                    Environment.Exit(0);
                } else 
                {
                    MainMenuScreen();
                }
            }

            static void LevelSelect() 
            {
                Console.Clear();
                Console.WriteLine("Kage");
            }

        }

    }
}