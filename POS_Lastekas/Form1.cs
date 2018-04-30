using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_Lastekas
{
    public partial class Main_Panel : Form
    {
        Timer t = new Timer();
        public Main_Panel()
        {

            InitializeComponent();
        }

        private void Main_Panel_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
            // load users 
            string myConnection = "datasource=localhost;port=3306;username=root;password=LaseSisse123";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand getNameCommand = new MySqlCommand("select * from ladu_1.kasutajad ", myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = getNameCommand.ExecuteReader();
                int nameCounter = 0;

                while (myReader.Read())
                {
                    string sName = myReader.GetString("eesnimi");
                    Bunifu.Framework.UI.BunifuTileButton logIn = new Bunifu.Framework.UI.BunifuTileButton();
                    this.Controls.Add(logIn);
                    if (nameCounter == 0)
                    {
                        logIn.Top = 51;
                    }
                    else
                    {
                        logIn.Top = (nameCounter * 140) + 51;
                    }
                    logIn.Left = 55;
                    logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
                    logIn.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
                    logIn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
                    logIn.LabelText = sName;
                    nameCounter = nameCounter + 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            // get current time 
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            // time 
            string time = "";

            // padding leading zero 
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            // update timeLabel
            timeLabel.Text = time; 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Minimize the form
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 49)
            {
                //Expand
                //  1. Expand the panel, w = 160
                //  2. Show Logo

                sideMenu.Visible = false;
                sideMenu.Width = 176;
                menuAnimator2.ShowSync(sideMenu);
            }
            else
            {
                //Minimize
                //  1. Hide the logo
                //  2. Slide the panel, w = 50

                sideMenu.Visible = false;
                sideMenu.Width = 49;
                menuAnimator.ShowSync(sideMenu);
            }
        }
    }
}
