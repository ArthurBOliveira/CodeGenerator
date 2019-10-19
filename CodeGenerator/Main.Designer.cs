namespace CodeGenerator
{
    partial class Main
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.chkListModels = new System.Windows.Forms.CheckedListBox();
            this.lblModels = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.chkAPI = new System.Windows.Forms.CheckBox();
            this.chkDAL = new System.Windows.Forms.CheckBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtViewModel = new System.Windows.Forms.RichTextBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.chkService = new System.Windows.Forms.CheckBox();
            this.chkRelation = new System.Windows.Forms.CheckBox();
            this.chkTsModel = new System.Windows.Forms.CheckBox();
            this.chkTsStore = new System.Windows.Forms.CheckBox();
            this.chkTsService = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(12, 21);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(171, 25);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "lblProjectName";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(556, 574);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(166, 48);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Criar Projeto";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditName.Location = new System.Drawing.Point(557, 12);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(166, 46);
            this.btnEditName.TabIndex = 3;
            this.btnEditName.Text = "Escolha um Nome";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // chkListModels
            // 
            this.chkListModels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkListModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListModels.FormattingEnabled = true;
            this.chkListModels.Location = new System.Drawing.Point(17, 100);
            this.chkListModels.Name = "chkListModels";
            this.chkListModels.Size = new System.Drawing.Size(350, 466);
            this.chkListModels.TabIndex = 4;
            this.chkListModels.SelectedIndexChanged += new System.EventHandler(this.chkListModels_SelectedIndexChanged);
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModels.Location = new System.Drawing.Point(13, 73);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(83, 24);
            this.lblModels.TabIndex = 5;
            this.lblModels.Text = "Modelos";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(17, 574);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(179, 574);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Ver";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(98, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkTable
            // 
            this.chkTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTable.AutoSize = true;
            this.chkTable.Checked = true;
            this.chkTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTable.Location = new System.Drawing.Point(372, 577);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(53, 17);
            this.chkTable.TabIndex = 58;
            this.chkTable.Text = "Table";
            this.chkTable.UseVisualStyleBackColor = true;
            // 
            // chkAPI
            // 
            this.chkAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAPI.AutoSize = true;
            this.chkAPI.Checked = true;
            this.chkAPI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAPI.Location = new System.Drawing.Point(323, 577);
            this.chkAPI.Name = "chkAPI";
            this.chkAPI.Size = new System.Drawing.Size(43, 17);
            this.chkAPI.TabIndex = 56;
            this.chkAPI.Text = "API";
            this.chkAPI.UseVisualStyleBackColor = true;
            // 
            // chkDAL
            // 
            this.chkDAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDAL.AutoSize = true;
            this.chkDAL.Checked = true;
            this.chkDAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDAL.Location = new System.Drawing.Point(270, 577);
            this.chkDAL.Name = "chkDAL";
            this.chkDAL.Size = new System.Drawing.Size(47, 17);
            this.chkDAL.TabIndex = 54;
            this.chkDAL.Text = "DAL";
            this.chkDAL.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Location = new System.Drawing.Point(557, 64);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(166, 30);
            this.btnRead.TabIndex = 59;
            this.btnRead.Text = "Ler Arquivos";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtViewModel
            // 
            this.txtViewModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewModel.Location = new System.Drawing.Point(372, 100);
            this.txtViewModel.Name = "txtViewModel";
            this.txtViewModel.ReadOnly = true;
            this.txtViewModel.Size = new System.Drawing.Size(350, 466);
            this.txtViewModel.TabIndex = 60;
            this.txtViewModel.Text = "";
            // 
            // chkModel
            // 
            this.chkModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkModel.AutoSize = true;
            this.chkModel.Enabled = false;
            this.chkModel.Location = new System.Drawing.Point(495, 577);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(55, 17);
            this.chkModel.TabIndex = 61;
            this.chkModel.Text = "Model";
            this.chkModel.UseVisualStyleBackColor = true;
            // 
            // lblRows
            // 
            this.lblRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(306, 79);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(0, 16);
            this.lblRows.TabIndex = 62;
            // 
            // chkService
            // 
            this.chkService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkService.AutoSize = true;
            this.chkService.Checked = true;
            this.chkService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkService.Location = new System.Drawing.Point(431, 577);
            this.chkService.Name = "chkService";
            this.chkService.Size = new System.Drawing.Size(62, 17);
            this.chkService.TabIndex = 63;
            this.chkService.Text = "Service";
            this.chkService.UseVisualStyleBackColor = true;
            this.chkService.CheckedChanged += new System.EventHandler(this.chkTeste_CheckedChanged);
            // 
            // chkRelation
            // 
            this.chkRelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRelation.AutoSize = true;
            this.chkRelation.Location = new System.Drawing.Point(17, 605);
            this.chkRelation.Name = "chkRelation";
            this.chkRelation.Size = new System.Drawing.Size(103, 17);
            this.chkRelation.TabIndex = 64;
            this.chkRelation.Text = "Relacionamento";
            this.chkRelation.UseVisualStyleBackColor = true;
            this.chkRelation.CheckedChanged += new System.EventHandler(this.chkRelation_CheckedChanged);
            // 
            // chkTsModel
            // 
            this.chkTsModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTsModel.AutoSize = true;
            this.chkTsModel.Checked = true;
            this.chkTsModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTsModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkTsModel.Location = new System.Drawing.Point(270, 605);
            this.chkTsModel.Name = "chkTsModel";
            this.chkTsModel.Size = new System.Drawing.Size(72, 17);
            this.chkTsModel.TabIndex = 65;
            this.chkTsModel.Text = "TS Model";
            this.chkTsModel.UseVisualStyleBackColor = true;
            // 
            // chkTsStore
            // 
            this.chkTsStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTsStore.AutoSize = true;
            this.chkTsStore.Enabled = false;
            this.chkTsStore.Location = new System.Drawing.Point(347, 605);
            this.chkTsStore.Name = "chkTsStore";
            this.chkTsStore.Size = new System.Drawing.Size(68, 17);
            this.chkTsStore.TabIndex = 66;
            this.chkTsStore.Text = "TS Store";
            this.chkTsStore.UseVisualStyleBackColor = true;
            // 
            // chkTsService
            // 
            this.chkTsService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTsService.AutoSize = true;
            this.chkTsService.Enabled = false;
            this.chkTsService.Location = new System.Drawing.Point(418, 605);
            this.chkTsService.Name = "chkTsService";
            this.chkTsService.Size = new System.Drawing.Size(79, 17);
            this.chkTsService.TabIndex = 67;
            this.chkTsService.Text = "TS Service";
            this.chkTsService.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 629);
            this.Controls.Add(this.chkTsService);
            this.Controls.Add(this.chkTsStore);
            this.Controls.Add(this.chkTsModel);
            this.Controls.Add(this.chkRelation);
            this.Controls.Add(this.chkService);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.chkModel);
            this.Controls.Add(this.txtViewModel);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.chkTable);
            this.Controls.Add(this.chkAPI);
            this.Controls.Add(this.chkDAL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.chkListModels);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.CheckedListBox chkListModels;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.CheckBox chkAPI;
        private System.Windows.Forms.CheckBox chkDAL;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox txtViewModel;
        private System.Windows.Forms.CheckBox chkModel;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.CheckBox chkService;
        private System.Windows.Forms.CheckBox chkRelation;
        private System.Windows.Forms.CheckBox chkTsModel;
        private System.Windows.Forms.CheckBox chkTsStore;
        private System.Windows.Forms.CheckBox chkTsService;
    }
}