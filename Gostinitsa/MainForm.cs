using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gostinitsa
{
    public partial class MainForm : Form
    {
        //Функция Select-запроса
        public static List<string> myselect(string cmdText)
        {
            List<string> list = new List<string>();
            MySqlConnection con = new MySqlConnection(CONNECTION_STRING);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            DbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for(int i=0; i<reader.FieldCount; i++)
                {
                    list.Add(reader.GetString(i).ToString());
                }

            }
            reader.Close();
            con.Close();
            return list;

        }

        const string CONNECTION_STRING = "SslMode=none;Server=localhost;Database=gostinitsa;port=3306;Uid=root;charset=utf8";

        List<string> city = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            List<string> city = myselect("Select name FROM city ORDER BY name");
           
            Citycombobox.Items.Clear();
            Citycombobox.Items.Add("");
            foreach (string citi in city)
               Citycombobox.Items.Add(citi);

            List<string> hotel = myselect("Select name, ID, adress_pic FROM hotel");

            int x = 40;
            for(int i=0; i<hotel.Count; i+=3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 80);
                lbl.Size = new Size(260, 30);
                lbl.Font = new Font("Arial", 13);
                lbl.Text = hotel[i+1];
                lbl.Click += new EventHandler(LabelHotel_Click);
                infopanel.Controls.Add(lbl) ;

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + hotel[i+2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 145); 
                pb.Size = new Size(280, 182);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = hotel[i+2];
                pb.Click += new EventHandler(Hotel_Click);
                infopanel.Controls.Add(pb);
                x += 320;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void filtrpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filtrbutton_Click(object sender, EventArgs e)
        {
            if (filtrpanel.Height < 172)
            {
                filtrpanel.Height = 172;
            }
            else
            {
                filtrpanel.Height = filtrbutton.Size.Height;
            }
        }
        
        private void Hotel_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Hotelform hotelform = new Hotelform(pb.Tag.ToString());
            hotelform.ShowDialog();
        }

        private void Citycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
