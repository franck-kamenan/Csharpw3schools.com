using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Constructors
{
    class SecondCarClass
    {
        public string model;
        public string color;

        public SecondCarClass()
        {
            model = "Mustang";
        }

        public SecondCarClass(string modelName)
        {
            model = modelName;
        }

        public SecondCarClass(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
