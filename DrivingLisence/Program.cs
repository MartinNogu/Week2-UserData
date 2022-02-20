using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on liiga noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, eet juhilube saada.";
            //kui ksutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada.";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taotelda.";

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - yearOfBirth;

            if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, eet juhilube saada.");
            }
            else if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotelda.");
            }
        }
    }
}
