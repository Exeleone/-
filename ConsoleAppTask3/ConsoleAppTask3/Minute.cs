using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTask3
{
    class Minute
    {
        int amount_minuts;

        public Minute(int amount_minuts)
        {
            this.amount_minuts = amount_minuts;
        }

        public int gerMinuts()
        {
            return amount_minuts;
        }

        public void setMinuts(int minuts)
        {
            this.amount_minuts  = minuts;
        }

    }
}
