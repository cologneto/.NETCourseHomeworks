using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Policeman : Employee
    {
        public string Rang { get; set; }

        public Policeman() { }

        public override string ToString()
        {
            return string.Format("Policeman rang is : {0} \nHis salary is: {1} \nPoliceman works {2} hours ", this.Rang, this.Salary, this.WorkingHours);
        }
    }
}
