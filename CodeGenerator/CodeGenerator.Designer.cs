namespace CodeGenerator
{
    partial class CodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbType1 = new System.Windows.Forms.ComboBox();
            this.cbbType2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbType4 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbType3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbType6 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbbType5 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbType8 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbType7 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbType10 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbType9 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.chkIdentity = new System.Windows.Forms.CheckBox();
            this.chkDAL = new System.Windows.Forms.CheckBox();
            this.chkBLL = new System.Windows.Forms.CheckBox();
            this.chkAPI = new System.Windows.Forms.CheckBox();
            this.chkMVC = new System.Windows.Forms.CheckBox();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.chkProc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Objeto";
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(247, 342);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(166, 46);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Finalizar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtModelName.Location = new System.Drawing.Point(89, 12);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(233, 20);
            this.txtModelName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Propriedade 1";
            // 
            // cbbType1
            // 
            this.cbbType1.FormattingEnabled = true;
            this.cbbType1.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType1.Location = new System.Drawing.Point(89, 38);
            this.cbbType1.Name = "cbbType1";
            this.cbbType1.Size = new System.Drawing.Size(121, 21);
            this.cbbType1.TabIndex = 8;
            // 
            // cbbType2
            // 
            this.cbbType2.FormattingEnabled = true;
            this.cbbType2.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType2.Location = new System.Drawing.Point(89, 65);
            this.cbbType2.Name = "cbbType2";
            this.cbbType2.Size = new System.Drawing.Size(121, 21);
            this.cbbType2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Propriedade 2";
            // 
            // cbbType4
            // 
            this.cbbType4.FormattingEnabled = true;
            this.cbbType4.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType4.Location = new System.Drawing.Point(89, 117);
            this.cbbType4.Name = "cbbType4";
            this.cbbType4.Size = new System.Drawing.Size(121, 21);
            this.cbbType4.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(216, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Propriedade 4";
            // 
            // cbbType3
            // 
            this.cbbType3.FormattingEnabled = true;
            this.cbbType3.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType3.Location = new System.Drawing.Point(89, 90);
            this.cbbType3.Name = "cbbType3";
            this.cbbType3.Size = new System.Drawing.Size(121, 21);
            this.cbbType3.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Propriedade 3";
            // 
            // cbbType6
            // 
            this.cbbType6.FormattingEnabled = true;
            this.cbbType6.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType6.Location = new System.Drawing.Point(89, 173);
            this.cbbType6.Name = "cbbType6";
            this.cbbType6.Size = new System.Drawing.Size(121, 21);
            this.cbbType6.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(216, 173);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 20);
            this.textBox6.TabIndex = 22;
            // 
            // cbbType5
            // 
            this.cbbType5.FormattingEnabled = true;
            this.cbbType5.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType5.Location = new System.Drawing.Point(89, 146);
            this.cbbType5.Name = "cbbType5";
            this.cbbType5.Size = new System.Drawing.Size(121, 21);
            this.cbbType5.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(216, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Propriedade 5";
            // 
            // cbbType8
            // 
            this.cbbType8.FormattingEnabled = true;
            this.cbbType8.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType8.Location = new System.Drawing.Point(89, 226);
            this.cbbType8.Name = "cbbType8";
            this.cbbType8.Size = new System.Drawing.Size(121, 21);
            this.cbbType8.TabIndex = 29;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(216, 226);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(149, 20);
            this.textBox8.TabIndex = 28;           
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Propriedade 8";
            // 
            // cbbType7
            // 
            this.cbbType7.FormattingEnabled = true;
            this.cbbType7.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType7.Location = new System.Drawing.Point(89, 199);
            this.cbbType7.Name = "cbbType7";
            this.cbbType7.Size = new System.Drawing.Size(121, 21);
            this.cbbType7.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(216, 199);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(149, 20);
            this.textBox7.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Propriedade 7";
            // 
            // cbbType10
            // 
            this.cbbType10.FormattingEnabled = true;
            this.cbbType10.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType10.Location = new System.Drawing.Point(89, 278);
            this.cbbType10.Name = "cbbType10";
            this.cbbType10.Size = new System.Drawing.Size(121, 21);
            this.cbbType10.TabIndex = 35;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(216, 278);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(149, 20);
            this.textBox10.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Propriedade 10";
            // 
            // cbbType9
            // 
            this.cbbType9.FormattingEnabled = true;
            this.cbbType9.Items.AddRange(new object[] {
            "int",
            "float",
            "string",
            "DateTime",
            "bool"});
            this.cbbType9.Location = new System.Drawing.Point(89, 252);
            this.cbbType9.Name = "cbbType9";
            this.cbbType9.Size = new System.Drawing.Size(121, 21);
            this.cbbType9.TabIndex = 32;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(216, 252);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(149, 20);
            this.textBox9.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(14, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "Propriedade 9";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(371, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "List";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(371, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 17);
            this.checkBox2.TabIndex = 38;
            this.checkBox2.Text = "List";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(371, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 17);
            this.checkBox3.TabIndex = 39;
            this.checkBox3.Text = "List";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(371, 117);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 17);
            this.checkBox4.TabIndex = 40;
            this.checkBox4.Text = "List";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(371, 148);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(42, 17);
            this.checkBox5.TabIndex = 41;
            this.checkBox5.Text = "List";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Propriedade 6";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(371, 176);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(42, 17);
            this.checkBox6.TabIndex = 42;
            this.checkBox6.Text = "List";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(371, 201);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(42, 17);
            this.checkBox7.TabIndex = 43;
            this.checkBox7.Text = "List";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(371, 228);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(42, 17);
            this.checkBox8.TabIndex = 44;
            this.checkBox8.Text = "List";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(371, 255);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(42, 17);
            this.checkBox9.TabIndex = 45;
            this.checkBox9.Text = "List";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(371, 282);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(42, 17);
            this.checkBox10.TabIndex = 46;
            this.checkBox10.Text = "List";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // chkIdentity
            // 
            this.chkIdentity.AutoSize = true;
            this.chkIdentity.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkIdentity.Checked = true;
            this.chkIdentity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdentity.Location = new System.Drawing.Point(337, 15);
            this.chkIdentity.Name = "chkIdentity";
            this.chkIdentity.Size = new System.Drawing.Size(76, 17);
            this.chkIdentity.TabIndex = 47;
            this.chkIdentity.Text = "Identidade";
            this.chkIdentity.UseVisualStyleBackColor = true;
            // 
            // chkDAL
            // 
            this.chkDAL.AutoSize = true;
            this.chkDAL.Checked = true;
            this.chkDAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDAL.Location = new System.Drawing.Point(21, 319);
            this.chkDAL.Name = "chkDAL";
            this.chkDAL.Size = new System.Drawing.Size(47, 17);
            this.chkDAL.TabIndex = 48;
            this.chkDAL.Text = "DAL";
            this.chkDAL.UseVisualStyleBackColor = true;
            // 
            // chkBLL
            // 
            this.chkBLL.AutoSize = true;
            this.chkBLL.Checked = true;
            this.chkBLL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBLL.Location = new System.Drawing.Point(74, 319);
            this.chkBLL.Name = "chkBLL";
            this.chkBLL.Size = new System.Drawing.Size(45, 17);
            this.chkBLL.TabIndex = 49;
            this.chkBLL.Text = "BLL";
            this.chkBLL.UseVisualStyleBackColor = true;
            // 
            // chkAPI
            // 
            this.chkAPI.AutoSize = true;
            this.chkAPI.Checked = true;
            this.chkAPI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAPI.Location = new System.Drawing.Point(125, 319);
            this.chkAPI.Name = "chkAPI";
            this.chkAPI.Size = new System.Drawing.Size(43, 17);
            this.chkAPI.TabIndex = 50;
            this.chkAPI.Text = "API";
            this.chkAPI.UseVisualStyleBackColor = true;
            // 
            // chkMVC
            // 
            this.chkMVC.AutoSize = true;
            this.chkMVC.Checked = true;
            this.chkMVC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMVC.Location = new System.Drawing.Point(176, 319);
            this.chkMVC.Name = "chkMVC";
            this.chkMVC.Size = new System.Drawing.Size(49, 17);
            this.chkMVC.TabIndex = 51;
            this.chkMVC.Text = "MVC";
            this.chkMVC.UseVisualStyleBackColor = true;
            // 
            // chkTable
            // 
            this.chkTable.AutoSize = true;
            this.chkTable.Checked = true;
            this.chkTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTable.Location = new System.Drawing.Point(227, 319);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(53, 17);
            this.chkTable.TabIndex = 52;
            this.chkTable.Text = "Table";
            this.chkTable.UseVisualStyleBackColor = true;
            // 
            // chkProc
            // 
            this.chkProc.AutoSize = true;
            this.chkProc.Checked = true;
            this.chkProc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProc.Location = new System.Drawing.Point(286, 319);
            this.chkProc.Name = "chkProc";
            this.chkProc.Size = new System.Drawing.Size(80, 17);
            this.chkProc.TabIndex = 53;
            this.chkProc.Text = "Procedures";
            this.chkProc.UseVisualStyleBackColor = true;
            // 
            // CodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 396);
            this.Controls.Add(this.chkProc);
            this.Controls.Add(this.chkTable);
            this.Controls.Add(this.chkMVC);
            this.Controls.Add(this.chkAPI);
            this.Controls.Add(this.chkBLL);
            this.Controls.Add(this.chkDAL);
            this.Controls.Add(this.chkIdentity);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbbType10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbbType9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbType8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbType7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbType6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbType5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbType4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbType3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbType2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbType1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbType1;
        private System.Windows.Forms.ComboBox cbbType2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbType4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbType3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbType6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cbbType5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbType8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbType7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbType10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbType9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox chkIdentity;
        private System.Windows.Forms.CheckBox chkDAL;
        private System.Windows.Forms.CheckBox chkBLL;
        private System.Windows.Forms.CheckBox chkAPI;
        private System.Windows.Forms.CheckBox chkMVC;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.CheckBox chkProc;
    }
}

