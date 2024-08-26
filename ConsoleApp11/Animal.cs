using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Animal 
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }

    class Dog : Animal
    {
      
        public override string ToString()
        {
            return $"Dog: {Name} {Age}";
        }
    }
    class Cat : Animal
    {
        public override string ToString()
        {
            return $"Cat: {Name} {Age}";
        }
    }
}
