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
    public partial class EditForm : Form
    {
        Module currentModule;
        public EditForm(Module mod)
        {
            currentModule = mod;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the button is clicked all the data are sent to dashboard form. ///
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_finish_Click(object sender, EventArgs e)
        {
            bool errors = false;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text == string.Empty)
                {
                    errors = true;
                }
            }
            if (ed_assignmentType.Text == string.Empty)
            {
                errors = true;
            }

            if (errors == false)
            {
                currentModule.year = ed_year.Text;
                currentModule.assignmentNum = Convert.ToInt32(ed_assignmentNumber.Text);
                currentModule.assigmentType = ed_assignmentType.Text;
                currentModule.moduleName = ed_moduleName.Text;
                currentModule.startDate = ed_startDate.Value;
                currentModule.dueDate = ed_dueDate.Value;
                currentModule.mark = Convert.ToInt32(ed_MarkTexbox.Text);

                Dashboard dash = new Dashboard(currentModule);
                dash.Show();
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }

            EditForm formEdit = new EditForm(currentModule);
            this.Close();
           
            /* dashboard = new Dashboard();
            this.Show();*/
        }
    }
}
