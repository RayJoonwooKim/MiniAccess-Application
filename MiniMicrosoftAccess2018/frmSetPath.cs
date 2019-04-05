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
    public partial class frmSetPath : Form
    {
        public frmSetPath()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select path to save your file";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPath.Text=="")
            {
                MessageBox.Show("You have to choose the path to save your file!","Path Undefined",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (txtFileName.Text==".accdb")
            {
                MessageBox.Show("You have to enter file name to continue!", "File Name Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            
                frmNewDB fnd = new frmNewDB(txtPath.Text, txtFileName.Text);
                fnd.Show();
                txtFileName.ReadOnly = true;
            }
            
        }

        private void frmSetPath_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            txtFileName.Text = ".accdb";
            txtPath.Clear();
            txtFileName.ReadOnly = false;
        }
    }
}
