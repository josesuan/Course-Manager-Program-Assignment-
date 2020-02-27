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
    public partial class OptionsForm : Form
    {
        Module currentModule;

		Dashboard Dashboard = new Dashboard(); //Initialised object

		public OptionsForm(Module mod)
        {
            InitializeComponent();
            currentModule = mod;

        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {

        }
		

        private void Bt_sendPending_Click(object sender, EventArgs e)
        {
			//Dashboard.removeOldLocation(currentModule); //Remove module in Ongoing
			
			Dashboard.AddToPending(currentModule); // Adds selected module in dgv pending
			this.Close();
		}

		//Continue here!
		private void Bt_remove_Click(object sender, EventArgs e)
		{
			//Remove in the dgv 
			Dashboard dashboard = new Dashboard();


			//Remove in object class
			Dashboard.removeOldLocation(currentModule);
			Dashboard.moduleList.Remove(currentModule);
			this.Hide();
		}

		private void Bt_sendFinish_Click(object sender, EventArgs e)
		{

		}
	}
}
