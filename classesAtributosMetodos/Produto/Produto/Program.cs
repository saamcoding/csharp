using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Program // Internal indica que essa classe funciona apenas dentro do projeto produto
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto da classe Produto
            // produto, nome do produto = novo Produto (atributos do produto)
            Produto chocolate = new Produto("Ferrero Rocher", 30.00, 100);

            Produto refrigerante = new Produto("Coca-Cola Zero", 5.00, 200);

            //Outra forma de criar uma instância de um objeto
            Produto chinelo = new Produto();
            // e adicionar os atributos
            chinelo.Nome = "Havaianas";
            chinelo.Preco = 40.00;
            chinelo.Quantidade = 50;

            // Para mudar algum atributo do produto
            refrigerante.Preco = 10.00;

            // Exibir detalhes do produto no console
            chocolate.ExibirDetalhesProduto();
            Console.WriteLine();
            refrigerante.ExibirDetalhesProduto();
            Console.WriteLine();
            chinelo.ExibirDetalhesProduto();

            Console.WriteLine();
            Console.WriteLine();
            // Exibir informações no console, dentro das chaves estamos acessando a informa 'Nome' do objeto chocolate
            // isso retorna o valor armazenado no atributo Nome do objeto chocolate
            // o mesmo vale para os outros atributos
            // Tambem estamos chamando o método de valor total em estoque que retorna o valor total
            Console.WriteLine($"Valor total em estoque de {chocolate.Nome}: {chocolate.ValorTotalEmEstoque()}");
            Console.WriteLine($"Valor total em estoque de {refrigerante.Nome}: {refrigerante.ValorTotalEmEstoque()}");
            Console.WriteLine($"Valor total em estoque de {chinelo.Nome}: {chinelo.ValorTotalEmEstoque()}");

        }
    }
}
