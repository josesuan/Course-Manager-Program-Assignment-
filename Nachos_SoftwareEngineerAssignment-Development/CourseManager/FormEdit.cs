using CourseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FormEdit : Form
    {
        OptionsForm optForm;
        public FormEdit(OptionsForm optForm2)
        {
            InitializeComponent();
            optForm = optForm2;
        }
        public FormEdit()
        {
            InitializeComponent();
        }

        public void Bt_edit_Click(object sender, EventArgs e)
        {
            optForm.Show();
            this.Close();
        }
        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

    }
}



