using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TablePanel : ITablePanel
    {
        InformationState infoState;

        private int ID;

        List<Medicaments> medicaments;

        public TablePanel(InformationState infoState, int id)
        {
            this.ID = id;
            this.infoState = infoState;
        }

        public void Update(List<Medicaments> medicaments)
        {
            this.medicaments = medicaments;
            //логика выбора
            Display(medicaments.Last());
        }

        public void Display(Medicaments med) //Вывод информации
        {
            Console.WriteLine($"ID Панели: {ID}\tНазвание товара: {med.getName()}\tКол-во товара: {med.getAmount()} ");
        }
    }

}
