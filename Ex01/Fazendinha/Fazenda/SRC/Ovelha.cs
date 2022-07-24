using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Ovelha : Animais
    {
        public Ovelha(string nome, string cor, string alimentacao, string ambiente) : base(nome, cor, alimentacao, ambiente)
        {

        }
        public override void Um()
        {
            Console.WriteLine($" Pompom não para de mastigar... nhac nhac nhac!");
        }

        public override void Dois()
        {
            Console.WriteLine($" Méééeeeeee!!!");
        }
    }
}
