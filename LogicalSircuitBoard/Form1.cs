using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalSircuitBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        bool color = false;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbAnd_Click(object sender, EventArgs e)
        {

        }

        
        
        private void pbAnd_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }*/

            //pnlWorking.Controls.Add(pbAnd);
            //pbAndPlus = pbAnd;
            //pnlWorking.Controls.Add(pbAndPlus);

            //selected = true;
        }

        private void pbAnd_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (selected)
            {
                PictureBox pbAndPlus = new PictureBox();
                pbAndPlus = pbAnd;
                pnlWorking.Controls.Add(pbAndPlus);

                pbAndPlus.Location = e.Location;
            }*/

            /*if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pbAnd.Left = e.X + pbAnd.Left - MouseDownLocation.X;
                pbAnd.Top = e.Y + pbAnd.Top - MouseDownLocation.Y;
            }*/
        }

        private void pbAnd_MouseUp(object sender, MouseEventArgs e)
        {
            /*pnlWorking.Controls.Add(pbAndPlus);
            pbAndPlus.Location = MouseDownLocation;
            selected = false;*/
        }

        private void rbAnd_CheckedChanged(object sender, EventArgs e)
        {
            selected = true;
        }

        private void pnlWorking_MouseClick(object sender, MouseEventArgs e)
        {
            /*PictureBox pbAndPlus = new PictureBox();
           
            pbAndPlus.Size = pbAnd.Size;
            pbAndPlus.BackgroundImage = pbAnd.BackgroundImage;
            pbAndPlus.BackgroundImageLayout = pbAnd.BackgroundImageLayout;
            pbAndPlus.Location = MouseDownLocation;

            pnlWorking.Controls.Add(pbAndPlus);*/

        }

        private void pnlWorking_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        int a = 1;
        //PictureBox[] pbAndPlus = new PictureBox[10];
        private void pnlWorking_MouseUp(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                PictureBox[] pbAndPlus = new PictureBox[a + 1];
                pbAndPlus[a] = new PictureBox();
                pbAndPlus[a].Size = pbAnd.Size;
                pbAndPlus[a].BackgroundImage = pbAnd.BackgroundImage;
                pbAndPlus[a].BackgroundImageLayout = pbAnd.BackgroundImageLayout;
                pbAndPlus[a].Location = MouseDownLocation;

                pnlWorking.Controls.Add(pbAndPlus[a]);
                a++;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (delete)
            {
                for(int i = 0; i<=a+1; i++)
                {

                }
            }
            if (selected)
            {
                //btnEnable.Enabled = true;
            }
            else
            {
                //rbAnd.Checked = false;
            }
        }

        bool delete = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            timer1.Start();
            delete = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selected = !selected;
            if (selected)
            {
                //btnEnable.Text = "Done";
               // rbAnd.Checked = true ;
            }
            else
            {
                //btnEnable.Text = "Enable";
                //rbAnd.Checked = false;
            }
                

            
           
        }
        bool selected;
        private Point MouseDownLocation;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            selected = false;
        
    }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlWorking.Invalidate();
            pnlWorking.Refresh();
        }

        private void gbWorkingPanel_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            color = !color;
            if (color)
                button4.BackColor = Color.LightGray;
            else
                button4.BackColor = Color.Green;
        }
    }
}
