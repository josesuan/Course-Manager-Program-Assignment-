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
		//Get current module
        Module currentModule;

		//Object dashbooard
		Dashboard dashboard = new Dashboard(); //Initialised object

		public OptionsForm(Module mod)
        {
            InitializeComponent();
            currentModule = mod;
        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {
            EditForm formEdit = new EditForm(currentModule);
            formEdit.Show();           
            this.Close();
        }
		
        private void Bt_sendPending_Click(object sender, EventArgs e)
        {
			//Change location of selected module attribute to pending.
            currentModule.location = "Pending";
            dashboard.Show();
			this.Close();
		}

		private void Bt_remove_Click(object sender, EventArgs e)
		{
			//Removes object in module list and dgv list
			Dashboard.moduleList.Remove(currentModule);
            dashboard.Show();
			this.Close();
		}

		private void Bt_sendFinish_Click(object sender, EventArgs e)
		{
            currentModule.location = "Finished";
            dashboard.Show();
            this.Close();

        }
    }
}
