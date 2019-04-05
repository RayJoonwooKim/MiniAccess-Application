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
namespace MiniMicrosoftAccess2018
{
    public partial class frmRelation : Form
    {
        public frmRelation()
        {
            InitializeComponent();
        }
        DBEngine dbe = new DBEngine();
        Database myDB;
        Field myFL;

        private void frmRelation_Load(object sender, EventArgs e)
        {
            
           
        }
        private void ClearAll()
        {
            txtRelName.Clear();
            cboForeignField.SelectedIndex = -1;
            cboForeignTable.SelectedIndex = -1;
            cboPrimaryField.SelectedIndex = -1;
            cboPrimaryTable.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Access Files|*.accdb|All Files|*.*";
            ofd.Title = "Open Database";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                myDB = dbe.OpenDatabase(txtFilePath.Text);
                for (int t = 0; t < myDB.TableDefs.Count; t++)
                {
                    if (myDB.TableDefs[t].Attributes == 0)
                    {
                        cboPrimaryTable.Items.Add(myDB.TableDefs[t].Name);
                        //cboForeignTable.Items.Add(myDB.TableDefs[t].Name);
                    }

                }

            } 
        }

        private void btnCreateRelation_Click(object sender, EventArgs e)
        {
            if (txtRelName.Text=="")
            {
                MessageBox.Show("Please enter relation name!","Relation Name ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cboPrimaryTable.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate origin table", "Origin Table ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboPrimaryField.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose appropriate origin field","Origin Field ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cboForeignTable.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate foreign table", "Foreign Table ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboForeignField.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate foreign field", "Foreign Field ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Relation myRel = myDB.CreateRelation(txtRelName.Text, cboPrimaryTable.Text, cboForeignTable.Text);
            myFL = myRel.CreateField(cboPrimaryField.Text);
            myFL.ForeignName = cboForeignField.Text;
            myRel.Fields.Append(myFL);
            myDB.Relations.Append(myRel);

            ListViewItem lvitem = new ListViewItem(txtRelName.Text);
            lvitem.SubItems.Add(cboPrimaryField.Text);
            lvitem.SubItems.Add(cboForeignField.Text);
            lvRelation.Items.Add(lvitem);

            MessageBox.Show("Relation created successfully!","Create Relation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearAll();
        }

        private void cboPrimaryTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboForeignTable.Items.Clear();
            cboPrimaryField.Items.Clear();
            for (int i = 0; i < myDB.TableDefs.Count; i++)
            {
                if (cboPrimaryTable.Text == myDB.TableDefs[i].Name)
                {
                    for (int f = 0; f < myDB.TableDefs[i].Fields.Count; f++)
                    {
                        cboPrimaryField.Items.Add(myDB.TableDefs[i].Fields[f].Name);
                    }
                }
                if (cboPrimaryTable.Text != myDB.TableDefs[i].Name && myDB.TableDefs[i].Attributes == 0)
                {
                    cboForeignTable.Items.Add(myDB.TableDefs[i].Name);
                }
            }
            
           
        }

        private void cboForeignTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboForeignField.Items.Clear();
            for (int i = 0; i < myDB.TableDefs.Count; i++)
            {
                if (cboForeignTable.Text == myDB.TableDefs[i].Name)
                {
                    for (int f = 0; f < myDB.TableDefs[i].Fields.Count; f++)
                    {
                        cboForeignField.Items.Add(myDB.TableDefs[i].Fields[f].Name);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                this.Close();
                myDB.Close();
            }
        }
    }
}
