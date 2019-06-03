using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon.Klassen.Funktionen
{
    public static class Systemfunktions
    {
        //Programm schließen
        public static void ProgramShutdown()
        {
            Application.Exit();
        }

        //Programneustart
        public static void ProgramRestart()
        {
            Application.Restart();
        }

        //Herunterfahren
        public static void Shutdown()
        {
            Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t 0");
        }

        //Herunterfahren nach Zeit
        public static void Shutdown(int zeit)
        {
            Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t " + zeit);
        }

        //Neustart
        public static void Restart()
        {
            Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-r -t 0");
        }

        //Neustart nach Zeit
        public static void Restart(int zeit)
        {
            Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-r -t " + zeit);
        }

        //Musik
        public static class Music
        {
            public static void SuperMarioSound()
            {
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            }

            public static void Mozard()
            {
                beep(659, 120);
                beep(0, 120);
                beep(622, 120);
                beep(0, 120);

                beep(659, 120);
                beep(0, 120);
                beep(622, 120);
                beep(0, 120);
                beep(659, 120);
                beep(0, 120);
                beep(494, 120);
                beep(0, 120);
                beep(587, 120);
                beep(0, 120);
                beep(523, 120);
                beep(0, 120);

                beep(440, 120);
                beep(0, 140);
                beep(262, 120);
                beep(0, 120);
                beep(330, 120);
                beep(0, 120);
                beep(440, 120);
                beep(0, 120);

                beep(494, 120);
                beep(0, 140);
                beep(330, 120);
                beep(0, 120);
                beep(415, 120);
                beep(0, 120);
                beep(494, 120);
                beep(0, 120);

                beep(523, 120);
                beep(0, 140);
                beep(330, 120);
                beep(0, 120);
                beep(659, 120);
                beep(0, 120);
                beep(622, 120);
                beep(0, 120);

                beep(659, 120);
                beep(0, 120);
                beep(622, 120);
                beep(0, 120);
                beep(659, 120);
                beep(0, 120);
                beep(494, 120);
                beep(0, 120);
                beep(587, 120);
                beep(0, 120);
                beep(523, 120);
                beep(0, 120);

                beep(440, 120);
                beep(0, 140);
                beep(262, 120);
                beep(0, 120);
                beep(330, 120);
                beep(0, 120);
                beep(440, 120);
                beep(0, 120);

                beep(494, 120);
                beep(0, 140);
                beep(330, 120);
                beep(0, 120);
                beep(523, 120);
                beep(0, 120);
                beep(494, 120);
                beep(0, 140);
                beep(440, 120);
            }

            public static void Wecker()
            {
                Console.Beep(800, 500);
                Thread.Sleep(200);
                Console.Beep(800, 500);
                Thread.Sleep(200);
                Console.Beep(800, 500);
                Thread.Sleep(200);
                Console.Beep(800, 500);
            }

            public static void NationalHymne()
            { 
                beep(704, 750);
                beep(792, 250);
                beep(880, 500);
                beep(792, 500);
                beep(940, 500);
                beep(880, 500);
                beep(792, 250);
                beep(660, 250);
                beep(704, 500);
                beep(1188, 500);
                beep(1056, 500);
                beep(940, 500);
                beep(880, 500);
                beep(792, 500);
                beep(880, 250);
                beep(704, 250);
                beep(1056, 1000);
                beep(704, 750);
                beep(792, 250);
                beep(880, 500);
                beep(792, 500);
                beep(940, 500);
                beep(880, 500);
                beep(792, 250);
                beep(660, 250);
                beep(704, 500);
                beep(1188, 500);
                beep(1056, 500);
                beep(940, 500);
                beep(880, 500);
                beep(792, 500);
                beep(880, 250);
                beep(704, 250);
                beep(1056, 1000);
                beep(792, 500);
                beep(880, 500);
                beep(792, 250);
                beep(660, 250);
                beep(528, 500);
                beep(940, 500);
                beep(880, 500);
                beep(792, 250);
                beep(660, 250);
                beep(528, 500);
                beep(1056, 500);
                beep(940, 500);
                beep(880, 750);
                beep(880, 250);
                beep(990, 500);
                beep(940, 250);
                beep(1056, 250);
                beep(1056, 1000);
                beep(1408, 750);
                beep(1320, 250);
                beep(1320, 250);
                beep(1188, 250);
                beep(1056, 500);
                beep(1188, 750);
                beep(1056, 250);
                beep(1056, 250);
                beep(940, 250);
                beep(880, 500);
                beep(792, 750);
                beep(880, 125);
                beep(940, 125);
                beep(1056, 250);
                beep(1188, 250);
                beep(940, 250);
                beep(792, 250);
                beep(704, 500);
                beep(880, 250);
                beep(792, 250);
                beep(704, 1000);
                beep(1408, 750);
                beep(1320, 250);
                beep(1320, 250);
                beep(1188, 250);
                beep(1056, 500);
                beep(1188, 750);
                beep(1056, 250);
                beep(1056, 250);
                beep(940, 250);
                beep(880, 500);
                beep(792, 750);
                beep(880, 125);
                beep(940, 125);
                beep(1056, 250);
                beep(1188, 250);
                beep(940, 250);
                beep(792, 250);
                beep(704, 500);
                beep(880, 250);
                beep(792, 250);
                beep(704, 1000);
            }

            public static void Tetris()
            {
                beep(1320, 500);
                beep(990, 250);
                beep(1056, 250);
                beep(1188, 250);
                beep(1320, 125);
                beep(1188, 125);
                beep(1056, 250);
                beep(990, 250);
                beep(880, 500);
                beep(880, 250);
                beep(1056, 250);
                beep(1320, 500);
                beep(1188, 250);
                beep(1056, 250);
                beep(990, 750);
                beep(1056, 250);
                beep(1188, 500);
                beep(1320, 500);
                beep(1056, 500);
                beep(880, 500);
                beep(880, 500);
                Thread.Sleep(250);
                beep(1188, 500);
                beep(1408, 250);
                beep(1760, 500);
                beep(1584, 250);
                beep(1408, 250);
                beep(1320, 750);
                beep(1056, 250);
                beep(1320, 500);
                beep(1188, 250);
                beep(1056, 250);
                beep(990, 500);
                beep(990, 250);
                beep(1056, 250);
                beep(1188, 500);
                beep(1320, 500);
                beep(1056, 500);
                beep(880, 500);
                beep(880, 500);
                Thread.Sleep(500);
                beep(1320, 500);
                beep(990, 250);
                beep(1056, 250);
                beep(1188, 250);
                beep(1320, 125);
                beep(1188, 125);
                beep(1056, 250);
                beep(990, 250);
                beep(880, 500);
                beep(880, 250);
                beep(1056, 250);
                beep(1320, 500);
                beep(1188, 250);
                beep(1056, 250);
                beep(990, 750);
                beep(1056, 250);
                beep(1188, 500);
                beep(1320, 500);
                beep(1056, 500);
                beep(880, 500);
                beep(880, 500);
                Thread.Sleep(250);
                beep(1188, 500);
                beep(1408, 250);
                beep(1760, 500);
                beep(1584, 250);
                beep(1408, 250);
                beep(1320, 750);
                beep(1056, 250);
                beep(1320, 500);
                beep(1188, 250);
                beep(1056, 250);
                beep(990, 500);
                beep(990, 250);
                beep(1056, 250);
                beep(1188, 500);
                beep(1320, 500);
                beep(1056, 500);
                beep(880, 500);
                beep(880, 500);
                Thread.Sleep(500);
                beep(660, 1000);
                beep(528, 1000);
                beep(594, 1000);
                beep(495, 1000);
                beep(528, 1000);
                beep(440, 1000);
                beep(419, 1000);
                beep(495, 1000);
                beep(660, 1000);
                beep(528, 1000);
                beep(594, 1000);
                beep(495, 1000);
                beep(528, 500);
                beep(660, 500);
                beep(880, 1000);
                beep(838, 2000);
                beep(660, 1000);
                beep(528, 1000);
                beep(594, 1000);
                beep(495, 1000);
                beep(528, 1000);
                beep(440, 1000);
                beep(419, 1000);
                beep(495, 1000);
                beep(660, 1000);
                beep(528, 1000);
                beep(594, 1000);
                beep(495, 1000);
                beep(528, 500);
                beep(660, 500);
                beep(880, 1000);
                beep(838, 2000);
            }

            static void beep(int f, int t)
            {
                if (f > 0)
                    Console.Beep(f, t);
                else
                    System.Threading.Thread.Sleep(t);
            }
        }
    }
}
