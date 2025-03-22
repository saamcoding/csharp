using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liastas_e_Arrays
{
    internal class Funcionarios
    {
        //ATRIBUTOS
        public string Nome;
        public string CPF;
        public string Cargo;
        public double Salario;
        public double CargaHoraria;

        // METODO CONSTRUTOR
        public Funcionarios(string nome, string cpf, string cargo, double salario, double cargahoraria) {

            //ATRIBUIÇÃO DE VALORES AS PROPRIEDADES
            Nome = nome;
            CPF = cpf;
            Cargo = cargo;
            Salario = salario;
            CargaHoraria = cargahoraria;
        }
    }
}
