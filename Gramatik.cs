using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon.Klassen
{
    public static class Gramatik
    {
        public enum Satzart { Fragesatz, Aussagesatz };

        public static Satzart GetSatzart(string text)
        {
            string[] startsignal = new string[] { "warum", "wieso", "weshalb", "wie", "was", "wo", "wer" };
            bool frage = false;

            for (int i = 0; i < startsignal.Length; i++)
            {
                if (text.StartsWith(startsignal[i]))
                {
                    frage = true;
                    break;
                }
            }

            if (frage)
                return Satzart.Fragesatz;
            else
                return Satzart.Aussagesatz;
        }

        public static class Objekt
        {
            public static string GetObjekt(string text)
            {
                StreamReader sr = new StreamReader(new FileStream(Application.StartupPath + "\\Objekte.txt", FileMode.Open));

                string line;

                while ((line = sr.ReadLine().ToLower()) != null)
                {
                    string[] splittext = text.ToLower().Split(' ');

                    for (int i = 0; i < splittext.Length; i++)
                    {
                        if (splittext[i] == line)
                        {
                            sr.Close();
                            return line;
                        }
                    }
                }
                sr.Close();
                return "";
            }

            public static void AddNewObjekt(string objekt)
            {
                StreamWriter sr = new StreamWriter(new FileStream(Application.StartupPath + "\\Objekte.txt", FileMode.Open));
                sr.WriteLine(objekt);
                sr.Close();
            }

            public static void AddNewObjekt(string[] objekte)
            {
                StreamWriter sr = new StreamWriter(new FileStream(Application.StartupPath + "\\Objekte.txt", FileMode.Open));

                for (int i = 0; i < objekte.Length; i++)
                {
                    sr.WriteLine(objekte[i]);
                }

                sr.Close();
            }
        }
    }
}