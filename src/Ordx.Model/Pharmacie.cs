using System;
using System.Collections.Generic;
namespace Ordx.Models
{
    public class Pharmacie
    {
        public int IdPharmacie { get; set; }
        public string NamePharmacie { get; set; }
        public string Adress { get; set; }
        public string Pharmacien { get; set; }
        ICollection<Pharmaceutical> pharmaceuticals { get; set; }
        ICollection<Pharmacist> pharmacists { get; set; }


    }
}