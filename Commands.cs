using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimonSpeechEngine;

namespace Simon.Klassen
{
    public static class Commands
    {
        //In dieser Methode wird geprüft ob der Satz ein Frage -oder Aussagesatz
        public static void Erkennen(string text)
        {
            if (Gramatik.GetSatzart(text) == Gramatik.Satzart.Aussagesatz)
                Aussage.Identify(text);
            else if (Gramatik.GetSatzart(text) == Gramatik.Satzart.Fragesatz)
                Frage.Identify(text);

            Simon.SimonWaitforAwaik();
        }
    }
}
