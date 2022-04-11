using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTask3
{
    class Hour
    {
        int amount_hours;

        public Hour(int amount_hours)
        {
            this.amount_hours = amount_hours;
        }

        public int getHours()
        {
            return amount_hours;
        }

        public void setHours(int hours)
        {
            this.amount_hours = hours;
        }
    }
}
