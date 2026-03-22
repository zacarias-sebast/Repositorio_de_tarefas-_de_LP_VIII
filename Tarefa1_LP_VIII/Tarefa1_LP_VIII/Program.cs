using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa1_LP_VIII
{
    using System;

    class Empregado
    {
        private string primeiroNome;
        private string sobrenome;
        private double salarioMensal;

        
        public Empregado(string primeiroNome, string sobrenome, double salarioMensal)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;

            
            if (salarioMensal > 0)
                this.salarioMensal = salarioMensal;
            else
                this.salarioMensal = 0;
        }

        
        public string GetPrimeiroNome()
        {
            return primeiroNome;
        }

        public void SetPrimeiroNome(string nome)
        {
            primeiroNome = nome;
        }

        public string GetSobrenome()
        {
            return sobrenome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public double GetSalarioMensal()
        {
            return salarioMensal;
        }

        public void SetSalarioMensal(double salario)
        {
            if (salario > 0)
                salarioMensal = salario;
        }

        
        public double SalarioAnual()
        {
            return salarioMensal * 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        
            Empregado empregado1 = new Empregado("Zacarias", "Sebastião", 45000);
            Empregado empregado2 = new Empregado("Quianguebeni", "Domingos", 65000);

            Console.WriteLine(); 
            Console.WriteLine("==Salário anual inicial==");
            Console.WriteLine(empregado1.GetPrimeiroNome() + ": " + empregado1.SalarioAnual());
            Console.WriteLine(empregado2.GetPrimeiroNome() + ": " + empregado2.SalarioAnual());

            empregado1.SetSalarioMensal(empregado1.GetSalarioMensal() * 1.10);
            empregado2.SetSalarioMensal(empregado1.GetSalarioMensal() * 1.10);

            Console.WriteLine(); 
            Console.WriteLine("==Salário anual após aumento de 10%==");

            Console.WriteLine(empregado1.GetPrimeiroNome() + " " + empregado1.GetSobrenome() + ": " + empregado1.SalarioAnual());
            Console.WriteLine(empregado2.GetPrimeiroNome() + " " + empregado2.GetSobrenome() + ": " + empregado2.SalarioAnual());
            Console.ReadLine(); 
        }
    }
}
