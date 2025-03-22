namespace _01_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 21;
            string nomeCompleto = "Sarah Santiago";

            //  VAR - Declaração de variável com tipo inferido
            //  É uma forma simplificada de declarar uma variável,
            //  permitindo que o compilador determine automaticamente o tipo
            //  da variável com base no valor atribuído a ela.
            var variavelSemTipo = "Sarah";

            //  GetType()
            //  É um método usado para obter o tipo de um objeto em tempo
            //  de execução. Ele retorna um objeto Type que contém
            //  informações sobre o tipo da variável ou objeto.
            Console.WriteLine(variavelSemTipo.GetType()); //  Vai imprimir: System.String

            Console.Write("Digite seu nome: ");
            //  Foi criada uma variável do tipo string 
            //  para guardar o que o usuario digitar.
            string nomeUsuario = Console.ReadLine(); // -> leia(nomeUsuario)

            Console.Write("Digite sua idade: ");
            string idadeUsuario = Console.ReadLine(); // ReadLine() lê uma linha de texto inserida pelo
                                                      // usuário no console e a retorna como uma string.

            Console.WriteLine($"Meu nome é {nomeUsuario} e a minha idade é {idadeUsuario}");
        }
    }
}
