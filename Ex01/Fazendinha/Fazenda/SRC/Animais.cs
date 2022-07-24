using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.SRC
{
    public class Animais
    {
        string Nome { get; set; }
        string Cor { get; set; }
        string Alimentacao { get; set; }
        string Ambiente { get; set; }

        public Animais(string nome, string cor, string alimentacao, string ambiente)
        {
            Nome = nome;
            Cor = cor;
            Alimentacao = alimentacao;
            Ambiente = ambiente;
        }
        public override string ToString()
        {
            return
            $"- Nome: {Nome} \n" +
            $"- Cor: {Cor} \n" +
            $"- Alimentação: {Alimentacao} \n" +
            $"- Ambiente que vive: {Ambiente} \n";
        }

        public virtual void Um()
        {
            //ação
        }
        public virtual void Dois()
        {
           //ação
        }
    }
} 
