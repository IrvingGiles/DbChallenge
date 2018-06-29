using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Procedure
    {
        private int procedureId;
        private string description;
        private double price;

        public int ProcedureId
        {
            get { return procedureId; }
            set { procedureId = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
