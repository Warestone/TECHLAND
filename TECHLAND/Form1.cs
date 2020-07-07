using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECHLAND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Opacity = 0.40;
                Timer timer = new Timer();
                timer.Tick += new EventHandler((sender, e) =>
                {
                    if ((Opacity += 0.05d) == 1) timer.Stop();
                });
                timer.Interval = 3;
                timer.Start();
            }
            catch (Exception)
            {}           
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void ButtonIn1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Silver;
        }
        private void ButtonOut1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
        private void ButtonIn2(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Silver;
        }
        private void ButtonOut2(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void ExitIn(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Button_Exit_Enabled;
        }
        private void ExitOut(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Button_Exit;
        }
        private void InfoIn(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Info_Button_Enabled;
        }
        private void InfoOut(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Info_Button;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти к информации о программе?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form Form7 = new Form7();
                Form7.Show();
                this.Hide();
            }
        }
    }
}
