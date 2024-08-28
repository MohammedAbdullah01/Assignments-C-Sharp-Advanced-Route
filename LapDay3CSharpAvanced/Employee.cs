
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LapDay3CSharpAdvanced
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        public string? Name { get; set; }
        public float Salary { get; set; }

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }


        public int VacationStock { get ;  set ;  }



        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)

        {
           EmployeeLayOff?.Invoke(this, e);
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int requestedDays = (To - From).Days + 1;
            if(VacationStock -  requestedDays < 0 )
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeAboveSixty });
                return false;
            }
            VacationStock -= requestedDays;
            return true;
        }


        public void EndOfYearOperation()
        {
            if(VacationStock < 0 )
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.HolidayStockLessThanZero});
            }
            else if(differenceTwoDate() > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeAboveSixty });

            }

        }


        public int differenceTwoDate()
        {
            return DateTime.Now.Year - BirthDate.Year;  
        }








    }
}
