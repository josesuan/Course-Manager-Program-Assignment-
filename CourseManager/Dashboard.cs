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
    public partial class Dashboard : Form
    {
		Module currentModule = new Module(); //selection is the current module
        List<Module> moduleList = new List<Module>();

		

		//static List<string> OnGoing = new List<string>();
		static public List<Module> Pending = new List<Module>();
		static public List<Module> Finish = new List<Module>();


        public Dashboard()
        {
            InitializeComponent();
        }
		/*public Dashboard(string location, Module mod)
        {
            InitializeComponent();

            currentModule = mod;

            switch (location)
            {
                case "Ongoing":
                    AddToOngoing();
                    break;
                case "Pending":
                    AddToPending(mod);
                    break;
                case "Finished":
                    AddToFinished();
                    break;
                default: MessageBox.Show("Unexpected error, please try again");
                    break;
            }
        }*/

		static public void dashboard(string location, Module mod)
		{

		
		}


		#region buttonClick
		private void Btn_add_Click(object sender, EventArgs e)
        {
            bool errors = false;
            foreach (TextBox tb in this.tab_ongoing.Controls.OfType<TextBox>())
            {
                if (tb.Text == string.Empty)
                {
                    errors = true;
                }
            }
            if (cb_assignmentType.Text == string.Empty)
            {
                errors = true;
            }

            if (errors == false)
            {
				currentModule.year = tb_year.Text;
                currentModule.assignmentNum = Convert.ToInt32(tb_assignmentNumber.Text);
                currentModule.assigmentType = cb_assignmentType.Text;
                currentModule.moduleName = tb_moduleName.Text;
                currentModule.startDate = dt_startDate.Value;
                currentModule.dueDate = dt_dueDate.Value;
                currentModule.location = "Ongoing";

				moduleList.Add(new Module(currentModule.year, currentModule.moduleName, currentModule.assignmentNum, currentModule.assigmentType, currentModule.startDate,currentModule.dueDate, currentModule.location));

                AddToOngoing();
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }

        private void Btn_addFinished_Click(object sender, EventArgs e)
        {
            bool errors = false;
            foreach (TextBox tb in this.tab_finished.Controls.OfType<TextBox>())
            {
                if (tb.Text == string.Empty)
                {
                    errors = true;
                }
            }

            if (errors == false)
            {
                bool moduleFound = false;
                foreach (Module mod in moduleList)
                {
                    if (mod.moduleName == tb_moduleNameFinished.Text && mod.assignmentNum == Convert.ToInt32(tb_assignmentNumberFinished.Text))
                    {
                        currentModule = mod;
                        moduleFound = true;
                    }
                }

                if (moduleFound == false)
                {
                    MessageBox.Show("Module Not found");
                }
                else
                {
                    AddToFinished();
                }

            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }


        #endregion

        #region cellContentClick

        private void Dgv_ongoing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			ShowOptions(e);
		}

        private void ShowOptions(DataGridViewCellEventArgs e)
        {
            bool moduleFound = false;
            foreach (Module mod in moduleList)
            {
                if (mod.moduleName == dgv_ongoing.Rows[dgv_ongoing.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_ongoing.Rows[dgv_ongoing.CurrentCell.RowIndex].Cells[1].Value))
                {
					
					moduleFound = true;
                    currentModule = mod;
                }
            }

            if (moduleFound == true)
            {
                OptionsForm optionsForm = new OptionsForm(currentModule);
                optionsForm.ShowDialog();
				//this.Hide();
            }
			else
			{
				MessageBox.Show("Module not found");
			}
        }

		#endregion

		#region Add/Remove methods
		private void AddToOngoing()
        {
            string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.TimeRemaining().ToString() };
            dgv_ongoing.Rows.Add(row);
        }
        private void AddToPending(Module mod)
        {
			Pending.Add(mod);//Add to pending list
            string[] row = {currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.dueDate.ToString() };
            dgv_pending.Rows.Add(row);
			
        }
        private void AddToFinished()
        {
            string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), tb_marksFinished.Text, currentModule.year };
            dgv_finished.Rows.Add(row);
        }

		//removing
        private void removeOldLocation(Module mod)
        {
			currentModule = mod;
            //ongoing
            for (int ongoingIndex = 0; ongoingIndex < dgv_ongoing.Rows.Count -1; ongoingIndex++)
            {
                if (currentModule.moduleName == dgv_ongoing.Rows[ongoingIndex].Cells[0].Value.ToString() && currentModule.assignmentNum == Convert.ToInt32(dgv_ongoing.Rows[ongoingIndex].Cells[1].Value))
                {
                    dgv_ongoing.Rows.Remove(dgv_ongoing.Rows[ongoingIndex]);
                }
            }

            //Pending
            for (int pendingIndex = 0; pendingIndex < dgv_pending.Rows.Count -1; pendingIndex++)
            {
                if (currentModule.moduleName == dgv_pending.Rows[pendingIndex].Cells[0].Value.ToString() && currentModule.assignmentNum == Convert.ToInt32(dgv_pending.Rows[pendingIndex].Cells[1].Value))
                {
                    dgv_pending.Rows.Remove(dgv_pending.Rows[pendingIndex]);
                }
            }

            //Finished
            for (int finsihedIndex = 0; finsihedIndex < dgv_finished.Rows.Count -1; finsihedIndex++)
            {
                if (currentModule.moduleName == dgv_finished.Rows[finsihedIndex].Cells[0].Value.ToString() && currentModule.assignmentNum == Convert.ToInt32(dgv_finished.Rows[finsihedIndex].Cells[1].Value))
                {
                    dgv_finished.Rows.Remove(dgv_finished.Rows[finsihedIndex]);
                }
            }
        }


		#endregion

		private void Dashboard_Activated(object sender, EventArgs e)
		{
			
			foreach (Module mod in Pending)
			{
				removeOldLocation(mod);
				string[] row = { mod.moduleName, mod.assignmentNum.ToString(), mod.dueDate.ToString() };
				dgv_pending.Rows.Add(row);
			}
		}
	}
}
