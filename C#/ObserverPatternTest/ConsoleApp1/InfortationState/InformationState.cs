using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class InformationState : ISubject<TablePanel>
    {
        List<ITablePanel> panels;

        List<Medicaments> listMedicament;

        public InformationState()
        {
            panels = new List<ITablePanel>();
            //imit connect to bd
            listMedicament = new List<Medicaments>();
            // endl
        }

        public void RegisterPanel(TablePanel table)
        {
            panels.Add(table);
        }

        public void DeletedPanel(TablePanel table)
        {
            panels.Remove(table);
        }

        public void NotificationPanels()
        {
            foreach (var panel in panels)
                panel.Update(listMedicament);
        }

        public void InfoChanged()
        {
            NotificationPanels();
        }


        // TT
        public void AddBDMedicament(Medicaments medicaments)
        {
            listMedicament.Add(medicaments);
            InfoChanged();
        }

        public void Buy(Medicament medicament, int amount)
        {
            //logic deleted amount db
        }
    }

}
