using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Doctor : Employee
    {
        public int NightShifts { get; set; }
        public int DayShifts { get; set; }

        public Doctor() 
        { 
            
        }

        public override string ToString()
        {
            return string.Format("Doctor Night shifts are: {0}\n Day shifts are: {1} \n Doctor's salary is: {2} \n Doctor's working hours are: {3}", this.NightShifts, this.DayShifts, this.Salary, this.WorkingHours);
        }

    }
}
