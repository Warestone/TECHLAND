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
    public partial class Form3 : Form
    {
        public string UPD = "";
        public string ID_Order = "";
        public int Messages = 0;
        public Form3()
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView5.AllowUserToResizeColumns = false;
            dataGridView5.AllowUserToResizeRows = false;
            dataGridView6.AllowUserToResizeColumns = false;
            dataGridView6.AllowUserToResizeRows = false;
            dataGridView7.AllowUserToResizeColumns = false;
            dataGridView7.AllowUserToResizeRows = false;
            dataGridView8.AllowUserToResizeColumns = false;
            dataGridView8.AllowUserToResizeRows = false;
            dataGridView9.AllowUserToResizeColumns = false;
            dataGridView9.AllowUserToResizeRows = false;
            dataGridView10.AllowUserToResizeColumns = false;
            dataGridView10.AllowUserToResizeRows = false;
            dataGridView11.AllowUserToResizeColumns = false;
            dataGridView11.AllowUserToResizeRows = false;
            dataGridView12.AllowUserToResizeColumns = false;
            dataGridView12.AllowUserToResizeRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView2.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView3.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView4.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView5.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView6.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView7.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView8.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView9.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView10.DefaultCellStyle.Font = new Font("Georgia", 8);
            dataGridView11.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView12.DefaultCellStyle.Font = new Font("Georgia", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView8.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView9.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView10.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 9, FontStyle.Bold);
            dataGridView11.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridView12.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);

            /*-----------------------------------------CPU-------------------------------------------------------------------------*/
            //try
            //{
                SQLiteConnection ConnectDB = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = ConnectDB.CreateCommand();
                ConnectDB.Open();
                sql.CommandText="SELECT ID_CPU, Model_CPU, Socket_CPU, GHz_CPU, NumCores_CPU, Price_CPU FROM CPU;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.Columns["ID_CPU"].ColumnName = "№";
                dt.Columns["Model_CPU"].ColumnName = "Модель";
                dt.Columns["Socket_CPU"].ColumnName = "Тип сокета";
                dt.Columns["GHz_CPU"].ColumnName = "Частота, Ггц";
                dt.Columns["NumCores_CPU"].ColumnName = "Кол-во ядер";
                dt.Columns["Price_CPU"].ColumnName = "Цена, Р";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 340;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 145;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 120;

                /*-----------------------------------------GPU-------------------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_GPU, Model_GPU, TypeMemory_GPU, TotalMemory_GPU, Price_GPU FROM GPU;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt2 = new DataTable();
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql);
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                dt2.Columns["ID_GPU"].ColumnName = "№";
                dt2.Columns["Model_GPU"].ColumnName = "Модель";
                dt2.Columns["TypeMemory_GPU"].ColumnName = "Тип памяти";
                dt2.Columns["TotalMemory_GPU"].ColumnName = "Всего памяти, Гб";
                dt2.Columns["Price_GPU"].ColumnName = "Цена, Р";
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Width = 385;
                dataGridView2.Columns[2].Width = 165;
                dataGridView2.Columns[3].Width = 185;
                dataGridView2.Columns[4].Width = 160;

                /*-----------------------------------------Case------------------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_Case, Model_Case, Color_Case, Price_Case FROM [Case];";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt3 = new DataTable();
                SQLiteDataAdapter da3 = new SQLiteDataAdapter(sql);
                da3.Fill(dt3);
                dataGridView3.DataSource = dt3;
                dt3.Columns["ID_Case"].ColumnName = "№";
                dt3.Columns["Model_Case"].ColumnName = "Модель";
                dt3.Columns["Color_Case"].ColumnName = "Цвет";
                dt3.Columns["Price_Case"].ColumnName = "Цена, Р";
                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[1].Width = 500;
                dataGridView3.Columns[2].Width = 200;
                dataGridView3.Columns[3].Width = 195;

                /*-----------------------------------------Power Blocks-----------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_PowerBlock, Model_PowerBlock, Voltage_PowerBlock, Price_PowerBlock FROM PowerBlock;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt4 = new DataTable();
                SQLiteDataAdapter da4 = new SQLiteDataAdapter(sql);
                da4.Fill(dt4);
                dataGridView4.DataSource = dt4;
                dt4.Columns["ID_PowerBlock"].ColumnName = "№";
                dt4.Columns["Model_PowerBlock"].ColumnName = "Модель";
                dt4.Columns["Voltage_PowerBlock"].ColumnName = "Мощность";
                dt4.Columns["Price_PowerBlock"].ColumnName = "Цена, Р";
                dataGridView4.Columns[0].Visible = false;
                dataGridView4.Columns[1].Width = 500;
                dataGridView4.Columns[2].Width = 200;
                dataGridView4.Columns[3].Width = 195;

                /*-----------------------------------------Cooling Systems-------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_Cooling, Model_Cooling, Price_Cooling FROM Cooling;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt5 = new DataTable();
                SQLiteDataAdapter da5 = new SQLiteDataAdapter(sql);
                da5.Fill(dt5);
                dataGridView5.DataSource = dt5;
                dt5.Columns["ID_Cooling"].ColumnName = "№";
                dt5.Columns["Model_Cooling"].ColumnName = "Модель";
                dt5.Columns["Price_Cooling"].ColumnName = "Цена, Р";
                dataGridView5.Columns[0].Visible = false;
                dataGridView5.Columns[1].Width = 600;
                dataGridView5.Columns[2].Width = 295;

                /*-----------------------------------------Motherboards---------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_Motherboard, Model_Motherboard, Socket_Motherboard, Price_Motherboard FROM Motherboard;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt6 = new DataTable();
                SQLiteDataAdapter da6 = new SQLiteDataAdapter(sql);
                da6.Fill(dt6);
                dataGridView6.DataSource = dt6;
                dt6.Columns["ID_Motherboard"].ColumnName = "№";
                dt6.Columns["Model_Motherboard"].ColumnName = "Модель";
                dt6.Columns["Socket_Motherboard"].ColumnName = "Сокет";
                dt6.Columns["Price_Motherboard"].ColumnName = "Цена, Р";
                dataGridView6.Columns[0].Visible = false;
                dataGridView6.Columns[1].Width = 500;
                dataGridView6.Columns[2].Width = 200;
                dataGridView6.Columns[3].Width = 195;

                /*----------------------------------------------RAM-------------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_RAM, Model_RAM, Interface_RAM, TypeMemory_RAM, TotalMemory_RAM, Price_RAM FROM RAM;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt7 = new DataTable();
                SQLiteDataAdapter da7 = new SQLiteDataAdapter(sql);
                da7.Fill(dt7);
                dataGridView7.DataSource = dt7;
                dt7.Columns["ID_RAM"].ColumnName = "№";
                dt7.Columns["Model_RAM"].ColumnName = "Модель";
                dt7.Columns["Interface_RAM"].ColumnName = "Интерфейс";
                dt7.Columns["TypeMemory_RAM"].ColumnName = "Тип памяти";
                dt7.Columns["TotalMemory_RAM"].ColumnName = "Всего памяти, Гб";
                dt7.Columns["Price_RAM"].ColumnName = "Цена, Р";
                dataGridView7.Columns[0].Visible = false;
                dataGridView7.Columns[1].Width = 310;
                dataGridView7.Columns[2].Width = 135;
                dataGridView7.Columns[3].Width = 140;
                dataGridView7.Columns[4].Width = 180;
                dataGridView7.Columns[5].Width = 130;

                /*----------------------------------------------SSD/HDD---------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_Memory, Model_Memory, Interface_Memory, TypeMem_Memory, TotalMem_Memory, Price_Memory FROM Memory;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt8 = new DataTable();
                SQLiteDataAdapter da8 = new SQLiteDataAdapter(sql);
                da8.Fill(dt8);
                dataGridView8.DataSource = dt8;
                dt8.Columns["ID_Memory"].ColumnName = "№";
                dt8.Columns["Model_Memory"].ColumnName = "Модель";
                dt8.Columns["Interface_Memory"].ColumnName = "Интерфейс";
                dt8.Columns["TypeMem_Memory"].ColumnName = "Тип памяти";
                dt8.Columns["TotalMem_Memory"].ColumnName = "Всего памяти, Гб";
                dt8.Columns["Price_Memory"].ColumnName = "Цена, Р";
                dataGridView8.Columns[0].Visible = false;
                dataGridView8.Columns[1].Width = 310;
                dataGridView8.Columns[2].Width = 135;
                dataGridView8.Columns[3].Width = 140;
                dataGridView8.Columns[4].Width = 180;
                dataGridView8.Columns[5].Width = 130;

                /*----------------------------------------------Clients-------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_Client, Surname_Client, Name_Client, Patronumic_Client, NumberTel_Client, NumberCart_Client, (SELECT City_Address FROM Address WHERE ID_Address = Client.ID_Client) AS Город FROM Client;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt9 = new DataTable();
                SQLiteDataAdapter da9 = new SQLiteDataAdapter(sql);
                da9.Fill(dt9);
                dataGridView9.DataSource = dt9;
                dt9.Columns["ID_Client"].ColumnName = "№";
                dt9.Columns["Surname_Client"].ColumnName = "Фамилия";
                dt9.Columns["Name_Client"].ColumnName = "Имя";
                dt9.Columns["Patronumic_Client"].ColumnName = "Отчество";
                dt9.Columns["NumberTel_Client"].ColumnName = "Номер телефона";
                dt9.Columns["NumberCart_Client"].ColumnName = "Номер карты";
                dataGridView9.Columns[0].Visible = false;
                dataGridView9.Columns[1].Width = 150;
                dataGridView9.Columns[2].Width = 150;
                dataGridView9.Columns[3].Width = 197;
                dataGridView9.Columns[4].Width = 160;
                dataGridView9.Columns[5].Width = 138;

            /*----------------------------------------------Orders--------------------------------------------------------------*/

            ConnectDB.Open();
            sql.CommandText = "SELECT ID_Order, (SELECT Model_Motherboard FROM Motherboard WHERE ID_Motherboard = [Order].ID_MotherboardO) AS ID_MotherboardO, (SELECT Model_GPU FROM GPU WHERE ID_GPU = [Order].ID_GPUO) AS ID_GPUO, (SELECT Model_PowerBlock FROM PowerBlock WHERE ID_PowerBlock = [Order].ID_PowerBlockO) AS ID_PowerBlockO, (SELECT Model_Cooling FROM Cooling WHERE ID_Cooling = [Order].ID_CoolingO) AS ID_CoolingO, (SELECT Model_CPU FROM CPU WHERE ID_CPU = [Order].ID_CPUO) AS ID_CPUO, (SELECT Model_Case FROM [Case] WHERE ID_Case = [Order].ID_CaseO) AS ID_CaseO, (SELECT Model_RAM FROM RAM WHERE ID_RAM = [Order].ID_RAMO) AS ID_RAMO, (SELECT Model_Memory FROM Memory WHERE ID_Memory = [Order].ID_MemoryO) AS ID_MemoryO, (SELECT Surname_Client FROM Client WHERE ID_Client = [Order].ID_ClientSurname) AS ID_ClientSurname, (SELECT Name_Client FROM Client WHERE ID_Client = [Order].ID_ClientName) AS ID_ClientName, (SELECT Surname_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerSurname) AS ID_SellerSurname, (SELECT Name_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerName) AS ID_SellerName, TotalPrice_OrderO FROM [Order];";
            sql.ExecuteNonQuery();
            ConnectDB.Close();
            DataTable dt10 = new DataTable();
            SQLiteDataAdapter da10 = new SQLiteDataAdapter(sql);
            da10.Fill(dt10);
            dataGridView10.DataSource = dt10;
            dt10.Columns["ID_Order"].ColumnName = "№";
            dt10.Columns["ID_MotherboardO"].ColumnName = "Мат. плата";
            dt10.Columns["ID_GPUO"].ColumnName = "GPU";
            dt10.Columns["ID_PowerBlockO"].ColumnName = "Блок питания";
            dt10.Columns["ID_CoolingO"].ColumnName = "Система охлажд.";
            dt10.Columns["ID_CPUO"].ColumnName = "CPU";
            dt10.Columns["ID_CaseO"].ColumnName = "Корпус";
            dt10.Columns["ID_RAMO"].ColumnName = "RAM";
            dt10.Columns["ID_MemoryO"].ColumnName = "SSD/HDD";
            dt10.Columns["ID_ClientSurname"].ColumnName = "Фамилия клиента";
            dt10.Columns["ID_ClientName"].ColumnName = "Имя клиента";
            dt10.Columns["ID_SellerSurname"].ColumnName = "Фамилия продавца";
            dt10.Columns["ID_SellerName"].ColumnName = "Имя продавца";
            dt10.Columns["TotalPrice_OrderO"].ColumnName = "Цена всего, Р";
            dataGridView10.Columns[1].Width = 55;
            dataGridView10.Columns[2].Width = 40;
            dataGridView10.Columns[3].Width = 75;
            dataGridView10.Columns[4].Width = 70;
            dataGridView10.Columns[5].Width = 40;
            dataGridView10.Columns[6].Width = 65;
            dataGridView10.Columns[7].Width = 45;
            dataGridView10.Columns[8].Width = 75;
            dataGridView10.Columns[9].Width = 85;
            dataGridView10.Columns[10].Width = 80;
            dataGridView10.Columns[11].Width = 85;
            dataGridView10.Columns[12].Width = 85;
            dataGridView10.Columns[13].Width = 95;
            dataGridView10.Columns[0].Visible = false;


            /*----------------------------------------------Adresses------------------------------------------------------------*/

            ConnectDB.Open();
                sql.CommandText = "SELECT ID_Address, Country_Address, City_Address, Street_Address, NumHouse_Address, NumFlat_Address FROM Address;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt11 = new DataTable();
                SQLiteDataAdapter da11 = new SQLiteDataAdapter(sql);
                da11.Fill(dt11);
                dataGridView11.DataSource = dt11;
                dt11.Columns["ID_Address"].ColumnName = "№";
                dt11.Columns["Country_Address"].ColumnName = "Страна";
                dt11.Columns["City_Address"].ColumnName = "Город";
                dt11.Columns["Street_Address"].ColumnName = "Улица";
                dt11.Columns["NumHouse_Address"].ColumnName = "Номер дома";
                dt11.Columns["NumFlat_Address"].ColumnName = "Номер квартиры";
                dataGridView11.Columns[0].Visible = false;
                dataGridView11.Columns[1].Width = 200;
                dataGridView11.Columns[2].Width = 170;
                dataGridView11.Columns[3].Width = 200;
                dataGridView11.Columns[4].Width = 160;
                dataGridView11.Columns[5].Width = 165;

                /*----------------------------------------------Sellers-------------------------------------------------------------*/

                ConnectDB.Open();
                sql.CommandText = "SELECT ID_Seller, Surname_Seller, Name_Seller, Patronymic_Seller, PersonalNum_Seller FROM Seller;";
                sql.ExecuteNonQuery();
                ConnectDB.Close();
                DataTable dt12 = new DataTable();
                SQLiteDataAdapter da12 = new SQLiteDataAdapter(sql);
                da12.Fill(dt12);
                dataGridView12.DataSource = dt12;
                dt12.Columns["ID_Seller"].ColumnName = "№";
                dt12.Columns["Surname_Seller"].ColumnName = "Фамилия";
                dt12.Columns["Name_Seller"].ColumnName = "Имя";
                dt12.Columns["Patronymic_Seller"].ColumnName = "Отчество";
                dt12.Columns["PersonalNum_Seller"].ColumnName = "Табельный номер";
                dataGridView12.Columns[0].Visible = false;
                dataGridView12.Columns[1].Width = 225;
                dataGridView12.Columns[2].Width = 225;
                dataGridView12.Columns[3].Width = 225;
                dataGridView12.Columns[4].Width = 220;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("База данных 'DATA_BASE' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView4.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView5.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView6.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView7.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView8.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView9.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView10.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView11.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridView12.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Messages == 0)
            {
                if (MessageBox.Show("Вы действительно хотите закрыть программу?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Messages == 0)
            {
                if (MessageBox.Show("Отключить уведомления?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Messages++;
                    pictureBox3.Image = Properties.Resources.Message_buttonOff;
                    ToolTip OffMessage= new ToolTip();
                    OffMessage.SetToolTip(pictureBox3, "Включить уведомления");
                }
            }
            else if (MessageBox.Show("Включить уведомления?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Messages--;
                pictureBox3.Image = Properties.Resources.Message_button;
                ToolTip OnMessage = new ToolTip();
                OnMessage.SetToolTip(pictureBox3, "Включить уведомления");
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Messages == 0)
            {
                if (MessageBox.Show("Вернуться на главную?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Form Form1 = new Form1();
                    Form1.Show();
                    this.Close();
                }
            }
            else
            {
                Form Form1 = new Form1();
                Form1.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Messages == 0)
            {
                if (MessageBox.Show("Перейти к изменению пароля администратора?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Form Form5 = new Form5();
                    Form5.Show();
                    this.Close();
                }
            }
            else
            {
                Form Form5 = new Form5();
                Form5.Show();
                this.Close();
            }
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
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
        private void ButtonIn9(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Silver;
        }
        private void ButtonOut9(object sender, EventArgs e)
        {
            button9.ForeColor = Color.White;
        }
        private void ButtonIn31(object sender, EventArgs e)
        {
            button31.ForeColor = Color.Silver;
        }
        private void ButtonOut31(object sender, EventArgs e)
        {
            button31.ForeColor = Color.White;
        }
        private void ButtonIn11(object sender, EventArgs e)
        {
            button11.ForeColor = Color.Silver;
        }
        private void ButtonOut11(object sender, EventArgs e)
        {
            button11.ForeColor = Color.White;
        }
        private void ButtonIn12(object sender, EventArgs e)
        {
            button12.ForeColor = Color.Silver;
        }
        private void ButtonOut12(object sender, EventArgs e)
        {
            button12.ForeColor = Color.White;
        }
        private void ButtonIn13(object sender, EventArgs e)
        {
            button13.ForeColor = Color.Silver;
        }
        private void ButtonOut13(object sender, EventArgs e)
        {
            button13.ForeColor = Color.White;
        }
        private void ButtonIn14(object sender, EventArgs e)
        {
            button14.ForeColor = Color.Silver;
        }
        private void ButtonOut14(object sender, EventArgs e)
        {
            button14.ForeColor = Color.White;
        }
        private void ButtonIn15(object sender, EventArgs e)
        {
            button15.ForeColor = Color.Silver;
        }
        private void ButtonOut15(object sender, EventArgs e)
        {
            button15.ForeColor = Color.White;
        }
        private void ButtonIn16(object sender, EventArgs e)
        {
            button16.ForeColor = Color.Silver;
        }
        private void ButtonOut16(object sender, EventArgs e)
        {
            button16.ForeColor = Color.White;
        }
        private void ButtonIn17(object sender, EventArgs e)
        {
            button17.ForeColor = Color.Silver;
        }
        private void ButtonOut17(object sender, EventArgs e)
        {
            button17.ForeColor = Color.White;
        }
        private void ButtonIn18(object sender, EventArgs e)
        {
            button18.ForeColor = Color.Silver;
        }
        private void ButtonOut18(object sender, EventArgs e)
        {
            button18.ForeColor = Color.White;
        }
        private void ButtonIn33(object sender, EventArgs e)
        {
            button33.ForeColor = Color.Silver;
        }
        private void ButtonOut33(object sender, EventArgs e)
        {
            button33.ForeColor = Color.White;
        }
        private void ButtonIn20(object sender, EventArgs e)
        {
            button20.ForeColor = Color.Silver;
        }
        private void ButtonOut20(object sender, EventArgs e)
        {
            button20.ForeColor = Color.White;
        }
        private void ButtonIn21(object sender, EventArgs e)
        {
            button21.ForeColor = Color.Silver;
        }
        private void ButtonOut21(object sender, EventArgs e)
        {
            button21.ForeColor = Color.White;
        }
        private void ButtonIn22(object sender, EventArgs e)
        {
            button22.ForeColor = Color.Silver;
        }
        private void ButtonOut22(object sender, EventArgs e)
        {
            button22.ForeColor = Color.White;
        }
        private void ButtonIn23(object sender, EventArgs e)
        {
            button23.ForeColor = Color.Silver;
        }
        private void ButtonOut23(object sender, EventArgs e)
        {
            button23.ForeColor = Color.White;
        }
        private void ButtonIn24(object sender, EventArgs e)
        {
            button24.ForeColor = Color.Silver;
        }
        private void ButtonOut24(object sender, EventArgs e)
        {
            button24.ForeColor = Color.White;
        }
        private void ButtonIn25(object sender, EventArgs e)
        {
            button25.ForeColor = Color.Silver;
        }
        private void ButtonOut25(object sender, EventArgs e)
        {
            button25.ForeColor = Color.White;
        }
        private void ButtonIn26(object sender, EventArgs e)
        {
            button26.ForeColor = Color.Silver;
        }
        private void ButtonOut26(object sender, EventArgs e)
        {
            button26.ForeColor = Color.White;
        }
        private void ButtonIn27(object sender, EventArgs e)
        {
            button27.ForeColor = Color.Silver;
        }
        private void ButtonOut27(object sender, EventArgs e)
        {
            button27.ForeColor = Color.White;
        }
        private void ButtonIn28(object sender, EventArgs e)
        {
            button28.ForeColor = Color.Silver;
        }
        private void ButtonOut28(object sender, EventArgs e)
        {
            button28.ForeColor = Color.White;
        }
        private void ButtonIn29(object sender, EventArgs e)
        {
            button29.ForeColor = Color.Silver;
        }
        private void ButtonOut29(object sender, EventArgs e)
        {
            button29.ForeColor = Color.White;
        }
        private void ButtonIn30(object sender, EventArgs e)
        {
            button30.ForeColor = Color.Silver;
        }
        private void ButtonOut30(object sender, EventArgs e)
        {
            button30.ForeColor = Color.White;
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
        private void KeyIn(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Key_button_Enabled;
        }
        private void KeyOut(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Key_button;
        }
        private void MessageIn(object sender, EventArgs e)
        {
            if (Messages == 0)
            {
                pictureBox3.Image = Properties.Resources.Message_button_Enabled;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.Message_button_EnabledOff;
            }
        }
        private void MessageOut(object sender, EventArgs e)
        {
            if (Messages == 0)
            {
                pictureBox3.Image = Properties.Resources.Message_button;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.Message_buttonOff;
            }
        }
        /*---------------------------------------------------------------DELETE BUTTONS---------------------------------------------------------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELL = dataGridView1.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM CPU WHERE ID_CPU=" + SelectedDELL + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_CPU();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM CPU WHERE ID_CPU=" + SelectedDELL + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_CPU();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
             }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl2 = dataGridView2.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM GPU WHERE ID_GPU=" + SelectedDELLl2 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_GPU();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM GPU WHERE ID_GPU=" + SelectedDELLl2 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_GPU();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl3 = dataGridView3.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM [Case] WHERE ID_Case=" + SelectedDELLl3 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Case();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM [Case] WHERE ID_Case=" + SelectedDELLl3 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Case();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl4 = dataGridView4.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM PowerBlock WHERE ID_PowerBlock=" + SelectedDELLl4 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_PowerBlock();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM PowerBlock WHERE ID_PowerBlock=" + SelectedDELLl4 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_PowerBlock();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl5 = dataGridView5.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Cooling WHERE ID_Cooling=" + SelectedDELLl5 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Cooling();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Cooling WHERE ID_Cooling=" + SelectedDELLl5 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Cooling();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl6 = dataGridView6.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Motherboard WHERE ID_Motherboard=" + SelectedDELLl6 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Motherboard();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Motherboard WHERE ID_Motherboard=" + SelectedDELLl6 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Motherboard();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl7 = dataGridView7.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM RAM WHERE ID_RAM=" + SelectedDELLl7 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_RAM();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM RAM WHERE ID_RAM=" + SelectedDELLl7 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_RAM();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl8 = dataGridView8.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Memory WHERE ID_Memory=" + SelectedDELLl8 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Memory();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Memory WHERE ID_Memory=" + SelectedDELLl8 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Memory();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl12 = dataGridView12.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {
                    if (MessageBox.Show("Удалить запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Seller WHERE ID_Seller=" + SelectedDELLl12 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Seller();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    try
                    {
                        SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = ConDEL.CreateCommand();
                        ConDEL.Open();
                        sql.CommandText = "DELETE FROM Seller WHERE ID_Seller=" + SelectedDELLl12 + ";";
                        sql.ExecuteNonQuery();
                        ConDEL.Close();
                        Update_Seller();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedDELLl14 = dataGridView10.SelectedCells[0].Value.ToString();
                if (Messages == 0)
                {                   
                    if (MessageBox.Show("Удалить запись? Внимание, при удалении данной записи, будет удалена запись из Клиентов и Адресов!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        sql.CommandText = "SELECT ID_ClientSurname FROM [Order] WHERE ID_Order=" + SelectedDELLl14 + ";";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                        DataTable dt = new DataTable();
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        da.Fill(dt);
                        string ClientID = dt.Rows[0].ItemArray.GetValue(0).ToString();

                        Conn.Open();
                        sql.CommandText = "DELETE FROM Address WHERE ID_Address='" + ClientID + "';";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        Conn.Open();
                        sql.CommandText = "DELETE FROM Client WHERE ID_Client='" + ClientID + "';";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        Conn.Open();
                        sql.CommandText = "DELETE FROM [Order] WHERE ID_Order='" + SelectedDELLl14 + "';";
                        sql.ExecuteNonQuery();
                        Conn.Close();

                        Update_Order();
                        Update_Address();
                        Update_Client();
                        MessageBox.Show("Запись удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    }
                }
                else
                {
                    SQLiteConnection ConDEL = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = ConDEL.CreateCommand();
                    ConDEL.Open();
                    sql.CommandText = "DELETE FROM [Order] WHERE ID_Order=" + SelectedDELLl14 + ";";
                    sql.ExecuteNonQuery();
                    ConDEL.Close();
                    Update_Order();
                    Update_Address();
                    Update_Client();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*---------------------------------------------------------------CHANGE BUTTONS--------------------------------------------------------------*/

        private void button21_Click(object sender, EventArgs e)
        {        
                if (button21.Text == "Принять изменения")
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                    {
                        MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto EXIT;
                    }
                    try
                    {
                        SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                        SQLiteCommand sql = Conn.CreateCommand();
                        Conn.Open();
                        sql.CommandText = "UPDATE CPU SET Model_CPU='" + textBox1.Text + "', Socket_CPU = '" + textBox4.Text + "', GHz_CPU = '" + textBox3.Text + "', NumCores_CPU = '" + textBox2.Text + "', Price_CPU = '" + textBox5.Text + "' WHERE ID_CPU=" + UPD + ";";
                        sql.ExecuteNonQuery();
                        Conn.Close();
                        button21.Text = "Изменить запись";
                        Update_CPU();
                        Update_Order();
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        if (Messages == 0)
                        {
                            MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Некорректно заполнены поля!\nПоля 'Модель'и 'Количество ядер' могут принимать только целые числа, поле 'Частота' может принимать целые числа и числа с десятками через запятую!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else
            {
                try
                {
                    UPD = dataGridView1.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM CPU Where ID_CPU=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox1.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox5.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();
                    textBox2.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
                    textBox3.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox4.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    button21.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.Text == "Принять изменения")
            {
                if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE GPU SET Model_GPU='" + textBox6.Text + "', TypeMemory_GPU = '" + textBox7.Text + "', TotalMemory_GPU = '" + textBox8.Text + "', Price_GPU = '" + textBox9.Text + "' WHERE ID_GPU=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button22.Text = "Изменить запись";
                    Update_GPU();
                    Update_Order();
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Цена' и 'Обьём памяти' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView2.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM GPU Where ID_GPU=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox6.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox9.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
                    textBox7.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox8.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    button22.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.Text == "Принять изменения")
            {
                if (textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE [Case] SET Model_Case='" + textBox10.Text + "', Color_Case = '" + textBox11.Text + "', Price_Case = '" + textBox12.Text + "' WHERE ID_Case=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button23.Text = "Изменить запись";
                    Update_Case();
                    Update_Order();
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;
                    textBox12.Visible = false;
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView3.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM [Case] Where ID_Case=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox10.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox11.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox12.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    textBox10.Visible = true;
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                    button23.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.Text == "Принять изменения")
            {
                if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE PowerBlock SET Model_PowerBlock='" + textBox13.Text + "', Voltage_PowerBlock = '" + textBox14.Text + "', Price_PowerBlock = '" + textBox15.Text + "' WHERE ID_PowerBlock=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button24.Text = "Изменить запись";
                    Update_PowerBlock();
                    Update_Order();
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    textBox13.Visible = false;
                    textBox14.Visible = false;
                    textBox15.Visible = false;
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView4.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM PowerBlock Where ID_PowerBlock=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox13.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox14.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox15.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    textBox13.Visible = true;
                    textBox14.Visible = true;
                    textBox15.Visible = true;
                    button24.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.Text == "Принять изменения")
            {
                if (textBox16.Text == "" || textBox17.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE Cooling SET Model_Cooling='" + textBox16.Text + "', Price_Cooling = '" + textBox17.Text + "' WHERE ID_Cooling=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button25.Text = "Изменить запись";
                    Update_Cooling();
                    Update_Order();
                    label17.Visible = false;
                    label18.Visible = false;
                    textBox16.Visible = false;
                    textBox17.Visible = false;
                    textBox16.Text = "";
                    textBox17.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView5.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM Cooling Where ID_Cooling=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox16.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox17.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    label17.Visible = true;
                    label18.Visible = true;
                    textBox16.Visible = true;
                    textBox17.Visible = true;
                    button25.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.Text == "Принять изменения")
            {
                if (textBox18.Text == "" || textBox19.Text == ""|| textBox20.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE Motherboard SET Model_Motherboard='" + textBox19.Text + "', Price_Motherboard = '" + textBox18.Text + "', Socket_Motherboard = '" + textBox20.Text + "' WHERE ID_Motherboard=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button26.Text = "Изменить запись";
                    Update_Motherboard();
                    Update_Order();
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    textBox18.Visible = false;
                    textBox19.Visible = false;
                    textBox20.Visible = false;
                    textBox18.Text = "";
                    textBox19.Text = "";
                    textBox20.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView6.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM Motherboard Where ID_Motherboard=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox18.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox19.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox20.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    label19.Visible = true;
                    label20.Visible = true;
                    label21.Visible = true;
                    textBox18.Visible = true;
                    textBox19.Visible = true;
                    textBox20.Visible = true;
                    button26.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.Text == "Принять изменения")
            {
                if (textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || textBox24.Text == "" || textBox25.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE RAM SET Model_RAM='" + textBox21.Text + "', Interface_RAM = '" + textBox22.Text + "', TypeMemory_RAM = '" + textBox23.Text + "', TotalMemory_RAM = '" + textBox24.Text + "', Price_RAM = '" + textBox25.Text + "' WHERE ID_RAM=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button27.Text = "Изменить запись";
                    Update_Order();
                    Update_RAM();
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                    label25.Visible = false;
                    label26.Visible = false;
                    textBox21.Visible = false;
                    textBox22.Visible = false;
                    textBox23.Visible = false;
                    textBox24.Visible = false;
                    textBox25.Visible = false;
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    textBox24.Text = "";
                    textBox25.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Цена' и 'Обьём памяти' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView7.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM RAM Where ID_RAM=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox21.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox25.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();
                    textBox22.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox23.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox24.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
                    label22.Visible = true;
                    label23.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    textBox21.Visible = true;
                    textBox22.Visible = true;
                    textBox23.Visible = true;
                    textBox24.Visible = true;
                    textBox25.Visible = true;
                    button27.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.Text == "Принять изменения")
            {
                if (textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE Memory SET Model_Memory='" + textBox28.Text + "', Interface_Memory = '" + textBox27.Text + "', TypeMem_Memory = '" + textBox26.Text + "', TotalMem_Memory = '" + textBox29.Text + "', Price_Memory = '" + textBox30.Text + "' WHERE ID_Memory=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button28.Text = "Изменить запись";
                    Update_Memory();
                    Update_Order();
                    label27.Visible = false;
                    label28.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label31.Visible = false;
                    textBox26.Visible = false;
                    textBox27.Visible = false;
                    textBox28.Visible = false;
                    textBox29.Visible = false;
                    textBox30.Visible = false;
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox28.Text = "";
                    textBox29.Text = "";
                    textBox30.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Цена' и 'Обьём памяти' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView8.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM Memory Where ID_Memory=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox26.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox27.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox28.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox29.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
                    textBox30.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    textBox26.Visible = true;
                    textBox27.Visible = true;
                    textBox28.Visible = true;
                    textBox29.Visible = true;
                    textBox30.Visible = true;
                    button28.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.Text == "Принять изменения")
            {
                if (textBox31.Text == "" || textBox32.Text == "" || textBox33.Text == "" || textBox34.Text == "" || textBox35.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE Address SET Country_Address='" + textBox31.Text + "', City_Address = '" + textBox32.Text + "', Street_Address = '" + textBox33.Text + "', NumHouse_Address = '" + textBox35.Text + "', NumFlat_Address = '" + textBox34.Text + "' WHERE ID_Address=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button29.Text = "Изменить запись";
                    Update_Address();
                    Update_Order();
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    textBox31.Visible = false;
                    textBox32.Visible = false;
                    textBox33.Visible = false;
                    textBox34.Visible = false;
                    textBox35.Visible = false;
                    textBox31.Text = "";
                    textBox32.Text = "";
                    textBox33.Text = "";
                    textBox34.Text = "";
                    textBox35.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Возникла ошибка при добавлении записи, база данных 'DATA_BASE' используется другим процессом (приложением)!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView11.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM Address Where ID_Address=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox31.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox32.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox33.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox34.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();
                    textBox35.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
                    label32.Visible = true;
                    label33.Visible = true;
                    label34.Visible = true;
                    label35.Visible = true;
                    label36.Visible = true;
                    textBox31.Visible = true;
                    textBox32.Visible = true;
                    textBox33.Visible = true;
                    textBox34.Visible = true;
                    textBox35.Visible = true;
                    button29.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.Text == "Принять изменения")
            {
                if (textBox36.Text == "" || textBox37.Text == "" || textBox38.Text == "" || textBox39.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE Seller SET Surname_Seller='" + textBox36.Text + "', Name_Seller = '" + textBox37.Text + "', Patronymic_Seller = '" + textBox38.Text + "', PersonalNum_Seller = '" + textBox39.Text + "' WHERE ID_Seller=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button30.Text = "Изменить запись";
                    Update_Seller();
                    Update_Order();
                    label37.Visible = false;
                    label38.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    textBox36.Visible = false;
                    textBox37.Visible = false;
                    textBox38.Visible = false;
                    textBox39.Visible = false;
                    textBox36.Text = "";
                    textBox37.Text = "";
                    textBox38.Text = "";
                    textBox39.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Табельный номер' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView12.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM Seller Where ID_Seller=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox36.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox37.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox38.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox39.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
                    label37.Visible = true;
                    label38.Visible = true;
                    label39.Visible = true;
                    label40.Visible = true;
                    textBox36.Visible = true;
                    textBox37.Visible = true;
                    textBox38.Visible = true;
                    textBox39.Visible = true;
                    button30.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            EXIT:;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Принять изменения")
            {
                if (textBox40.Text == "" || textBox41.Text == "" || textBox42.Text == "" || textBox43.Text == "" || textBox44.Text == "" )
                {
                    MessageBox.Show("Заполните поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto EXIT;
                }
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "UPDATE Client SET Surname_Client='" + textBox43.Text + "', Name_Client = '" + textBox42.Text + "', Patronumic_Client = '" + textBox41.Text + "', NumberTel_Client = '" + textBox40.Text + "', NumberCart_Client = '" + textBox44.Text + "' WHERE ID_Client=" + UPD + ";";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    button31.Text = "Изменить запись";
                    Update_Order();
                    Update_Client();
                    label41.Visible = false;
                    label42.Visible = false;
                    label43.Visible = false;
                    label44.Visible = false;
                    label45.Visible = false;
                    textBox40.Visible = false;
                    textBox41.Visible = false;
                    textBox42.Visible = false;
                    textBox43.Visible = false;
                    textBox44.Visible = false;
                    textBox40.Text = "";
                    textBox41.Text = "";
                    textBox42.Text = "";
                    textBox43.Text = "";
                    textBox44.Text = "";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Номер телефона' и 'Номер карты' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    UPD = dataGridView9.SelectedCells[0].Value.ToString();
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT * FROM Client Where ID_Client=" + UPD + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    textBox43.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    textBox42.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                    textBox41.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
                    textBox40.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();
                    textBox44.Text = dt.Rows[0].ItemArray.GetValue(6).ToString();
                    label41.Visible = true;
                    label42.Visible = true;
                    label43.Visible = true;
                    label44.Visible = true;
                    label45.Visible = true;
                    textBox40.Visible = true;
                    textBox41.Visible = true;
                    textBox42.Visible = true;
                    textBox43.Visible = true;
                    textBox44.Visible = true;
                    button31.Text = "Принять изменения";
                    if (Messages == 0)
                    {
                        MessageBox.Show("Измените запись и нажмите кнопку 'Принять изменения'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
            }
                catch (Exception)
            {
                MessageBox.Show("Выберите запись.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
            EXIT:;
        }

        /*---------------------------------------------------------------INSERT BUTTONS---------------------------------------------------------------*/

        private void button3_Click(object sender, EventArgs e)
        {
            if(label2.Visible != true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                goto Exit;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_CPU) FROM CPU;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO CPU (ID_CPU, Model_CPU, Socket_CPU, GHz_CPU, NumCores_CPU, Price_CPU) VALUES ('" + NewID + "','" + textBox1.Text + "','" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "','" + textBox5.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_CPU();
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Модель'и 'Количество ядер' могут принимать только целые числа, поле 'Частота' может принимать целые числа и числа с десятками через запятую!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(label7.Visible!=true)
            {
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                goto Exit;
            }
            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_GPU) FROM GPU;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO GPU (ID_GPU, Model_GPU, TypeMemory_GPU, TotalMemory_GPU, Price_GPU) VALUES ('" + NewID + "','" + textBox6.Text + "','" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_GPU();
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Цена' и 'Обьём памяти' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(label11.Visible!=true)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                goto Exit;
            }
            if (textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_Case) FROM [Case];";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO [Case] (ID_Case, Model_Case, Color_Case, Price_Case) VALUES ('" + NewID + "','" + textBox10.Text + "','" + textBox11.Text + "', '" + textBox12.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_Case();
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;
                    textBox12.Visible = false;
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(label14.Visible!=true)
            {
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                goto Exit;
            }
            if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_PowerBlock) FROM PowerBlock;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO PowerBlock (ID_PowerBlock, Model_PowerBlock, Voltage_PowerBlock, Price_PowerBlock) VALUES ('" + NewID + "','" + textBox13.Text + "','" + textBox14.Text + "', '" + textBox15.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_PowerBlock();
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    textBox13.Visible = false;
                    textBox14.Visible = false;
                    textBox15.Visible = false;
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(label17.Visible!=true)
            {
                label17.Visible = true;
                label18.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                goto Exit;
            }
            if (textBox16.Text == "" || textBox17.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_Cooling) FROM Cooling;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO Cooling (ID_Cooling, Model_Cooling, Price_Cooling) VALUES ('" + NewID + "','" + textBox16.Text + "','" + textBox17.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_Cooling();
                    label17.Visible = false;
                    label18.Visible = false;
                    textBox16.Visible = false;
                    textBox17.Visible = false;
                    textBox16.Text = "";
                    textBox17.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(label20.Visible!=true)
            {
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                goto Exit;
            }
            if (textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_Motherboard) FROM Motherboard;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO Motherboard (ID_Motherboard, Model_Motherboard,Socket_Motherboard, Price_Motherboard) VALUES ('" + NewID + "','" + textBox19.Text + "','" + textBox20.Text + "','"+ textBox18.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_Motherboard();
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    textBox18.Visible = false;
                    textBox19.Visible = false;
                    textBox20.Visible = false;
                    textBox18.Text = "";
                    textBox19.Text = "";
                    textBox20.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Цена' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(label22.Visible!=true)
            {
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                goto Exit;
            }
            if (textBox21.Text == "" || textBox21.Text == "" || textBox23.Text == "" || textBox24.Text == "" || textBox25.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_RAM) FROM RAM;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO RAM (ID_RAM, Model_RAM, Interface_RAM, TypeMemory_RAM, TotalMemory_RAM, Price_RAM) VALUES ('" + NewID + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_RAM();
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                    label25.Visible = false;
                    label26.Visible = false;
                    textBox21.Visible = false;
                    textBox22.Visible = false;
                    textBox23.Visible = false;
                    textBox24.Visible = false;
                    textBox25.Visible = false;
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    textBox24.Text = "";
                    textBox25.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Цена' и 'Обьём памяти' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(label27.Visible!=true)
            {
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label31.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                goto Exit;
            }
            if (textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_Memory) FROM Memory;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO Memory (ID_Memory, Model_Memory, Interface_Memory, TypeMem_Memory, TotalMem_Memory, Price_Memory) VALUES ('" + NewID + "','" + textBox28.Text + "','" + textBox27.Text + "','" + textBox26.Text + "','" + textBox29.Text + "','" + textBox30.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_Memory();
                    label27.Visible = false;
                    label28.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label31.Visible = false;
                    textBox26.Visible = false;
                    textBox27.Visible = false;
                    textBox28.Visible = false;
                    textBox29.Visible = false;
                    textBox30.Visible = false;
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox28.Text = "";
                    textBox29.Text = "";
                    textBox30.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоля 'Цена' и 'Обьём памяти' могут принимать только целые числа!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(label32.Visible!=true)
            {
                label32.Visible = true;
                label33.Visible = true;
                label34.Visible = true;
                label35.Visible = true;
                label36.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                goto Exit;
            }
            if (textBox31.Text == "" || textBox32.Text == "" || textBox33.Text == "" || textBox34.Text == "" || textBox35.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();
                    Conn.Open();
                    sql.CommandText = "INSERT INTO Address (Country_Address, City_Address, Street_Address, NumHouse_Address, NumFlat_Address) VALUES ('" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox35.Text + "','" + textBox34.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_Address();
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    textBox31.Visible = false;
                    textBox32.Visible = false;
                    textBox33.Visible = false;
                    textBox34.Visible = false;
                    textBox35.Visible = false;
                    textBox31.Text = "";
                    textBox32.Text = "";
                    textBox33.Text = "";
                    textBox34.Text = "";
                    textBox35.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Возникла ошибка при добавлении записи, база данных 'OLD_DATA_BASE' используется другим процессом (приложением)!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if(label37.Visible!=true)
            {
                label37.Visible = true;
                label38.Visible = true;
                label39.Visible = true;
                label40.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                goto Exit;
            }
            if (textBox36.Text == "" || textBox37.Text == "" || textBox38.Text == "" || textBox39.Text == "" )
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                    SQLiteCommand sql = Conn.CreateCommand();

                    DataTable dt = new DataTable();
                    Conn.Open();
                    sql.CommandText = "SELECT max(ID_Seller) FROM Seller;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql);
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    da.Fill(dt);
                    string NewID = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    if (NewID == "")
                    {
                        NewID = "0";
                    }
                    int ConvertID = Convert.ToInt32(NewID) + 1;
                    NewID = ConvertID.ToString();

                    Conn.Open();
                    sql.CommandText = "INSERT INTO Seller (ID_Seller, Surname_Seller, Name_Seller, Patronymic_Seller, PersonalNum_Seller) VALUES ('" + NewID + "','" + textBox36.Text + "','" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "');";
                    sql.ExecuteNonQuery();
                    Conn.Close();
                    if (Messages == 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Update_Seller();
                    label37.Visible = false;
                    label38.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    textBox36.Visible = false;
                    textBox37.Visible = false;
                    textBox38.Visible = false;
                    textBox39.Visible = false;
                    textBox36.Text = "";
                    textBox37.Text = "";
                    textBox38.Text = "";
                    textBox39.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно заполнены поля!\nПоле 'Табельный номер' может принимать только целое число!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Exit:;
        }

        /*---------------------------------------------------------------UPDATES FORMS---------------------------------------------------------------*/

        void Update_CPU()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD1 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM CPU WHERE [ID_CPU] >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD1 = new SQLiteDataAdapter(sql);
                daUPD1.Fill(dtUPD1);
                dtUPD1.Columns["ID_CPU"].ColumnName = "№";
                dtUPD1.Columns["Model_CPU"].ColumnName = "Модель";
                dtUPD1.Columns["Socket_CPU"].ColumnName = "Тип сокета";
                dtUPD1.Columns["GHz_CPU"].ColumnName = "Частота, Ггц";
                dtUPD1.Columns["NumCores_CPU"].ColumnName = "Кол-во ядер";
                dtUPD1.Columns["Price_CPU"].ColumnName = "Цена, Р";
                dataGridView1.DataSource = dtUPD1;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 340;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 145;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 120;
                Conn.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_GPU()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD2 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM GPU WHERE [ID_GPU] >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD2 = new SQLiteDataAdapter(sql);
                daUPD2.Fill(dtUPD2);
                dtUPD2.Columns["ID_GPU"].ColumnName = "№";
                dtUPD2.Columns["Model_GPU"].ColumnName = "Модель";
                dtUPD2.Columns["TypeMemory_GPU"].ColumnName = "Тип памяти";
                dtUPD2.Columns["TotalMemory_GPU"].ColumnName = "Всего памяти, Гб";
                dtUPD2.Columns["Price_GPU"].ColumnName = "Цена, Р";
                dataGridView2.DataSource = dtUPD2;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Width = 385;
                dataGridView2.Columns[2].Width = 165;
                dataGridView2.Columns[3].Width = 185;
                dataGridView2.Columns[4].Width = 160;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_Case()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD3 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM [Case] WHERE [ID_Case] >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD3 = new SQLiteDataAdapter(sql);
                daUPD3.Fill(dtUPD3);
                dtUPD3.Columns["ID_Case"].ColumnName = "№";
                dtUPD3.Columns["Model_Case"].ColumnName = "Модель";
                dtUPD3.Columns["Color_Case"].ColumnName = "Цвет";
                dtUPD3.Columns["Price_Case"].ColumnName = "Цена, Р";
                dataGridView3.DataSource = dtUPD3;
                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[1].Width = 500;
                dataGridView3.Columns[2].Width = 200;
                dataGridView3.Columns[3].Width = 195;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_PowerBlock()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD4 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM PowerBlock WHERE ID_PowerBlock >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD4 = new SQLiteDataAdapter(sql);
                daUPD4.Fill(dtUPD4);
                dtUPD4.Columns["ID_PowerBlock"].ColumnName = "№";
                dtUPD4.Columns["Model_PowerBlock"].ColumnName = "Модель";
                dtUPD4.Columns["Voltage_PowerBlock"].ColumnName = "Мощность";
                dtUPD4.Columns["Price_PowerBlock"].ColumnName = "Цена, Р";
                dataGridView4.DataSource = dtUPD4;
                dataGridView4.Columns[0].Visible = false;
                dataGridView4.Columns[1].Width = 500;
                dataGridView4.Columns[2].Width = 200;
                dataGridView4.Columns[3].Width = 195;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView4.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
             
        }
        void Update_Cooling()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD5 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Cooling WHERE ID_Cooling >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD4 = new SQLiteDataAdapter(sql);
                daUPD4.Fill(dtUPD5);
                dtUPD5.Columns["ID_Cooling"].ColumnName = "№";
                dtUPD5.Columns["Model_Cooling"].ColumnName = "Модель";
                dtUPD5.Columns["Price_Cooling"].ColumnName = "Цена, Р";
                dataGridView5.Columns[0].Visible = false;
                dataGridView5.Columns[1].Width = 600;
                dataGridView5.Columns[2].Width = 295;
                dataGridView5.DataSource = dtUPD5;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView5.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_Motherboard()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD6 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Motherboard WHERE ID_Motherboard >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD6 = new SQLiteDataAdapter(sql);
                daUPD6.Fill(dtUPD6);
                dtUPD6.Columns["ID_Motherboard"].ColumnName = "№";
                dtUPD6.Columns["Model_Motherboard"].ColumnName = "Модель";
                dtUPD6.Columns["Socket_Motherboard"].ColumnName = "Сокет";
                dtUPD6.Columns["Price_Motherboard"].ColumnName = "Цена, Р";
                dataGridView6.DataSource = dtUPD6;
                dataGridView6.Columns[0].Visible = false;
                dataGridView6.Columns[1].Width = 500;
                dataGridView6.Columns[2].Width = 200;
                dataGridView6.Columns[3].Width = 195;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView6.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_RAM()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD7 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM RAM WHERE ID_RAM >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD7 = new SQLiteDataAdapter(sql);
                daUPD7.Fill(dtUPD7);
                dtUPD7.Columns["ID_RAM"].ColumnName = "№";
                dtUPD7.Columns["Model_RAM"].ColumnName = "Модель";
                dtUPD7.Columns["Interface_RAM"].ColumnName = "Интерфейс";
                dtUPD7.Columns["TypeMemory_RAM"].ColumnName = "Тип памяти";
                dtUPD7.Columns["TotalMemory_RAM"].ColumnName = "Всего памяти, Гб";
                dtUPD7.Columns["Price_RAM"].ColumnName = "Цена, Р";
                dataGridView7.DataSource = dtUPD7;
                dataGridView7.Columns[0].Visible = false;
                dataGridView7.Columns[1].Width = 310;
                dataGridView7.Columns[2].Width = 135;
                dataGridView7.Columns[3].Width = 140;
                dataGridView7.Columns[4].Width = 180;
                dataGridView7.Columns[5].Width = 130;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView7.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_Memory()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD8 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Memory WHERE ID_Memory >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD8 = new SQLiteDataAdapter(sql);
                daUPD8.Fill(dtUPD8);
                dtUPD8.Columns["ID_Memory"].ColumnName = "№";
                dtUPD8.Columns["Model_Memory"].ColumnName = "Модель";
                dtUPD8.Columns["Interface_Memory"].ColumnName = "Интерфейс";
                dtUPD8.Columns["TypeMem_Memory"].ColumnName = "Тип памяти";
                dtUPD8.Columns["TotalMem_Memory"].ColumnName = "Всего памяти, Гб";
                dtUPD8.Columns["Price_Memory"].ColumnName = "Цена, Р";
                dataGridView8.DataSource = dtUPD8;
                dataGridView8.Columns[0].Visible = false;
                dataGridView8.Columns[1].Width = 310;
                dataGridView8.Columns[2].Width = 135;
                dataGridView8.Columns[3].Width = 140;
                dataGridView8.Columns[4].Width = 180;
                dataGridView8.Columns[5].Width = 130;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView8.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_Address()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD11 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT ID_Address, Country_Address, City_Address, Street_Address, NumHouse_Address, NumFlat_Address FROM Address WHERE ID_Address >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD11 = new SQLiteDataAdapter(sql);
                daUPD11.Fill(dtUPD11);
                dtUPD11.Columns["ID_Address"].ColumnName = "№";
                dtUPD11.Columns["Country_Address"].ColumnName = "Страна";
                dtUPD11.Columns["City_Address"].ColumnName = "Город";
                dtUPD11.Columns["Street_Address"].ColumnName = "Улица";
                dtUPD11.Columns["NumHouse_Address"].ColumnName = "Номер дома";
                dtUPD11.Columns["NumFlat_Address"].ColumnName = "Номер квартиры";
                dataGridView11.DataSource = dtUPD11;
                dataGridView11.Columns[0].Visible = false;
                dataGridView11.Columns[1].Width = 200;
                dataGridView11.Columns[2].Width = 170;
                dataGridView11.Columns[3].Width = 200;
                dataGridView11.Columns[4].Width = 160;
                dataGridView11.Columns[5].Width = 165;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView11.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_Seller()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD12 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT * FROM Seller WHERE ID_Seller >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD12 = new SQLiteDataAdapter(sql);
                daUPD12.Fill(dtUPD12);
                dtUPD12.Columns["ID_Seller"].ColumnName = "№";
                dtUPD12.Columns["Surname_Seller"].ColumnName = "Фамилия";
                dtUPD12.Columns["Name_Seller"].ColumnName = "Имя";
                dtUPD12.Columns["Patronymic_Seller"].ColumnName = "Отчество";
                dtUPD12.Columns["PersonalNum_Seller"].ColumnName = "Табельный номер";
                dataGridView12.DataSource = dtUPD12;
                dataGridView12.Columns[0].Visible = false;
                dataGridView12.Columns[1].Width = 225;
                dataGridView12.Columns[2].Width = 225;
                dataGridView12.Columns[3].Width = 225;
                dataGridView12.Columns[4].Width = 220;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dataGridView12.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void Update_Client()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD13 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT ID_Client, Surname_Client, Name_Client, Patronumic_Client, NumberTel_Client, NumberCart_Client, (SELECT City_Address FROM Address WHERE ID_Address = Client.ID_Client) AS Город FROM Client WHERE ID_Client >" + 0 + ";";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD13 = new SQLiteDataAdapter(sql);
                daUPD13.Fill(dtUPD13);
                dtUPD13.Columns["ID_Client"].ColumnName = "№";
                dtUPD13.Columns["Surname_Client"].ColumnName = "Фамилия";
                dtUPD13.Columns["Name_Client"].ColumnName = "Имя";
                dtUPD13.Columns["Patronumic_Client"].ColumnName = "Отчество";
                dtUPD13.Columns["NumberTel_Client"].ColumnName = "Номер телефона";
                dtUPD13.Columns["NumberCart_Client"].ColumnName = "Номер карты";
                dataGridView9.DataSource = dtUPD13;
                dataGridView9.Columns[0].Visible = false;
                dataGridView9.Columns[1].Width = 150;
                dataGridView9.Columns[2].Width = 150;
                dataGridView9.Columns[3].Width = 197;
                dataGridView9.Columns[4].Width = 160;
                dataGridView9.Columns[5].Width = 138;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Update_Order()
        {
            try
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source='DATA_BASE.db'; Password='2033database';");
                SQLiteCommand sql = Conn.CreateCommand();
                DataTable dtUPD14 = new DataTable();
                Conn.Open();
                sql.CommandText = "SELECT ID_Order, (SELECT Model_Motherboard FROM Motherboard WHERE ID_Motherboard = [Order].ID_MotherboardO) AS ID_MotherboardO, (SELECT Model_GPU FROM GPU WHERE ID_GPU = [Order].ID_GPUO) AS ID_GPUO, (SELECT Model_PowerBlock FROM PowerBlock WHERE ID_PowerBlock = [Order].ID_PowerBlockO) AS ID_PowerBlockO, (SELECT Model_Cooling FROM Cooling WHERE ID_Cooling = [Order].ID_CoolingO) AS ID_CoolingO, (SELECT Model_CPU FROM CPU WHERE ID_CPU = [Order].ID_CPUO) AS ID_CPUO, (SELECT Model_Case FROM [Case] WHERE ID_Case = [Order].ID_CaseO) AS ID_CaseO, (SELECT Model_RAM FROM RAM WHERE ID_RAM = [Order].ID_RAMO) AS ID_RAMO, (SELECT Model_Memory FROM Memory WHERE ID_Memory = [Order].ID_MemoryO) AS ID_MemoryO, (SELECT Surname_Client FROM Client WHERE ID_Client = [Order].ID_ClientSurname) AS ID_ClientSurname, (SELECT Name_Client FROM Client WHERE ID_Client = [Order].ID_ClientName) AS ID_ClientName, (SELECT Surname_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerSurname) AS ID_SellerSurname, (SELECT Name_Seller FROM Seller WHERE ID_Seller = [Order].ID_SellerName) AS ID_SellerName, TotalPrice_OrderO FROM [Order];";
                sql.ExecuteNonQuery();
                SQLiteDataAdapter daUPD13 = new SQLiteDataAdapter(sql);
                daUPD13.Fill(dtUPD14);
                dtUPD14.Columns["ID_Order"].ColumnName = "№";
                dtUPD14.Columns["ID_MotherboardO"].ColumnName = "Мат. плата";
                dtUPD14.Columns["ID_GPUO"].ColumnName = "GPU";
                dtUPD14.Columns["ID_PowerBlockO"].ColumnName = "Блок питания";
                dtUPD14.Columns["ID_CoolingO"].ColumnName = "Система охлажд.";
                dtUPD14.Columns["ID_CPUO"].ColumnName = "CPU";
                dtUPD14.Columns["ID_CaseO"].ColumnName = "Корпус";
                dtUPD14.Columns["ID_RAMO"].ColumnName = "RAM";
                dtUPD14.Columns["ID_MemoryO"].ColumnName = "SSD/HDD";
                dtUPD14.Columns["ID_ClientSurname"].ColumnName = "Фамилия клиента";
                dtUPD14.Columns["ID_ClientName"].ColumnName = "Имя клиента";
                dtUPD14.Columns["ID_SellerSurname"].ColumnName = "Фамилия продавца";
                dtUPD14.Columns["ID_SellerName"].ColumnName = "Имя продавца";
                dtUPD14.Columns["TotalPrice_OrderO"].ColumnName = "Цена всего, Р";
                dataGridView10.DataSource = dtUPD14;
                dataGridView10.Columns[1].Width = 55;
                dataGridView10.Columns[2].Width = 40;
                dataGridView10.Columns[3].Width = 75;
                dataGridView10.Columns[4].Width = 70;
                dataGridView10.Columns[5].Width = 40;
                dataGridView10.Columns[6].Width = 65;
                dataGridView10.Columns[7].Width = 45;
                dataGridView10.Columns[8].Width = 75;
                dataGridView10.Columns[9].Width = 85;
                dataGridView10.Columns[10].Width = 80;
                dataGridView10.Columns[11].Width = 85;
                dataGridView10.Columns[12].Width = 85;
                dataGridView10.Columns[13].Width = 95;
                dataGridView10.Columns[0].Visible = false;
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("База данных 'DATA_BASE.db' не найдена или используется другим процессом (приложением) в данный момент.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
