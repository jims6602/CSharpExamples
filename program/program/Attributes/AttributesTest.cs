using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Attributes
{
    [AttributeSample(Name = "John", Version = 1)]
    class AttributesTest
    {
        public int Age { get; set; }

        [AttributeSample]
        public void Print()
        {
            Console.Write("Class: AttributesTest, Methon: Print");
        }
    }
}
