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
        string _IDhotelname = "";
        public Hotelform(string IDhotelname)
        {
            _IDhotelname = IDhotelname;
            InitializeComponent();

            List<string> hotel = MainForm.myselect("SELECT name, adress_pic, rating, desc FROM hotel WHERE ID = " + _IDhotelname);
            List<string> room = MainForm.myselect("SELECT id, name, adress_pic FROM room WHERE ID_HOTEL = " + _IDhotelname);
            #region            
            Text = hotel[1];
            Hotellabel.Text = hotel[1];
            HotelpictureBox.Load("../../Pictures/" + hotel[1]);
            int ratinghotel = Convert.ToInt32(hotel[2]);
            HoteltextBox.Text = hotel[3];

            int x = 517;
            for(int i=0; i< ratinghotel; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Звезда.png");
                box.Location = new Point(x, 136);
                box.Size = new Size(75, 68);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                Hotelpanel.Controls.Add(box);

                x += 65;
            }
            #endregion
            
            #region комнаты
            int x1 = 40;
            for (int i = 0; i < room.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x1, 80);
                lbl.Size = new Size(260, 30);
                lbl.Font = new Font("Arial", 13);
                lbl.Text = room[i + 1];
                lbl.Click += new EventHandler(Room_Click);
                infopanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + room[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x1, 93);
                pb.Size = new Size(300, 194);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = room[i + 2];
                pb.Click += new EventHandler(Room_Click);
                infopanel.Controls.Add(pb);
                x += 320;
            }
            #endregion
            
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

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(pb.Tag.ToString());
            rf.ShowDialog();
        }

        private void Hotelform_Load(object sender, EventArgs e)
        {

        }
    
    }
}
