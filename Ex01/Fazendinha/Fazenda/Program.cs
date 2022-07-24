using System;
using Fazenda.SRC;

namespace Fazenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Cavalo = new Cavalo("Pocotó", "Marrom", "Ração e Forragem", "Estábulo");
            var Galinha = new Galinha("Merilu", "Branca", "Milho e Migalhas", "Galinheiro");
            var Ovelha = new Ovelha("Pompom", "Bege", "Pastagem", "Palheiro");
            var Pato = new Pato("Duck", " Verde Cintilante", "Peixes e Plantas", "Lagoa");
            var Porco = new Porco("Baby", "Rosa", "Ração de soja e milho", "Chiqueiro");
            var Vaca = new Vaca("Mimoza", "Preto-branco", "Pasto", "Celeiro");

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---> Bom Dia! O Sol já nasceu lá na Fazendinha <---- ");
            Console.WriteLine("----------------------------------------------------- \n");
            Console.WriteLine("\n --------------------- Cavalo ------------------------ \n");
            Console.WriteLine(Cavalo.ToString());
            Cavalo.Um();
            Cavalo.Dois();
            Console.WriteLine("\n --------------------- Galinha ----------------------- \n");
            Console.WriteLine(Galinha.ToString());
            Galinha.Um();
            Galinha.Dois();
            Console.WriteLine("\n --------------------- Ovelha ------------------------ \n");
            Console.WriteLine(Ovelha.ToString());
            Ovelha.Um();
            Ovelha.Dois();
            Console.WriteLine("\n --------------------- Pato ------------------------- \n");
            Console.WriteLine(Pato.ToString());
            Pato.Um();
            Pato.Dois();
            Console.WriteLine("\n -------------------- Porco ------------------------- \n");
            Console.WriteLine(Porco.ToString());
            Porco.Um();
            Porco.Dois();
            Console.WriteLine("\n -------------------- Vaca --------------------------- \n");
            Console.WriteLine(Vaca.ToString());
            Vaca.Um();
            Vaca.Dois();
            Console.WriteLine("\n ---------------------------------------------------- \n");



        }

    }

}