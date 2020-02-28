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
		//Initialised
		Module currentModule = new Module(); //selection is the current module

		//Module list
        static public List<Module> moduleList = new List<Module>();

        public Dashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chooses the specific function through using to check the attribute location of the module.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            foreach (Module mod in moduleList)
            {
                currentModule = mod;

                switch (mod.location)
                {
                    case "Ongoing":
                        AddToOngoing();
                        break;

                    case "Pending":
                        AddToPending();
                        break;

                    case "Finished":
                        AddToFinished();
                        break;

                    default:
                        break;
                }
            }
        }

        #region buttonClick
        /// <summary>
        /// Button click for adding new module to ongoing dgv 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

				//Add to module list as object
				moduleList.Add(new Module(currentModule.year, currentModule.moduleName, currentModule.assignmentNum, currentModule.assigmentType, currentModule.startDate,currentModule.dueDate, currentModule.location));

				AddToOngoing(); //Add to ongoing dgv
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }


		/// <summary>
		/// Button click to send finished module to finish dgv
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// <summary>
		/// Cell clicked - selecting particular module and display show options
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Dgv_ongoing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool moduleFound = false;
            foreach (Module mod in moduleList)
            {
                if (mod.moduleName == dgv_ongoing.Rows[dgv_ongoing.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_ongoing.Rows[dgv_ongoing.CurrentCell.RowIndex].Cells[1].Value))
                {
                    moduleFound = true;
                    currentModule = mod; //Goes to current module whatever is selected
                }
            }
            if (moduleFound == true)
            {
                ShowOptions();
            }
            else
            {
                MessageBox.Show("Module not found");
            }
        }

		private void Dgv_pending_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            bool moduleFound = false;
            foreach (Module mod in moduleList)
            {
                if (mod.moduleName == dgv_pending.Rows[dgv_pending.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_pending.Rows[dgv_pending.CurrentCell.RowIndex].Cells[1].Value))
                {
                    moduleFound = true;
                    currentModule = mod; //Goes to current module whatever is selected
                }
            }
            if (moduleFound == true)
            {
                ShowOptions();
            }
            else
            {
                MessageBox.Show("Module not found");
            }
        }

		private void Dgv_finished_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            bool moduleFound = false;
            foreach (Module mod in moduleList)
            {
                if (mod.moduleName == dgv_finished.Rows[dgv_finished.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_finished.Rows[dgv_finished.CurrentCell.RowIndex].Cells[1].Value))
                {
                    moduleFound = true;
                    currentModule = mod; //Goes to current module whatever is selected
                }
            }
            if (moduleFound == true)
            {
                ShowOptions();
            }
            else
            {
                MessageBox.Show("Module not found");
            }
        }

		/// <summary>
		/// Display the option form and checking against dgv and module objects
		/// </summary>
		/// <param name="e"></param>
		private void ShowOptions()
        {
            OptionsForm optionsForm = new OptionsForm(currentModule);
            optionsForm.ShowDialog();
            this.Close();
        }
		#endregion


		//Add methods
		#region Add/Remove methods
		private void AddToOngoing()
        {
            string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.TimeRemaining().ToString() };
            dgv_ongoing.Rows.Add(row);
        }
        public void AddToPending()
        {
            string[] row = {currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.dueDate.ToString() }; //Change it to mod because it already contains the selected object/module
			dgv_pending.Rows.Add(row);
            
        }
        private void AddToFinished()
        {
            string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), tb_marksFinished.Text, currentModule.year };
            dgv_finished.Rows.Add(row);
        }
        #endregion

    }
}
