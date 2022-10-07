using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class FormAmbul : Form
    {
        MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);
        private int key,num_card;
        public FormAmbul()
        {
            InitializeComponent();
            day_obr.Text = DateTime.Now.Day.ToString();
            month_obr.Text = DateTime.Now.Month.ToString();
            year_obr.Text = DateTime.Now.Year.ToString();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Forms.FormSearch form = new Forms.FormSearch();
            form.Show();
        }

        private void FormAmbul_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Prinyat2_Click_1(object sender, EventArgs e)
        {
            if (dataamb.Visible == true)
            {
                try
                {

                        Const.Const.openConnection(connection);
                        string ishod = "";
                        if (amb_gospit.Checked == true)
                        {
                            ishod += "Госпитализирован. ";
                            if (checkBox1.Checked)
                            {
                                ishod += "Наитяжелейшая степень. ";
                            }
                            else
                            {
                                if (checkBox2.Checked)
                                {
                                    ishod += "Тяжелая степень. ";
                                }
                                else
                                {
                                    ishod += "Легкая степень. ";
                                }
                            }


                        }
                        else
                        {
                            if (amb_end_box.Checked == true)
                            {
                                ishod += "Конец лечения. ";
                            }
                        }
                        if (ishod_com.Text != " ")
                        {
                            ishod += ishod_com.Text;
                        }
                        string date_obr = year_obr.Text + "-" + month_obr.Text + "-" + day_obr.Text;

                        string date_next_obr = null;
                        if (year_next.Text != "" && month_next.Text != "" && day_next.Text != "")
                        {
                            date_next_obr = year_next.Text + "-" + month_next.Text + "-" + day_next.Text;
                        }

                        MySqlCommand command = new MySqlCommand("UPDATE hotel.`posechenie` SET " +
                            "`Явка`= @iavka, `Дата`= @data, `Состояние`= @sost, `Лечение`= @lech, `Исход`= @ishod, `След_посещение`= @sleddat,`МКБ`= @mkb WHERE `Ключ`=@key ", Const.Const.getConnection(connection));
                        command.Parameters.Add("@iavka", MySqlDbType.Int32).Value = 1;
                        command.Parameters.Add("@data", MySqlDbType.Date).Value = date_obr;
                        command.Parameters.Add("@sost", MySqlDbType.VarChar).Value = amb_ran_diag.Text;
                        command.Parameters.Add("@ishod", MySqlDbType.VarChar).Value = ishod;
                        command.Parameters.Add("@sleddat", MySqlDbType.Date).Value = date_next_obr;
                        command.Parameters.Add("@mkb", MySqlDbType.VarChar).Value = amb_ran_mkb.Text;
                        command.Parameters.Add("@lech", MySqlDbType.VarChar).Value = amb_lech.Text;
                        command.Parameters.Add("@key", MySqlDbType.Int32).Value = key;

                        command.ExecuteNonQuery().ToString();
                        
                        Const.Const.closeConnection(connection);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (amb_f_osm.Checked == true)
                    {
                        Const.Const.openConnection(connection);
                        string ishod = "";
                        if (amb_gospit.Checked == true)
                        {
                            ishod += "Госпитализирован. ";
                            if (checkBox1.Checked)
                            {
                                ishod += "Наитяжелейшая степень. ";
                            }
                            else{
                                if (checkBox2.Checked)
                                {
                                    ishod += "Тяжелая степень. ";
                                }
                                else
                                {
                                    ishod += "Легкая степень. ";
                                }
                            }


                        }
                        else
                        {
                            if (amb_end_box.Checked == true)
                            {
                                ishod += "Конец лечения. ";
                            }
                        }
                        if (ishod_com.Text != " ")
                        {
                            ishod += ishod_com.Text;
                        }
                        string date_obr = year_obr.Text + "-" + month_obr.Text + "-" + day_obr.Text;

                        string date_next_obr = null;
                        if (year_next.Text != "" && month_next.Text != "" && day_next.Text != "")
                        {
                            date_next_obr = year_next.Text + "-" + month_next.Text + "-" + day_next.Text;
                        }

                        MySqlCommand command = new MySqlCommand("INSERT INTO `posechenie`" +
                            "(`Номер_карточки`, `Явка`, `Дата`, `Состояние`, `Лечение`, `Исход`, `След_посещение`,`МКБ`) VALUES" +
                             "('" + Const.IspolzData.num_card + "', '0', '" + date_obr + "', '" + amb_ran_diag.Text + "', '" + amb_lech.Text +
                             "', '" + ishod + "', '" + date_next_obr + "', '" + amb_ran_mkb.Text + "')", connection);
                        command.ExecuteNonQuery().ToString();

                        command = new MySqlCommand("INSERT INTO `kartochka_bolezney`" +
                            "( `Номер_карточки`, `МКБ`, `Диагноз`, `Дата_постановки`, `Дата_снятия`)" +
                            " VALUES ('" + Const.IspolzData.num_card + "', '" + amb_ran_mkb.Text + "', '" + amb_ran_diag.Text + "', '" + date_obr + "', '" + date_next_obr + "')", connection);
                        command.ExecuteNonQuery().ToString();


                        Const.Const.closeConnection(connection);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (amb_gospit.Checked == true)
                {
                    Class1_Incriment.Class1 cl = new Class1_Incriment.Class1();
                    int razn = (DateTime.Now - Convert.ToDateTime(FromPC.Findpeople.day_rojd)).Days;
                    cl.inc_for_hospit(razn, FromPC.Findpeople.berem == "1" ? true : false, false, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, "" + DateTime.Now); ;
                }
            }
            Const.Const.openConnection(connection);
            MySqlDataAdapter adapter = null;
            DataTable table = null;
            adapter = new MySqlDataAdapter("SELECT * FROM hotel.posechenie WHERE Номер_карточки = " + Const.IspolzData.num_card + " ", Const.Const.getConnection(connection));
            table = new DataTable();
            adapter.Fill(table);
            dataamb.DataSource = table;
        }

        private void amb_gospit_CheckedChanged(object sender, EventArgs e)
        {
            if(amb_gospit.Checked == true)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRowCount = dataamb.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && dataamb[0, dataamb.SelectedRows[0].Index].Value.ToString() != "")
            {
                key = Convert.ToInt32(dataamb[0, dataamb.SelectedRows[0].Index].Value.ToString());
                num_card = Convert.ToInt32(dataamb[1, dataamb.SelectedRows[0].Index].Value.ToString());
                string date0 = dataamb[3, dataamb.SelectedRows[0].Index].Value.ToString();
                string[] date = date0.Split('.');
                d1.Text = ""+date[0];
                m1.Text = "" + date[1];
                y1.Text = "" + date[2];
                amb_ran_diag.Text = dataamb[4, dataamb.SelectedRows[0].Index].Value.ToString();
                amb_lech.Text= dataamb[5, dataamb.SelectedRows[0].Index].Value.ToString();
                amb_ran_mkb.Text = dataamb[8, dataamb.SelectedRows[0].Index].Value.ToString();

            }

        }

        private void amb_f_osm_CheckedChanged(object sender, EventArgs e)
        {
            dataamb.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void day_obr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void month_obr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void year_obr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void d1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void m1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void day_next_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void month_next_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void year_next_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void day_obr_TextChanged(object sender, EventArgs e)
        {
            if (day_obr.TextLength == 2)
            {
                month_obr.Focus();
            }
            else if (day_obr.TextLength > 2)
            {
                day_obr.Text = "";
            }
        }

        private void d1_TextChanged(object sender, EventArgs e)
        {
            if (d1.TextLength == 2)
            {
                m1.Focus();
            }
            else if (d1.TextLength > 2)
            {
                d1.Text = "";
            }
        }

        private void day_next_TextChanged(object sender, EventArgs e)
        {
            if (day_next.TextLength == 2)
            {
                month_next.Focus();
            }
            else if (day_next.TextLength > 2)
            {
                day_next.Text = "";
            }
        }

        private void month_obr_TextChanged(object sender, EventArgs e)
        {
            if (month_obr.TextLength == 2)
            {
                year_obr.Focus();
            }
            else if (month_obr.TextLength > 2)
            {
                month_obr.Text = "";
            }
        }

        private void m1_TextChanged(object sender, EventArgs e)
        {
            if (m1.TextLength == 2)
            {
                y1.Focus();
            }
            else if (m1.TextLength > 2)
            {
                m1.Text = "";
            }
        }

        private void month_next_TextChanged(object sender, EventArgs e)
        {
            if (month_next.TextLength == 2)
            {
                year_next.Focus();
            }
            else if (month_next.TextLength > 2)
            {
                month_next.Text = "";
            }
        }

        private void year_obr_TextChanged(object sender, EventArgs e)
        {
            if (year_obr.TextLength > 4)
            {
                year_obr.Text = "";
            }
        }

        private void y1_TextChanged(object sender, EventArgs e)
        {
            if (y1.TextLength > 4)
            {
                y1.Text = "";
            }
        }

        private void year_next_TextChanged(object sender, EventArgs e)
        {
            if (year_next.TextLength > 4)
            {
                year_next.Text = "";
            }
        }

        private void amb_end_box_CheckedChanged(object sender, EventArgs e)
        {
            if (amb_end_box.Checked)
            {
                label13.Visible = false;
                label19.Visible = false;
                label18.Visible = false;
                label17.Visible = false;
                day_next.Text = "";
                month_next.Text = "";
                year_next.Text = "";
                day_next.Visible = false;
                month_next.Visible = false;
                year_next.Visible = false;
            }
            else
            {
                label13.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                day_next.Visible = true;
                month_next.Visible = true;
                year_next.Visible = true;
            }


        }

        private void s_osm_CheckedChanged(object sender, EventArgs e)
        {
            if (s_osm.Checked == true)
            {
                dataamb.Visible = true;
                Const.Const.openConnection(connection);
                MySqlDataAdapter adapter = null;
                DataTable table = null;
                adapter = new MySqlDataAdapter("SELECT * FROM hotel.posechenie WHERE Номер_карточки = " + Const.IspolzData.num_card + " ", Const.Const.getConnection(connection));
                table = new DataTable();
                adapter.Fill(table);
                dataamb.DataSource = table;
            }
        }
    }
}
