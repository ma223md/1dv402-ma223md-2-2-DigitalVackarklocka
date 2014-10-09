using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalVackarklocka
{
    class AlarmClock
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
            get { return _alarmHour; }
            set
            {
                // Validera att _alarmHour är mellan 0-23
                if (value > 23)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");
                }
                else { _alarmHour = value; }
            }
        }

        // egenskapen AlarmMinute
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                // Validera att _alarmMinute är mellan 1-59
                if (value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                else { _alarmMinute = value; }
            }
        }

        // egenskapen Hour
        public int Hour
        {
            get { return _hour; }
            set
            {
                // Validera att _hour är mellan 0-23
                if (value > 23)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                }
                else { _hour = value; }
            }
        }
        // egenskapen Minute
        public int Minute
        {
            get { return _minute; }
            set
            {
                // Validera att _minute är mellan 1-59
                if (value > 59)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59.");
                }
                else { _minute = value; }   
            }
        }

        // konstruktor som initierar fälten till deras standardvärden
        public AlarmClock()
            : this(0, 0) // kalla på konstruktor med 2 parametrar 
        {

        }

        // konstruktor med 2 parametrar
        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0) // kalla på konstruktorn med 4 parametrar
        {

        }

        // konstruktor med 4 parametrar
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            // tilldela fält i klassen värden från egenskaper, kasta undantag om tid ej är giltig
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        // Metod som anropas för att få klockan att gå en minut, stämmer ny tid med alarmtid ska true returneras
        public bool TickTock()
        {
            // Vid anrop ska en minut plussas på
            if (_minute < 59)
            {
                _minute++;
            }
            // återgå till 0 efter 59
            else
            {
                _minute = 0;
            }
            // plussa på timmar efter 60 min
            if (_minute == 0)
            {
                _hour++;
            }

            if (_hour > 23)
            {
                _hour = 0;
            }

            // om alarmtiden är den aktuella tiden, returnera true
            if (_hour == _alarmHour && _minute == _alarmMinute)
            {
                return true;
            }
                
            else { return false; }
            
        }

        // Metod som skickar sträng med värdet från ticktock
        public override string ToString()
        {
            return (String.Format("{0}:{1:00} ({2}:{3:00})", Hour, Minute, AlarmHour, AlarmMinute));
        }

    }
}
