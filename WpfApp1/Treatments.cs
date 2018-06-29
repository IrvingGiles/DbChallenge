using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Treatment
    {
        private int treatmentId;
        private string petName;
        private int ownerId;
        private int procedureId;
        private DateTime date;
        private string notes;
        private double price;

        public int TreatmentId
        {
            get { return treatmentId; }
            set { treatmentId = value; }
        }

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }

        public int OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }

        public int ProcedureId
        {
            get { return procedureId; }
            set { procedureId = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
