using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace CodeGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            HideFields();
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            ProjectName pn = new ProjectName();

            if (pn.ShowDialog() == DialogResult.OK)
            {
                lblProjectName.Text = Program.project.Name;

                if (lblProjectName.Text != "")
                    ShowFields();
                else
                    HideFields();
            }
        }

        private void RefreshModels()
        {
            chkListModels.Items.Clear();

            foreach (Model m in Program.project.Models)
                chkListModels.Items.Add(m.Name);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CodeGenerator cg = new CodeGenerator();

            if (cg.ShowDialog() == DialogResult.OK)
            {
                RefreshModels();
            }
        }

        private void HideFields()
        {
            lblModels.Visible = false;
            chkListModels.Visible = false;
            btnCreate.Visible = false;
            btnDelete.Visible = false;
            btnNew.Visible = false;
            btnEdit.Visible = false;
        }

        private void ShowFields()
        {
            lblModels.Visible = true;
            chkListModels.Visible = true;
            btnCreate.Visible = true;
            btnDelete.Visible = true;
            btnNew.Visible = true;
            btnEdit.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListModels.SelectedItems.Count; i++)
            {
                var aux = chkListModels.SelectedItems[i];

                Program.project.Models.Remove(new Model(chkListModels.SelectedItems[i].ToString()));
            }

            RefreshModels();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (Model m in Program.project.Models)
            {
                ModelGenerator.Generate(m);
                StoredProceduresGenerator.Generate(m);
                APIControllerGenerator.Generate(m);
                MVCControllerGenerator.Generate(m);
                DALGenerator.Generate(m);
                BLLGenerator.Generate(m);
                TableGenerator.Generate(m);
            }

            Process.Start(@"C:\Users\Arthur\Documents\GitHub\CodeGenerator\CodeGenerator\CodeGenerator\bin\Debug");
        }
    }
}
