using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalSircuitBoard
{
    public partial class Source : UserControl
    {
        bool onoff;
        int valuenumber;
        SourceElement sourceelement;
        public Source()
        {
            InitializeComponent();
            onoff = false;
            sourceelement = new SourceElement();
        }

        private System.Drawing.Color colorinput;

        public void Calculate()
        {

        }

        private void Source_Click(object sender, EventArgs e)
        {
            onoff = !onoff;
            if (onoff)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.Gray;

            sourceelement.SetColorInput(this.BackColor);
            valuenumber = sourceelement.GetValue();
            value.Text = Convert.ToString(valuenumber); 

        }
        
        private void Source_Load(object sender, EventArgs e)
        {
            
        }
    }
}
