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
        public OptionsForm(Module mod)
        {
            InitializeComponent();
            currentModule = mod;
        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void Bt_sendPending_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard("Pending", currentModule);
        }
    }
}
