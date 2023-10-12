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
    public partial class RoomForm : Form
    {
        public RoomForm(string IDROOM)
        {
            InitializeComponent();
            List<string> room = MainForm.myselect("Select  name, adress_pic, ID_HOTEL FROM room WHERE ID_HOTEL = " + IDROOM);
            List<string> hotel = MainForm.myselect("Select  name FROM hotel WHERE ID_HOTEL = " + room[2]);

            Text = hotel[0] + ": " + room[0];
            Roomlabel.Text = hotel[0] + ": " + room[0];
            RoompictureBox.Load("../../Pictures/" + room[1]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
