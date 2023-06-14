using System;

namespace PrismaBoy
{
    [Serializable]
    
    public class TimeOfDay
    {
        public int Minutes;
        public int Hours;

        public TimeOfDay(int hours, int minutes)
        {
            Minutes = minutes;
            Hours = hours;
        }
    }
}
