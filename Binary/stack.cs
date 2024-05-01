using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class stack
    {
        char [] stk;
        int tos = 0;

        public stack(int size)
        {
            stk = new char[size];
            tos = 0;
        }

        public void push(char  c)
        {
            if(tos==stk.Length)
            {
                Console.WriteLine("Stack is full");
                return;
            }

            stk[tos] = c;
            tos++;
        }

        public char getp()
        {
            if(tos==0)
            {
                Console.WriteLine("Stack is empty");
            }
            tos--;
            return stk[tos];
        }

        public bool isempty()
        {
            return tos == 0;
        }

        public bool isfull()
        {
            return tos == stk.Length;
        }
    }
}
