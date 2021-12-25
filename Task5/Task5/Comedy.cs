using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Comedy : DomesticFilm
    {
        String country;
        int funnyMoments;

        public Comedy(string name, int durationFilm, string directorsName, Dictionary<string, int> awards,string country, int funnyMoments):base (name, durationFilm, directorsName, awards)
        {
            this.country = country;
            this.funnyMoments = funnyMoments;
        }

        public int FunnyMoments { get => funnyMoments; set => funnyMoments = value; }
        public string Country { get => country; set => country = value; }

        public override int MovieSession(Dictionary<string, int> cost)
        {
            Dictionary<String, int>.KeyCollection keyColl = cost.Keys;
            foreach (String s in keyColl)
            {
                if (s == DirectorsName) { return cost[s]; }  
            }
            return 0;
        }
        public double EmpPercentage(int watchingT)
        {
           
            return Math.Round((double)FunnyMoments / watchingT * 100); 
        }

        public override string ToString()
        {
            return "Name: " + Name + "; DurationFilm: " + DurationFilm + "; DirectorsName: " + DirectorsName + "; Awards: " + Awards["1s"]  + "; Curators name: " + Country + "; Additional hours: " + FunnyMoments;
            ;
        }
    }
}
