using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula05Arrays
    {
        public void Aula5Arrays()
        {
            int[] x = new int[3];
            x[0] = 5;
            x[1] = 10;
            x[2] = 20;
            //x[3] = 30;

            Console.WriteLine(x[1]);
            //Console.WriteLine(x[3]);

            string[] sayajins = new string[2];
            sayajins[0] = "Vegeta";
            sayajins[1] = "Goku";

            string[] dragonBall = new string[] { sayajins[1], "Picollo", "Kuririn", "tenten" };
          
            Console.WriteLine(dragonBall[0]);


        }
    }
}
