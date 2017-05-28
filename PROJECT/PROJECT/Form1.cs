using PROJECT.Properties;
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

    public partial class Form1 : Form
    {


        //CSign _sign;
        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(Resources.emesprani172);
            this.Cursor = CustomCursor.CreateCursor(b, 17, 2);
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);

            //  _sign = new CSign() { Left = 340, Top = 10 }; //ovde gi inicjilaiziravme 

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("FINISH!");
            Start frm = new Start();
            frm.Show();
            this.Hide();
            Close();
        }
        /* private void MoveToStart()
         {
             Point startingPoint = panel1.Location;
             startingPoint.Offset(10, 10);
             Cursor.Position = PointToScreen(startingPoint);
         }
         */
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }
        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            //MoveToStart();
        }
        int lives = 10;
        private void zid_MouseEnter(object sender, EventArgs e)
        {
            lives--;
            this.Refresh();
            if (lives == 0)
            {
                MessageBox.Show("GAME OVER!");
                Start frm = new Start();
                frm.Show();
                this.Hide();
            }
            MoveToStart();
           
        }

        int flag = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                label29.Enabled = true;
                label29.Visible = true;
                label33.Enabled = true;
                label33.Visible = true;
                label32.Enabled = true;
                label32.Visible = true;
                label31.Enabled = true;
                label31.Visible = true;
                label40.Enabled = true;
                label40.Visible = true;
                flag = 1;

            }
            else
            {
                label29.Enabled = false;
                label29.Visible = false;
                label33.Enabled = false;
                label33.Visible = false;
                label32.Enabled = false;
                label32.Visible = false;
                label31.Enabled = false;
                label31.Visible = false;
                label40.Enabled = false;
                label40.Visible = false;
                flag = 0;
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        int fruits = 0;
        private void label36_MouseEnter(object sender, EventArgs e)
        {
            fruits++;
            label36.Visible = false;
            this.Refresh();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

            TextFormatFlags flags = TextFormatFlags.Left;
            Font _font = new System.Drawing.Font("Stencil", 20, FontStyle.Bold);
            TextRenderer.DrawText(e.Graphics, "FRUITS 🍎: " + fruits.ToString(), _font, new Rectangle(678, 275, 200, 70), SystemColors.ControlText, flags);
            TextRenderer.DrawText(e.Graphics, "LIVES ❤️: " + lives.ToString(), _font, new Rectangle(678, 318, 200, 70), SystemColors.ControlText, flags);
            TextRenderer.DrawText(e.Graphics, "TIME LEFT ⏲️: " + timer2.ToString(), _font, new Rectangle(642, 12, 200, 70), SystemColors.ControlText, flags);

            base.OnPaint(e);
            // _sign.DrawImage(dc);
        }

      /*  private void label37_MouseEnter(object sender, EventArgs e)
        {
            fruits++;
            label37.Visible = false;
            this.Refresh();
        }
        */
        private void label38_MouseEnter(object sender, EventArgs e)
        {
            fruits++;
            label38.Visible = false;
            this.Refresh();
        }
        private void label39_MouseEnter(object sender, EventArgs e)
        {
            fruits++;
            label39.Visible = false;
            this.Refresh();
        }
        private void label41_MouseEnter(object sender, EventArgs e)
        {
            fruits++;
            label41.Visible = false;
            this.Refresh();
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            Start frm = new Start();
            frm.Show();
            this.Hide();
            this.Close();
        }
    }
}
