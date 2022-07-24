using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Pato : Animais
    {
        public Pato(string nome, string cor, string alimentacao, string ambiente) : base(nome, cor, alimentacao, ambiente)
        {

        }
        public override void Um()
        {
            Console.WriteLine($" Duck está a passear no lago, tranquilamente...");
        }

        public override void Dois()
        {
            Console.WriteLine($" Quack! Quack!");
        }
    }
}
