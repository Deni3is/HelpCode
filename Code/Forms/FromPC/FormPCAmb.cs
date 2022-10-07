using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Forms.FromPC
{
    public partial class FormPCAmb : Form
    {
        public FormPCAmb()
        {
            InitializeComponent();
        }

        private void FormPCAmb_Load(object sender, EventArgs e)
        {
            Const.Const.openConnection();
            string adept = "SELECT МКБ, Диагноз, Дата_постановки,Дата_снятия FROM hotel.kartochka_bolezney where Номер_карточки ='" + Forms.FromPC.Findpeople.num_card + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(adept, Const.Const.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            History_bolezn.DataSource = table;
            Const.Const.closeConnection();
            //Заполнение данных
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPC form = new FormPC();
            form.Show();
            Hide();
        }

        private void FormPCAmb_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
