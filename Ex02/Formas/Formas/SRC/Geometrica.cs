using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas.SRC
{
    public class Geometrica
    {
        public string Forma { get; set; }
        public double Alt { get; set; }
        public double Larg { get; set; }

        public Geometrica(string forma, double alt, double larg)
        {
            Forma = forma;
            Alt = alt;
            Larg = larg;
        }

        public override string ToString()
        {
            return
                $"\n - Forma: {Forma}" +
                $"\n - Altura: {Alt}" +
                $"\n - Largura: {Larg}";
        }

        public virtual void Area()
        {
            Console.WriteLine($"\n A area do {Forma} é de: {Alt * Larg} ");
        }
    }
}
