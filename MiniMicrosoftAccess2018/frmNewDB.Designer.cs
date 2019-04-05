namespace MiniMicrosoftAccess2018
{
    partial class frmNewDB
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
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSavedPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPK = new System.Windows.Forms.Button();
            this.lvFieldList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter table name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(21, 41);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(266, 24);
            this.txtTableName.TabIndex = 1;
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Location = new System.Drawing.Point(18, 97);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(130, 18);
            this.lblFieldType.TabIndex = 2;
            this.lblFieldType.Text = "Enter field name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose type of the field.";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(21, 118);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(200, 24);
            this.txtFieldName.TabIndex = 6;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "AutoNumber",
            "Text",
            "Number",
            "Currency",
            "Date/Time"});
            this.cboType.Location = new System.Drawing.Point(21, 53);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(141, 26);
            this.cboType.TabIndex = 7;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(203, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Field";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateTable);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateTable.Location = new System.Drawing.Point(148, 78);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(161, 37);
            this.btnCreateTable.TabIndex = 2;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFieldType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFieldName);
            this.groupBox2.Controls.Add(this.cboType);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(15, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 201);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saved Path";
            // 
            // txtSavedPath
            // 
            this.txtSavedPath.Location = new System.Drawing.Point(15, 47);
            this.txtSavedPath.Name = "txtSavedPath";
            this.txtSavedPath.ReadOnly = true;
            this.txtSavedPath.Size = new System.Drawing.Size(300, 24);
            this.txtSavedPath.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(15, 111);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(300, 24);
            this.txtFileName.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPK);
            this.groupBox3.Controls.Add(this.lvFieldList);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(336, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 453);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Field List (Select field that you want as Primary Key)";
            // 
            // btnAddPK
            // 
            this.btnAddPK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPK.Location = new System.Drawing.Point(182, 400);
            this.btnAddPK.Name = "btnAddPK";
            this.btnAddPK.Size = new System.Drawing.Size(173, 37);
            this.btnAddPK.TabIndex = 11;
            this.btnAddPK.Text = "Add Primary Key";
            this.btnAddPK.UseVisualStyleBackColor = true;
            this.btnAddPK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvFieldList
            // 
            this.lvFieldList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFieldList.FullRowSelect = true;
            this.lvFieldList.GridLines = true;
            this.lvFieldList.Location = new System.Drawing.Point(6, 43);
            this.lvFieldList.Name = "lvFieldList";
            this.lvFieldList.Size = new System.Drawing.Size(349, 351);
            this.lvFieldList.TabIndex = 10;
            this.lvFieldList.UseCompatibleStateImageBehavior = false;
            this.lvFieldList.View = System.Windows.Forms.View.Details;
            this.lvFieldList.SelectedIndexChanged += new System.EventHandler(this.lvFieldList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Field Name";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 160;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveTable.Location = new System.Drawing.Point(396, 506);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(189, 37);
            this.btnSaveTable.TabIndex = 17;
            this.btnSaveTable.Text = "Save Current Table";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(591, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewTable.Location = new System.Drawing.Point(248, 506);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(142, 37);
            this.btnNewTable.TabIndex = 19;
            this.btnNewTable.Text = "New Table";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // frmNewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 567);
            this.Controls.Add(this.btnNewTable);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSavedPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmNewDB";
            this.Text = "Create New Database";
            this.Load += new System.EventHandler(this.frmNewDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblFieldType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSavedPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvFieldList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnAddPK;
    }
}