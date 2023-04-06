using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_G2.Controller
{
    public class RoutineCheckController
    {


        public bool RoutineVisit(PatientVisit visit)
        {
            if (visit == null)
            {
                throw new ArgumentNullException("Please enter a valid visit object.");
            }

            return RoutineCheckDAL.RoutineVisit(visit);
        }
    }
}
