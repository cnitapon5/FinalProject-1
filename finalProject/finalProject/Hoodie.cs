using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Hoodie
    {
        protected string Name;
        protected string Color;
        protected string Price;
        public string getName()
        {
            return this.Name;
        }
        public string getColor()
        {
            return this.Color;
        }
        public string getPrice()
        {
            return this.Price;
        }
    }
}
