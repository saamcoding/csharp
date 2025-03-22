using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    // Internal indica que essa classe funciona apenas dentro do projeto produto
    internal class Produto
    {
        // Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto()
        {
        }

        // Método para calcular o valor total e estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Método para exibir detalhes produto
        // Void não retorna nada
        public void ExibirDetalhesProduto() {

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade: {Quantidade}");

        }

    }
}
