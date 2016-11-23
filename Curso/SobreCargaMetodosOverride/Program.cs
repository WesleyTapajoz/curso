using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaMetodosOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Musica mp3 = new Musica() { Nome = "Lá lá" };
            DocumentoWord doc = new DocumentoWord() { Nome = "Redacao" };
            Imagem img = new Imagem() { Nome = "Praia" };
            Windows windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(img);
            Console.ReadLine();

        }
    }
}
