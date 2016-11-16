using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    //Bad Smell
    //public class DialogoBad
    //{
    //    public void Show(string Mensagem, bool MostrarBotaoOk, bool MostrarBotaoNo, bool MostrarBotaoCancel, int Delay)
    //    {
    //        Console.WriteLine(Mensagem);
    //    }
    //}

    public class Dialogo
    {
        public void Show(DialogoParams parametros)
        {
            Console.WriteLine(parametros.Mensagem);
        }
    }

    public class DialogoParams
    {
        public string Mensagem;
        public bool MostrarBotaoOk;
        public bool MostrarBotaoNo;
        public bool MostrarBotaoCancel;
        public int Delay;
        public void Show()
        {
            Console.WriteLine(Mensagem);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bad Smell
            //var Dl = new DialogoBad();
            ////Quando utiliza-se Parametros nomeados a ordem dos parametros pode ser invertidos sem afetar o outro, mas deve ser passado todos os parametros
            //Dl.Show(Mensagem: "Confirmar ?", MostrarBotaoOk: true, MostrarBotaoNo: false, MostrarBotaoCancel: false, Delay: 10);

            //Criando uma classe com as propriedades evita quebra e rafatoração DialogoParams
            var parametros = new DialogoParams()
            {
                Mensagem = "Confirmar ok ",
                MostrarBotaoCancel = true,
                MostrarBotaoNo = true,
                MostrarBotaoOk = true,
                Delay = 10
            };
            var dialogo = new Dialogo();
            dialogo.Show(parametros: parametros);
            Console.ReadLine();
        }
    }
}
