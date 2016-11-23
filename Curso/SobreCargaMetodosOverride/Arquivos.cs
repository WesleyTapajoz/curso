using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaMetodosOverride
{
    public class Musica
    {
        public string Nome;
        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Tocando música: " + Nome);
        }
    }

    public class DocumentoWord
    {
        public string Nome;
        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Mostrando documento do word : " + Nome);
        }
    }

    public class Imagem
    {
        public string Nome;
        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Abrindo imagem: " + Nome);
        }
    }

    public class Windows
    {
        private ArrayList _arquivo;
        public Windows()
        {
            _arquivo = new ArrayList();
        }

        public void Add(object arquivo)
        {
            _arquivo.Add(arquivo);
        }

        public void Abrir(object arquivo)
        {
            if (arquivo is Musica)
                (arquivo as Musica).Abrir();
            if (arquivo is DocumentoWord)
                (arquivo as DocumentoWord).Abrir();
            if (arquivo is Imagem)
                (arquivo as Imagem).Abrir();
        }
    }
}
