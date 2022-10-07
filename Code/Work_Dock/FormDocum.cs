using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Work_Dock
{
    public partial class FormDocum : Form
    {
        MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);

        public FormDocum()
        {
            InitializeComponent();
            day.Text = dat.day1;
            month.Text = dat.month1;
            year.Text = dat.year1;
            dayEnd.Text = dat.day2;
            monthEnd.Text = dat.month2;
            yearEnd.Text = dat.year2;
            
        }
        private ComboBox[] comb;
        private string vibor = null;
        private string keyName = null; //добавлено, так как в одной из таблиц ключевое поле называется не "Ключ"
        private string dateName = null; // так же как и выше
        private bool truebutton = false; //если количество полей подтверждено кнопкой, то больше они создаваться не могут
        private void button9_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            Const.Const.openConnection(connection);
            if (truebutton == true)
                return;

            if (rB1.Checked)
            {
                dateName = "Дата_поступления_в_ПВР";
                keyName = "Ключ";
                vibor = "hotel.patient";
                MySqlCommand command = new MySqlCommand("SELECT COLUMN_NAME from information_schema.COLUMNS WHERE TABLE_NAME =" +
                    "'patient'" +
                    " AND TABLE_SCHEMA = 'hotel';", Const.Const.getConnection(connection));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                reader.Close();
            }
            if (rB2.Checked)
            {
                keyName = "Ключ";
                dateName = "Дата";
                vibor = "hotel.svodnaya_tablica_po_razmeshcheniyu_pribyvshih";
                MySqlCommand command = new MySqlCommand("SELECT COLUMN_NAME from information_schema.COLUMNS WHERE TABLE_NAME =" +
                    "'svodnaya_tablica_po_razmeshcheniyu_pribyvshih'" +
                   " AND TABLE_SCHEMA = 'hotel';", Const.Const.getConnection(connection));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                reader.Close();
            }

            if (rB3.Checked)
            {
                keyName = "Ключ";
                dateName = "Дата";
                vibor = "hotel.svedeniya_o_vakcinacii_pribyvshih";
                MySqlCommand command = new MySqlCommand("SELECT COLUMN_NAME from information_schema.COLUMNS WHERE TABLE_NAME =" +
                    "'svedeniya_o_vakcinacii_pribyvshih'" +
                   " AND TABLE_SCHEMA = 'hotel';", Const.Const.getConnection(connection));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                reader.Close();
            }

            if (rB4.Checked)
            {
                keyName = "Ключ";
                dateName = "Дата";
                vibor = "hotel.informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan";
                MySqlCommand command = new MySqlCommand("SELECT COLUMN_NAME from information_schema.COLUMNS WHERE TABLE_NAME =" +
                    "'informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan'" +
                   " AND TABLE_SCHEMA = 'hotel';", Const.Const.getConnection(connection));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                reader.Close();
            }

            if (rB5.Checked)
            {
                keyName = "Ключ";
                dateName = "Дата";
                vibor = "hotel.svedeniya_o_gospitalizacii_pribyvshih";
                MySqlCommand command = new MySqlCommand("SELECT COLUMN_NAME from information_schema.COLUMNS WHERE TABLE_NAME =" +
                    "'svedeniya_o_gospitalizacii_pribyvshih'" +
                   " AND TABLE_SCHEMA = 'hotel';", Const.Const.getConnection(connection));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                reader.Close();
            }


            if (num_polei.Text != "")
            {
                comb = new ComboBox[Convert.ToInt32(num_polei.Text)];
                bool flag=true;
                for (int i = 0; i < Convert.ToInt32(num_polei.Text); i++)
                {
                    if (Convert.ToInt32(num_polei.Text)>60)
                    {
                         MessageBox.Show("Слишком много полей выбрано, максимум 60");
                         flag = false;
                         break;
                        
                    }


                    if (i < 12)
                    {
                        comb[i] = new ComboBox() { Name = "comb_" + i, Location = new System.Drawing.Point(19, 300 + i * 30), Width = 200, Height = 25 };
                        panel1.Controls.Add(comb[i]);
                    }
                    else if (i < 24)
                    {
                        comb[i] = new ComboBox() { Name = "comb_" + i, Location = new System.Drawing.Point(319, 300 + (i - 12) * 30), Width = 200, Height = 25 };
                        panel1.Controls.Add(comb[i]);
                    }
                    else if (i < 36)
                    {
                        comb[i] = new ComboBox() { Name = "comb_" + i, Location = new System.Drawing.Point(619, 300 + (i - 24) * 30), Width = 200, Height = 25 };
                        panel1.Controls.Add(comb[i]);
                    }
                    else if (i < 48)
                    {
                        comb[i] = new ComboBox() { Name = "comb_" + i, Location = new System.Drawing.Point(919, 300 + (i - 36) * 30), Width = 200, Height = 25 };
                        panel1.Controls.Add(comb[i]);
                    }
                    else if (i < 60)
                    {
                        comb[i] = new ComboBox() { Name = "comb_" + i, Location = new System.Drawing.Point(1219, 300 + (i - 48) * 30), Width = 200, Height = 25 };
                        panel1.Controls.Add(comb[i]);
                    }
                    
                }
                if (flag)
                {
                    for (int i = 0; i < Convert.ToInt32(num_polei.Text); i++)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            comb[i].Items.Add(list[j]);
                        }

                    }
                    truebutton = true; //подтвердение, что создалось 
                }
            }
            else
            {
                MessageBox.Show("Введите количество полей");
            }
            Const.Const.closeConnection(connection);
        }

        private void Tablicacreate_Click(object sender, EventArgs e)
        {
            if (day.Text != "" && month.Text != "" && year.Text != "" && dayEnd.Text != "" && monthEnd.Text != "" && yearEnd.Text != "")
            {
                Dock_helper.Word_Helper work = new Dock_helper.Word_Helper("tost.docx");
                string[] ColName = new string[Convert.ToInt32(num_polei.Text)]; //Массив названий колонок
                bool flag = true;

                if (vibor != null && keyName != null && dateName != null)
                {
                    for (int i = 0; i < Convert.ToInt32(num_polei.Text); i++)
                    {
                        if (comb[i].Text != "")
                        {
                            ColName[i] = comb[i].Text;
                        }
                        else
                        {
                            MessageBox.Show("Не все поля заполнены");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        string dateStart = year.Text + "-" + month.Text + "-" + day.Text;
                        string dateEnd = yearEnd.Text + "-" + monthEnd.Text + "-" + dayEnd.Text;

                        work.Table(vibor, ColName, keyName, dateName, dateStart, dateEnd);
                    }
                }
                else
                {
                    MessageBox.Show("Не выбрана таблица");
                }
                MessageBox.Show("Выполнено составление отчета");
            }
            else
            {
                MessageBox.Show("Введены не все поля");

            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tablica_polnaya_Click(object sender, EventArgs e)
        {
            if (day.Text != "" && month.Text != "" && year.Text != "" && dayEnd.Text != "" && monthEnd.Text != "" && yearEnd.Text != "")
            {
                string dateStart = year.Text + "-" + month.Text + "-" + day.Text;
                string dateEnd = yearEnd.Text + "-" + monthEnd.Text + "-" + dayEnd.Text;
                datedate.nullall();
                dat.schitivanie("Дата", dateStart, dateEnd);
                dat.schitivanie2("Дата", dateStart, dateEnd);
                dat.schitivanie3("Дата", dateStart, dateEnd);
                dat.schitivanie4("Дата", dateStart, dateEnd);
                otchet.obshci(dateStart, dateEnd);
                MessageBox.Show("Выполнено составление отчета");
            }
            else
            {
                MessageBox.Show("Введены не все поля");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            dat.day1 = day.Text;
            dat.month1 = month.Text;
            dat.year1 = year.Text;
            dat.day2 = dayEnd.Text;
            dat.month2 = monthEnd.Text;
            dat.year2 = yearEnd.Text;
            Work_Dock.FormDocum form1 = new Work_Dock.FormDocum();
            form1.Show();
        }

        private void day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dayEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void monthEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void yearEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void day_TextChanged(object sender, EventArgs e)
        {
            if (day.TextLength == 2)
            {
                month.Focus();
            }
            else if (day.TextLength > 2)
            {
                day.Text = "";
            }
        }

        private void dayEnd_TextChanged(object sender, EventArgs e)
        {
            if (dayEnd.TextLength == 2)
            {
                monthEnd.Focus();
            }
            else if (dayEnd.TextLength > 2)
            {
                dayEnd.Text = "";
            }
        }

        private void month_TextChanged(object sender, EventArgs e)
        {
            if (month.TextLength == 2)
            {
                year.Focus();
            }
            else if (month.TextLength > 2)
            {
                month.Text = "";
            }
        }

        private void monthEnd_TextChanged(object sender, EventArgs e)
        {
            if (monthEnd.TextLength == 2)
            {
                yearEnd.Focus();
            }
            else if (monthEnd.TextLength > 2)
            {
                monthEnd.Text = "";
            }
        }

        private void year_TextChanged(object sender, EventArgs e)
        {
            if (year.TextLength > 4)
            {
                year.Text = "";
            }
        }

        private void yearEnd_TextChanged(object sender, EventArgs e)
        {
            if (yearEnd.TextLength > 4)
            {
                yearEnd.Text = "";
            }
        }

        private void FormDocum_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
