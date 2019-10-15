namespace ConsoleApp
{
    using System;

    internal class Ex02
    {
        public static void Run()
        {
            ConvertCinF();

            ConvertFinC();

            NumberOfDays();
        }

        private static void ConvertCinF()
        {
            Console.Write("Enter temp in C: ");

            string input = Console.ReadLine();
            double tempInC = double.Parse(input);

            double tempInF = (tempInC * 1.8) + 32;

            Console.WriteLine($"{tempInC} C = {tempInF} F");
        }

        private static void ConvertFinC()
        {
            Console.Write("Enter temp in F: ");

            string input = Console.ReadLine();
            double tempInF = double.Parse(input);

            double tempInC = (tempInF - 32) / 1.8;

            Console.WriteLine($"{tempInF} F = {tempInC} C");
        }

        private static void NumberOfDays()
        {
            Console.Write("Enter number of days: ");

            string input = Console.ReadLine();
            int nrDays = int.Parse(input);

            const int daysInYear = 365;   // days in a year
            const int daysInMonth = 30;   // days in a month
            const int daysInWeek = 7;     // days in a week

            int daysRemaining = nrDays;

            int numberOfYears = nrDays / daysInYear;
            //daysRemaining = daysRemaining - (numberOfYears * daysInYear);
            daysRemaining = daysRemaining % daysInYear;

            int numberOfMonths = daysRemaining / daysInMonth;
            //daysRemaining = daysRemaining - (numberOfMonths * daysInMonth);
            daysRemaining = daysRemaining % daysInMonth;

            int numberOfWeeks = daysRemaining / daysInWeek;
            //daysRemaining = daysRemaining - (numberOfWeeks * daysInWeek);
            daysRemaining = daysRemaining % daysInWeek;

            Console.WriteLine($"{nrDays} days: {numberOfYears} y, {numberOfMonths} m, {numberOfWeeks} w, {daysRemaining} days");
        }
    }
}