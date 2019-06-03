using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Klassen.Funktionen
{
    public static class InternetSearch
    {
        //Öffnet mit denn Standartbrowser Google mit dem bestimmten Suchbegriff 
        public static void Seach(string text)
        {
            Process.Start("https://www.google.de/search?hl=de&ei=2Q3xXK78CYXcwAK1t6jIBQ&q=" + text.Replace(' ', '+') + "&oq=albert+einstein&gs_l=psy-ab.3...0.0..2956...0.0..0.0.0.......0......gws-wiz.MEZiRBB6G0Y");
        }
    }
}
