using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinForm
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using (var context = new SchoolContext())
			{
				var student = new Student() { StudentName = "Reyansh" };
				context.Students.Add(student);
				context.SaveChanges();
				//var student = context.Students.First();
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new CustomerDetails());
		}
	}
}
