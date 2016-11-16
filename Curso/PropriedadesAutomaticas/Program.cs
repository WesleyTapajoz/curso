using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropriedadesAutomaticas
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
            Codigo = 1;
            Nome = "Wesley";
            Salario = 1000;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario
            {
                Codigo = 1,
                Nome = "Wesley",
                Salario = 1000
            };

            Funcionario fun = new Funcionario(1, "",21);
        }
    }
}
