using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Start : Form
    {
        private void button1_Click(object sender, System.EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
            
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Close();
            this.Hide();

        }


        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
        private void Start_MouseClick(object sender, MouseEventArgs e)
        {
            //start hotspot
            if (e.X > 56 && e.X < 306 && e.Y > 88 && e.Y < 89)
            {
                MessageBox.Show("dsadsadsadas");

            }
            else if (e.X > 345 && e.X < 513 && e.Y > 151 && e.Y < 171)//reset hotspot
            {
                timer1.Stop();

            }
            else if (e.X > 347 && e.X < 511 && e.Y > 182 && e.Y < 198) //quit hotspot
            {
                timer1.Stop();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
