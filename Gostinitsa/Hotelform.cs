using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gostinitsa
{
    public partial class Hotelform : Form
    {
        public Hotelform(string hotelname)
        {
            InitializeComponent();

            Text = "Гостиница \"" + hotelname + "\"";
            Hotellabel.Text = hotelname;
            HotelpictureBox.Load("../../Pictures/" + hotelname + ".jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void HotelpictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
