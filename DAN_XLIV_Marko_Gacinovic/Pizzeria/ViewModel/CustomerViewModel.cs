using Pizzeria.Commands;
using Pizzeria.Models;
using Pizzeria.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pizzeria.ViewModel
{
    class CustomerViewModel : ViewModelBase
    {
        CustomerView customer;

        //private tblMenu article;
        //public tblMenu Article
        //{
        //    get { return article; }
        //    set { article = value;
        //        OnPropertyChanged("Article");
        //    }
        //}

        //private List<tblMenu> articleList;
        //public List<tblMenu> ArticleList
        //{
        //    get { return articleList; }
        //    set { articleList = value;
        //        OnPropertyChanged("ArticleList");
        //    }
        //}

        private tblOrder order;
        public tblOrder Order
        {
            get { return order; }
            set { order = value;
                OnPropertyChanged("Order");
            }
        }

        private int smallPizza;
        public int SmallPizza
        {
            get { return smallPizza; }
            set { smallPizza = value;
                OnPropertyChanged("SmallPizza");
            }
        }

        private int mediumPizza;
        public int MediumPizza
        {
            get { return mediumPizza; }
            set
            {
                mediumPizza = value;
                OnPropertyChanged("MediumPizza");
            }
        }

        private int bigPizza;
        public int BigPizza
        {
            get { return bigPizza; }
            set
            {
                bigPizza = value;
                OnPropertyChanged("BigPizza");
            }
        }

        private int jumboPizza;
        public int JumboPizza
        {
            get { return jumboPizza; }
            set
            {
                jumboPizza = value;
                OnPropertyChanged("JumboPizza");
            }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged("Status"); }
        }

        public CustomerViewModel(CustomerView customerOpen, string username)
        {
            customer = customerOpen;
            order = new tblOrder();
            order.CustomerJMBG = username;            
        }
                
        // command for closing the window
        private ICommand logout;
        public ICommand Logout
        {
            get
            {
                if (logout == null)
                {
                    logout = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return logout;
            }
        }

        /// <summary>
        /// method for closing the window
        /// </summary>
        private void CloseExecute()
        {
            try
            {
                customer.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }

        private bool CanCloseExecute()
        {
            return true;
        }

        private ICommand orderButton;
        public ICommand OrderButton
        {
            get
            {
                if (orderButton==null)
                {
                    orderButton = new RelayCommand(param => OrderExecute(), param => CanOrderExecute());
                }
                return orderButton;
            }            
        }

        private bool CanOrderExecute()
        {
            if (status == "Waiting")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OrderExecute()
        {
            try
            {
                using (PizzeriaEntities context = new PizzeriaEntities())
                {
                    tblOrder newOrder = new tblOrder();

                    newOrder.SmallPizza = order.SmallPizza;
                    newOrder.MediumPizza = order.MediumPizza;
                    newOrder.BigPizza = order.BigPizza;
                    newOrder.JumboPizza = order.JumboPizza;
                    newOrder.OrderDate = DateTime.Now;
                    newOrder.OrderStatus = "Waiting";
                    Status = "Waiting";
                    newOrder.CustomerJMBG = order.CustomerJMBG;

                    context.tblOrders.Add(newOrder);
                    context.SaveChanges();                    
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }
    }
}
