using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Student:Person
    {
		private string id;

		public string ID
		{
			get { return id; }
			set { id = value; }
		}


		private string carrer;

		public string Carrer
		{
			get { return carrer; }
			set { carrer = value; }
		}

		private decimal average;

		public decimal Average
		{
			get { return average; }
			set { average = value; }
		}


        public Student():base()
        {
			carrer = "";
			average = 0;
			id = "";
        }


        public override string ToString()
        {
            return "Fullname: "+Fullname.ToString()+"\nBirthDate: "+BirthDate.ToString("d")+"\nId: "+ID+"\nCarrer: "+Carrer+"\nAverage: "+Average;
        }
    }
}
