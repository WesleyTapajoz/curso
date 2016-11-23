using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{

    public class Produtos
    {
        public List<string> _itens;

        public Produtos()
        {
            _itens = new List<string>();
        }
        public void Add(string index)
        {
            _itens.Add(index);
        }


        public string this[int index]
        {
            get
            {
                return _itens[index];
            }
        }

        public int this[string nome]
        {
            get
            {
                return _itens.IndexOf(nome);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var prod = new Produtos();
            prod.Add("Carro");
            prod.Add("Moto");
            prod.Add("Bicicleta");
            Console.WriteLine(prod[0]);
            Console.WriteLine(prod[1]);
            Console.WriteLine(prod[2]);

            Console.WriteLine("Exemplo de index string : Index: " + prod["Moto"]);

            Console.ReadLine();


        }
    }
}
