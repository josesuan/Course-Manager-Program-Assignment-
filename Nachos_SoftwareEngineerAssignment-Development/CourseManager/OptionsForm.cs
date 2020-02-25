using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CourseManager
{
    public partial class OptionsForm : Form
    {
        Module currentModule;
        FormEdit formEdit; 

		public OptionsForm(Module mod)
        {
            InitializeComponent();
            currentModule = mod;

        }

        

        private void Bt_sendPending_Click(object sender, EventArgs e)
        {
			Dashboard.Pending.Add(currentModule);//Add to pending list
			this.Close();
		}

		//Continue here!
		private void Bt_remove_Click(object sender, EventArgs e)
		{  
            this.Close();
		}

        public void Bt_edit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormEdit formEdit = new FormEdit();
            formEdit.ShowDialog();
            
        }
    }
}
