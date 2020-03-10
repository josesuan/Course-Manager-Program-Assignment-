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

        /// <summary>
        /// When the button is clicked, it updates the module object attribute location. ///
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_finish_Click(object sender, EventArgs e)
        {
            bool errors = false;

            //Verify if all textbox is filled
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

                Dashboard dash = new Dashboard();
                dash.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			OptionsForm optionsForm = new OptionsForm(currentModule);
			optionsForm.Show();
			this.Close();
		}

		private void EditForm_Load(object sender, EventArgs e)
		{
			//Load current module details to edit form forms
			ed_year.Text = currentModule.year;
			ed_assignmentNumber.Text = currentModule.assignmentNum.ToString();
			ed_assignmentType.SelectedItem = currentModule.assigmentType;
			ed_moduleName.Text = currentModule.moduleName;
			ed_startDate.Value = currentModule.startDate;
			ed_dueDate.Value = currentModule.dueDate;
			ed_MarkTexbox.Text = currentModule.mark.ToString();
		}
	}
}
