using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWinForm
{
	interface ICustomer
	{
		string CustomerName { get; set; }

		DateTime DOB { get; set; }

		string Address { get; set; }

		string PhoneNumber { get; set; }

		bool IsDirty { get; set; }

		event EventHandler<EventArgs> SaveCustomer;

		event EventHandler<EventArgs> NewCustomer;

		event EventHandler<EventArgs> PreviousCustomer;

		event EventHandler<EventArgs> NextCustomer;
	}

	class Customer
	{
		public string CustomerName { get; set; }

		public DateTime DOB { get; set; }

		public string Address { get; set; }

		public string PhoneNumber { get; set; }

		public bool IsDirty { get; set; }

		public event EventHandler<EventArgs> SaveCustomer;


		
	}
}
