using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopRite_IMS
{
    public partial class SplashScrn : Form
    {
        public SplashScrn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void SplashScrn_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }
        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgress.Value = startpoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                LoginScrn log = new LoginScrn();
                this.Hide();
                log.Show();


            }
        }

        private void MyProgress_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
