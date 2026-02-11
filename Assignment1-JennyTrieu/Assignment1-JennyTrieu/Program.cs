///<summary>
/// FutureValue.cs
/// Description : A program to calculate what the prize will be worth if invested into a savings account
/// Author : Jenny Trieu
/// Date : Febuary 10 2026
///</summary>

using System;

namespace Assignment1_JennyTrieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Varibles 
            double initial;
            double ratePercent;
            double monthlyRate;
            double futureValue;
            int months;
            int years;

            //Prompt user to put in the input
            Console.WriteLine("Enter Initial winnings: ");
            initial = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Interest rate %: ");
            ratePercent = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many years you wnt to invest: ");
            years = int.Parse(Console.ReadLine());
        }
    }
}
