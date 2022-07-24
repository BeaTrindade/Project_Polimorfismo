using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Porco : Animais
    {
        public Porco(string nome, string cor, string alimentacao, string ambiente) : base(nome, cor, alimentacao, ambiente)
        {

        }
        public override void Um()
        {
            Console.WriteLine($" Baby está se divertindo na lama...");
        }

        public override void Dois()
        {
            Console.WriteLine($" Roinc Roinc, rolando na lama... Ai que Delicia!!!");
        }
    }
}
