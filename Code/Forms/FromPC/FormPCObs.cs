using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Forms.FromPC
{
    public partial class FormPCObs : Form
    {
        MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);

        private string CheckYear(string year1, string dat = "Не обследован")
        {
            if (year1 != "")
            {
                var year = DateTime.Parse(year1);
                DateTime tempdate = new DateTime(1800, 1, 1); //раньше данной даты только системные значения
                if (DateTime.Compare(year, tempdate) > 0) //возраст наступает позже (т.е. человек моложе) чем временное время
                {

                    return Convert.ToString(year).Substring(0, Convert.ToString(year).Length - 8);
                }
                else
                {

                    return dat;

                }
            }
            else {
                return dat;
            }
        }
        public FormPCObs()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPC form = new FormPC();
            form.Show();
            Hide();
        }

        private void FormPCObs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormPCObs_Load(object sender, EventArgs e)
        {
            num_card.Text = ""+Findpeople.num_card;

            string ippp_obs = "", ippp_bol = "", tyber_obs = "", tyber_bol = "", gep_b_obs = "", gep_b_bol = "", gep_c_obs = "", gep_c_bol = "", vich_obs = "", vich_bol = "", shugar_obs = "",
          shugar_bol = "", psyho_obs = "", psyho_bol = "", onc_obs = "", onc_bol = "", blood_obs = "",
          blood_bol = "", other_obs = "", other_bol = "", other_data = "", which = "",arvt="";
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT Номер_Карточки,ИППП_обследование,ИППП_болен,ИППП_дата," +
                   "ИППП_комментарий,Туберкулез_обследование,Туберкулез_болен,Туберкулез_дата,Туберкулез_комментарий,Гепатит_B_обследование," +
                   "Гепатит_B_болен,Гепатит_B_дата,Гепатит_В_комментарий,Гепатит_C_обследование,Гепатит_C_болен,Гепатит_C_дата, " +
                   "Гепатит_С_комментарий,ВИЧ_инфекция_обследование,ВИЧ_инфекция_болен,ВИЧ_инфекция_дата,ВИЧ_комментарий,АРВТ,Сахарный_диабет_обследование," +
                   "Сахарный_диабет_болен,Сахарный_диабет_дата,Сахар_комментарий,Психические_расстройства_обследование,Психические_расстройства_болен," +
                   "Психические_расстройства_дата,Псих_комментарий,Онкологические_заболевания_обследование,Онкологические_заболевания_болен," +
                   "Онкологические_заболевания_дата,Онкология_коммент,Болезни_системы_кровообращения_обследование," +
                   "Болезни_системы_кровообращения_болен,Болезни_системы_кровообращения_дата,Болезни_крови_коммент," +
                   "Прочие_заболевания_обследование,Прочие_заболевания_болен,Прочие_заболевания_дата,Какие_прочие_заболевания " +
                   "FROM hotel.patient WHERE `Номер_Карточки` = @key", Const.Const.getConnection(connection));
            command.Parameters.Add("@key", MySqlDbType.String).Value = Findpeople.num_card;
            Const.Const.openConnection(connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tyber_obs = Convert.ToString(reader["Туберкулез_обследование"]);
                tyber_bol = Convert.ToString(reader["Туберкулез_болен"]);
                tuber_data.Text = CheckYear(Convert.ToString(reader["Туберкулез_дата"]));
                tuber_com.Text = Convert.ToString(reader["Туберкулез_комментарий"]);

                gep_b_obs = Convert.ToString(reader["Гепатит_B_обследование"]);
                gep_b_bol = Convert.ToString(reader["Гепатит_B_болен"]);
                gepb_data.Text = CheckYear(Convert.ToString(reader["Гепатит_B_дата"]));
                gepb_com.Text = Convert.ToString(reader["Гепатит_В_комментарий"]);

                vich_obs = Convert.ToString(reader["ВИЧ_инфекция_обследование"]);
                vich_bol = Convert.ToString(reader["ВИЧ_инфекция_болен"]);
                vich_data.Text = CheckYear(Convert.ToString(reader["ВИЧ_инфекция_дата"]));
                vich_com.Text = Convert.ToString(reader["ВИЧ_комментарий"]);
                arvt = Convert.ToString(reader["АРВТ"]);


                shugar_obs = Convert.ToString(reader["Сахарный_диабет_обследование"]);
                shugar_bol = Convert.ToString(reader["Сахарный_диабет_болен"]);
                sahar_data.Text = CheckYear(Convert.ToString(reader["Сахарный_диабет_дата"]));
                sahar_com.Text = Convert.ToString(reader["Сахар_комментарий"]);

                ippp_obs = Convert.ToString(reader["ИППП_обследование"]);
                ippp_bol = Convert.ToString(reader["ИППП_болен"]);
                ippp_data.Text = CheckYear(Convert.ToString(reader["ИППП_дата"]));
                ippp_com.Text = Convert.ToString(reader["ИППП_комментарий"]);

                blood_obs = Convert.ToString(reader["Болезни_системы_кровообращения_обследование"]);
                blood_bol = Convert.ToString(reader["Болезни_системы_кровообращения_болен"]);
                blood_data.Text = CheckYear(Convert.ToString(reader["Болезни_системы_кровообращения_дата"]));
                blood_com.Text = Convert.ToString(reader["Болезни_крови_коммент"]);

                gep_c_obs = Convert.ToString(reader["Гепатит_C_обследование"]);
                gep_c_bol = Convert.ToString(reader["Гепатит_C_болен"]);
                gepc_data.Text = CheckYear(Convert.ToString(reader["Гепатит_C_дата"]));
                gepc_com.Text = Convert.ToString(reader["Гепатит_С_комментарий"]);

                psyho_obs = Convert.ToString(reader["Психические_расстройства_обследование"]);
                psyho_bol = Convert.ToString(reader["Психические_расстройства_болен"]);
                psih_data.Text = CheckYear(Convert.ToString(reader["Психические_расстройства_дата"]));
                psih_com.Text = Convert.ToString(reader["Псих_комментарий"]);

                onc_obs = Convert.ToString(reader["Онкологические_заболевания_обследование"]);
                onc_bol = Convert.ToString(reader["Онкологические_заболевания_болен"]);
                oncol_data.Text = CheckYear(Convert.ToString(reader["Онкологические_заболевания_дата"]));
                oncol_com.Text = Convert.ToString(reader["Онкология_коммент"]);

                other_obs = Convert.ToString(reader["Прочие_заболевания_обследование"]);
                other_bol = Convert.ToString(reader["Прочие_заболевания_болен"]);
                other_data = CheckYear(Convert.ToString(reader["Прочие_заболевания_дата"]));
                which = Convert.ToString(reader["Какие_прочие_заболевания"]);
            }
            Const.Const.closeConnection(connection);
            if (tyber_obs == "1")
            {
                t_ob.Visible = true;
                t_dat_obs.Visible = true;
            }
            else {
                if (tyber_bol == "1")
                {
                    t_b.Visible = true;
                    t_datdiag.Visible = true;

                }
                else
                {
                    tuber_com.Text = ("Нет информации");
                }
            }
            if (gep_b_obs == "1")
            {
                gb_dobs.Visible = true;
                gb_obs.Visible = true;

            }
            else
            {
                if (gep_b_bol == "1")
                {
                    gb_bol.Visible = true;
                    gb_diag.Visible = true;

                }
                else
                {
                    gepb_com.Text = ("Нет информации");
                }
            }

            if (vich_obs == "1")
            {
                v_obs.Visible = true;
                vd_ob.Visible = true;
            }
            else
            {
                if (vich_bol == "1")
                {
                    vd_bl.Visible = true;
                    v_bol.Visible = true;
                }
                else
                {
                    vich_com.Text = ("Нет информации");
                }
            }
            if (shugar_obs == "1") {
                sah_ob.Visible = true;
                sahd_ob.Visible = true;
            }
            else { 
                if (shugar_bol == "1") {
                    sah_bol.Visible = true;
                    sahd_bol.Visible = true;
                    if (arvt == "1")
                    {
                        dob_arvt.Checked=true;
                    }
                }
                else
                {
                    sahar_com.Text = ("Нет информации");
                }
            }
            if (ippp_obs == "1")
            {
                ippp_ob.Visible = true;
                ipppd_ob.Visible = true;
            }
            if (ippp_bol == "1")
            {
                this.ippp_bol.Visible = true;
                ipppd_bol.Visible = true;
            }
            else
            {
                ippp_com.Text = ("Нет информации");
            }
            if (blood_obs == "1")
            {
                blood_obse.Visible = true;
                bloodd_obs.Visible = true;
            }
            else
            {
                if (blood_bol == "1")
                {
                    bloodd_bol.Visible = true;
                    blood_bole.Visible = true;
                }
                else
                {
                    blood_com.Text = ("Нет информации");
                }
            }
            if (gep_c_obs == "1")
            {
                gepc_obs.Visible = true;
                gepcd_obs.Visible = true;
            }
            else
            {
                if (gep_c_bol == "1")
                {
                    gepc_bol.Visible = true;
                    gepcd_bol.Visible = true;

                }
                else
                {
                    gepc_com.Text = ("Нет информации");
                }
            }

            if (psyho_obs == "1")
            {
                psih_obs.Visible = true;
                psihd_obs.Visible = true;

            }
            else
            {
                if (psyho_bol == "1")
                {
                    psih_bole.Visible = true;
                    psihd_bol.Visible = true;

                }
                else
                {
                    psih_com.Text = ("Нет информации");
                }
            }
            if (onc_obs == "1")
            {
                this.onc_obs.Visible = true;
                oncd_obs.Visible = true;

            }
            else
            {
                if (onc_bol == "1")
                {
                    this.onc_bol.Visible = true;
                    oncd_bol.Visible = true;

                }
                else
                {
                    oncol_com.Text = ("Нет информации");
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var helper = new Dock_helper.Word_Helper("test.docx");
            //var items = new Dictionary<string, string>
            //{
            //    { "{фамилия}", pc_fio.Text},
            //    { "{комната}", pc_room.Text},
            //    { "{пол}", pc_gen.Text},

            //    { "{дата_поступления}", pc_date_postyp.Text},
            //    { "{дата_рождения}",pc_day_rojd.Text },
            //    { "{гражданин_РФ}", pc_gr_ru.Text },
            //    { "{беженец}",pc_bej.Text },

            //    { "{беременность}", pc_berem.Text=="0"?"нет":"да" },
            //    { "{родов}", pc_rody.Text},
            //    { "{рожденных_детей}", pc_deti.Text},
            //    {"{ограничения}", pc_ogr.Text},

            //    {"{вакцинирован}", pc_vac.Text},
            //    {"{на_карантине}", pc_karan.Text},
            //    {"{переболел}", pc_pereb.Text},
            //    {"{вакцинирован_д}", textBox1.Text},
            //    {"{на_карантине_д}", textBox2.Text},
            //    {"{переболел_д}", textBox3.Text},

            //};
            //helper.Process(items);
        }
    }
}
