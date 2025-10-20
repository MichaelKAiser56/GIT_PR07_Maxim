using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpov_PR07_GIT
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            label1.Text = "";
            timer1.Interval = 1000;
           

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Karpov Maksim Vladimirovich", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button2.Text = "Показать время";

            }
            else
            {
                label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                timer1.Start();
                button2.Text = "Остановить";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

    }
}
