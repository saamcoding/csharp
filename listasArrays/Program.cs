using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liastas_e_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo ARRAYS
            int[] numeros = new int[5];
            int[] numerosInteiros = { 5, 3, 8, 10, 6, 8, 45 };
            #endregion



            #region Exemplo FOREACH
            /*  uma estrutura de repetição (ou loop) 
             *  que permite iterar ou percorrer os 
             *  elementos de uma coleção
             

             *  Quando você precisa percorrer todos os 
             *  itens da lista sem se preocupar com o índice 
             *  (posição) de cada item


             * SINTASE DO FOR EACH
             foreach (tipoDeDado elemento in coleção)
             {
             código a ser executado para cada elemento na coleção 
             } 
            
            * tipodeDado se refere aos int, string, double,etc
            * elemento é a variável que representará cada item da coleção
            * coleção (como uma lista, array) pela qual voce esta iterando
            */
            Console.WriteLine(numerosInteiros[2]);

            foreach (int numero in numerosInteiros)
            {

                // int noovNumero = numero * 2;;
                // Console.WriteLine(novoNumero);

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            #endregion



            #region Exemplo FOR

            /* SINTAXE DO FOR
             for (inicialização; condição; incremento)
             {
             Bloco de código que será executado a cada iteração
             }
             
             * inicialização: é a parte onde você declara e inicializa a variável
             * condição: é a parte onde você coloca a condição que será avaliada a cada iteração
             * incremento: é a parte onde você incrementa ou decrementa a variável de controle
            
             * o FOR é ideal quando voce sabe o numero de iterações que deseja fazer
             * parecido com o PARA de portugol
             */

            for (int i = 0; i < numerosInteiros.Length; i++)
            {
                if (numerosInteiros[i] % 2 == 0)
                {
                    Console.WriteLine(numerosInteiros[i]);
                }

            }
            #endregion



            #region MÉTODO DE ARRAYS - CONTAINS
            /* METODO CONTAINS
             * verifica se um determinado item ou valor existe no array */

            string[] arrayFrutas = { "banana", "maça", "pera" };
            double[] arrayNotas = { 8.6, 9.6, 3.5, 4.5 };


            if (arrayFrutas.Contains("banana"))
            {
                Console.WriteLine("A fruta banana está no array");
            }
            else
            {
                Console.WriteLine("A fruta banana não está no array");
            }
            #endregion



            #region MÉTODO DE ARRAYS - INDEXOF
            /* METODO INDEXOF
             * retorna o índice de um determinado item ou valor no array */
            int indice = Array.IndexOf(arrayFrutas, "pera");
            Console.WriteLine("O índice da fruta pera é: " + indice);
            #endregion



            #region LIST<T>
            int[] arrayNumeris = new int[5];

            /* LIST<T>
             * é uma classe genérica que cria uma lista
             * que pode armazenar qualquer tipo de dado */

            /* <>
             * sintaxe <> é usada para especificar o 
             * tipo de dados que será usado em uma classe 
             * ou estrutura genérica */
            List<string> ListaAlunos = new List<string>(); // lista para armazenar apenas strings

            List<double> listaNotas = new List<double>(); // lista para armazenar apenas doublE
            // double sao numeros flutuantes - decimais

            List<int> listNumeros = new List<int>(); // lista para armazenar apenas inteiros
            
            ListaAlunos.Add("Dudu");
            ListaAlunos.Add("Bea");
            ListaAlunos.Add("Sam");

            Console.WriteLine(ListaAlunos.Count);

            foreach (string aluno in ListaAlunos)
            {
                Console.WriteLine(aluno.Length);
            }
            #endregion



            #region CLASSE FUNCIONARIOS
            // INSTANCIAR OBJETO DA CLASSES FUNCIONARIOS
            Funcionarios funcionario1 = new Funcionarios("Eduardo Santos Silva", "268.000.000-01", "Desenvolvedor Full Stack", 16000, 40);
            Funcionarios funcionario2 = new Funcionarios("Beatriz Ribeiro", "268.000.000-02", "Desenvolvedor Back End", 15000, 30);

            // CRIAR UMA LISTA DE FUNCIONARIOS PARA GUARDAR OBJETOS
            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

            // ADICIONAR OS FUNCIONARIOS A LISTA
            listaFuncionarios.Add(funcionario1);
            listaFuncionarios.Add(funcionario2);

            // PERCORRER A LISTA DE FUNCIONARIOS
            foreach (Funcionarios funcionario in listaFuncionarios)
            {
                Console.WriteLine($"Nome: {funcionario.Nome} ");
                Console.WriteLine($"Cargo: {funcionario.Cargo} ");
                Console.WriteLine($"Salario: {funcionario.Salario} ");
                
            }
            #endregion
        }

    }
}
