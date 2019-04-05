using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.IO;

namespace MiniMicrosoftAccess2018
{
    public partial class frmNewDB : Form
    {
        public frmNewDB(string val1, string val2)
        {
            InitializeComponent();
            txtSavedPath.Text = val1;
            txtFileName.Text = val2;
            ButtonControl(true, false, false, false, false);
            

        }
        void ListViewField(ListView lv, string field, string type)
        {
            ListViewItem item = new ListViewItem(field);
            item.SubItems.Add(type);
            lv.Items.Add(item);
        }
        
        void ButtonControl(bool table, bool new_table, bool add, bool pk, bool save)
        {
            btnCreateTable.Enabled = table;
            btnAdd.Enabled = add;
            btnAddPK.Enabled = pk;
            btnSaveTable.Enabled = save;
            btnNewTable.Enabled = new_table;
            
        }
        void ClearAll(TextBox txt1, ComboBox cbo2)
        {
            txt1.Clear();
            cbo2.SelectedIndex = -1;
        }
        
        DBEngine dbe = new DBEngine();
        Database myDB;
        TableDef myTB;
        Field myFL;
        Index myInd;
        
        bool isPK = false;
        private void frmNewDB_Load(object sender, EventArgs e)
        {
            myDB = dbe.CreateDatabase(txtSavedPath.Text + "\\" + txtFileName.Text, DAO.LanguageConstants.dbLangGeneral);
            
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text=="")
            {
                MessageBox.Show("You must enter table name to proceed!","Table Name ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            myTB = myDB.CreateTableDef(txtTableName.Text);
            MessageBox.Show("Table created successfully!","Create Table",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtTableName.ReadOnly = true;
            ButtonControl(false, false, true, false, false);
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "")
            {
                MessageBox.Show("You must choose field type!", "Field ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtFieldName.Text == "")
            {
                MessageBox.Show("You must enter field name!", "Field ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (cboType.SelectedIndex)
            {
                case 0: //AutoNumber
                    
                    myFL = myTB.CreateField(txtFieldName.Text, DAO.DataTypeEnum.dbLong);
                    myFL.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                    myTB.Fields.Append(myFL);
                    ListViewField(lvFieldList, txtFieldName.Text, cboType.Text);
                    ClearAll(txtFieldName, cboType);
                    MessageBox.Show("Field added successfully!","Add Field",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    ButtonControl(false, false, true, false, true);

                    break;
                case 1: //Text
                    
                    myFL = myTB.CreateField(txtFieldName.Text, DAO.DataTypeEnum.dbText, 100);
                    myTB.Fields.Append(myFL);
                    ListViewField(lvFieldList, txtFieldName.Text, cboType.Text);
                    ClearAll(txtFieldName, cboType);
                    MessageBox.Show("Field added successfully!", "Add Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ButtonControl(false, false, true, false, true);

                    break;
                case 2: //Number
                    
                    myFL = myTB.CreateField(txtFieldName.Text, DAO.DataTypeEnum.dbLong); 
                    myTB.Fields.Append(myFL);
                    ListViewField(lvFieldList, txtFieldName.Text, cboType.Text);
                    ClearAll(txtFieldName, cboType);
                    MessageBox.Show("Field added successfully!", "Add Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ButtonControl(false, false, true, false, true);
                    
                    break;
                case 3: //Currency
                    
                    myFL = myTB.CreateField(txtFieldName.Text, DAO.DataTypeEnum.dbCurrency);
                    myTB.Fields.Append(myFL);
                    ListViewField(lvFieldList, txtFieldName.Text, cboType.Text);
                    ClearAll(txtFieldName, cboType);
                    MessageBox.Show("Field added successfully!", "Add Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ButtonControl(false, false, true, false, true);

                    break;
                case 4: //DateTime
                    
                    myFL = myTB.CreateField(txtFieldName.Text, DAO.DataTypeEnum.dbDate);
                    myTB.Fields.Append(myFL);
                    ListViewField(lvFieldList, txtFieldName.Text, cboType.Text);
                    ClearAll(txtFieldName, cboType);
                    MessageBox.Show("Field added successfully!", "Add Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ButtonControl(false, false, true, false, true);

                    break;
                
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            if (!isPK)
            {
                MessageBox.Show("You have to add primary key first!","Save ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            myDB.TableDefs.Append(myTB);
            MessageBox.Show("Table Saved successfully!", "Save Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSaveTable.Enabled = false;
            btnAdd.Enabled = false;
            btnNewTable.Enabled = true;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you really want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                myDB.Close();
                this.Close();
            }
            
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to create a new table?","New Table",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                
                txtTableName.Clear();
                ClearAll(txtFieldName, cboType);
                btnCreateTable.Enabled = true;
                txtTableName.ReadOnly = false;
                lvFieldList.Items.Clear();

                isPK = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            myInd = myTB.CreateIndex("PrimaryKey");
            myFL = myInd.CreateField(lvFieldList.SelectedItems[0].SubItems[0].Text);
            ((IndexFields)(myInd.Fields)).Append(myFL);
            myInd.Primary = true;
            myTB.Indexes.Append(myInd);
            MessageBox.Show("Primary key added successfully!", "Add PK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvFieldList.SelectedItems[0].SubItems[0].ForeColor = Color.Red;
            ButtonControl(false, false, true, false, true);

            isPK = true;
        }

        private void lvFieldList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPK.Enabled = true;
        }
    }
}
