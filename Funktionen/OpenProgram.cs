using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Klassen.Funktionen
{
    public static class OpenProgram
    {
        //Öffnet ein Program
        public static void Open(string name)
        {
            string pfad = Environment.SpecialFolder.Desktop + "\\" + name;
            
            if(File.Exists(pfad))
            {
                Process.Start(pfad);
            }
        }
    }
}
