using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();

            try
            {
                Const.Const.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Фамилия,Имя,Отчество,Ключ,Номер_комнаты ,Дата_рождения,Номер_карточки,Беременность FROM hotel.patient;", Const.Const.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                data_obschee.DataSource = table;
                Const.Const.closeConnection();
            }
            catch
            {
                MessageBox.Show("Проблемы с БД");
            }
            if (Const.IspolzData.surname != null)
            {
                famil.Text = Const.IspolzData.surname;
                name.Text = Const.IspolzData.name;
                otchestvo.Text = Const.IspolzData.otchestvo;

                if (Const.IspolzData.num_card =="")
                {
                    obs.Enabled = true;
                    amb.Enabled = false;
                    pc.Enabled = false;
                    Const.IspolzData.obsledovan = false;
                }
                else
                {
                    obs.Enabled = true;
                    amb.Enabled = true;
                    pc.Enabled = true;
                    Const.IspolzData.obsledovan = true;

                }
            }

        }



        //
        private void amb_Click(object sender, EventArgs e)
        {
            Const.IspolzData.numkeypeople = otchestvo.Text;
            this.Hide();
            Forms.FormAmbul form1 = new Forms.FormAmbul();
            form1.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            Hide();
        }

        private void pc_Click(object sender, EventArgs e)
        {

            try
            {

                FromPC.Findpeople.famil = data_obschee[0, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.Findpeople.name = data_obschee[1, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.Findpeople.otchestvo = data_obschee[2, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.Findpeople.key = Convert.ToInt32(data_obschee[3, data_obschee.SelectedRows[0].Index].Value.ToString());
                FromPC.Findpeople.berem = data_obschee[7, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.Findpeople.day_rojd = data_obschee[5, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.FormPC formPC = new Forms.FromPC.FormPC();
                formPC.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Нажмите на первый столбец выбранного пациента");
            }

        }

        private void obs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormObsledovanie form = new FormObsledovanie();
            form.Show();



        }



        private void data_obschee_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = data_obschee.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && data_obschee[0, data_obschee.SelectedRows[0].Index].Value.ToString()!="")
            {
                famil.Text = data_obschee[0, data_obschee.SelectedRows[0].Index].Value.ToString();
                name.Text = data_obschee[1, data_obschee.SelectedRows[0].Index].Value.ToString();
                otchestvo.Text = data_obschee[2, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.Findpeople.key = Convert.ToInt32(data_obschee[3, data_obschee.SelectedRows[0].Index].Value.ToString());
                Const.IspolzData.num_card = data_obschee[6, data_obschee.SelectedRows[0].Index].Value.ToString();


                Const.IspolzData.surname = famil.Text;
                Const.IspolzData.name = name.Text;
                Const.IspolzData.otchestvo = otchestvo.Text;
                FromPC.Findpeople.berem = data_obschee[7, data_obschee.SelectedRows[0].Index].Value.ToString();
                FromPC.Findpeople.day_rojd= data_obschee[5, data_obschee.SelectedRows[0].Index].Value.ToString();

                if (data_obschee[6, data_obschee.SelectedRows[0].Index].Value.ToString() == "")
                {
                    obs.Enabled = true;
                    amb.Enabled = false;
                    pc.Enabled = false;
                    Const.IspolzData.obsledovan = false;
                }
                else
                {
                    obs.Enabled = true;
                    amb.Enabled = true;
                    pc.Enabled = true;
                    Const.IspolzData.obsledovan = true;

                }

            }
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

   

        private void find_famil_TextChanged(object sender, EventArgs e)
        {
            findPeople();
        }

        private void find_name_TextChanged(object sender, EventArgs e)
        {
            findPeople();
        }

        private void find_surname_TextChanged(object sender, EventArgs e)
        {
            findPeople();
        }
        private void findPeople()
        {
            Const.Const.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Фамилия,Имя,Отчество,Ключ,Номер_комнаты ,Дата_рождения,Номер_карточки,Беременность FROM hotel.patient WHERE Фамилия LIKE '" + find_famil.Text + "%' AND Имя LIKE '" + find_name.Text + "%' AND Отчество LIKE '" + find_surname.Text + "%'", Const.Const.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            data_obschee.DataSource = table;
            Const.Const.closeConnection();
        }


    }
}
