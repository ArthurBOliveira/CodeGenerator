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
        private List<Control> objectsToToggle;

        public Main()
        {
            InitializeComponent();

            this.objectsToToggle = new List<Control>()
            {
                lblProjectName,
                lblModels,
                chkListModels,
                btnCreate,
                btnDelete,
                btnNew,
                btnEdit,
                btnRead,
                chkAPI,
                chkDAL,
                chkTable,
                txtViewModel,
                chkModel,
                lblRows,
                chkRelation,
                chkService,
                chkTsModel,
                chkTsStore,
                chkTsService,
            };

            HideFields();
        }

        /// <summary>
        /// Edit project name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            objectsToToggle.ForEach(x => x.Visible = false);
        }

        private void ShowFields()
        {
            objectsToToggle.ForEach(x => x.Visible = true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListModels.CheckedItems.Count; i++)
                Program.project.Models.Remove(Program.project.Models.Find(item => item.Name == chkListModels.CheckedItems[i].ToString()));

            RefreshModels();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog()
            {
                AddExtension = true,
                RestoreDirectory = true,
                FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm")
            };

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string path = "";

            var aux = dialog.FileName.Split('\\');

            //create folder selected on the dialog
            DirectoryInfo di = new DirectoryInfo(dialog.FileName);

            if(di.Exists == false)
            {
                di.Create();
            }

            for (int i = 0; i < aux.Length; i++)
                path += aux[i] + "\\";

            foreach (Model m in Program.project.Models)
            {
                var modelPath = path + m.Name + "\\";

                //create model directory
                di = new DirectoryInfo(modelPath);
                if(di.Exists == false) { di.Create(); }

                if (chkTable.Checked)
                    TableGenerator.Generate(m, path); // scripts are created as a single file
                if (chkModel.Checked)
                    ModelGenerator.Generate(m, modelPath);
                if (chkAPI.Checked)
                    APIControllerGenerator.Generate(m, modelPath);
                if (chkDAL.Checked)
                    RepositoryGenerator.Generate(m, modelPath);
                if (chkService.Checked)
                    ServiceGenerator.Generate(m, modelPath);
                if (chkTsModel.Checked)
                    ModelTsGenerator.Generate(m, modelPath);
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

            // dialog has been cancelled
            if(dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

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
