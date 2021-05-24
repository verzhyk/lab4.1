using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba2Vlad
{
    public class ComplexNumbers : Normalizer
    {
        public double Module { get; set; }

        public ComplexNumbers(double module)
        {
            Module = module;
        }
        public override double Norma()
        {
            return Math.Pow(Module, 2);
        }
    }
}
