using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Request<T>
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        private T data;

        public T Data
        {
            get { return data; }
            set {
                if (value == null) throw new ArgumentException("No se encontró el recurso buscado.");
                data = value;
            }
        }


    }
}
