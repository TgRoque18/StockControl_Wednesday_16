using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class Log
    {
        private int id;
        private string description;
        private DateTime date;
        private LogType logType;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public LogType LogType
        {
            get
            {
                return logType;
            }

            set
            {
                logType = value;
            }
        }
    }
}
