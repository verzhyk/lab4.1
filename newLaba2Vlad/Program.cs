using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba2Vlad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Normalizer> link = new List<Normalizer>();
            link.Add(new ComplexNumbers(5));
            link.Add(new Matrix());
            link.Add(new Vector());

            for (int i = 0; i < link.Count; i++)
            {
                Console.WriteLine($"Class: {link[i].GetType()}. Result: {link[i].Norma()}.");
            }
        }
    }
}
