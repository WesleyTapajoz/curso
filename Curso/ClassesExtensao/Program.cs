using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExtensao
{
    public static class DataSetExtension
    {
        public static void WriteJson(this DataSet ds, string fileName)
        {

        }

        public static string ToUrl(this string str)
        {
            return "http://" + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var ds = new DataSet();
            //ds.WriteXml("dados.xml");
            //ds.WriteJson("dados.xml");

            string url = "wwww.google.com.br";
            Console.WriteLine(url.ToUrl());
            Console.ReadLine();
        }
    }
}
