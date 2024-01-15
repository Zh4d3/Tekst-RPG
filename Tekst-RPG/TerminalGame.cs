using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_RPG {
    internal class TerminalGame {
        public void Play() {
            Game game = new Game();

            string wrongWord = "";
            string entry = "";
            string likeness = "";

            List<string> wordsList = GetRandomWordList(out string correctWord, out List<string> wrongWordList);

            List<List<string>> lines = new List<List<string>>();

            for (int i = 0; i < 32; i++) {
                List<string> line = new List<string>();

                for (int j = 0; j < 8; j++) {
                    Random random = new Random();
                    int randomIndex = random.Next(wordsList.Count);

                    string selectedWord = wordsList[randomIndex];

                    wordsList.RemoveAt(randomIndex);
                    line.Add(selectedWord);
                }

                lines.Add(line);
            }

            string display1 = $"\n\n0xADD0 {string.Join("", lines[0])} 0xAE90 {string.Join("", lines[1])}" +
            $"\n0xADDC {string.Join("", lines[2])} 0xAE9C {string.Join("", lines[3])}" +
            $"\n0xADE8 {string.Join("", lines[4])} 0xAEA8 {string.Join("", lines[5])}" +
            $"\n0xADF4 {string.Join("", lines[6])} 0xAEB4 {string.Join("", lines[7])}" +
            $"\n0xAE00 {string.Join("", lines[8])} 0xAEC0 {string.Join("", lines[9])}" +
            $"\n0xAE0C {string.Join("", lines[10])} 0xAECC {string.Join("", lines[11])}" +
            $"\n0xAE18 {string.Join("", lines[12])} 0xAED8 {string.Join("", lines[13])}" +
            $"\n0xAE24 {string.Join("", lines[14])} 0xAEE4 {string.Join("", lines[15])}" +
            $"\n0xAE30 {string.Join("", lines[16])} 0xAEF0 {string.Join("", lines[17])}" +
            $"\n0xAE3c {string.Join("", lines[18])} 0xAEFC {string.Join("", lines[19])}" +
            $"\n0xAE48 {string.Join("", lines[20])} 0xAF08 {string.Join("", lines[21])}" +
            $"\n0xAE54 {string.Join("", lines[22])} 0xAF14 {string.Join("", lines[23])}";
            string display2 = $"\n0xAE60 {string.Join("", lines[24])} 0xAF20 {string.Join("", lines[25])}";
            string display3 = $"\n0xAE6C {string.Join("", lines[26])} 0xAF2C {string.Join("", lines[27])}";
            string display4 = $"\n0xAE78 {string.Join("", lines[28])} 0xAF38 {string.Join("", lines[29])}";
            string display5 = $"\n0xAE84 {string.Join("", lines[30])} 0xAF44 {string.Join("", lines[31])}";


            for (int i = 4; i > 0; i--) {
                Console.Clear();
                string attemptsRemaining = new string('o', i);
                Display(wrongWord, entry, likeness, attemptsRemaining, display1, display2, display3, display4, display5);

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
            };

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

        static void Display(string wrongWord, string entry, string likeness, string attemptsRemaining, string display1, string display2, string display3, string display4, string display5) {

            Console.Write($"Welcome to ROBCO Industries (TM) Termlink" +
            "\n\nPassword Required" +
            $"\n\nAttempts Remaining: {attemptsRemaining}" +
            $"{display1}" +
            $"{display2} {wrongWord}" +
            $"{display3} {entry}" +
            $"{display4} {likeness}" +
            $"{display5} >");
        }
        char GetRandomFillChar() {
            char[] fillChar = { '.', '*', '!', '`', '(', ']', '^', '/', '$', ';', '%', '\'', '>', ':', ',', '?', ')', '}', '[', '-', '<', '_', '|', '\"', '+', '#', '{', '=', '@', '\\' };

            Random random = new Random();

            int randomFillCharPicker = random.Next(fillChar.Length);
            return fillChar[randomFillCharPicker];
        }

        List<string> GetRandomWordList(out string correctWord, out List<string> wrongWordList) {
            string correctWord1 = "SKIES";
            List<string> wrongWords1 = new List<string>() { "BONES", "TILES", "SLATE", "DAILY", "CLUBS", "SKULL", correctWord1 };
            for (int i = 0; i < 249; i++) 
            {
                wrongWords1.Add(Convert.ToString(GetRandomFillChar()));
            }

            string correctWord2 = "WAKES";
            List<string> wrongWords2 = new List<string>() { "TAKEN", "TREES", "WRITE", "GHOST", "SHINY", "SKIES", "RAISE", "WAVES", correctWord2 };

            for (int i = 0; i < 247; i++) 
            {
                wrongWords2.Add(Convert.ToString(GetRandomFillChar()));
            }

            string correctWord3 = "BOOST";
            List<string> wrongWords3 = new List<string>() { "GREED", "NOISE", "BOOTS", "SCENE", "CLUBS", "CHEAP", "CHEAT", correctWord3 };

            for (int i = 0; i < 248; i++) 
            {
                wrongWords3.Add(Convert.ToString(GetRandomFillChar()));
            }

            List<string> wordsList = new List<string>() { };

            Random random = new Random();
            int randomChoice = random.Next(3);

            switch (randomChoice) {
                case 0:
                    correctWord = correctWord1;
                    wrongWordList = new List<string>(wrongWords1);
                    break;
                case 1:
                    correctWord = correctWord2;
                    wrongWordList = new List<string>(wrongWords2);
                    break;
                case 2:
                    correctWord = correctWord3;
                    wrongWordList = new List<string>(wrongWords3);
                    break;
                default:
                    Console.WriteLine("An error has occured");
                    correctWord = string.Empty;
                    wrongWordList = new List<string>();
                    break;
            }

            wordsList = new List<string>(wrongWordList) { correctWord };
            return wordsList;
        }

        static int DetermineLikeness(string input, string correctWord) {
            int likeness = 0;

            for (int i = 0; i < input.Length; i++) {
                if (input[i] == correctWord[i]) {
                    likeness++;
                }
            }
            return likeness;
        }

    }
}
