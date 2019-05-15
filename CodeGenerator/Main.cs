using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            lblRows.Text = Program.project.Models.Count + " Modelos";

            foreach (var m in Program.project.Models)
                chkListModels.Items.Add(m.Name);
            foreach (var c in Program.project.Controllers)
                chkListModels.Items.Add(c.Name);
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
            btnRead.Visible = false;
            chkAPI.Visible = false;
            chkDAL.Visible = false;
            chkTable.Visible = false;
            txtViewModel.Visible = false;
            chkModel.Visible = false;
            lblRows.Visible = false;
            chkRelation.Visible = false;
            chkService.Visible = false;
            chkTsModel.Visible = false;
            chkTsStore.Visible = false;
            chkTsService.Visible = false;
        }

        private void ShowFields()
        {
            lblModels.Visible = true;
            chkListModels.Visible = true;
            btnCreate.Visible = true;
            btnDelete.Visible = true;
            btnNew.Visible = true;
            btnEdit.Visible = true;
            btnRead.Visible = true;
            chkAPI.Visible = true;
            chkDAL.Visible = true;
            chkTable.Visible = true;
            txtViewModel.Visible = true;
            chkModel.Visible = true;
            lblRows.Visible = true;
            chkRelation.Visible = true;
            chkService.Visible = true;
            chkTsModel.Visible = true;
            chkTsStore.Visible = true;
            chkTsService.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListModels.CheckedItems.Count; i++)
                Program.project.Models.Remove(Program.project.Models.Find(item => item.Name == chkListModels.CheckedItems[i].ToString()));

            RefreshModels();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if (chkDAL.Checked)
            //    RepositoryGenerator.Generate();
            //if (chkAPI.Checked)
            //    APIControllerGenerator.Generate();

            foreach (Model m in Program.project.Models)
            {
                if (chkModel.Checked)
                    ModelGenerator.Generate(m);
                if (chkAPI.Checked)
                    APIControllerGenerator.Generate(m);
                if (chkTable.Checked)
                    TableGenerator.Generate(m);
                if (chkDAL.Checked)
                    RepositoryGenerator.Generate(m);
                if (chkService.Checked)
                    ServiceGenerator.Generate(m);
                if (chkTsModel.Checked)
                    ModelTsGenerator.Generate(m);
            }

            foreach (var c in Program.project.Controllers)
            {
                if (chkTsService.Checked)
                    ServiceTsGenerator.Generate(c);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dialog.FileNames)
                {
                    string result = "";

                    var sr = new StreamReader(file);
                    result = sr.ReadToEnd();
                    sr.Close();

                    if (file.Contains("Controller"))
                        ReadControllerFromFile(result);
                    else
                        ReadModelFromFile(result);
                }
            }
        }

        private void ReadControllerFromFile(string result)
        {
            var controllers = result.Split(new string[] { "RoutePrefix" }, StringSplitOptions.None);

            for (int i = 1; i < controllers.Length; i++)
            {
                var c = new Controller(controllers[i]);

                Program.project.Controllers.Add(c);
            }

            RefreshModels();
        }

        private void ReadModelFromFile(string result)
        {
            var models = result.Split(new string[] { "class" }, StringSplitOptions.None);

            for (int i = 1; i < models.Length; i++)
            {
                Model m = new Model(models[i]);

                Program.project.Models.Add(m);
            }

            RefreshModels();
        }

        private void chkListModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 < chkListModels.SelectedItems.Count)
            {
                string name = chkListModels.SelectedItems[0].ToString();

                Model m = Program.project.Models.Find(item => item.Name == name);

                if (m.Parent == "")
                    txtViewModel.Text = "class " + m.Name + "\r\n";
                else
                    txtViewModel.Text = "class " + m.Name + " : " + m.Parent + "\r\n";

                txtViewModel.Text += "{\r\n";

                foreach (Property p in m.Properties)
                    txtViewModel.Text += "\t" + p.Type + " " + p.Name + "\r\n";

                txtViewModel.Text += "}";

                chkRelation.Checked = m.IsRelation;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void chkRelation_CheckedChanged(object sender, EventArgs e)
        {
            if (0 < chkListModels.SelectedItems.Count)
            {
                string name = chkListModels.SelectedItems[0].ToString();

                Model m = Program.project.Models.Find(item => item.Name == name);

                m.IsRelation = chkRelation.Checked;
            }
        }

        private void chkTeste_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
