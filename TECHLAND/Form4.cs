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

namespace TECHLAND
{
    public partial class Form4 : Form
    {
        string Price1 = "0";
        string Price2 = "0";
        string Price3 = "0";
        string Price4 = "0";
        string Price5 = "0";
        string Price6 = "0";
        string Price7 = "0";
        string Price8 = "0";
        public string TotalPrice = "0";
        string UPD1 = "";
        string UPD2 = "";
        string UPD3 = "";
        string UPD4 = "";
        string UPD5 = "";
        string UPD6 = "";
        string UPD7 = "";
        string UPD8 = "";
        string Clear = "0";
        int Flag1 = 0;
        int Flag2 = 0;
        int Flag3 = 0;
        int Flag4 = 0;
        int Flag5 = 0;
        int Flag6 = 0;
        int Flag7 = 0;
        int Flag8 = 0;
        int Total = 0;
        public string NewID = "";
        public List<String> Model = new List<String>();
        public Form4()
        {
            InitializeComponent();
            SmallSize();
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
            dataGridView1.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView1.AllowUserToResizeColumns = false;
            /*------------------------------------------------------------------------Model Motherboard-----------------------------------------------------------------------------*/

            try
            {
                int ASD = 0;
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                Conn.Open();
                sql.CommandText = "SELECT Model_Motherboard FROM Motherboard;";
                SQLiteDataReader CBB1 = sql.ExecuteReader();
                while (CBB1.Read())
                {
                    Model.Add(CBB1.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox1.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB1.Close();
                Conn.Close();

                /*------------------------------------------------------------------------Model GPU-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_GPU FROM GPU;";
                SQLiteDataReader CBB2 = sql.ExecuteReader();
                while (CBB2.Read())
                {
                    Model.Add(CBB2.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox3.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB2.Close();
                Conn.Close();                

                /*------------------------------------------------------------------------Model PowerBlock-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_PowerBlock FROM PowerBlock;";
                SQLiteDataReader CBB3 = sql.ExecuteReader();
                while (CBB3.Read())
                {
                    Model.Add(CBB3.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox4.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB3.Close();
                Conn.Close();

                /*------------------------------------------------------------------------Model Cooling-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_Cooling FROM Cooling;";
                SQLiteDataReader CBB4 = sql.ExecuteReader();
                while (CBB4.Read())
                {
                    Model.Add(CBB4.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox5.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB4.Close();
                Conn.Close();                

                /*------------------------------------------------------------------------Model CPU-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_CPU FROM CPU;";
                SQLiteDataReader CBB5 = sql.ExecuteReader();
                while (CBB5.Read())
                {
                    Model.Add(CBB5.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox2.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB5.Close();
                Conn.Close();                

                /*------------------------------------------------------------------------Model Case-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_Case FROM [Case];";
                SQLiteDataReader CBB6 = sql.ExecuteReader();
                while (CBB6.Read())
                {
                    Model.Add(CBB6.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox6.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB6.Close();
                Conn.Close();               

                /*------------------------------------------------------------------------Model RAM-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_RAM FROM RAM;";
                SQLiteDataReader CBB7 = sql.ExecuteReader();
                while (CBB7.Read())
                {
                    Model.Add(CBB7.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox7.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB7.Close();
                Conn.Close();                

                /*------------------------------------------------------------------------Model Memory-----------------------------------------------------------------------------*/

                Conn.Open();
                sql.CommandText = "SELECT Model_Memory FROM Memory;";
                SQLiteDataReader CBB8 = sql.ExecuteReader();
                while (CBB8.Read())
                {
                    Model.Add(CBB8.GetValue(0).ToString());
                    ASD++;
                }
                for (int vvI = 0; vvI < ASD; vvI++)
                {
                    comboBox8.Items.Add(Model[vvI]);
                }
                Model.Clear();
                ASD = 0;
                CBB8.Close();
                Conn.Close();               

            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (NewID != "")
            {
                if (MessageBox.Show("Очистить корзину и вернуться на главную?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    Form Form1 = new Form1();
                    Form1.Show();
                    this.Close();
                    goto Exit;
                }
            }
            if (MessageBox.Show("Вернуться на главную?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form Form1 = new Form1();
                Form1.Show();
                this.Close();
            }
            Exit:;
        }

        private void ExitIn(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Button_Exit_Enabled;
        }
        private void ExitOut(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Button_Exit;
        }
        private void BackIn(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back_Button_Enabled;
        }
        private void BacktOut(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back_Button;
        }
        private void ButtonIn18(object sender, EventArgs e)
        {
            button18.ForeColor = Color.Silver;
        }
        private void ButtonOut18(object sender, EventArgs e)
        {
            button18.ForeColor = Color.White;
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
        private void ButtonIn3(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Silver;
        }
        private void ButtonOut3(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }
        private void ButtonIn4(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Silver;
        }
        private void ButtonOut4(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }
        private void ButtonIn5(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Silver;
        }
        private void ButtonOut5(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }
        private void ButtonIn6(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Silver;
        }
        private void ButtonOut6(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }
        private void ButtonIn7(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Silver;
        }
        private void ButtonOut7(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
        }
        private void ButtonIn8(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Silver;
        }
        private void ButtonOut8(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (NewID != "")
            {
                if (MessageBox.Show("Очистить корзину и закрыть программу?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    Application.Exit();
                    goto Exit;
                }
            }
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            Exit:;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD1 = comboBox1.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Motherboard WHERE Model_Motherboard='" + UPD1 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD1 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price1 = dt.Rows[0].ItemArray.GetValue(3).ToString();
                label19.Text = "Цена: "+dt.Rows[0].ItemArray.GetValue(3).ToString() + " P";
                label20.Text = "Модель: "+ dt.Rows[0].ItemArray.GetValue(1).ToString();
                label21.Text ="Сокет: "+ dt.Rows[0].ItemArray.GetValue(2).ToString();
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                button18.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD2 = comboBox3.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM GPU WHERE Model_GPU='" + UPD2 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD2 =  dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price2 = dt.Rows[0].ItemArray.GetValue(4).ToString();
                label12.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(4).ToString() + " P";
                label15.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label13.Text = "Объём памяти: " + dt.Rows[0].ItemArray.GetValue(3).ToString() + " Гб";
                label14.Text = "Тип памяти: " + dt.Rows[0].ItemArray.GetValue(2).ToString();
                label12.Visible = true;
                label15.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                button1.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD3 = comboBox4.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM PowerBlock WHERE Model_PowerBlock='" + UPD3 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD3 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price3 = dt.Rows[0].ItemArray.GetValue(3).ToString();
                label17.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(3).ToString() + " P";
                label22.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label18.Text = "Мощность: " + dt.Rows[0].ItemArray.GetValue(2).ToString();
                label22.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                button3.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD4 = comboBox5.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Cooling WHERE Model_Cooling='" + UPD4 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD4 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price4 = dt.Rows[0].ItemArray.GetValue(2).ToString();
                label24.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(2).ToString() + " P";
                label25.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label25.Visible = true;
                label24.Visible = true;
                button4.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD5 = comboBox2.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM CPU WHERE Model_CPU='" + UPD5 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD5 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price5 = dt.Rows[0].ItemArray.GetValue(5).ToString();
                label6.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(5).ToString() + " P";
                label9.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label8.Text = "Сокет: " + dt.Rows[0].ItemArray.GetValue(2).ToString();
                label5.Text = "Количество ядер: " + dt.Rows[0].ItemArray.GetValue(4).ToString();
                label7.Text = "Частота: " + dt.Rows[0].ItemArray.GetValue(3).ToString()+" GHz";
                label6.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                button5.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD6 = comboBox6.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM [Case] WHERE Model_Case='" + UPD6 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD6 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price6 = dt.Rows[0].ItemArray.GetValue(3).ToString();
                label27.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(3).ToString() + " P";
                label41.Text = "Цвет: " + dt.Rows[0].ItemArray.GetValue(2).ToString();
                label28.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label27.Visible = true;
                label41.Visible = true;
                label28.Visible = true;
                button6.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD7 = comboBox7.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM RAM WHERE Model_RAM='" + UPD7 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD7 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price7 = dt.Rows[0].ItemArray.GetValue(5).ToString();
                label30.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(5).ToString() + " P";
                label34.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label33.Text = "Интерфейс: " + dt.Rows[0].ItemArray.GetValue(2).ToString();
                label31.Text = "Объём памяти: " + dt.Rows[0].ItemArray.GetValue(4).ToString()+" Гб";
                label32.Text = "Тип памяти: " + dt.Rows[0].ItemArray.GetValue(3).ToString();
                label30.Visible = true;
                label31.Visible = true;
                label34.Visible = true;
                label33.Visible = true;
                label32.Visible = true;
                button7.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UPD8 = comboBox8.SelectedItem.ToString();
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dt = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Memory WHERE Model_Memory='" + UPD8 + "';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                sql.ExecuteNonQuery();
                Conn.Close();
                da.Fill(dt);
                UPD8 = dt.Rows[0].ItemArray.GetValue(0).ToString();
                Price8 = dt.Rows[0].ItemArray.GetValue(5).ToString();
                label36.Text = "Цена: " + dt.Rows[0].ItemArray.GetValue(5).ToString() + " P";
                label40.Text = "Модель: " + dt.Rows[0].ItemArray.GetValue(1).ToString();
                label39.Text = "Интерфейс: " + dt.Rows[0].ItemArray.GetValue(2).ToString();
                label37.Text = "Объём памяти: " + dt.Rows[0].ItemArray.GetValue(4).ToString() + " Гб";
                label38.Text = "Тип памяти: " + dt.Rows[0].ItemArray.GetValue(3).ToString();
                label36.Visible = true;
                label37.Visible = true;
                label38.Visible = true;
                label39.Visible = true;
                label40.Visible = true;
                button8.Visible = true;
                label1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
                if (Flag1 == 0)
                {
                    if (Total == 0)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            DataTable dt = new DataTable();
                            Conn.Open();
                            sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                            SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            da.Fill(dt);
                            NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                            if(NewID=="")
                            {
                                NewID = "0";
                            }
                            int ConvertID = Convert.ToInt32(NewID) + 1;
                            NewID = ConvertID.ToString();

                            Conn.Open();
                            CountTotalPrice();
                            sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_MotherboardO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD1 + "','" + TotalPrice + "');";
                            sql.ExecuteNonQuery();
                            Conn.Close();

                            comboBox1.Visible = false;
                            label4.Visible = false;
                            Visualization();
                            FullSize();
                            Total++;
                            Flag1++;
                            button18.Text = "Убрать из корзины";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }

                }
                    else
                    {
                         try
                         {
                                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                                SQLiteCommand sql = Conn.CreateCommand();
                                Conn.Open();
                                CountTotalPrice();
                                sql.CommandText = "UPDATE [Order] SET ID_MotherboardO='" + UPD1 + "', TotalPrice_OrderO ='"+TotalPrice+ "' WHERE ID_Order=" + NewID + ";";
                                sql.ExecuteNonQuery();
                                Conn.Close();
                                comboBox1.Visible = false;
                                label4.Visible = false;
                                Visualization();
                                Total++;
                                Flag1++;
                                button18.Text = "Убрать из корзины";
                            }
                         catch(Exception)
                         {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                    }
                    }
                }
                else
                {
                    if (Total == 1)
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                                SQLiteCommand sql = Conn.CreateCommand();
                                Conn.Open();
                                Price1 = "0";
                                CountTotalPrice();
                                sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                                sql.ExecuteNonQuery();
                                Conn.Close();
                                comboBox1.Visible = true;
                                label4.Visible = true;
                                button18.Text = "Добавить в корзину";
                                Visualization();
                                SmallSize();
                                Total--;
                                Flag1--;                                
                                goto Exit;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto Exit;
                            }
                }
                    }
                    else
                    {
                        try
                        {
                            if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                                SQLiteCommand sql = Conn.CreateCommand();
                                Conn.Open();
                                Price1 = "0";
                                CountTotalPrice();
                                sql.CommandText = "UPDATE [Order] SET ID_MotherboardO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                                sql.ExecuteNonQuery();
                                Conn.Close();
                                comboBox1.Visible = true;
                                label4.Visible = true;
                                button18.Text = "Добавить в корзину";
                                Visualization();
                                Total--;
                                Flag1--;
                            }                           
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }       
            }
                Exit:;
        }

        private void FullSize()
        {
            this.Width = 994;
            this.Height = 545;
            label3.Location = new Point(-2, 155);
            tabControl1.Location = new Point(4, 196);
            label2.Visible = true;
            dataGridView1.Visible = true;
            button2.Visible = true;
        }
        private void SmallSize()
        {
            this.Width = 994;
            this.Height = 357;
            label3.Location = new Point(-2, 39);
            tabControl1.Location = new Point(4, 80);
            label2.Visible = false;
            dataGridView1.Visible = false;
            button2.Visible = false;
        }
        private void CountTotalPrice()
        {
            long P1 = Convert.ToInt32(Price1);
            long P2 = Convert.ToInt32(Price2);
            long P3 = Convert.ToInt32(Price3);
            long P4 = Convert.ToInt32(Price4);
            long P5 = Convert.ToInt32(Price5);
            long P6 = Convert.ToInt32(Price6);
            long P7 = Convert.ToInt32(Price7);
            long P8 = Convert.ToInt32(Price8);
            long TotalP = P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8;
            TotalPrice = TotalP.ToString();
        }
        private void Visualization()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                Conn.Open();
                sql.CommandText = "SELECT ID_Order, (SELECT Model_Motherboard FROM Motherboard WHERE ID_Motherboard = [Order].ID_MotherboardO) AS ID_MotherboardO, (SELECT Model_GPU FROM GPU WHERE ID_GPU = [Order].ID_GPUO) AS ID_GPUO, (SELECT Model_PowerBlock FROM PowerBlock WHERE ID_PowerBlock = [Order].ID_PowerBlockO) AS ID_PowerBlockO,(SELECT Model_Cooling FROM Cooling WHERE ID_Cooling = [Order].ID_CoolingO) AS ID_CoolingO, (SELECT Model_CPU FROM CPU WHERE ID_CPU = [Order].ID_CPUO) AS ID_CPUO, (SELECT Model_Case FROM [Case] WHERE ID_Case = [Order].ID_CaseO) AS ID_CaseO, (SELECT Model_RAM FROM RAM WHERE ID_RAM = [Order].ID_RAMO) AS ID_RAMO, (SELECT Model_Memory FROM Memory WHERE ID_Memory = [Order].ID_MemoryO) AS ID_MemoryO, TotalPrice_OrderO FROM [Order] WHERE ID_Order=" + NewID + ";";
                sql.ExecuteNonQuery();
                Conn.Close();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.Columns["ID_Order"].ColumnName = "№";
                dt.Columns["ID_MotherboardO"].ColumnName = "Материнская плата";
                dt.Columns["ID_GPUO"].ColumnName = "Видеокарта";
                dt.Columns["ID_PowerBlockO"].ColumnName = "Блок питания";
                dt.Columns["ID_CoolingO"].ColumnName = "Система охлаждения";
                dt.Columns["ID_CPUO"].ColumnName = "Процессор";
                dt.Columns["ID_CaseO"].ColumnName = "Корпус";
                dt.Columns["ID_RAMO"].ColumnName = "Оперативная память";
                dt.Columns["ID_MemoryO"].ColumnName = "Жёсткий диск/SSD";
                dt.Columns["TotalPrice_OrderO"].ColumnName = "Цена всего, P";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 128;
                dataGridView1.Columns[2].Width = 118;
                dataGridView1.Columns[3].Width = 90;
                dataGridView1.Columns[4].Width = 118;
                dataGridView1.Columns[5].Width = 108;
                dataGridView1.Columns[6].Width = 75;
                dataGridView1.Columns[7].Width = 128;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Flag2 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_GPUO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD2 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox3.Visible = false;
                        label11.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag2++;
                        button1.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

                }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_GPUO='" + UPD2 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox3.Visible = false;
                        label11.Visible = false;
                        Visualization();
                        Total++;
                        Flag2++;
                        button1.Text = "Убрать из корзины";
                    }   
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price2 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox3.Visible = true;
                            label11.Visible = true;
                            button1.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag2--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price2 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_GPUO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox3.Visible = true;
                            label11.Visible = true;
                            button1.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag2--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Flag3 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_PowerBlockO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD3 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox4.Visible = false;
                        label16.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag3++;
                        button3.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

                }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_PowerBlockO='" + UPD3 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox4.Visible = false;
                        label16.Visible = false;
                        Visualization();
                        Total++;
                        Flag3++;
                        button3.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price3 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox4.Visible = true;
                            label16.Visible = true;
                            button3.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag3--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price3 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_PowerBlockO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox4.Visible = true;
                            label16.Visible = true;
                            button3.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag3--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Flag4 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_CoolingO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD4 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox5.Visible = false;
                        label23.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag4++;
                        button4.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

                }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_CoolingO='" + UPD4 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox5.Visible = false;
                        label23.Visible = false;
                        Visualization();
                        Total++;
                        Flag4++;
                        button4.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price4 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox5.Visible = true;
                            label23.Visible = true;
                            button4.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag4--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price4 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_CoolingO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox5.Visible = true;
                            label23.Visible = true;
                            button4.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag4--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Flag5 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_CPUO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD5 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox2.Visible = false;
                        label10.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag5++;
                        button5.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

            }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_CPUO='" + UPD5 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox2.Visible = false;
                        label10.Visible = false;
                        Visualization();
                        Total++;
                        Flag5++;
                        button5.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price5 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox2.Visible = true;
                            label10.Visible = true;
                            button5.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag5--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price5 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_CPUO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox2.Visible = true;
                            label10.Visible = true;
                            button5.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag5--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Flag6 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_CaseO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD6 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox6.Visible = false;
                        label26.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag6++;
                        button6.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

                }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_CaseO='" + UPD6 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox6.Visible = false;
                        label26.Visible = false;
                        Visualization();
                        Total++;
                        Flag6++;
                        button6.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price6 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox6.Visible = true;
                            label26.Visible = true;
                            button6.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag6--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price6 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_CaseO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox6.Visible = true;
                            label26.Visible = true;
                            button6.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag6--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Flag7 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_RAMO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD7 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox7.Visible = false;
                        label29.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag7++;
                        button7.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

                }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_RAMO='" + UPD7 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox7.Visible = false;
                        label29.Visible = false;
                        Visualization();
                        Total++;
                        Flag7++;
                        button7.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price7 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox7.Visible = true;
                            label29.Visible = true;
                            button7.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag7--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price7 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_RAMO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox7.Visible = true;
                            label29.Visible = true;
                            button7.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag7--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Flag8 == 0)
            {
                if (Total == 0)
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        DataTable dt = new DataTable();
                        Conn.Open();
                        sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        if (NewID == "")
                        {
                            NewID = "0";
                        }
                        int ConvertID = Convert.ToInt32(NewID) + 1;
                        NewID = ConvertID.ToString();

                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "INSERT INTO [Order] (ID_Order, ID_MemoryO, TotalPrice_OrderO) VALUES ('" + NewID + "','" + UPD8 + "','" + TotalPrice + "');";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        comboBox8.Visible = false;
                        label35.Visible = false;
                        Visualization();
                        FullSize();
                        Total++;
                        Flag8++;
                        button8.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }

                }
                else
                {
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        CountTotalPrice();
                        sql.CommandText = "UPDATE [Order] SET ID_MemoryO='" + UPD8 + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        comboBox8.Visible = false;
                        label35.Visible = false;
                        Visualization();
                        Total++;
                        Flag8++;
                        button8.Text = "Убрать из корзины";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            else
            {
                if (Total == 1)
                {
                    if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price8 = "0";
                            CountTotalPrice();
                            sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox8.Visible = true;
                            label35.Visible = true;
                            button8.Text = "Добавить в корзину";
                            Visualization();
                            SmallSize();
                            Total--;
                            Flag8--;
                            goto Exit;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Убрать из корзины?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                            SQLiteCommand sql = Conn.CreateCommand();
                            Conn.Open();
                            Price8 = "0";
                            CountTotalPrice();
                            sql.CommandText = "UPDATE [Order] SET ID_MemoryO='" + Clear + "', TotalPrice_OrderO ='" + TotalPrice + "' WHERE ID_Order=" + NewID + ";";
                            sql.ExecuteNonQuery();
                            Conn.Close();
                            comboBox8.Visible = true;
                            label35.Visible = true;
                            button8.Text = "Добавить в корзину";
                            Visualization();
                            Total--;
                            Flag8--;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
            }
            Exit:;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти к оформлению заказа?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    Conn.Open();
                    DataTable dt = new DataTable();
                    sql.CommandText = "SELECT max(ID_Seller) FROM Seller;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string SellersMax = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    int ConvertSellersMax = Convert.ToInt32(SellersMax);
                    Random RND = new Random();
                    int SellerID = RND.Next(1, ConvertSellersMax);

                    Conn.Open();
                    sql.CommandText = "UPDATE [Order] SET ID_ClientSurname='" + NewID + "', ID_ClientName ='" + NewID + "', ID_SellerSurname ='" + SellerID + "', ID_SellerName ='" + SellerID + "' WHERE ID_Order=" + NewID + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();

                    Form Form6 = new Form6();
                    Form6.Show();
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Exit;
                }
            }
            Exit:;
        }
    }
}
