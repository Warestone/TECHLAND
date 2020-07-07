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
    public partial class Form7 : Form
    {
        public Form7()
        {
            try
            {
                InitializeComponent();
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
        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void BackIn(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back_Button_Enabled;
        }
        private void BacktOut(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back_Button;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вернуться на главную?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form Form1 = new Form1();
                Form1.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/warestone");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string MailAddress = "jontimofeev@yandex.ru";
            Clipboard.SetText(MailAddress);
            MessageBox.Show("Адрес электронной почты скопирован в буфер обмена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
