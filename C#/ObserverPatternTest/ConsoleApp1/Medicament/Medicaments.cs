using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Medicaments
    {
        protected Medicament Medicament { get; set; }

        protected int Amount { get; set; }

        public Medicaments(Medicament medicament, int amount)
        {
            this.Medicament = medicament;
            this.Amount = amount;
        }

        public void Buy(int amount)
        {
            if(!(Amount < amount))
                Amount -= amount;
            else
                Console.WriteLine("Товара не хватает");
        }

        public int getAmount()
        {
            return Amount;
        }
        public string getName()
        {
            return Medicament.getName();
        }
    }
}
