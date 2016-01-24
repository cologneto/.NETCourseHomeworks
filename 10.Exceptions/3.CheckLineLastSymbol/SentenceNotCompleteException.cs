using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckLineLastSymbol
{
    class SentenceNotCompleteException : Exception
    {
        

        public SentenceNotCompleteException(string message) 
            : base(message) 
        {
        }
    }
}
