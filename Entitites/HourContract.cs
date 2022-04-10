using System;
namespace Enumerations.Entitites
{
    class HourContract
    {
        public DateTime Dta { get; set; }
        public double ValorPorHor { get; set; }
        public int Horas { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime dta, double valorPorHor, int horas)
        {
            Dta = dta;
            ValorPorHor = valorPorHor;
            Horas = horas;
        }

        public double TotalHoras()
        {
            return ValorPorHor * Horas;
        }
    }
}
