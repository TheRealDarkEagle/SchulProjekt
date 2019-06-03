using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simon.Klassen.Funktionen
{
    public static class Timer
    {
        public static void StartTimer(int minuten)
        {
            Thread timer = new Thread(threadtimer);
            timer.Start(minuten);
        }

        private static void threadtimer(Object time)
        {
            int zeit = Convert.ToInt32(time) * 60 * 1000;

            Thread.Sleep(zeit);

            Systemfunktions.Music.Wecker();
        }
    }
}
