using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Disc
    {
        public List<Musicalcomposition> tracklist;
        public Disc() 
        {
            tracklist = new List<Musicalcomposition>();
            tracklist.Add(new Musicalcomposition("Yanix - classic", 3.06, Styles.RAP));
            tracklist.Add(new Musicalcomposition("Король и шут - Кукла колдуна ", 3.22, Styles.ROCK));
            tracklist.Add(new Musicalcomposition("Yanix -  Gang Bang", 2.39, Styles.RAP));
            tracklist.Add(new Musicalcomposition("Chris Brown - Under The Influence ", 3.21, Styles.ALTERNATIVE));
            tracklist.Add(new Musicalcomposition("Queen - Bohemian Rhapsody ", 5.55, Styles.ROCK));
            tracklist.Add(new Musicalcomposition("Zivert - WAKE UP!", 3.16, Styles.POP));
            tracklist.Add(new Musicalcomposition("Coolio Feat. L.V. - Gangsta's Paradise ", 4.32, Styles.ELECTRONIC));
            tracklist.Add(new Musicalcomposition("Imagine Dragons - Bones ", 3.36, Styles.POP));
            tracklist.Add(new Musicalcomposition("2 Die 4 - Tove Lo ", 3.33, Styles.POP));
            tracklist.Add(new Musicalcomposition("Raffa Fl - Ritmo ", 4.04, Styles.HIPHOP_RAP));
            tracklist.Add(new Musicalcomposition("Pompeya - 90 ", 3.02, Styles.ELECTRONIC));
            tracklist.Add(new Musicalcomposition("Pyrokinesis - Tell Me Why ", 4.38, Styles.HIPHOP_RAP));
        }

        public double DiscLength()
        {
            double len_disc = 0;
            for (int i = 0; i < tracklist.Count(); i++)
            {
                len_disc += tracklist[i].GetMusic_length();
            }
            return len_disc;
        }

        public List<Musicalcomposition> SortByStyles(Styles style) 
        {

            List<Musicalcomposition> sortedtracklist = tracklist.OrderByDescending(s => s.GetStyle() == style).ToList();
            return sortedtracklist;
        }

        public string FindByRange(double first, double last) 
        {
            string str = "";
            double len;
            for (int i = 0; i < tracklist.Count(); i++)
            {
                len = tracklist[i].GetMusic_length();
                if (len >= first && len <= last)
                {
                    str+= tracklist[i].MakeStr() + " ";
                }
            }
            return str;
        }
    }
}
