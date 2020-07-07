using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace TECHLAND
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string PasswordHash = "";
                string PasswordIn = textBox1.Text;
                string PasswordInHash = "";
                MD5 Hasher = MD5.Create();
                StringBuilder SBuilder = new StringBuilder();
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection ("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "SELECT PasswordHash FROM Password;";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);                                       
                    da.Fill(dt);
                    PasswordHash = dt.Rows[0].ItemArray.GetValue(0).ToString();
                }
                catch (Exception)
                {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            byte[] ByteHash = Hasher.ComputeHash(Encoding.Default.GetBytes(PasswordIn));
                for (int vvI = 0; vvI < ByteHash.Length; vvI++)
                {
                    SBuilder.Append(ByteHash[vvI].ToString("x2"));
                }
                SBuilder.ToString();
                PasswordInHash = Convert.ToString(SBuilder);
                if (PasswordHash == PasswordInHash)
                {
                    Form Form3 = new Form3();
                    Form3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль!","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form Form1 = new Form1();
                    Form1.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Введите пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
