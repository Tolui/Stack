using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class player
    {
        public string name = "tommy";
        public int health = 49;
        public void sethealth(int h)
        {
            health += h;
        }
        public void run()
        {
            Console.WriteLine("running...");
        }
    }
}
