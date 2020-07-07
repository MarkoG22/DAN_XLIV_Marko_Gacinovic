using Pizzeria.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.ViewModel
{
    class EmployeeViewModel : ViewModelBase
    {
        EmployeeView employee;

        public EmployeeViewModel(EmployeeView employeeOpen)
        {
            employee = employeeOpen;
        }
    }
}
