using System;

namespace EXERCISE_02___OOP
{
    class Program{
        //-----> INICIO
        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Employe emp = new Employe();

            Console.Write("Nome do funcionario: "); emp.Name = Console.ReadLine();
            Console.Write("Salario Bruto: "); emp.GroossSalary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: "); emp.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Funcionario: "+emp);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário? "); double percentage = double.Parse(Console.ReadLine());
            emp.IncreaseSalary(percentage); //-----> SEND INTEL TO PERCENTAGE CLASS EMPLOYE
            Console.WriteLine();
            Console.WriteLine("DADOS ATUAIS: " +emp);          
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //-----> FIM
    }
}
