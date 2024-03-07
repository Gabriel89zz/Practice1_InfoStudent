using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class PersonName
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string lastname;

		public string LastName
		{
			get { return lastname; }
			set { lastname = value; }
		}

		private string motherlastname;

		public string MotherLastName
		{
			get { return motherlastname; }
			set { motherlastname = value; }
		}

        public PersonName()
        {
			name = "";
			lastname = "";
			motherlastname = "";
		}

        public override string ToString()
        {
            return name+" "+lastname+" "+motherlastname;
        }
    }
}
