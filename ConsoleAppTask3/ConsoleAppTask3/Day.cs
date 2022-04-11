using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTask3
{
    class Day
    {
        Hour h;
        Minute m;
       public Day(Hour h, Minute m)
       {
            this.m = m;
            this.h = h;
       }

        public String getCurrentTime()
        {
            return h.getHours() + "часов" + m.gerMinuts() + "минут";
        }

        public String getDayParth()
        {
            if (h.getHours() >= 4 && h.getHours() < 11)
            {
                return "Утро";
            }
            if (h.getHours() >= 11 && h.getHours() < 17)
            {
                return "День";
            }
            if (h.getHours() >= 17 && h.getHours() < 23)
            {
                return "Вечер";
            }
            if (h.getHours() == 24 && h.getHours() < 3)
            {
                return "Ночь";
            }
            return "";
        }

    }
}
