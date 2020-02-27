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
            OptionsForm optionForm = new OptionsForm(currentModule);
            this.Close();
            

        }
		

        private void Bt_sendPending_Click(object sender, EventArgs e)
        {
            //Dashboard.removeOldLocation(currentModule); //Remove module in Ongoing
            currentModule.location = "Pending";
            dashboard.Show();
            //Dashboard.AddToPending(); // Adds selected module in dgv pending
			this.Close();
		}

		//Continue here!
		private void Bt_remove_Click(object sender, EventArgs e)
		{
			//Remove in the dgv 


            //Remove in object class
            //Dashboard.removeOldLocation(currentModule);
			Dashboard.moduleList.Remove(currentModule);
            dashboard.Show();
			this.Hide();
		}

		private void Bt_sendFinish_Click(object sender, EventArgs e)
		{
            

        }
	}
}
