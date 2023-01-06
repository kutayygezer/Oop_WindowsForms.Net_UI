using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloUniverseUI
{
    public partial class Form3 : Form
    {
        BaseHumanoid _baseHumanoid;
        int _check;
        public Form3(BaseHumanoid baseHumanoid,int check)
        {
            InitializeComponent();
            _baseHumanoid = baseHumanoid;
            _check = check;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_check == 1)
            {
                Spartan spartan = new Spartan();
                Form4 form = new Form4(spartan,1,2);
                form.Show();
                Visible = false;
            }
            else if(_check == 2)
            {
                Elites elites = new Elites();
                Form4 form = new Form4(elites,2,2);
                form.Show();
                Visible = false;
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_check == 1)
            {
                Civilian civilian = new Civilian();
                Form4 form = new Form4(civilian,1,1);
                form.Show();
                Visible = false;
            }
            
            else if(_check == 2)
            {
                Grunts grunts = new Grunts();
                Form4 form = new Form4(grunts,2,1);
                form.Show();
                Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = _baseHumanoid.Name1;
            label2.Text = _baseHumanoid.Name2;
            pictureBox1.Image = _baseHumanoid.ImagePath1;
            pictureBox2.Image = _baseHumanoid.ImagePath2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (_check == 1)
            {
                Spartan spartan = new Spartan();
                Form4 form = new Form4(spartan, 1, 2);
                form.Show();
                Visible = false;
            }
            else if (_check == 2)
            {
                Elites elites = new Elites();
                Form4 form = new Form4(elites, 2, 2);
                form.Show();
                Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_check == 1)
            {
                Civilian civilian = new Civilian();
                Form4 form = new Form4(civilian, 1, 1);
                form.Show();
                Visible = false;
            }

            else if (_check == 2)
            {
                Grunts grunts = new Grunts();
                Form4 form = new Form4(grunts, 2, 1);
                form.Show();
                Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Halo, The Elites are my favourite!",
                "Halo Universe User Interface made by Osman K. Gezer");
        }

        private void haloTitlePic_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Visible = false;
        }
    }
}
