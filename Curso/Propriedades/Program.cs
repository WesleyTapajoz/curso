using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    public class MensalidadeNegativaException : Exception
    {
        public MensalidadeNegativaException(string message) : base(message)
        {

        }
    }

    public enum TipoAluno
    {
        Regular,
        Especial
    }

    public class Aluno
    {
        private int _matricula;

        public int Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private double _mensalidade;

        public double Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                if (value < 0)
                    throw new MensalidadeNegativaException("Valor negativo");
                else
                    _mensalidade = value;

            }
        }

        public TipoAluno Tipo;
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno a = new Aluno
                {
                    Matricula = 123,
                    Nome = "Wesley",
                    Mensalidade = -500,
                    Tipo = TipoAluno.Regular
                };
            }
            catch (MensalidadeNegativaException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

            Console.ReadLine();
        }
    }
}
