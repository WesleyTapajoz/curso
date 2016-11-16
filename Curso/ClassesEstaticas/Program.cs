using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class Conversor
    {
        public static double CelsiusTOFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    public class ConversorInstancia
    {
        public static double Temperatura;
        public double CelsiusToFah()
        {
            return (Temperatura * 9 / 5) + 32;
        }

        public double FahToCelsius()
        {
            return (Temperatura - 32) * 5 / 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new ConversorInstancia();
            var c2 = new ConversorInstancia();
            ConversorInstancia.Temperatura = 30;
            var celsius = c1.CelsiusToFah();
            ConversorInstancia.Temperatura = 70;
            var fah = c1.CelsiusToFah();
            Console.WriteLine("Celsius =" + celsius);
            Console.WriteLine("Fah =" + fah);
            Console.ReadLine();




            //var temperatura = 35.0;
            //temperatura = Conversor.CelsiusTOFah(temperatura);
            //Console.WriteLine(temperatura);
            //Console.ReadLine();
        }
    }
}
