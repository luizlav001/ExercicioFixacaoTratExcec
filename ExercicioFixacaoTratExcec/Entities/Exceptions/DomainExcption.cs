using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoTratExcec.Entities.Exceptions
{
    class DomainExcption : ApplicationException
    {
        public DomainExcption(string message) : base(message)
        {

        }
    }
}
