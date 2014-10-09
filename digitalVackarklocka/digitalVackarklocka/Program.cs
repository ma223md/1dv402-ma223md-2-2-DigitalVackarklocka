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
            string dottedLine = "-----------------------------------";
            // Instansierar AlarmClock-objekt
            AlarmClock alarmClock = new AlarmClock();

            // test av standardkonstruktor
            ViewTestHeader("Test 1.");
            ViewTestHeader("Test av standardkonstruktor");
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine(dottedLine);

            // testa konstruktor med 2 parametrar
            ViewTestHeader("Test 2.");
            ViewTestHeader("Test av konsturktorn med 2 parametrar");
            alarmClock.Hour = 9;
            alarmClock.Minute = 42;
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine(dottedLine);

            // testa konstruktor med 4 parametrar
            ViewTestHeader("Test 3.");
            ViewTestHeader("Test av konsturktorn med 4 parametrar");
            alarmClock.Hour = 13;
            alarmClock.Minute = 24;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine(dottedLine);

            // testa TickTock()-metoden
            ViewTestHeader("Test 4.");
            ViewTestHeader("Ställer befintligt AlarmClock-objekt till 23:58 och låter det gå 13 minuter");
            alarmClock.Hour = 23;
            alarmClock.Minute = 58;
            //kör klockan 13 minuter
            ClockHeader();
            Run(alarmClock, 13);
            Console.WriteLine(dottedLine);

            // testa att alarm indikeras
            ViewTestHeader("Test 5.");
            ViewTestHeader("Ställer befintligt AlarmClock-objekt till 6:12 med alarmtiden till 6:15, och låter den gå 6 minuter");
            alarmClock.Hour = 6;
            alarmClock.Minute = 12;
            alarmClock.AlarmHour = 6;
            alarmClock.AlarmMinute = 15;

            // Kör väckarklocka 6 minuter
            ClockHeader();
            Run(alarmClock, 6);
            Console.WriteLine(dottedLine);

            // testa egenskaper för undantag för felaktiga tider
            ViewTestHeader("Test 6.");
            Console.WriteLine("Test av egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");
            // Fånga exception om timmen inte är 0-23
            try
            {
                alarmClock.Hour = 45;
            }

            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            // Fånga exception om minuten inte är 0-59
            try
            {
                alarmClock.Minute = 67;
            }

            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            // Fånga exception om alarmtimmen inte är 0-23
            try
            {
                alarmClock.AlarmHour = 45;
            }

            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            // Fånga exception om alarmminuten inte är 0-59
            try
            {
                alarmClock.AlarmMinute = 67;
            }

            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

            Console.WriteLine(dottedLine);
            
            // testa konstruktorer för undantag för felaktiga tider
            ViewTestHeader("Test 7.");
            Console.WriteLine("Test av konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");

            try 
            { 
                AlarmClock acTest = new AlarmClock(24,0,0,0); 
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try 
            { 
                AlarmClock acTest = new AlarmClock(0, 0, 24, 0); 
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            
            Console.WriteLine(dottedLine);
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            // AlarmClock-objekt som anropar TickTock upprepade ggr

            for (int i = 0; i < minutes; i++)
            {
                // Om TickTock returnerar True, visa alarm-meddelande
                bool Alarm = ac.TickTock();
                
                if (Alarm == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(ac.ToString());
                    Console.WriteLine(" BEEP! BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else { Console.WriteLine(ac.ToString()); }
            }   
        }

        private static void ViewErrorMessage(string message)
        {
            // tar felmeddelande som argument och presenterar det
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            // tar sträng som argument och presenterar strängen
            Console.WriteLine(header);
        }

        public static void ClockHeader()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
        }

    }
}
