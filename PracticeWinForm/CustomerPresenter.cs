using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PracticeWinForm
{
	class CustomerPresenter
	{
		public CustomerPresenter(ICustomer customer)
		{
			view = customer;
			Initialize();
		}

		void Initialize()
		{
			customers = new List<Customer>();
			view.SaveCustomer += Save;
			view.NewCustomer += New;
			view.PreviousCustomer += Previous;
			view.NextCustomer += Next;


		}

		void Save(object sender, EventArgs e)
		{
			Customer customer;
			if (view.IsNew)
			{
				customer = JsonConvert.DeserializeObject<Customer>(view.CustomerJSON);
				customers.Add(customer);
				isNew = false;
				currentIndex = customers.Count - 1;
				LoadCustomer(currentIndex);
			}
			else
			{
				customer = customers[currentIndex];
				customer.CustomerName = view.CustomerName;
				customer.DOB = view.DOB;
				customer.Address = view.Address;
				customer.PhoneNumber = view.PhoneNumber;
			}

			view.IsDirty = false;
		}


		void New(object sender, EventArgs e)
		{
			BlankCustomer();
			isNew = true;
			view.IsDirty = true;
			currentIndex = customers.Count;

			void BlankCustomer()
			{
				view.CustomerName = string.Empty;
				view.DOB = DateTime.MinValue;
				view.Address = string.Empty;
				view.PhoneNumber = string.Empty;
			}
		}

		void Previous(object sender, EventArgs e)
		{
			if (currentIndex > 0)
			{
				currentIndex--;
				LoadCustomer(currentIndex);
			}
		}

		void Next(object sender, EventArgs e)
		{
			if (currentIndex < customers.Count - 1)
			{
				currentIndex++;
				LoadCustomer(currentIndex);
			}
		}

		void LoadCustomer(int currentIndex)
		{
			var customer = customers[currentIndex];
			view.CustomerName = customer.CustomerName;
			view.DOB = customer.DOB;
			view.Address = customer.Address;
			view.PhoneNumber = customer.PhoneNumber;
			isNew = false;
		}

		readonly ICustomer view;
		List<Customer> customers;
		int currentIndex = 0;
		bool isNew = true;
	}
}
