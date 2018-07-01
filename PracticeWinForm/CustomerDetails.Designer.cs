namespace PracticeWinForm
{
	partial class CustomerDetails
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtJSON = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.dtDOB = new System.Windows.Forms.DateTimePicker();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer JSON:";
			// 
			// txtJSON
			// 
			this.txtJSON.Location = new System.Drawing.Point(193, 37);
			this.txtJSON.Multiline = true;
			this.txtJSON.Name = "txtJSON";
			this.txtJSON.Size = new System.Drawing.Size(651, 66);
			this.txtJSON.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(193, 109);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnParseJSON_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "DOB: ";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(74, 240);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(68, 17);
			this.lblAddress.TabIndex = 5;
			this.lblAddress.Text = "Address: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(74, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Phone Number:";
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(77, 344);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(75, 23);
			this.btnPrevious.TabIndex = 7;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(769, 344);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(193, 151);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(651, 22);
			this.txtName.TabIndex = 9;
			// 
			// dtDOB
			// 
			this.dtDOB.Location = new System.Drawing.Point(193, 194);
			this.dtDOB.Name = "dtDOB";
			this.dtDOB.Size = new System.Drawing.Size(200, 22);
			this.dtDOB.TabIndex = 10;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(193, 240);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(651, 22);
			this.txtAddress.TabIndex = 11;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(193, 275);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(651, 22);
			this.txtPhone.TabIndex = 12;
			// 
			// CustomerDetails
			// 
			this.ClientSize = new System.Drawing.Size(920, 396);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.dtDOB);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtJSON);
			this.Controls.Add(this.label1);
			this.Name = "CustomerDetails";
			this.Load += new System.EventHandler(this.CustomerDetails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtJSON;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.DateTimePicker dtDOB;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhone;
	}
}

