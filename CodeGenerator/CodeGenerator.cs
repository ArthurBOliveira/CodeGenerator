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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model m = new Model();
            List<Property> Properties = new List<Property>();
            Property aux;

            //Model Name
            if (!String.IsNullOrEmpty(txtModelName.Text))
                m.Name = txtModelName.Text;
            else
            {
                txtModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
                return;
            }

            //Identity
            if (chkIdentity.Checked)
            {
                aux = new Property();
                aux.Type = "int";
                aux.Name = "id" + m.Name;

                Properties.Add(aux);
            }

            //Prop 1
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                aux = new Property();

                aux.Type = cbbType1.Text;
                aux.Name = textBox1.Text;
                //aux.IsList = checkBox1.Checked;

                Properties.Add(aux);
            }

            //Prop 2
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                aux = new Property();

                aux.Type = cbbType2.Text;
                aux.Name = textBox2.Text;
                //aux.IsList = checkBox2.Checked;

                Properties.Add(aux);
            }


            //Prop 3
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                aux = new Property();

                aux.Type = cbbType3.Text;
                aux.Name = textBox3.Text;
                //aux.IsList = checkBox3.Checked;

                Properties.Add(aux);
            }

            //Prop 4
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                aux = new Property();

                aux.Type = cbbType4.Text;
                aux.Name = textBox4.Text;
                //aux.IsList = checkBox4.Checked;

                Properties.Add(aux);
            }

            //Prop 5
            if (!String.IsNullOrEmpty(textBox5.Text))
            {
                aux = new Property();

                aux.Type = cbbType5.Text;
                aux.Name = textBox5.Text;
                //aux.IsList = checkBox5.Checked;

                Properties.Add(aux);
            }

            //Prop 6
            if (!String.IsNullOrEmpty(textBox6.Text))
            {
                aux = new Property();

                aux.Type = cbbType6.Text;
                aux.Name = textBox6.Text;
                //aux.IsList = checkBox6.Checked;

                Properties.Add(aux);
            }

            //Prop 7
            if (!String.IsNullOrEmpty(textBox7.Text))
            {
                aux = new Property();

                aux.Type = cbbType7.Text;
                aux.Name = textBox7.Text;
                //aux.IsList = checkBox7.Checked;

                Properties.Add(aux);
            }


            //Prop 8
            if (!String.IsNullOrEmpty(textBox8.Text))
            {
                aux = new Property();

                aux.Type = cbbType8.Text;
                aux.Name = textBox8.Text;
                //aux.IsList = checkBox8.Checked;

                Properties.Add(aux);
            }

            //Prop 9
            if (!String.IsNullOrEmpty(textBox9.Text))
            {
                aux = new Property();

                aux.Type = cbbType9.Text;
                aux.Name = textBox9.Text;
                //aux.IsList = checkBox9.Checked;

                Properties.Add(aux);
            }

            //Prop 10
            if (!String.IsNullOrEmpty(textBox10.Text))
            {
                aux = new Property();

                aux.Type = cbbType10.Text;
                aux.Name = textBox10.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            //Prop 10
            if (!String.IsNullOrEmpty(textBox10.Text))
            {
                aux = new Property();

                aux.Type = comboBox1.Text;
                aux.Name = textBox10.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            //Prop 11
            if (!String.IsNullOrEmpty(txtName11.Text))
            {
                aux = new Property();

                aux.Type = cbbType11.Text;
                aux.Name = txtName11.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            //Prop 12
            if (!String.IsNullOrEmpty(txtName12.Text))
            {
                aux = new Property();

                aux.Type = cbbType12.Text;
                aux.Name = txtName12.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            //Prop 13
            if (!String.IsNullOrEmpty(txtName13.Text))
            {
                aux = new Property();

                aux.Type = cbbType13.Text;
                aux.Name = txtName13.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            //Prop 14
            if (!String.IsNullOrEmpty(txtName14.Text))
            {
                aux = new Property();

                aux.Type = cbbType14.Text;
                aux.Name = txtName14.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            //Prop 15
            if (!String.IsNullOrEmpty(txtName15.Text))
            {
                aux = new Property();

                aux.Type = cbbType15.Text;
                aux.Name = txtName15.Text;
                //aux.IsList = checkBox10.Checked;

                Properties.Add(aux);
            }

            m.Properties = Properties;

            m.NameProject = Program.project.Name;

            Program.project.Models.Add(m);

            Close();
        }
    }
}
