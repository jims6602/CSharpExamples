using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Generics
{
    class ResultPrinter
    {
        public void Print<T,U>(Result<T,U> result)
        {
            Console.Write("Result[ Success : {0}, Data : {1} , Action : {2} ] \n", result.Success, result.Data, result.Action);
        }
    }
}
