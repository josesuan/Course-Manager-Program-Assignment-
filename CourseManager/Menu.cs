using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Btn_StartDashboard_Click(object sender, EventArgs e)
		{
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
			this.Hide();
		}


	}
}
