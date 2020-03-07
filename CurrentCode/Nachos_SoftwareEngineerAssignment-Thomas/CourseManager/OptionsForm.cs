using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CourseManager
{
    public partial class OptionsForm : Form
    {
		//Get current module
        Module currentModule;		

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
            Dashboard dashboard = new Dashboard();
            //Change location of selected module attribute to pending.
            currentModule.location = "Pending";
            dashboard.Show();
			this.Close();
		}

		private void Bt_remove_Click(object sender, EventArgs e)
		{
            Dashboard dashboard = new Dashboard();
            if (MessageBox.Show("Are you sure to remove selected module?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//Removes object in module list and dgv list
				Dashboard.moduleList.Remove(currentModule);
				dashboard.Show();
				this.Close();
			}
			else
			{
				//Stays the same form, if no 
			}
		}

		private void Bt_sendFinish_Click(object sender, EventArgs e)
		{
            // Add marks Pop-up
            string input = Interaction.InputBox("How Many Marks(%) did you get?", "Add Marks", "");
            int mark;
            if (input == string.Empty)
            {

            }
            else
            {
                if ((int.TryParse(input, out mark)) && (Convert.ToInt32(input) >=0 && Convert.ToInt32(input) <= 100))
                {
                    currentModule.mark = mark;
                    currentModule.location = "Finished";
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Marks(%) sould be between 0 and 100");
                }
            }
            
            

        }

		private void Btn_Back_Click(object sender, EventArgs e)
		{
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
			this.Close();
		}
	}
}
