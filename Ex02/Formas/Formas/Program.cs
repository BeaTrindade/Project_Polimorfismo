using System;
using Formas.SRC;

namespace Formas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------> Descubra a Área da figura Geométrica <------------");
            Console.WriteLine("\n Digite a Forma Geometrica (Quadrado|Triangulo|Retangulo): \n");
            string forma = Console.ReadLine();
            string formaupper = forma.ToUpper();
            Console.WriteLine("\n Digite a altura: \n");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Digite a largura: \n");
            double y = Convert.ToDouble(Console.ReadLine());

            if (formaupper == "TRIANGULO")
            {
                Triangulo triangle = new Triangulo("Triangulo", x, y);
                Console.WriteLine(triangle.ToString());
                triangle.Area();
            }
            else if (formaupper == "QUADRADO")
            {
                Quadrado quadrate = new Quadrado("Quadrado", x, y);
                Console.WriteLine(quadrate.ToString());
                quadrate.Area();
            }
            else if (formaupper == "RETANGULO")
            {
                Retangulo rectangle = new Retangulo("Retangulo", x, y);
                Console.WriteLine(rectangle.ToString());
                rectangle.Area();
            }
            else
            {
                Console.WriteLine("Insira uma forma geometrica valida.");
            }
        }
    }
}
