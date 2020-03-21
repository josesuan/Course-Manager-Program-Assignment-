using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseManager
{
    public partial class Dashboard : Form
    {
		//Initialised
		Module currentModule = new Module(); //selection is the current module

		//Create new object for adding new data in module list
		Module addnewModule = new Module();

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
			Sorting();
		}

        #region buttonClick
        /// <summary>
        /// Button click for adding new module to ongoing dgv 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_add_Click(object sender, EventArgs e)
        {
			//Checks if the textbox is empty
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

			
            if (errors == false) //If all the textxbox are filled
            {
				int result;
				int result2;
				if (int.TryParse(tb_assignmentNumber.Text, out result) && int.TryParse(tb_year.Text, out result2)) //checks input
				{



					//Checks if the module exists already
					bool moduleFound = false;
					foreach (Module mod in moduleList)
					{
						//if its true its an error
						if (mod.moduleName == tb_moduleName.Text && mod.assignmentNum == Convert.ToInt32(tb_assignmentNumber.Text))
						{
							//currentModule = mod;  eeewwww this was a BUG!!!
							moduleFound = true;
						}
					}

					if (moduleFound == false)
					{

						addnewModule.year = Convert.ToInt32(tb_year.Text);
						addnewModule.assignmentNum = Convert.ToInt32(tb_assignmentNumber.Text);
						addnewModule.assigmentType = cb_assignmentType.Text;
						addnewModule.moduleName = tb_moduleName.Text;
						addnewModule.startDate = dt_startDate.Value;
						addnewModule.dueDate = dt_dueDate.Value;
						addnewModule.location = "Ongoing";

						//Add to module list as object
						moduleList.Add(new Module(addnewModule.year, addnewModule.moduleName, addnewModule.assignmentNum, addnewModule.assigmentType, addnewModule.startDate, addnewModule.dueDate, addnewModule.location));

						//Then assign addmodule to current module to add in the DGV
						currentModule = addnewModule;
						AddToOngoing(); //Add to ongoing dgv

					}
					else if (moduleFound == true)
					{
						MessageBox.Show("Module already exits");
					}
				}
				else { MessageBox.Show("Invalid Input", "Error"); }
            }

            else
            {
                MessageBox.Show("Please complete the form","Missing input");
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
			try //This will TRY to run the following code, if not or there is any error, will run the CATCH statement. 
			{
				foreach (Module mod in moduleList)
				{
					if (mod.moduleName == dgv_ongoing.Rows[dgv_ongoing.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_ongoing.Rows[dgv_ongoing.CurrentCell.RowIndex].Cells[1].Value))
					{
						moduleFound = true;
						currentModule = mod; //Goes to current module whatever is selected
					}

					if (moduleFound == true)
					{
						ShowOptions();
						break; //Stops searching again that makes the error of null, same as pending click and finished click
					}
				}
			}
			catch
			{
				MessageBox.Show("Module not found!", "Alert");
			}
		}

		private void Dgv_pending_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            bool moduleFound = false;
			try
			{
				foreach (Module mod in moduleList)
				{
					if (mod.moduleName == dgv_pending.Rows[dgv_pending.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_pending.Rows[dgv_pending.CurrentCell.RowIndex].Cells[1].Value))
					{
						moduleFound = true;
						currentModule = mod; //Goes to current module whatever is selected
					}
					if (moduleFound == true)
					{
						ShowOptions();
						break;
					}
				}
			}
			catch
			{
				MessageBox.Show("Module not found!","Alert");
			}
		}

		private void Dgv_finished_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool moduleFound = false;
				foreach (Module mod in moduleList)
				{
					if (mod.moduleName == dgv_finished.Rows[dgv_finished.CurrentCell.RowIndex].Cells[0].Value.ToString() && mod.assignmentNum == Convert.ToInt32(dgv_finished.Rows[dgv_finished.CurrentCell.RowIndex].Cells[1].Value))
					{
						moduleFound = true;
						currentModule = mod; //Goes to current module whatever is selected
					}
					if (moduleFound == true)
					{
						ShowOptions();
						break;
					}
				}
			}
			catch
			{
				MessageBox.Show("Module not found!", "Alert");
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
			//------
            string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.TimeRemaining().ToString() };
            dgv_ongoing.Rows.Add(row);
        }
        public void AddToPending()
        {
            string[] row = {currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.dueDate.ToString() }; 
			dgv_pending.Rows.Add(row);
            
        }
        private void AddToFinished()
        {
                   
            string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.mark.ToString(), currentModule.year.ToString() };
            dgv_finished.Rows.Add(row);
           
        }
		#endregion


		private void Btn_Exit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Would you like to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (MessageBox.Show("Would you like to save your work?", "Save Work", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					//Saves file
					currentModule.SaveFile(moduleList);
				}
				//Closes the program
				Application.Exit();
			}
			else
			{
				//Stays in dashboard
			}
		}

        private void dgv_finished_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_finished_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sorts all assignments by year from the most recent to the last one. The sorting is made in the finished tab.
        /// </summary>
        public void Sorting()
        {
            dgv_finished.Sort(dgv_finished.Columns[3], ListSortDirection.Descending);
        }      

        private void dgv_finished_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

        }
    }
}
