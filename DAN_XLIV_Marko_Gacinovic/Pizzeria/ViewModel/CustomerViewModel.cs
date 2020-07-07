using Pizzeria.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.ViewModel
{
    class CustomerViewModel : ViewModelBase
    {
        CustomerView customer;

        public CustomerViewModel(CustomerView customerOpen)
        {
            customer = customerOpen;
        }
    }
}
