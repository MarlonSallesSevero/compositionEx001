using System;
using Enumerations.Entitites;
using System.Globalization;
using Enumerations.Entitites.Enums;

namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name:");
            string nomeDept = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):");
            TrabalhadorLevel level = (TrabalhadorLevel)Enum.Parse(typeof(TrabalhadorLevel), Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double slBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departamento dpto = new Departamento(nomeDept);
            Worker workk = new Worker(name, level, slBase, dpto);
            Console.Write("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.WriteLine("Date (DD/MM/YYYY):");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double vlPhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours):");
                int duracao = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(data, vlPhora, duracao);
                workk.AddContrato(contrato);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));
            Console.WriteLine($"Name - {workk.Name}");
            Console.WriteLine($"Department - {workk.Departamento.Nome}");
            Console.WriteLine($"Income for  - {mesEano} : {workk.Lucro(ano, mes)}");
            string a = Console.ReadLine();
        }
    }
}

