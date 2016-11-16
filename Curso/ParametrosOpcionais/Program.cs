using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionais
{
    public class CaixaDialogo
    {
        public void Show(string Mensagem, bool Ok, bool No, bool Cancel = false, int Delay = 10)
        {
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Parametros Opicionais trata-se de um modo inicializar o parametro no metodo, caso nenhum valor seja passado ele assume o valor defult inicializado
            var cD = new CaixaDialogo();
            cD.Show(Mensagem: "Confirmar ?",Ok: true,No: true, Delay: 10);


        }
    }
}
