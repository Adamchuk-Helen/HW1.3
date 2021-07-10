using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1._3
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static int r = 0;
        static int g = 0;
        private void button_red_Click(object sender, EventArgs e)
        {
            
            if (sender == button_red)
            {
                r++;
            }
            else if (sender == button_green)
            {
                g++;
            }

            label1.Text = "Red button was clicked "+ r + " times. \nGreen button was clicked " + g + " times.";
        }


    }


        
    
}
