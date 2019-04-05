namespace MiniMicrosoftAccess2018
{
    partial class frmRelation
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.cboPrimaryTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboForeignTable = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPrimaryField = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboForeignField = new System.Windows.Forms.ComboBox();
            this.btnCreateRelation = new System.Windows.Forms.Button();
            this.lvRelation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRelName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(28, 46);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(510, 24);
            this.txtFilePath.TabIndex = 0;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(25, 25);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(74, 18);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "File Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(28, 106);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(216, 24);
            this.txtFileName.TabIndex = 3;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(25, 85);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(84, 18);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "File Name";
            // 
            // cboPrimaryTable
            // 
            this.cboPrimaryTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimaryTable.FormattingEnabled = true;
            this.cboPrimaryTable.Location = new System.Drawing.Point(20, 48);
            this.cboPrimaryTable.Name = "cboPrimaryTable";
            this.cboPrimaryTable.Size = new System.Drawing.Size(161, 26);
            this.cboPrimaryTable.TabIndex = 5;
            this.cboPrimaryTable.SelectedIndexChanged += new System.EventHandler(this.cboPrimaryTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Primary Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Foreign Table";
            // 
            // cboForeignTable
            // 
            this.cboForeignTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForeignTable.FormattingEnabled = true;
            this.cboForeignTable.Location = new System.Drawing.Point(22, 48);
            this.cboForeignTable.Name = "cboForeignTable";
            this.cboForeignTable.Size = new System.Drawing.Size(160, 26);
            this.cboForeignTable.TabIndex = 7;
            this.cboForeignTable.SelectedIndexChanged += new System.EventHandler(this.cboForeignTable_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboPrimaryField);
            this.groupBox1.Controls.Add(this.cboPrimaryTable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 193);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Field";
            // 
            // cboPrimaryField
            // 
            this.cboPrimaryField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimaryField.FormattingEnabled = true;
            this.cboPrimaryField.Location = new System.Drawing.Point(20, 120);
            this.cboPrimaryField.Name = "cboPrimaryField";
            this.cboPrimaryField.Size = new System.Drawing.Size(161, 26);
            this.cboPrimaryField.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboForeignField);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboForeignTable);
            this.groupBox2.Location = new System.Drawing.Point(331, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 193);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foreign Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Field";
            // 
            // cboForeignField
            // 
            this.cboForeignField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForeignField.FormattingEnabled = true;
            this.cboForeignField.Location = new System.Drawing.Point(22, 120);
            this.cboForeignField.Name = "cboForeignField";
            this.cboForeignField.Size = new System.Drawing.Size(161, 26);
            this.cboForeignField.TabIndex = 8;
            // 
            // btnCreateRelation
            // 
            this.btnCreateRelation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateRelation.Location = new System.Drawing.Point(28, 417);
            this.btnCreateRelation.Name = "btnCreateRelation";
            this.btnCreateRelation.Size = new System.Drawing.Size(600, 40);
            this.btnCreateRelation.TabIndex = 12;
            this.btnCreateRelation.Text = "Create Relation";
            this.btnCreateRelation.UseVisualStyleBackColor = true;
            this.btnCreateRelation.Click += new System.EventHandler(this.btnCreateRelation_Click);
            // 
            // lvRelation
            // 
            this.lvRelation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRelation.GridLines = true;
            this.lvRelation.Location = new System.Drawing.Point(634, 25);
            this.lvRelation.Name = "lvRelation";
            this.lvRelation.Size = new System.Drawing.Size(456, 432);
            this.lvRelation.TabIndex = 13;
            this.lvRelation.UseCompatibleStateImageBehavior = false;
            this.lvRelation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Relation Name";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Origin Field";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Foreign Field";
            this.columnHeader3.Width = 130;
            // 
            // txtRelName
            // 
            this.txtRelName.Location = new System.Drawing.Point(165, 180);
            this.txtRelName.Name = "txtRelName";
            this.txtRelName.Size = new System.Drawing.Size(255, 24);
            this.txtRelName.TabIndex = 14;
            this.txtRelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Relation Name : ";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(973, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 33);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 520);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRelName);
            this.Controls.Add(this.lvRelation);
            this.Controls.Add(this.btnCreateRelation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmRelation";
            this.Text = "Create Relation";
            this.Load += new System.EventHandler(this.frmRelation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox cboPrimaryTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboForeignTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateRelation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPrimaryField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboForeignField;
        private System.Windows.Forms.ListView lvRelation;
        private System.Windows.Forms.TextBox txtRelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}