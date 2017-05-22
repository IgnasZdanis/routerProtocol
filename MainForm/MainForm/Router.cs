using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class Router
    {
        public static int count = 0;
        public int number;
        public List<Neighbour> neighbours;
        public Router()
        {
            number = count;
            count++;
            neighbours = new List<Neighbour>();
        }
        public void AddNeighbour(Router neighbour)
        {

        }
    }
}
