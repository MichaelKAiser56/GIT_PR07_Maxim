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

            this.pictureBox1.Image = Properties.Resources.logo;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
