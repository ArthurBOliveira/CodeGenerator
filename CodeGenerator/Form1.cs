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
    public partial class CodeGenerator : Form
    {
        public CodeGenerator()
        {
            InitializeComponent();

            CloseDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model m = new Model();
            List<Property> Properties = new List<Property>();
            Property aux;

            Loading();

            //Model Name
            if (!String.IsNullOrEmpty(txtModelName.Text))
                m.Name = txtModelName.Text;
            else
            {
                txtModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
                CallError();
                return;
            }

            //Project Name
            if (!String.IsNullOrEmpty(txtProjectName.Text))
                m.NameProject = txtProjectName.Text;
            else
            {
                txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
                CallError();
                return;
            }

            //Prop 1
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                aux = new Property();

                aux.Type = cbbType1.Text;
                aux.Name = textBox1.Text;

                Properties.Add(aux);
            }

            //Prop 2
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                aux = new Property();

                aux.Type = cbbType2.Text;
                aux.Name = textBox2.Text;

                Properties.Add(aux);
            }


            //Prop 3
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                aux = new Property();

                aux.Type = cbbType3.Text;
                aux.Name = textBox3.Text;

                Properties.Add(aux);
            }

            //Prop 4
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                aux = new Property();

                aux.Type = cbbType4.Text;
                aux.Name = textBox4.Text;

                Properties.Add(aux);
            }

            //Prop 5
            if (!String.IsNullOrEmpty(textBox5.Text))
            {
                aux = new Property();

                aux.Type = cbbType5.Text;
                aux.Name = textBox5.Text;

                Properties.Add(aux);
            }

            //Prop 6
            if (!String.IsNullOrEmpty(textBox6.Text))
            {
                aux = new Property();

                aux.Type = cbbType6.Text;
                aux.Name = textBox6.Text;

                Properties.Add(aux);
            }

            //Prop 7
            if (!String.IsNullOrEmpty(textBox7.Text))
            {
                aux = new Property();

                aux.Type = cbbType7.Text;
                aux.Name = textBox7.Text;

                Properties.Add(aux);
            }


            //Prop 8
            if (!String.IsNullOrEmpty(textBox8.Text))
            {
                aux = new Property();

                aux.Type = cbbType8.Text;
                aux.Name = textBox8.Text;

                Properties.Add(aux);
            }

            //Prop 9
            if (!String.IsNullOrEmpty(textBox9.Text))
            {
                aux = new Property();

                aux.Type = cbbType9.Text;
                aux.Name = textBox9.Text;

                Properties.Add(aux);
            }

            //Prop 10
            if (!String.IsNullOrEmpty(textBox10.Text))
            {
                aux = new Property();

                aux.Type = cbbType10.Text;
                aux.Name = textBox10.Text;

                Properties.Add(aux);
            }

            m.Properties = Properties;

            ModelGenerator.Generate(m);
            StoredProceduresGenerator.Generate(m);
            APIControllerGenerator.Generate(m);
            DALGenerator.Generate(m);
            BLLGenerator.Generate(m);
            TableGenerator.Generate(m);

            Success();
        }

        private void Success()
        {
            OpenDialog();

            lblResult.Text = "Funcionou!";
            lblResult.ForeColor = Color.Green;
        }

        private void CallError()
        {
            OpenDialog();

            lblResult.Text = "Ocorreu algum Erro!";
            lblResult.ForeColor = Color.Red;            
        }

        private void Loading()
        {
            OpenDialog();

            btnOk.Visible = false;

            lblResult.Text = "Carregando...";
            lblResult.ForeColor = Color.Black;
        }

        private void OpenDialog()
        {
            panel1.Visible = true;
            lblResult.Visible = true;
            btnOk.Visible = true;

            btnCreate.Visible = false;
        }

        private void CloseDialog()
        {
            panel1.Visible = false;
            lblResult.Visible = false;
            btnOk.Visible = false;

            btnCreate.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }
    }
}
