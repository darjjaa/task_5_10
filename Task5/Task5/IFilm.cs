using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface IFilm
    {
        string Name { get; set; }
        int MovieRental(Dictionary<int, int> allCinemas);
        int MovieSession(Dictionary<String,int> cost);

    }
}
