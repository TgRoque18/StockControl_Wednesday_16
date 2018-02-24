using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class Stock
    {
        private int id;
        private int quantity;
        private bool active;
        private Product product;
        private string name;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Stock() { }
    
        public Stock (int quantity, bool active, Product product, string name)
        {
            this.Quantity = quantity;
            this.Active = active;
            this.Product = product;
            this.Name = name;
        }

        public Stock(int id,int quantity, bool active, Product product, string name)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Active = active;
            this.Product = product;
            this.Name = name;
        }
    }
}
