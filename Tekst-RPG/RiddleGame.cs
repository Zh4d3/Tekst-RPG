using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Tekst_RPG {
    internal class RiddleGame {
        protected int score;

        public virtual void Play() {
            //Christian: Her skriver vi en velkomst til spilleren hvor vi giver dem noget lore og forklaring til spillet.
            Console.WriteLine("Welcome soldier!" +
                "\nWe are very thankful for having you help us defeat the evil empire, the government! " +
                "\nWe are planning a full scale attack, and we have already done some heavy damage to their weapon system. " +
                "\nAll we need you to do is hack these last few questions! " +
                "\nThey are very hard, but you just need to answer 3/5 questions correctly. " +
                "\nBest of luck my tog g, machala brother!");

            score = 0;
        }

        //ask question method
        //Christian: Her laver vi en method some vi bruger senere til at stille spørgsmål. 
        protected void AskQuestion(string question, string correctAnswer) {

            Console.WriteLine(question);
            string userAnswer = Console.ReadLine();

            //Christian: her tjekker vi at hvis ens userSvar er det samme som korrekte svar så for man points, og ellers er det forkert svar.
            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase)) {
                Console.Clear();
                Console.WriteLine("Correct!\n");
                score++;
            } else {
                Console.Clear();
                Console.WriteLine("Incorrect. The correct answer is: " + correctAnswer + "\n");
            }
        }
    }
    internal class Riddle : RiddleGame {
        public override void Play() {
            base.Play();

            //Christian: her bruger vi metoden fra før, hvor det første set string er spørgsmålet og sidste set string er det rigtige svar. Så i metoden bliver spørgsmålet spillet, og for et svar sputtet tilbage og tjekker om det er det samme som det sidste set string.
            AskQuestion("How many months has 28 days", "12");
            AskQuestion("When Henrick was 6 years old, his little sister was half his age. \nHow old will will his sister be when henrick is 40 years old?", "37");
            AskQuestion("There are 5 friends in a college dorm\nBente is listening to music on her phone\nVita is frying an egg\nRiggie is playing a game of chess\nPerniel is doing her nails\nWhat is the 5th person doing?", "chess");
            AskQuestion("I have roads, but no asphalt\nI have rivers, but no fish\nI have forests, but no trees\nI contain the whole world, but no humans\nWhat am i?", "Atlas");
            AskQuestion("There are 2024 people in a room\nThey now form a circle, and turn to face towards each other.\nThere are now 1000 people facing each other\nThey now turn the opposite direction\nHow many are now facing each other?", "1000");

            //Christian: her tjekker vi hvor mange points man har fået og derefter skrives i console om man har klaret sin opgave eller ej. 
            if (score < 3) {
                Console.Clear();
                Console.WriteLine("You have failed this city!");
            } else {
                Console.Clear();
                Console.WriteLine($"You have answered {score}/5 questions correctly");
                Console.WriteLine("You have successfully destroyed the governments weapon system." +
                    "\nThey are now much more vulnerable " +
                    "\nThanks a lot for your help machala!");
            }
        }
    }
}