using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
   public class Category
    {
        private int id;
        private string name;
        private bool active;

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

        public Category(string name, bool active) //Construtor
        {
            this.Name = name;
            this.Active = active;
        }

        public Category (string name, bool active,int id)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }
    }
}
