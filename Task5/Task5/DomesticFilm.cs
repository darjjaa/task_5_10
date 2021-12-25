using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    abstract class DomesticFilm:IFilm
    {
        public string Name { get; set ; }
        public string DirectorsName { get => directorsName; set => directorsName = value; }
        public Dictionary<string, int> Awards { get => awards; set => awards = value; }
        public int DurationFilm { get => durationFilm; set => durationFilm = value; }

        private int durationFilm;
        private string directorsName ;
        private Dictionary<string, int> awards;

        protected DomesticFilm(string name, int durationFilm, string directorsName, Dictionary<string, int> Awards)
        {
            Name = name;
            this.durationFilm = durationFilm;
            this.directorsName = directorsName;
            this.awards = awards;
        }

        public double AvgScore()
        {
            Dictionary<string, int>.KeyCollection keyColl = Awards.Keys;
            int Sum = 0;
            int Count = Awards.Count;
            foreach (string s in keyColl)
            {
                Sum += Awards[s];
            }
            double Avg = (double)Sum / Count;
            double Ravg = Math.Round(Avg,2);
            return Ravg;
        }

        public int MovieRental(Dictionary<int, int> allCinemas)
        {
            Dictionary<int, int>.KeyCollection keyColl = allCinemas.Keys;
            foreach (int s in keyColl)
            {
                if (s==DurationFilm) { return allCinemas[s]; }
            }
            return 0;

        }

        abstract public int MovieSession(Dictionary<string, int> cost);

        
    }
}
