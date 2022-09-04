using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Classes
{
    public class Animal
    {
        private string name;
        private int age;

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value >= 0)
                {
                    this.age = value;
                }else
                {
                    this.age = 0;
                }
            }
        }
        

        public Animal(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
      
        public override string ToString()
        {
           return "Name : " + this.name + " Age : " + this.age ;
        }


    }
}
