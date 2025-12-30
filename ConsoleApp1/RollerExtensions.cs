using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class RollerExtensions
    {
        public static int StrikeSummition(this int[] pins, int i)
        {
            return 10 + pins[i + 1] + pins[i + 2];
        }

        public static int SPareSummition(this int[] pins, int i)
        {
            return 10 + pins[i + 2];
        }

        public static int OpenFrameSummition(this int[] pins, int i)
        {
            return pins[i] + pins[i + 1];
        }

    }
}
