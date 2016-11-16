using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario() { Nome = "Wesley", Senha = "qualquer" };


            if (user.Autenticar())
                Console.WriteLine("Usuário Autenticado");
            else
                Console.WriteLine("Usuário Autenticado");

            Console.ReadLine();
        }
    }
}
