using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_RPG {
    internal class MatrixRain {
        static int Counter;
        static Random randomPosition = new Random();

        static int flowSpeed = 100;
        static int fastFlow = flowSpeed + 30;
        static int textFlow = fastFlow + 50;

        static ConsoleColor baseColor = ConsoleColor.DarkGreen;
        static ConsoleColor greenColor = ConsoleColor.Green;
        static ConsoleColor fadedColor = ConsoleColor.White;

        static string endText = "HACKMASTER";
        /*static string endText1 = "" +
                "\n__________________________________" +
                "\n|          `-:/+/:-`             |" +
                "\n|      `:ohmmmmmmmmmdy+-         |" +
                "\n|    `/hmmmmmmmmmmmmmmmmh+.      |" +
                "\n|   `smmmmmmmmmmmmmmmmmmmmms.    |" +
                "\n|  `ymmmmy/..+dmmmmmmmmmmmmmd:   |" +
                "\n| `ommmh:     -dmmmmmmmmmmmmmm-  |" +
                "\n| -dmmy.       +mmmmmy+/odmmmmy` |" +
                "\n|`ommy`        :mmm+`    .dmmmm` |" +
                "\n|`hmm+        `smd-      `ommmm. |" +
                "\n|`hmmmyo/-..-/ymms        /mmy`  |" +
                "\n| -shdmmmmmmmmmmmd.       /mmm:  |" +
                "\n|   ```.:dmmmmmmmmmo.    `ommo   |" +
                "\n|       `smmmmmmmmmmmdo/-+mmo`   |" +
                "\n|       :mmmmmmmmmmsoshmmmh/     |" +
                "\n|      `smmmmmmmmm/    ``.``     |" +
                "\n|       `-:y+mmdmm.              |" +
                "\n|            ...+:               |" +
                "\n__________________________________";

        */
        static char AsciiCharacters {
            get {
                int t = randomPosition.Next(10);

                if (t <= 2) return (char)('0' + randomPosition.Next(10));
                else if (t <= 4) return (char)('a' + randomPosition.Next(27));
                else if (t <= 6) return (char)('A' + randomPosition.Next(27));
                else return (char)(randomPosition.Next(32, 255));
            }
        }

        public void Run() {

            Console.ForegroundColor = baseColor;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.CursorVisible = false;

            int width, height;
            int[] y;
            Initialize(out width, out height, out y);
            int maxIterations = 250;

            for (int iteration = 0; iteration < maxIterations; iteration++) {
                Counter++;
                ColumnUpdate(width, height, y);
            }

        }

        public static int YPositionFields(int yPosition, int height) {
            if (yPosition < 0) return yPosition + height;
            else if (yPosition < height) return yPosition;
            else return 0;
        }

        private static void Initialize(out int width, out int height, out int[] y) {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;
            y = new int[width];
            Console.Clear();

            for (int x = 0; x < width; ++x) { y[x] = randomPosition.Next(height); }
        }

        private static void ColumnUpdate(int width, int height, int[] y) {
            int x;
            if (Counter < flowSpeed) {
                for (x = 0; x < width; ++x) {
                    if (x % 10 == 1) Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(AsciiCharacters);

                    if (x % 10 == 9) Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    int temp = y[x] - 2;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(AsciiCharacters);

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(' ');
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            } else if (Counter > flowSpeed && Counter < fastFlow) {
                for (x = 0; x < width; ++x) {
                    Console.SetCursorPosition(x, y[x]);
                    if (x % 10 == 9) Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    Console.Write(AsciiCharacters);

                    y[x] = YPositionFields(y[x] + 1, height);
                }
            } else if (Counter > fastFlow) {
                for (x = 0; x < width; x++) {
                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(' ');

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(' ');

                    if (Counter > fastFlow && Counter < textFlow) {
                        if (x % 10 == 9) Console.ForegroundColor = fadedColor;
                        else Console.ForegroundColor = baseColor;

                        int temp = y[x] - 2;
                        Console.SetCursorPosition(x, YPositionFields(temp, height));
                        Console.Write(AsciiCharacters);
                    }

                    Console.SetCursorPosition(width / 2, height / 2 - 1);
                    Console.Write(endText);

                    /*Console.SetCursorPosition(width / 2, height / 2 + 1);
                    Console.Write(endText1.Replace("\n", Environment.NewLine));*/

                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
        }
    }
}
