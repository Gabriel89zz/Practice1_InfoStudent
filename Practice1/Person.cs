using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Person
    {
		protected DateTime birthdate;

		public DateTime BirthDate
		{
			get { return birthdate; }
			set { birthdate = value; }
		}


		protected PersonName fullname;

		public PersonName Fullname
		{
			get { return fullname; }
			set { fullname = value; }
		}


		public Person()
        {
            birthdate = DateTime.MinValue;
			fullname=new PersonName();
        }

        public override string ToString()
        {
            return fullname.ToString()+" "+birthdate.Date;
        }
    }
}
