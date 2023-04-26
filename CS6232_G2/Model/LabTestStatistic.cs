using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.Model
{
    /// <summary>
    /// public class for LabTestStatistic objects
    /// </summary>
    public class LabTestStatistic
    {
        public int TestCode { get; set; }
        public string TestName { get; set; }
        public int QualifiedTestQuantity { get; set; }
        public int TotalTestQuantity { get; set; }
        public double QualifiedPercentage { get; set; }
        public int TotalNormal { get; set; }
        public int TotalAbnormal { get; set; }
        public double PercentageEighteenToTwentyNine { get; set; }
        public double PercentageThirtyToThirtyNine { get; set; }
        public double PercentageOtherYears { get; set; }

    }
}
