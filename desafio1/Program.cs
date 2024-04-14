using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 128;
            double n2 = 8;
            Calculadora calc = new Calculadora(" casio", "fx-50");
            double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);

            double Diferncia = calc.Restar(n1, n2);
            Console.WriteLine(Diferncia);
          
            CalculadoraCientifica Cientifica = new CalculadoraCientifica("xiami", "calx");
            double raiz = Cientifica.Raiz(n1);
            Console.WriteLine(raiz);
            MostrarTipo(calc);
            MostrarTipo(Cientifica);
            Console.ReadLine();
            

            
        }  
        public static void MostrarTipo(Calculadora Calculadora)
        {
        }
    }
    public class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; } 

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public  double Sumar(double n1, double n2)
        {
            return n1 + n2; 
        }
        public double Restar(double n1, double n2)
        {
                return n1 - n2; 
        }
        public double Multiplicar(double n1, double n2) { return n1 * n2; } 
        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
        public string Tipo()
        {
            return "calculadora basica";
        }

    }
    public class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }
        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
        public double Raiz(double n1)
        {
            return Math.Sqrt(n1);
        }
        public virtual string Tipo()
        {
            return "cientifica";
        }
    }
}