using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdpage
{
    public partial class Mainpage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Mainpage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void iconDemo_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            demo Demo = new demo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Demo.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(Demo);
            Demo.Show();
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            HomeScreen mainpage = new HomeScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mainpage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(mainpage);
            mainpage.Show();


        }

        private void iconAbout_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            aboutus aboutus = new aboutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            aboutus.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(aboutus);
            aboutus.Show();
        }

        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconcontactus_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ContactUS contactus = new ContactUS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            contactus.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(contactus);
            contactus.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
