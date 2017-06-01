using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Medicament
    {
        protected string Name { get; set; }

        protected double Cost { get; set; }

        protected bool Edible { get; set; }

        protected double Weight { get; set; }

        protected CompositionList[] Formulation { get; set; }

        public Medicament(string name, double cost, bool edible, double weight, CompositionList[] formulation)
        {
            this.Name = name;
            this.Cost = cost;
            this.Edible = edible;
            this.Weight = weight;
            this.Formulation = formulation;
        }

        public string getName()
        {
            return Name;
        }
    }
}
