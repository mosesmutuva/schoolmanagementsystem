using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userRegistrationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Ur = new Form2();
            Ur.Show();
        }

        private void userGrantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usergrant ug = new usergrant();
            ug.Show();
        }

        private void schoolEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schoolentry se = new schoolentry();
            se.Show();
        }

        private void classEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classentry ce = new classentry();
            ce.Show();
        }
    }
}
