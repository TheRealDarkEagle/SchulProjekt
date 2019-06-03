using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimonSpeechEngine;
using System.Threading;
using SimonAPI;
using Simon.Klassen.Funktionen;

namespace Simon.Klassen
{
    public static class Simon
    {
        public static System.Media.SoundPlayer awaiksound = new System.Media.SoundPlayer(Application.StartupPath + "\\Speech on.wav");

        public static void Start()
        {
            //Thread thread = new Thread(StartForm);
            //thread.Start();

            StartForm();

            //SimonWaitforAwaik();
        }

        public static void SimonWaitforAwaik()
        {
            if(Speech.WaitforStaticCommand("saimon") == true)
            {
                awaiksound.Play();
                WriteInLog("Awaik");
                Thread.Sleep(20);
                WriteInLog("Awaiked");
                SimonWaitforCommand();
            }
        }

        public static void SimonWaitforCommand()
        {
            string record = Speech.GetSpeakCommand(Application.StartupPath + "\\Commands.txt");
            WriteInLog("Recordet: " + record);
            Vorgegeben.Check(record);
        }

        public static void WriteInLog(string text)
        {
            Console.WriteLine(text);
        }

        private static void StartForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Design.Main_Form());
        }
    }
}
