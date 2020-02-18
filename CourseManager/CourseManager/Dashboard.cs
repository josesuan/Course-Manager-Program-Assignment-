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
        Module currentModule = new Module();
        List<Module> moduleList = new List<Module>();
        public Dashboard()
        {
            InitializeComponent();
        }

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

                moduleList.Add(currentModule);

                string[] row = {currentModule.moduleName, currentModule.assignmentNum.ToString(), currentModule.TimeRemaining().ToString() };

                dgv_ongoing.Rows.Add(row);
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
                    string[] row = { currentModule.moduleName, currentModule.assignmentNum.ToString(), tb_marksFinished.Text, currentModule.year };
                    dgv_finished.Rows.Add(row);
                }

            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }

        private void Dgv_pending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get module name and assignment number

            //open form options and carry over selected module
        }
    }
}
