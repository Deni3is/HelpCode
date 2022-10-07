using Hotel.Dock_helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=1234;database=hotel");

        MySqlDataAdapter adapter = null;

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
        public MySqlConnection getConnection()
        {
            return connection;
        }

        private DataTable table = null;
        private DataTable table1 = null;
        private DataTable table2 = null;
        private DataTable table3 = null;
        private DataTable table4 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openConnection();
            //
            adapter = new MySqlDataAdapter("SELECT * FROM Osnovnye_svedeniya_o_postupivshih", getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //
            adapter = new MySqlDataAdapter("SELECT * FROM svodnaya_tablica_po_razmeshcheniyu_pribyvshih", getConnection());
            table1 = new DataTable();
            adapter.Fill(table1);
            dataGridView2.DataSource = table1;
            //
            adapter = new MySqlDataAdapter("SELECT * FROM svedeniya_o_vakcinacii_pribyvshih", getConnection());
            table2 = new DataTable();
            adapter.Fill(table2);
            dataGridView3.DataSource = table2;
            //
            adapter = new MySqlDataAdapter("SELECT * FROM svedeniya_o_gospitalizacii_pribyvshih", getConnection());
            table3 = new DataTable();
            adapter.Fill(table3);
            dataGridView4.DataSource = table3;
            //
            adapter = new MySqlDataAdapter("SELECT * FROM informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan", getConnection());
            table4 = new DataTable();
            adapter.Fill(table4);
            dataGridView5.DataSource = table4;
            closeConnection();
        }
        //кнопка на 1ой форме добавление человека в таблицу "основные сведения о поступивших"
        private void enter_clck(object sender, EventArgs e)
        {
            Class1_Incriment.Class1 ci = new Class1_Incriment.Class1();
            Init init = new Init();
            if(name.Text!=""&& surname.Text != "" && age.Text != "" && (m.Checked || j.Checked)&& room.Text!="" && num_card.Text != "")
            {
                if (month.Text == "" || day.Text == "")
                {
                    month.Text = ""+DateTime.Now.Month;
                    day.Text = "" + DateTime.Now.Day;
                }
                int sex=0;
                if (m.Checked)
                {
                    sex = 1;
                }
                if (rodov.Text == "")
                {
                    rodov.Text = "0";
                }
                if (rojd_det.Text == "")
                {
                    rojd_det.Text = "0";
                }
                if (sex == 1)
                {
                    rodov.Text = "0";
                    rojd_det.Text = "0";
                    berem.Checked = false;
                }
                
                init.init_first(name.Text, surname.Text, patronimic.Text, Convert.ToInt32(age.Text),sex,berem.Checked, 
                    Convert.ToInt32(rodov.Text), Convert.ToInt32(rojd_det.Text),
                     Convert.ToInt32(room.Text), Convert.ToInt32(month.Text), Convert.ToInt32(day.Text), ogr_vozm.Checked,num_card.Text,bezjnc.Checked ?1:0);

                ci.incriment_for_Razm_prib(berem.Checked, Convert.ToInt32(age.Text), Convert.ToInt32(rodov.Text), Convert.ToInt32(rojd_det.Text),
                    ogr_vozm.Checked,false,DateTime.Now,true,false,false);
                name.Text = "";
                surname.Text = "";
                patronimic.Text = "";
                age.Text = "";
                m.Checked = false;
                j.Checked = false;
                berem.Checked = false;
                rodov.Text = "";
                rojd_det.Text = "";

                room.Text = "";
                month.Text = "";
                day.Text = "";
                ogr_vozm.Checked = false;
            }
            else
            {
                MessageBox.Show("Заполните поля : имя, фамилия, отчество , количество полных лет, номер комнаты и выберите пол, а также введите номер карточки");
            }


        }

        private void table1_finddate(object sender, EventArgs e)
        {
            if (t1.Text != "" && t2.Text != "")
            {
                openConnection();
                string adept = "SELECT* FROM hotel.osnovnye_svedeniya_o_postupivshih where Дата_поступления = '" + 2022 + "-" + Convert.ToInt64(t1.Text) + "-" + Convert.ToInt64(t2.Text) + "'";
                adapter = new MySqlDataAdapter(adept, getConnection());
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                closeConnection();
            }
            else
            {
                MessageBox.Show("Заполните поля :день и месяц");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var helper = new Word_Helper("test.docx");

            var items = new Dictionary<string, string>
            {
                { "{фамилия}", "Миронов"},
                { "{комната}", "12"},
                { "{имя_отчество}", "Савва Никитич" },
                { "{дата_поступления}", "02.03.2022"},
                { "{возраст}", "18" },
                { "{гражданин_РФ}", "1" },
                { "{беременность}", "0" },
                { "{родов}", "0"},
                { "{рожденных_детей}", "0"},
                { "{детей}", "1"},
                { "{детей_до_1_года}", "0"},
                {"{ограничения}", "0"},
                {"{обращение_за_мед_помощью}", "0"},
                {"{вакцинирован}", "0"},
                {"{на_карантине}", "0"},
                {"{иммунопрофилактика}", "0"},
                {"{госпитализирован}", "0"},
                {"{легкая_степень}", "0"},
                {"{средняя_степень}", "0"},
                {"{тяжелая_степень}", "0"},
                {"{крайне_тяжелая_степень}", "0"},
                {"{обследованный}", "0"},
                {"{туберкулёз}", "0"},
                {"{вич-инфекция}", "0"},
                {"{иппп}", "0"},
                {"{сахарный_диабет}", "0"},
                {"{болезни_системы_кровообращения}", "0"},
                {"{гепатит_B_C}", "0"},
                {"{онкологические_заболевания}", "0"},
                {"{психические_расстройства}", "0"},
                {"{прочие_аболевания}", "0"},
            };

            helper.Process(items);
        }

        //Страница Госпиталь
        private void find1(object sender, EventArgs e)
        {
            panelSost.BackColor = System.Drawing.Color.Green;
        }

        private void Prinyat2_Click(object sender, EventArgs e)
        {
            Init init = new Init();
            init.init_second(num_find1.Text,imun.Checked ? 1 : 0, vacin.Checked ? 1 : 0, karan.Checked ? 1 : 0, so_bad.Checked ? 1 : 0,
                bad.Checked ? 1 : 0, sred.Checked ? 1 : 0, ez.Checked ? 1 : 0,rana.Checked ? 1 : 0);
            //Очистка
            num_find1.Text = "";
            imun.Checked =false;
            vacin.Checked = false;
            karan.Checked = false;
            so_bad.Checked = false;
            bad.Checked = false;
            sred.Checked = false;
            ez.Checked = false;
            rana.Checked = false;
        }
        //Страница Обследование
        private void Prinyat3_Click(object sender, EventArgs e)
        {
            Class1_Incriment.Class1 ci = new Class1_Incriment.Class1();
            Init init = new Init();

            init.init_third(1,tub.Checked?1:0,vich.Checked ? 1 : 0, ippp.Checked ? 1 : 0, sahdiab.Checked ? 1 : 0,
                krov.Checked ? 1 : 0, gepatit.Checked ? 1 : 0, oncolog.Checked ? 1 : 0, psih.Checked ? 1 : 0, other.Checked ? 1 : 0, other_zab.Text,find_card2.Text);
            //Очистка
            tub.Checked = false;
            vich.Checked = false;
            ippp.Checked = false;
            sahdiab.Checked = false;
            gepatit.Checked = false;
            oncolog.Checked = false;
            psih.Checked = false;
            krov.Checked = false;
            other.Checked = false;
            other_zab.Text = "";
            find_card2.Text = "";
        }

        private void Tablicacreate_Click(object sender, EventArgs e)
        {
            Dock_helper.Word_Helper work = new Word_Helper("tost.docx");
            string[] str = new string[Convert.ToInt32(num_polei.Text)];
            for (int i = 0; i < Convert.ToInt32(num_polei.Text); i++) {
                 str[i]= comb[i].Text;
            }

            int[] key = {6,5};// 
            work.Table("hotel.osnovnye_svedeniya_o_postupivshih",str,key);//
        }
        private ComboBox[] comb;

        private void Col_vo_Combov(object sender, EventArgs e)
        {
            
            if (num_polei.Text != "")
            {
                comb = new ComboBox[Convert.ToInt32(num_polei.Text)];
                for (int i = 0; i < Convert.ToInt32(num_polei.Text); i++)
                {
                    comb[i] = new ComboBox(){Name = "comb_" + i, Location = new System.Drawing.Point(19, 65 + i * 30), Width = 121, Height = 21 };
                    tabPage7.Controls.Add(comb[i]);

                }
                for(int i = 0; i < Convert.ToInt32(num_polei.Text); i++)
                {
                    comb[i].Items.Add("Имя_отчество");
                    comb[i].Items.Add("Фамилия");
                    comb[i].Items.Add("Комната");
                    comb[i].Items.Add("Дата_поступления");

                }
            }
            else
            {
                MessageBox.Show("Введите количество полей");
            }
        }
    }
}
