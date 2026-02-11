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
            Console.Write("Enter Initial winnings: ");
            initial = double.Parse(Console.ReadLine());

            Console.Write("Enter Interest rate %: ");
            ratePercent = double.Parse(Console.ReadLine());

            Console.Write("Enter how many years you wnt to invest: ");
            years = int.Parse(Console.ReadLine());

            //Calculations
            monthlyRate = (ratePercent / 100) / 12;
            months = years * 12;

            futureValue = initial * Math.Pow(1 + monthlyRate, months);

            //Display the results

        }
    }
}
