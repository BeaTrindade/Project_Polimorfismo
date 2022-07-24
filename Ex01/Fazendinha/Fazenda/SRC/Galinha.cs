using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Galinha : Animais
    {
        public Galinha(string nome, string cor, string alimentacao, string ambiente) : base(nome, cor, alimentacao, ambiente)
        {

        }
        public override void Um()
        {
            Console.WriteLine($" Merilu está passeando no galinheiro, esperando o galo cantar...");
        }

        public override void Dois()
        {
            Console.WriteLine($" Creck... Creck... Pi-Piu-piu-pi! Nossa... Pintinhos nasceram!!!");
        }
    }
}

