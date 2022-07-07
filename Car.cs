using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car : Inheritance
    {
        private string color = "Blue";
        private string Name = "RollRoyces";

        public string Color { get => color; set => color = value; }
        public string Name1 { get => Name; set => Name = value; }
    }
}
