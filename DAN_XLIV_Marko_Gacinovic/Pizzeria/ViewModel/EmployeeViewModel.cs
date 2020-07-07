using Pizzeria.Models;
using Pizzeria.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pizzeria.ViewModel
{
    class EmployeeViewModel : ViewModelBase
    {
        EmployeeView employee;

        
        private tblOrder orderWaiting;
        public tblOrder OrderWaiting
        {
            get { return orderWaiting; }
            set { orderWaiting = value; OnPropertyChanged("OrderWaiting"); }
        }

        private List<tblOrder> orderList;
        public List<tblOrder> OrderList
        {
            get { return orderList; }
            set { orderList = value; OnPropertyChanged("OrderList"); }
        }

        public EmployeeViewModel(EmployeeView employeeOpen)
        {
            employee = employeeOpen;
            orderList = GetAllOrders().ToList();
            MessageBox.Show("Sorry, option is in preparation.");
        }

        public List<tblOrder> GetAllOrders()
        {
            try
            {
                using (PizzeriaEntities context = new PizzeriaEntities())
                {
                    List<tblOrder> list = new List<tblOrder>();

                    list = (from x in context.tblOrders select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
    }
}
