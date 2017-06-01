using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InformationState inforamtionState = new InformationState();

            inforamtionState.RegisterPanel(new TablePanel(inforamtionState, 1));
            inforamtionState.RegisterPanel(new TablePanel(inforamtionState, 2));
            inforamtionState.RegisterPanel(new TablePanel(inforamtionState, 3));
            inforamtionState.RegisterPanel(new TablePanel(inforamtionState, 4));

            inforamtionState.AddBDMedicament(new Medicaments(new Medicament("Citronom", 95, false, 0.2, new CompositionList[] { CompositionList.Tablet }), 105));

            inforamtionState.AddBDMedicament(new Medicaments(new Medicament("Pentalgon", 22, false, 0.4, new CompositionList[] { CompositionList.Capsule }), 200));

            Console.Read();
        }
    }
}
