using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Operation_Dividation
{
    internal class Program
    {
        public void Dividation()
        {
            int a = 100, b = 5;
            int c = a / b;
            Console.WriteLine("Dividation : " + c);
        }
        static void Main(string[] args)
        {
            Program op = new Program();
            op.Dividation();
            Console.ReadLine();
        }
    }
}
