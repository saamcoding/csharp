using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area;
        public double Perimetro;

        public Retangulo (double largura, double altura, double area, double perimetro)
        {
            Largura = largura;
            Altura = altura;
            Area = altura * largura;
            Perimetro = 2 * (altura + largura);
        }

        public double AreaRetangulo()
        {
            return Area;
        }

        public double PerimetroRetangulo()
        {
            return Perimetro;
        }

        public void ExibirDetalhes() 
        { 
            Console.WriteLine($"Area do Retângulo: {Area}");
            Console.WriteLine($"Perímetro do Retângulo: {Perimetro}");
        }
    }
}
