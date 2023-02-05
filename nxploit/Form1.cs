using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using WeAreDevs_API;

namespace nxploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;
        readonly ExploitAPI Api = new ExploitAPI();

        private void Button2_Click(object sender, EventArgs e)
        {
            Api.LaunchExploit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string vynixius = "loadstring(game:Httpget('https://raw.githubusercontent.com/RegularVynixu/Vynixius/main/Doors/Script.lua'))()";
            Api.SendLuaScript(vynixius);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/nxyoo/nxploit");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/nxyoo");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string entity = "loadstring(game:Httpget('https://raw.githubusercontent.com/plamen6789/DoorsEntitySummonerGUI/main/EntityGUI'))()";
            Api.SendLuaScript(entity);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckInjected()
        {
            if (Api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                label3.ForeColor = Color.Green;
                label3.Text = "Injected";
            }
            else
            {
                //The exploit is not injected... The client must inject
                label3.Text = "Not Injected";
            }
        }

        //Check if the exploit is injected on load
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        //Check if the exploit is injected every 3 seconds
        private void InjectedChecker_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

    }
}
