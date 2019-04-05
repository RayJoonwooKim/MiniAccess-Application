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
using System.Threading;
namespace MiniMicrosoftAccess2018
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Thread thr = new Thread(new ThreadStart(SplashScreen));
            thr.Start();
            Thread.Sleep(5000);
            thr.Abort();

        }
        public void SplashScreen()
        {
            Application.Run(new frmSplash());
        }

        private void createNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetPath fsp = new frmSetPath();
            fsp.MdiParent = this;
            fsp.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelation rel = new frmRelation();
            rel.MdiParent = this;
            rel.Show();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?","EXIT",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuDeveloper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student ID : 1632635 " + "\n" + "Developer : Joonwoo Kim" + "\n" + "Course Number : 420-P46-AS" + "\n" + "Course Name : Event Programming","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void mnuObjective_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The objective of the project is to create an user-friendly Windows Form Application that enables users to : " + "\n\n" + "1. Create tables" + "\n" +"2. Add fields (index, property, data type)" + "\n" + "3. Create relation" + "\n\nbased on Microsoft Database Access.","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
