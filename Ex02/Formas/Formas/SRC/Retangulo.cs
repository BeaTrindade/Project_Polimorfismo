﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas.SRC
{
    internal class Retangulo : Geometrica
    {
        public Retangulo(string forma, double alt, double larg) : base(forma, alt, larg)
        {
        }

        public override void Area()
        {
            Console.WriteLine($"\n A Área do {Forma} é de: {Alt * Larg} ");
        }
    }
}
