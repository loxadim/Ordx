using System;
using System.Collections.Generic;

namespace Ordx.Models
{
    public class Ordonnance
    {
        public int IdOrdonnance { get; set; }
        public string IdPrescripteur { get; set; }
        public int IdPatient { get; set; }
        public String FirstNamePatient { get; set; }
        public String LastNamePatient { get; set; }
        public DateTime DateDelivery { get; set; }
        public string IdMedicament { get; set; }
        public string Posologie { get; set; }
        public string ModeAdmin { get; set; }
        public DateTime DuréeTraitement { get; set; }
        public int Renouvellement { get; set; }
        public int MasseCorp { get; set; }
        public string IntThérap { get; set; }
        public DateTime ArretMed { get; set; }
        public Boolean Substitution { get; set; }
        

    }
}