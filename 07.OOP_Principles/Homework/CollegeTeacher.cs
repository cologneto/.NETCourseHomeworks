using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class CollegeTeacher : Teacher
    {
        private string college;

        public string College
        {
            get { return college; }
            set { college = value; }
        }

        /// <summary>
        /// Proper constructor to add
        /// </summary>
        public CollegeTeacher() { }

        
    }
}
