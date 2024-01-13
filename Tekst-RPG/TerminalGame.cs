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
            string wrongWord = "";
            string entry = "";
            string likeness = "";
            Console.Write($"Welcome to ROBCO Industries (TM) Termlink" +
            "\n\nPassword Required" +
            "\n\nAttempts Remaining: o o o" +
            "\n\n0xADD0 .*!BONES`.(] 0xAE90 ^/$.;%^/`'>%" +
            "\n0xADDC ,:^TILES$?/) 0xAE9C '/??,//:%^,]" +
            "\n0xADE8 }/;!'([(^:-' 0xAEA8 SLATE[;}$>:>" +
            "\n0xADF4 ^<_-|`,->/FA 0xAEB4 [)]:\"+/DAILY" +
            "\n0xAE00 ITH?_?/_PACK 0xAEC0 +(!+(_+)##]%" +
            "\n0xAE0C S},`?_?/-;:, 0xAECC {-?;-{^^?`_|" +
            "\n0xAE18 =<;{%%[+}++! 0xAED8 ,**>>@#_,/)>" +
            "\n0xAE24 _)^>>)]{]^$* 0xAEE4 -.%;(/@[>/?+" +
            "\n0xAE30 [((+%/==>#/< 0xAEF0 *;_$,=,|./{|" +
            "\n0xAE3c ){'##@!}>_*( 0xAEFC ^+*_)/{.>#(|" +
            "\n0xAE48 _^^;\"},')./[ 0xAF08 `*>]//=){)'+" +
            "\n0xAE54 %-(+_*<CLUBS 0xAF14 /`+_+#''>WAI" +
            $"\n0xAE60 ?^'$`]$.#(?/ 0xAF20 TS\"`@('>!>$; {wrongWord}" +
            $"\n0xAE6C |-._,SKULL.< 0xAF2C +,]$*+:^^#-\" {entry}" +
            $"\n0xAE78 /]<@,(/-`(%| 0xAF38 ]^^)^!//DEIT {likeness}" +
            "\n0xAE84 -SKIES%/%^>\" 0xAF44 Y<`-.+#$<^){ >");
            //LAV RANDOM FYLDE ORD (. eller ( eller ] eller * eller ! osv.
            //LAV RANDOM ORD: BONES CLUBS DAILY
            int Likeness = 1;
            string input = Console.ReadLine().ToLower();
            if (input == "daily")
            {
                Console.WriteLine("COMPLETED");
            } else
            {
                wrongWord = ">" + input;
                entry = ">Entry denied.";
                likeness = ">Likeness=" + Likeness;
                Play();
            }
        }
    }
}