using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.PropertiesAndEncapsulation
{
    class Person
    {
        private string name;

        // Property
        public string Name
        {
            get { return name; }
            set { name = value; } // value est le nom obligatoire
        }

        // Automatic Properties(Short Hand), no need for Fields/Attributes/Variables
        public int Age
        { get; set; }
    }
}
