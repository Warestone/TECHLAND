using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SQLite;


namespace TECHLAND
{
    public partial class Form6 : Form
    {
        public string IDOrder = "";
        public Form6()
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
            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
            SQLiteCommand sql = Conn.CreateCommand();
            DataTable dt = new DataTable();
            Conn.Open();
            sql.CommandText = "SELECT max(ID_Order) FROM [Order];";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
            sql.ExecuteNonQuery();
            Conn.Close();
            da.Fill(dt);
            IDOrder = dt.Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отменить заказ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                Conn.Open();
                sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + IDOrder + ";";
                sql.ExecuteNonQuery();
                Conn.Close();
                Application.Restart();
            }
        }

        private void Print()
        {
            SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
            SQLiteCommand sql = Conn.CreateCommand();
            DataTable dt = new DataTable();
            Conn.Open();
            sql.CommandText = "SELECT ID_Order, (SELECT Model_Motherboard FROM Motherboard WHERE ID_Motherboard = [Order].ID_MotherboardO), (SELECT Model_GPU FROM GPU WHERE ID_GPU = [Order].ID_GPUO), (SELECT Model_PowerBlock FROM PowerBlock WHERE ID_PowerBlock = [Order].ID_PowerBlockO), (SELECT Model_Cooling FROM Cooling WHERE ID_Cooling = [Order].ID_CoolingO), (SELECT Model_CPU FROM CPU WHERE ID_CPU = [Order].ID_CPUO), (SELECT Model_Case FROM [Case] WHERE ID_Case = [Order].ID_CaseO), (SELECT Model_RAM FROM RAM WHERE ID_RAM = [Order].ID_RAMO), (SELECT Model_Memory FROM Memory WHERE ID_Memory = [Order].ID_MemoryO), (SELECT Surname_Client FROM Client WHERE ID_Client = [Order].ID_ClientSurname), (SELECT Name_Client FROM Client WHERE ID_Client = [Order].ID_ClientName), (SELECT Patronumic_Client FROM Client WHERE ID_Client = [Order].ID_ClientName), (SELECT Surname_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerSurname), (SELECT Name_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerName), (SELECT Patronymic_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerName), (SELECT Country_Address FROM Address WHERE ID_Address = [Order].ID_ClientName), (SELECT City_Address FROM Address WHERE ID_Address = [Order].ID_ClientName), (SELECT Street_Address FROM Address WHERE ID_Address = [Order].ID_ClientName), (SELECT NumHouse_Address FROM Address WHERE ID_Address = [Order].ID_ClientName), (SELECT Price_Motherboard FROM Motherboard WHERE ID_Motherboard = [Order].ID_MotherboardO), (SELECT Price_GPU FROM GPU WHERE ID_GPU = [Order].ID_GPUO), (SELECT Price_PowerBlock FROM PowerBlock WHERE ID_PowerBlock = [Order].ID_PowerBlockO),(SELECT Price_Cooling FROM Cooling WHERE ID_Cooling = [Order].ID_CoolingO),(SELECT Price_CPU FROM CPU WHERE ID_CPU = [Order].ID_CPUO),(SELECT Price_Case FROM [Case] WHERE ID_Case = [Order].ID_CaseO), (SELECT Price_RAM FROM RAM WHERE ID_RAM = [Order].ID_RAMO), (SELECT Price_Memory FROM Memory WHERE ID_Memory = [Order].ID_MemoryO), TotalPrice_OrderO FROM [Order] WHERE ID_Order=" + IDOrder + ";";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
            sql.ExecuteNonQuery();
            Conn.Close();
            da.Fill(dt);
            string Model_Motherboard = dt.Rows[0].ItemArray.GetValue(1).ToString();
            string Model_GPU = dt.Rows[0].ItemArray.GetValue(2).ToString();
            string Model_PowerBlock = dt.Rows[0].ItemArray.GetValue(3).ToString();
            string Model_Cooling = dt.Rows[0].ItemArray.GetValue(4).ToString();
            string Model_CPU = dt.Rows[0].ItemArray.GetValue(5).ToString();
            string Model_Case = dt.Rows[0].ItemArray.GetValue(6).ToString();
            string Model_RAM = dt.Rows[0].ItemArray.GetValue(7).ToString();
            string Model_Memory = dt.Rows[0].ItemArray.GetValue(8).ToString();
            string Client = dt.Rows[0].ItemArray.GetValue(9).ToString()+" "+ dt.Rows[0].ItemArray.GetValue(10).ToString()+" "+ dt.Rows[0].ItemArray.GetValue(11).ToString();
            string Seller = dt.Rows[0].ItemArray.GetValue(12).ToString() + " " + dt.Rows[0].ItemArray.GetValue(13).ToString() + " " + dt.Rows[0].ItemArray.GetValue(14).ToString();
            string Address = dt.Rows[0].ItemArray.GetValue(15).ToString() + ", " + dt.Rows[0].ItemArray.GetValue(16).ToString() + ", " + dt.Rows[0].ItemArray.GetValue(17).ToString() + ", " + dt.Rows[0].ItemArray.GetValue(18).ToString();
            string CostMotherboard= dt.Rows[0].ItemArray.GetValue(19).ToString();
            string CostGPU = dt.Rows[0].ItemArray.GetValue(20).ToString();
            string CostPowerBlock = dt.Rows[0].ItemArray.GetValue(21).ToString();
            string CostCooling = dt.Rows[0].ItemArray.GetValue(22).ToString();
            string CostCPU = dt.Rows[0].ItemArray.GetValue(23).ToString();
            string CostCase = dt.Rows[0].ItemArray.GetValue(24).ToString();
            string CostRAM = dt.Rows[0].ItemArray.GetValue(25).ToString();
            string CostMemory = dt.Rows[0].ItemArray.GetValue(26).ToString();
            string TotalCost = dt.Rows[0].ItemArray.GetValue(27).ToString();
            string DateOrder = DateTime.Now.ToString("dd MMMM yyyy  HH:mm");

            using (System.IO.StreamWriter PrintFile = new System.IO.StreamWriter("Товарный чек.txt", true))
            {
                PrintFile.WriteLine("-------------------------------------- Магазин компьютерной техники --------------------------------------");
                PrintFile.WriteLine("------------------------------------------------ TECHLAND ------------------------------------------------");
                PrintFile.WriteLine("");
                if(Model_Motherboard!="")
                {
                    PrintFile.WriteLine("       Материнская плата: "+Model_Motherboard);
                    PrintFile.WriteLine("       "+CostMotherboard + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_GPU != "")
                {
                    PrintFile.WriteLine("       Видеокарта: " + Model_GPU);
                    PrintFile.WriteLine("       " + CostGPU + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_PowerBlock != "")
                {
                    PrintFile.WriteLine("       Блок питания: " + Model_PowerBlock);
                    PrintFile.WriteLine("       " + CostPowerBlock + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_Cooling != "")
                {
                    PrintFile.WriteLine("       Система охлаждения: " + Model_Cooling);
                    PrintFile.WriteLine("       " + CostCooling + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_CPU != "")
                {
                    PrintFile.WriteLine("       Процессор: " + Model_CPU);
                    PrintFile.WriteLine("       " + CostCPU + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_Case != "")
                {
                    PrintFile.WriteLine("       Корпус: " + Model_Case);
                    PrintFile.WriteLine("       " + CostCase + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_RAM != "")
                {
                    PrintFile.WriteLine("       Оперативная память: " + Model_RAM);
                    PrintFile.WriteLine("       " + CostRAM + " Р");
                    PrintFile.WriteLine("");
                }
                if (Model_Memory != "")
                {
                    PrintFile.WriteLine("       Память: " + Model_Memory);
                    PrintFile.WriteLine("       " + CostMemory + " Р");
                    PrintFile.WriteLine("");
                }
                PrintFile.WriteLine("");
                PrintFile.WriteLine("       Итого к оплате: "+TotalCost+ " Р");
                PrintFile.WriteLine("");
                PrintFile.WriteLine("");
                PrintFile.WriteLine("       Заказчик: "+Client);
                PrintFile.WriteLine("       Продавец: " + Seller);
                PrintFile.WriteLine("       Адрес доставки: " + Address);
                PrintFile.WriteLine("       Дата заказа: " + DateOrder);
                PrintFile.WriteLine("");
                PrintFile.WriteLine("------------------------------------------- Спасибо за покупку! ------------------------------------------");
                PrintFile.WriteLine("----------------------------------------------------------------------------------------------------------");
            }
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

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || textBox8.Text != "" || textBox10.Text != "")
            {
                string NumTelf = textBox3.Text;
                string NumCard = textBox4.Text;
                char Check;
                for(int vvI=0;vvI<NumTelf.Length;vvI++)
                {
                    Check = NumTelf[vvI];
                    if(Check!='0'&& Check != '1' && Check != '2' && Check != '3' && Check != '4' && Check != '5' && Check != '6' && Check != '7' && Check != '8' && Check != '9')
                    {
                        MessageBox.Show("В поле 'Номер телефона' могут быть только числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }                                           
                }
                for (int vvI = 0; vvI < NumCard.Length; vvI++)
                {
                    Check = NumCard[vvI];
                    if (Check != '0' && Check != '1' && Check != '2' && Check != '3' && Check != '4' && Check != '5' && Check != '6' && Check != '7' && Check != '8' && Check != '9')
                    {
                        MessageBox.Show("В поле 'Номер карты' могут быть только числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Exit;
                    }
                }
                              
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "INSERT INTO Client (ID_Client, Surname_Client, Name_Client, Patronumic_Client, NumberTel_Client, NumberCart_Client, ID_Order) VALUES ('" + IDOrder + "','" + textBox10.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + IDOrder + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();

                    if(textBox9.Text=="")
                    {
                        textBox9.Text = " ";
                    }

                    Conn.Open();
                    sql.CommandText = "INSERT INTO Address (ID_Address, Country_Address, City_Address, Street_Address, NumHouse_Address, NumFlat_Address, ID_Client) VALUES ('" + IDOrder + "','" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + IDOrder + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    Print();
                    MessageBox.Show("Заказ принят в обработку, спасибо!\nВозьмите ваш чек!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch(Exception)
                {
                    MessageBox.Show("В данный момент возможность заказа не доступна, обратитесь к продавцу (база данных блокирована или отсутствует)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Exit;
                }
            }
            else
            {
                MessageBox.Show("Поля должны быть заполнены!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Exit:;
        }
    }
}
