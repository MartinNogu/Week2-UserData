using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünnniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");



        }
    }
}
