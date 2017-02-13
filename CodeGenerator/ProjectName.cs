using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class ProjectName : Form
    {
        public ProjectName()
        {
            InitializeComponent();
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Program.project.Name = txtName.Text;

            Close();
        }
    }
}
