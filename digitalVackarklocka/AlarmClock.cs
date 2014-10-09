using System;

namespace DigitalVackarklocka
{ 
    public class AlarmClock
    {
            // fält som kapslas in av egenskapen AlarmHour
            private int _alarmHour;
            // fält som kapslas in av egenskapen AlarmMinute
            private int _alarmMinute;
            // fält som kapslas in av egenskapen Hour
            private int _hour;
            // fält som kapslas in av egenskapen Minute
            private int _minute;

            // egenskapen AlarmHour
            public int AlarmHour
            {
                get {  }
                set {  } // Validera att _alarmHour är mellan 0-23, annars kastas argument exception
            }

            // egenskapen AlarmMinute
            public int AlarmMinute
            {
                get { }
                set { } // Validera att _alarmMinute är mellan 0-59, annars kastas argument exception
            }

            // konstruktor som initierar fälten till deras standardvärden
            public AlarmClock()
            {
                // kalla på konstruktor med 2 parametrar
                AlarmClock(1, 2);
            }

            // konstruktor med 2 parametrar
            public AlarmClock(int hour, int minute)
            {
                // kalla på konstruktorn med 4 parametrar
                AlarmClock(1, 2, 3, 4);
            }

            // konstruktor med 4 parametrar
            public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
            {
                // tilldela fält i klassen värden
            }

            // Metod som anropas för att få klockan att gå en minut, stämmer ny tid med alarmtid ska true returneras
            public bool TickTock()
            {
                return true;
            }

            // Metod som skickar sträng med värdet från ticktock
            public string ToString()
            {
                string str = "hej";
                return str;
            }
    }
}
