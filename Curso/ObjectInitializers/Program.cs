using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {

        public class Filme
        {
            public string Nome { get; set; }
            public int Ano { get; set; }
        }

        public class Ator
        {
            public int Codigo;
            public string Nome;
            public List<Filme> Filmes;

            //public Ator(int codigo, string nome, string filme)
            //{
            //    Codigo = codigo;
            //    Nome = nome;
            //    Filme = filme;
            //}

            //public Ator(string nome)
            //{
            //    Nome = nome;
            //}

            //public Ator(int codigo)
            //{
            //    Codigo = codigo;
            //}
            //public Ator()
            //{
            //}
        }

        static void Main(string[] args)
        {
            //Ator a = new Ator();
            Ator a = new Ator()
            {
                Codigo = 1,
                Nome = "Wesley",
                Filmes = new List<Filme>()
                {
                    new Filme() {Nome = "C#", Ano = 2013},
                    new Filme() {Nome = "Developer", Ano = 2015}
                }
            };
        }
    }
}