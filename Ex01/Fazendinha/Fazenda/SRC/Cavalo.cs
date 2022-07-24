using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Cavalo : Animais
    {
        public Cavalo(string nome, string cor, string alimentacao, string ambiente) : base(nome, cor, alimentacao, ambiente)
        {

        }
        public override void Um()
        {
            Console.WriteLine($" Pocotó está correndo no pasto, com sua crina brilhante...");
        }

        public override void Dois()
        {
            Console.WriteLine($" O Sol está forte realçando o seu olhar cor de amêndoa...");
        }   
    }
}
