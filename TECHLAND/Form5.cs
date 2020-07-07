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
    public partial class Form5 : Form
    {
        public Form5()
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
                Initialization();
            }
            catch(Exception)
            {}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вернуться в администрирование?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form Form3 = new Form3();
                Form3.Show();
                this.Close();
            }
        }

        private void BackIn(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back_Button_Enabled;
        }
        private void BacktOut(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back_Button;
        }
        private void ButtonIn1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Silver;
        }
        private void ButtonOut1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""||textBox2.Text!="")
            {
                if(textBox1.Text==textBox2.Text)
                {
                    MessageBox.Show("Новый пароль не должен совпадать с текущим!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto Exit;
                }
                string PasswordOldIn = textBox1.Text;
                string PasswordNewIn = textBox2.Text;
                for (int vvI = 0; vvI < PasswordNewIn.Length; vvI++)
                {
                    if (PasswordNewIn[vvI] == '~'|| PasswordNewIn[vvI] == '!'|| PasswordNewIn[vvI] == '@' || PasswordNewIn[vvI] == '#' || PasswordNewIn[vvI] == '$' || PasswordNewIn[vvI] == '%' || PasswordNewIn[vvI] == '^' || PasswordNewIn[vvI] == '&' || PasswordNewIn[vvI] == '*' || PasswordNewIn[vvI] == '(' || PasswordNewIn[vvI] == ')' || PasswordNewIn[vvI] == '+' || PasswordNewIn[vvI] == '-' || PasswordNewIn[vvI] == '`' || PasswordNewIn[vvI] == '"' || PasswordNewIn[vvI] == ';' || PasswordNewIn[vvI] == ':' || PasswordNewIn[vvI] == '<' || PasswordNewIn[vvI] == '>' || PasswordNewIn[vvI] == '/' || PasswordNewIn[vvI] == '|' || PasswordNewIn[vvI] == '>')
                    {
                        MessageBox.Show("В пароле запрещены символы!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto Exit;
                    }
                }
                string PasswordOldDBHash = "";
                string PasswordOldInHash = "";
                string PasswordNewHash = "";
                string NewDataChanges = "";
                string OldDataChanges = "";
                int UPD = 1;
                MD5 Hasher = MD5.Create();
                StringBuilder SBuilderPass = new StringBuilder();
                StringBuilder SBuilderPass2 = new StringBuilder();

                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT PasswordHash, DateChanges FROM [Password];";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    PasswordOldDBHash = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    OldDataChanges = dt.Rows[0].ItemArray.GetValue(1).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                byte[] ByteHash = Hasher.ComputeHash(Encoding.Default.GetBytes(PasswordOldIn));
                for (int vvI = 0; vvI < ByteHash.Length; vvI++)
                {
                    SBuilderPass.Append(ByteHash[vvI].ToString("x2"));
                }
                SBuilderPass.ToString();
                PasswordOldInHash = Convert.ToString(SBuilderPass);
                if (PasswordOldInHash == PasswordOldDBHash)
                {
                    byte[] ByteHashNew = Hasher.ComputeHash(Encoding.Default.GetBytes(PasswordNewIn));
                    for (int vvI = 0; vvI < ByteHashNew.Length; vvI++)
                    {
                        SBuilderPass2.Append(ByteHashNew[vvI].ToString("x2"));
                    }
                    SBuilderPass2.ToString();
                    PasswordNewHash = Convert.ToString(SBuilderPass2);
                    NewDataChanges= DateTime.Now.ToString("dd MMMM yyyy  HH:mm:ss");

                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        sql.CommandText = "UPDATE [Password] SET PasswordHash='" + PasswordNewHash + "', DateChanges = '" + NewDataChanges + "' WHERE ID_Password=" + UPD + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        Initialization();
                        MessageBox.Show("Пароль успешно изменён.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Form Form3 = new Form3();
                        Form3.Show();
                        this.Close();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Текущие пароли не совпадают!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form Form3 = new Form3();
                    Form3.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Заполните поля!","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Exit:;
        }
        public void Initialization()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT DateChanges FROM [Password];";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                string DataChanges = dt.Rows[0].ItemArray.GetValue(0).ToString();
                label5.Text = "Последнее изменение пароля:  ";
                label5.Text += DataChanges;
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
