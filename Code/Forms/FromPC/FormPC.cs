using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Hotel.Forms.FromPC
{
    public partial class FormPC : Form
    {

        private string CheckYear(string year1,string dat= "Дата некорректна")
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

        public FormPC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            FormSearch form = new FormSearch();
            form.Show();

        }
        //Инфа о обследдовании 
        private void pc_otch_Click_1(object sender, EventArgs e)
        {

            var helper = new Dock_helper.Word_Helper("test.docx");
            var items = new Dictionary<string, string>
            {
                { "{фамилия}", pc_fio.Text},
                { "{комната}", pc_room.Text},
                { "{пол}", pc_gen.Text},
                { "{дата_поступления}", pc_date_postyp.Text},
                { "{дата_рождения}",pc_day_rojd.Text },
                { "{гражданин_РФ}", pc_gr_ru.Text },
                { "{беженец}",pc_bej.Text },
                { "{беременность}", pc_berem.Text=="0"?"да":" " },
                { "{родов}", pc_rody.Text},
                { "{рожденных_детей}", pc_deti.Text},
                {"{ограничения}", pc_ogr.Text},
                {"{вакцинирован}", pc_vac.Text},
                {"{на_карантине}", pc_karan.Text},
                {"{переболел}", pc_pereb.Text},
                {"{вакцинирован_д}", textBox1.Text},
                {"{на_карантине_д}", textBox2.Text},
                {"{переболел_д}", textBox3.Text},

            };
            helper.Process(items);
        }

        private void pc_amb_Click(object sender, EventArgs e)
        {
            FormPCAmb forms = new FromPC.FormPCAmb();
            forms.Show();
            this.Hide();
        }

        private void pc_obs_Click(object sender, EventArgs e)
        {
            Forms.FromPC.FormPCObs forms = new FromPC.FormPCObs();
            forms.Show();
            this.Hide();
        }

        private void FormPC_Load(object sender, EventArgs e)
        {
            Dobavlenie.Init init = new Dobavlenie.Init();
            init.dateforforms1();
            pc_fio.Text = Findpeople.famil+" "+ Findpeople.name +" "+ Findpeople.otchestvo;
            pc_gen.Text = (Findpeople.pol == "1") ? "М" : "Ж";
            pc_room.Text = Findpeople.room;
            pc_gr_ru.Text = Findpeople.grajd;
            pc_date_postyp.Text = CheckYear(Findpeople.day_postup);
            pc_day_rojd.Text = CheckYear(Findpeople.day_rojd);
            pc_bej.Text = (Findpeople.beznc == "1") ? "есть" : "нет";
            if (pc_gen.Text == "Ж")
            {
                label6.Visible = true;
                pc_berem.Visible = true;
                label9.Visible = true;
                pc_rody.Visible = true;
                label1.Visible = true;
                pc_deti.Visible = true;
                pc_berem.Text = (Findpeople.berem == "1") ? "есть" : "нет";
                pc_rody.Text = CheckYear(Findpeople.day_rodov,"небыло");
                pc_deti.Text = Findpeople.rodi_PVR_detei;
            }
            pc_pereb.Text = (Findpeople.bol_covid == "1") ? "да" : "нет";
            textBox1.Text = CheckYear(Findpeople.day_bol_covid,"отсутствует");
            pc_vac.Text = (Findpeople.vacin_covid == "1") ? "да" : "нет";
            textBox2.Text = CheckYear(Findpeople.day_vacin_covid, "отсутствует");
            pc_karan.Text = (Findpeople.karan == "1") ? "да" : "нет";
            textBox3.Text = CheckYear(Findpeople.day_karan,"отсутствует");
            pc_ogr.Text = (Findpeople.ogr_vozm == "1") ? "присутствуют" : "нет";
        }

        private void FormPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
