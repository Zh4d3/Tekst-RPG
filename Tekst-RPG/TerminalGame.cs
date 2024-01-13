using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_RPG {
    internal class TerminalGame 
    {
        public void Play() 
        {
            Game game = new Game();

            string wrongWord = "";
            string entry = "";
            string likeness = "";

            string display1 = $"\n\n0xADD0 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}BONES{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAE90 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xADDC {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}TILES{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAE9C {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xADE8 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAEA8 SLATE{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xADF4 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}FA 0xAEB4 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}DAILY" +
            $"\n0xAE00 ITH{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}PACK 0xAEC0 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE0C S{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAECC {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE18 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAED8 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE24 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAEE4 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE30 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAEF0 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE3c {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAEFC {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE48 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAF08 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}" +
            $"\n0xAE54 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}CLUBS 0xAF14 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}WAI";

            string display2 = $"\n0xAE60 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAF20 TS{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}";

            string display3 = $"\n0xAE6C {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}SKULL{GetRandomFillChar()}{GetRandomFillChar()} 0xAF2C {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}";

            string display4 = $"\n0xAE78 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAF38 {GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}DEIT";

            string display5 = $"\n0xAE84 {GetRandomFillChar()}SKIES{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()} 0xAF44 Y{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}{GetRandomFillChar()}";


            for (int i = 4; i > 0; i--)
            {
                Console.Clear();
                string attemptsRemaining = new string('o', i);
                Display(wrongWord, entry, likeness, attemptsRemaining, display1, display2, display3, display4, display5);

                string correctWord = "SKIES";
                string input = Console.ReadLine().ToUpper();

                int Likeness = DetermineLikeness(input, correctWord);

                if (input == correctWord) {
                    wrongWord = ">" + input;
                    entry = ">Entry accepted.";
                    likeness = ">Likeness=" + Likeness;

                    Console.Clear();
                    Display(wrongWord, entry, likeness, attemptsRemaining, display1, display2, display3, display4, display5);

                    Console.WriteLine("Congratz you have successfully hacked into the terminal.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    game.TerroistMissions();
                }

                wrongWord = ">" + input;
                entry = ">Entry denied.";
                likeness = ">Likeness=" + Likeness;
            }

            Console.WriteLine("Sadly, you failed. Type \"Start\" to try again, or type \"Back\" to go back to the missions tab.");
            string tryAgain;
            tryAgain = Console.ReadLine().ToLower();
            if (tryAgain == "start") {
                Console.Clear();
                Play();
            } else if (tryAgain == "quit") {
                Environment.Exit(0);
            } else {
                Console.Clear();
                game.TerroistMissions();
            }
        }

        static void Display(string wrongWord, string entry, string likeness, string attemptsRemaining, string display1, string display2, string display3, string display4, string display5)
        {

            Console.Write($"Welcome to ROBCO Industries (TM) Termlink" +
            "\n\nPassword Required" +
            $"\n\nAttempts Remaining: {attemptsRemaining}" +
            $"{display1}" +
            $"{display2} {wrongWord}" +
            $"{display3} {entry}" +
            $"{display4} {likeness}" +
            $"{display5} >");
        }
        char GetRandomFillChar() 
        {
            char[] fillChar = { '.', '*', '!', '`', '(', ']', '^', '/', '$', ';', '%', '\'', '>', ':', ',', '?', ')', '}', '[', '-', '<', '_', '|', '\"', '+', '#', '{', '=', '@', '\\' };

            Random random = new Random();

            int randomFillCharPicker = random.Next(fillChar.Length);
            return fillChar[randomFillCharPicker];
        }

        static int DetermineLikeness(string input, string correctWord)
        {
            int likeness = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == correctWord[i])
                {
                    likeness++;
                }
            }
            return likeness;
        }

    }
}