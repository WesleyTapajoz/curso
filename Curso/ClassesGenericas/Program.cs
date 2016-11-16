using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{
    //public class Pilha
    //{
    //    int pos = 0;
    //    object[] itens = new object[100];

    //    public void Push(object item)
    //    {
    //        itens[pos] = item;
    //        pos++;
    //    }
    //    public object Pop()
    //    {
    //        pos--;
    //        return itens[pos];

    //    }
    //}

    public class Pilha<T>
    {
        int pos = 0;
        T[] itens = new T[100];

        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }
        public T Pop()
        {
            pos--;
            return itens[pos];

        }
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public string Senha;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pi = new Pilha<string>();
            pi.Push("Wesley");
            pi.Push("Tapajoz");
            var pi2 = new Pilha<int>();
            pi2.Push(100);
            pi2.Push(200);
            var pi3 = new Pilha<Cliente>();
            pi3.Push(new Cliente(){Codigo = 1,Nome="Wesley", Senha="qualquer" });
            pi3.Push(new Cliente(){ Codigo = 2, Nome = "Wesley2", Senha = "qualquer2" });

        }
    }
}
