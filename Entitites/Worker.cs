using Enumerations.Entitites.Enums;
using System.Collections.Generic;

namespace Enumerations.Entitites

{
    internal class Worker
    {
        public string Name { get; set; }
        public TrabalhadorLevel LevelWorker { get; set; }
        public double SalBase { get; set; }
        public Departamento Departamento { get; set; }

        public List<HourContract> Contratos { get; set; } = new List<HourContract>();
        public Worker()
        {
        }
        public Worker(string name, TrabalhadorLevel levelWorker, double salBase, Departamento departamento)
        {
            Name = name;
            LevelWorker = levelWorker;
            SalBase = salBase;
            Departamento = departamento;
        }

        public void AddContrato(HourContract contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemvContrato(HourContract contrato) {
            Contratos.Remove(contrato);
        }
        public double Lucro(int ano, int mes)
        {
            double soma = SalBase;
            foreach(HourContract contr in Contratos)
            {
                if(contr.Dta.Year == ano && contr.Dta.Month == mes)
                {
                    soma += contr.TotalHoras(); //validacao
                }
            }
            return soma;
        }
    }
}
