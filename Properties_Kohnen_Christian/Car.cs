using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Kohnen_Christian
{
    class Car //creates the class of Car
    {
        private string model; //makes a private class
        public string Model { get { return model; } set { model = value; } } //makes a protected public Model class

        public string Make { get; set; } //makes a protected public Make class
    }
}
