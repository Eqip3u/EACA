using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ISubject<T>
    {
        void RegisterPanel(T table);
        void DeletedPanel(T table);
        void NotificationPanels();
    }
}
