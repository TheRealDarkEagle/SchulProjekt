using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Simon.Klassen
{
    public static class Vorgegeben
    {
        public static bool Check(string text)
        {
            if (File.Exists(Application.StartupPath + "\\Vorgegeben.txt"))
            {
                FileStream file = new FileStream(Application.StartupPath + "\\Vorgegeben.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file);

                while (reader.ReadLine() != null)
                {
                    string line = reader.ReadLine();



                }
                return true;
            }
            else
            {
                Simon.WriteInLog("Die Datei mit denn Vorgegebenen daten konnte nicht geladen werden!");
                return false;
            }
        }
    }
}
