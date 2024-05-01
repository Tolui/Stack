using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack(5);
            s.push('a');
            s.push('b');
            s.push('c');
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(s.getp());
            }
            Console.ReadLine();
        }
    }
}
