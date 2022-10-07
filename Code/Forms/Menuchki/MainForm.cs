using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {




            InitializeComponent();
            Const.Const.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT hotel.posechenie.Номер_карточки,hotel.patient.Фамилия,hotel.patient.Имя, hotel.patient.Отчество FROM hotel.posechenie,hotel.patient WHERE patient.Номер_карточки = posechenie.Номер_карточки AND " +
                "След_посещение = '" + DateTime.Now.Year+ "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "'", Const.Const.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            Const.Const.closeConnection();

        }
        //Добавление записи
        private void dobavlenie_butn(object sender, EventArgs e)
        {
            this.Hide();
            Dobavlenie.FormDobavlenie form2 = new Dobavlenie.FormDobavlenie();
            form2.Show();
        }
        //Поиск 
        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.FormSearch form1 = new Forms.FormSearch();
            form1.Show();
        }
        //Работа с доками
        private void butn_dock(object sender, EventArgs e)
        {

            this.Hide();
            Work_Dock.FormDocum form1 = new Work_Dock.FormDocum();
            form1.Show();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dobavlenie.Init elem = new Dobavlenie.Init();
            elem.NewDayInPVR("г.Волжский", "Больница Им. Фишера");
        }
    }
}
