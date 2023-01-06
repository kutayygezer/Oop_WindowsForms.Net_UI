using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloUniverseUI
{
    public partial class Form4 : Form
    {
        BaseHumanoid _baseHumanoid;
        int _check1;
        int _check2;
        
        public Form4(BaseHumanoid baseHumanoid, int check1, int check2)
        {
            _baseHumanoid = baseHumanoid;
            InitializeComponent();
            _check1 = check1;
            _check2 = check2;
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

        private void Form5_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            _baseHumanoid.SoundPlayer1.Stop();
            if (_check1 == 1)
            {
                Human human = new Human();
                Form3 form3 = new Form3(human, 1);
                form3.Show();
                Visible = false;
            }
            else if(_check1 == 2)
            {
                Covenant covenant = new Covenant();
                Form3 form3 = new Form3(covenant, 2);
                form3.Show();
                Visible = false;
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            nameLbl.Text = _baseHumanoid.Name1;
            speciesInfo.Text = _baseHumanoid.Species;
            powerInfo.Text = _baseHumanoid.PowerLvl;
            pictureBox1.Image = _baseHumanoid.ImagePath1;
            danceBtn.Text = "Dance!";
            speakBtn.Text = "Speak!";
            if(_check1 == 1 && _check2 == 1)
            {
                fightBtn.Enabled = false;
                punchBtn.Enabled = false;
            }
            else if(_check1 == 2 && _check2 == 1)
            {
                punchBtn.Enabled=false;
            }
            axWindowsMediaPlayer1.uiMode = "None"; //remove all the control
        }

        private void danceBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.URL = _baseHumanoid.DanceVidPath;
        }

        private void speakBtn_Click(object sender, EventArgs e)
        {
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            _baseHumanoid.SoundPlayer1.Play();
        }

        private void fightBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.URL = _baseHumanoid.FightVidPath;
        }

        private void vidStopBtn_Click(object sender, EventArgs e)
        {
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void vidPauseBtn_Click(object sender, EventArgs e)
        {
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void startVidBtn_Click(object sender, EventArgs e)
        {
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void punchBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.URL = _baseHumanoid.PunchVidPath;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Halo, The Elites are my favourite!",
                "Halo Universe User Interface made by Osman K. Gezer");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _baseHumanoid.SoundPlayer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            _baseHumanoid.SoundPlayer1.Play();
        }

        private void haloTitlePic_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            _baseHumanoid.SoundPlayer1.Stop();
            Form2 frm = new Form2();
            frm.Show();
            Visible = false;
        }
    }
}
