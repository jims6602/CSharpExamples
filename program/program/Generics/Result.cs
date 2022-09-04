using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Generics
{
    class Result<T,U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Action { get; set; }
    }
}
