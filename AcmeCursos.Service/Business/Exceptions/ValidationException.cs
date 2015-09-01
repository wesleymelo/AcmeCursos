using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AcmeCursos.Service.Business.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : base() { }
        public ValidationException(String message) : base(message) { }
    }
}
