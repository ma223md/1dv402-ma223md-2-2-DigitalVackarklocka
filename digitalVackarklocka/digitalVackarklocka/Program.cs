using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalVackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instansierar AlarmClock-objekt
            AlarmClock alarmClock = new AlarmClock();

            // test av standardkonstruktor

            // testa standardkonstruktor med 2 parametrar

            // testa standardkonstruktor med 4 parametrar

            // testa TickTock()-metoden

            // testa att alarm indikeras

            // testa egenskaper för undantag för felaktiga tider

            // testa konstruktorer för undantag för felaktiga tider
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            // AlarmClock-objekt som anropar TickTock upprepade ggr
        }

        private static void ViewErrorMessage(string message)
        {
            // tar felmeddelande som argument och presenterar det
        }

        private static void ViewTestHeader(string header)
        {
            // tar sträng som argument och presenterar strängen
        }

    }
}
