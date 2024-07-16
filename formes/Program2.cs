using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace formes
{
    public class Program2
    {
        public static void main(string[] args)
        {
            var s = "par tou le roi trouve sa place assise";
            var t = " physique liason reseau transport session presentation application  ";

            var sb = new StringBuilder(s);
            Console.WriteLine("debut de la concaténation");
            for (int i = 0; i < 200000; i++)
            {
                sb.Append(t);
            }

            Console.WriteLine("fin");
        }
    }
}
