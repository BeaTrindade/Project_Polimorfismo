using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Vaca : Animais
    {
        public Vaca(string nome, string cor, string alimentacao, string ambiente) : base(nome, cor, alimentacao, ambiente)
        {

        }
        public override void Um()
        {
            Console.WriteLine($" Mimoza está no pasto feliz...");
        }

        public override void Dois()
        {
            Console.WriteLine($" Mumuuuu Mu Muuuu !!!");
        }
    }
}