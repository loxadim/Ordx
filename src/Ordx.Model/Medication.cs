using System;
using System.Collections.Generic;

namespace Ordx.Models
{
    public class Medication : Pharmaceutical
    {
        public string NameMedication { get; set; }

        public string IdMedication { get; set; }

        public int Doses { get; set; }
        
               
               

    }
}