using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Randomform : Form
    {
        public Randomform()
        {
            InitializeComponent();
            string messagetitle = " Form Msg";
            string messagetext = "You've opened Form Random";
            MessageBox.Show(messagetext,messagetitle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messagetitle = "Rand Button";
            string messagetext = "You've clicked Random Button";
            MessageBox.Show(messagetext,messagetitle);
            string messagetitle1 = "Close Window";
            string message = "Do you want to close the window?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;           
            DialogResult result = MessageBox.Show(message, messagetitle1, buttons);
            if(result==DialogResult.Yes)
            {
                this.Close();
            }
            else if(result==DialogResult.No)
            {
                // nothing happens
            }


        }
    }
}
