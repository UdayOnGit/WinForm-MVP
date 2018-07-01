using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinForm
{
	public partial class CustomerDetails : Form, ICustomer
	{
		public CustomerDetails()
		{
			InitializeComponent();
		}

		void CustomerDetails_Load(object sender, EventArgs e)
		{
			presenter = new CustomerPresenter(this);
			this.IsDirty = false;
		}

		public string CustomerJSON
		{
			get => txtJSON.Text;
		}

		public string CustomerName
		{
			get => txtName.Text;
			set => txtName.Text = value;
		}

		public DateTime DOB
		{
			get => dtDOB.Value;
			set => dtDOB.Value = value;
		}

		public string Address
		{
			get => txtAddress.Text;
			set => txtAddress.Text = value;
		}

		public string PhoneNumber
		{
			get => txtPhone.Text;
			set => txtPhone.Text = value;
		}

		public bool IsDirty
		{
			get;
			set;
		}

		public bool IsNew
		{
			get;
			set;
		}

		public event EventHandler<EventArgs> SaveCustomer;
		public event EventHandler<EventArgs> NewCustomer;
		public event EventHandler<EventArgs> PreviousCustomer;
		public event EventHandler<EventArgs> NextCustomer;

		CustomerPresenter presenter;

		private void btnParseJSON_Click(object sender, EventArgs e)
		{
			this.IsDirty = true;
			IsNew = true;
			if (SaveCustomer != null)
			{
				SaveCustomer(this, EventArgs.Empty);
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (PreviousCustomer != null)
			{
				PreviousCustomer(this, EventArgs.Empty);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (NextCustomer != null)
			{
				NextCustomer(this, EventArgs.Empty);
			}
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			IsDirty = true;
		}

		private void dtDOB_ValueChanged(object sender, EventArgs e)
		{
			IsDirty = true;
		}

		private void txtAddress_TextChanged(object sender, EventArgs e)
		{
			IsDirty = true;
		}

		private void txtPhone_TextChanged(object sender, EventArgs e)
		{
			IsDirty = true;
		}
	}
}
