using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLInkedListJMC
{
    public class EmptyListException : NullReferenceException
    {
        public EmptyListException(string msg) : base(msg)
        {
            
        }
    }
}
