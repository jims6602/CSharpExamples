using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Attributes
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method)]
    class AttributeSample : Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
