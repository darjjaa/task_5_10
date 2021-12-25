using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Drama : DomesticFilm
    {
        int watchingMovie;
        Dictionary<String, int> tournmentRes;

        public Drama(string name, int durationFilm, string directorsName, Dictionary<string, int> awards
            ,int watchingMovie, Dictionary<String, int> tournmentRes) : base(name, durationFilm, directorsName, awards)
        {
            this.watchingMovie = watchingMovie;
            this.tournmentRes = tournmentRes;
        }

        public int WatchingMovie { get => watchingMovie; set => watchingMovie = value; }
        public Dictionary<string, int> TournmentRes { get => tournmentRes; set => tournmentRes = value; }

        public override int MovieSession(Dictionary<string, int> cost)
        {
            Dictionary<String, int>.KeyCollection keyColl = cost.Keys;
            foreach (String s in keyColl)
            {
                if (s == DirectorsName) { return cost[s]; }
            }
            return 0;
        }

        public int LastWatching()
        {
            return WatchingMovie;
        }
    }
}
