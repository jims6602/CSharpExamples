using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Delegates
{
    public class Square
    {
        public delegate void LogHandler(string message);
        public void Area(LogHandler logHandler, int width)
        {
            logHandler("Area: " + width * width);
        }
    }




}
