using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.Model
{
    public class PatientVisit
    {
        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public int Systolic { get; set; }

        public int Diastolic { get; set; }

        public decimal Temperature { get; set; }

        public int Pulse { get; set; }

        public string Symptoms { get; set; }

        public string InitialDiagnosis { get; set; }

        public string FinalDiagnosis { get; set; }
    }
}
