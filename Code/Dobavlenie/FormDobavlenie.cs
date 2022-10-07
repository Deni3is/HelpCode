using System;
using System.Windows.Forms;
namespace Hotel.Dobavlenie
{
    public partial class FormDobavlenie : Form
    {
        public FormDobavlenie()
        {
            InitializeComponent();
            day.Text = DateTime.Now.Day.ToString();
            month.Text = DateTime.Now.Month.ToString();
            year.Text = DateTime.Now.Year.ToString();
        }

        private void Prinyat_dobavlenie_Click(object sender, EventArgs e)
        {
            bool dobflag = false;
            if(surname.Text == "")
            {
                label2.Text = "Фамилия*";
                label2.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label2.Text = "Фамилия";
                label2.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (name.Text == "")
            {
                label1.Text = "Имя*";
                label1.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label1.Text = "Имя";
                label1.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (patronimic.Text == "")
            {
                label3.Text = "Отчество*";
                label3.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label3.Text = "Отчество";
                label3.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (day_rojd.Text == "" || montch_rojden.Text == "" || year_rojd.Text == "")
            {

                label4.Text = "Дата рождения*";
                label4.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label4.Text = "Дата рождения";
                label4.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (!men.Checked && !wom.Checked)
            {
                label5.Text = "Пол*";
                label5.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label5.Text = "Пол";
                label5.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (day.Text == "" || month.Text == "" || year.Text == "")
            {
                label14.Text = "Дата поступления в ПВР*";
                label14.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label14.Text = "Дата поступления в ПВР";
                label14.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (room.Text == "")
            {
                label13.Text = "Комната №*";
                label13.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label13.Text = "Комната №";
                label13.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            if (!grazh_rus.Checked && !grazh_uk.Checked && (!grazh_dif.Checked && othercountry.Text == ""))
            {
                label7.Text = "Гражданство*";
                label7.ForeColor = System.Drawing.Color.Red;
                dobflag = true;
            }
            else
            {
                label7.Text = "Гражданство";
                label7.ForeColor = System.Drawing.Color.Black;
                dobflag = false;
            }
            /*
              surname.Text != "" && name.Text != "" && patronimic.Text != "" &&
                day_rojd.Text != "" && montch_rojden.Text != "" && year_rojd.Text != "" &&
                (men.Checked || wom.Checked) && day.Text != "" && month.Text != "" && year.Text != "" &&
                room.Text != "" && (grazh_rus.Checked || grazh_uk.Checked || (grazh_dif.Checked && othercountry.Text != ""))
             */
            if (dobflag == false)
            {
                Init elem = new Init();
                try
                {
                    DateTime dayrojd = new DateTime(Convert.ToInt32(year_rojd.Text), Convert.ToInt32(montch_rojden.Text), Convert.ToInt32(day_rojd.Text));
                    DateTime daypostup = new DateTime(Convert.ToInt32(year.Text), Convert.ToInt32(month.Text), Convert.ToInt32(day.Text));
                    string grazdanstvo = "";
                    grazdanstvo += grazh_rus.Checked ? "Российское " : "";
                    grazdanstvo += grazh_uk.Checked ? "Украинское " : "";
                    grazdanstvo += grazh_dif.Checked ? othercountry.Text : "";
                    DateTime datarodov = new DateTime();
                    if (day_rod.Text != "") { datarodov = new DateTime(Convert.ToInt32(year_rod.Text), Convert.ToInt32(month_rod.Text), Convert.ToInt32(day_rod.Text)); }
                    DateTime bolel = new DateTime();
                    if (p_day.Text != "" && !p1.Visible == true) { bolel = new DateTime(Convert.ToInt32(p_year.Text), Convert.ToInt32(p_montch.Text), Convert.ToInt32(p_day.Text)); }
                    DateTime vacina = new DateTime();
                    if (v_day.Text != "" && !p2.Visible == true) vacina = new DateTime(Convert.ToInt32(v_year.Text), Convert.ToInt32(v_montch.Text), Convert.ToInt32(v_day.Text));
                    DateTime karantin = new DateTime();
                    if (k_day.Text != "" && !p3.Visible == true) karantin = karantin = new DateTime(Convert.ToInt32(k_year.Text), Convert.ToInt32(k_montch.Text), Convert.ToInt32(k_day.Text));

                    int room1 = Convert.ToInt32(room.Text);
                    int rojdeno_ = rojd_det.Text != "" ? Convert.ToInt32(rojd_det.Text) : 0;
                    elem.init_dobavlenie(name.Text, surname.Text, patronimic.Text,
                        dayrojd, (men.Checked ? 1 : 0), daypostup, room1,
                        grazdanstvo, (bezjnc.Checked ? 1 : 0), (berem.Checked ? 1 : 0),
                        (rody.Checked ? 1 : 0), datarodov, rojdeno_,
                        ((pereb.Checked && !p1.Visible) ? 1 : 0), bolel,
                        ((vacin.Checked && !p2.Visible) ? 1 : 0), vacina,
                        ((karan.Checked && !p3.Visible) ? 1 : 0), karantin);

                try
                {

                    Const.Const.openConnection();
                    DateTime NowDate = DateTime.Today;
                    string nDate = NowDate.ToString("yyyy-MM-dd");
                    int age = DateTime.Today.Year - dayrojd.Year;
                    Class1_Incriment.Class1 incr = new Class1_Incriment.Class1();
                    incr.incriment_for_Razm_prib((berem.Checked ? true : false), age, rojdeno_, nDate, (grazh_rus.Checked) ? true : false, (vacin.Checked) ? true : false, (bezjnc.Checked) ? true : false);
                    bool gep_b_c = false;
                    if (DataObs.gepatB_bolen == 1 || DataObs.gepatC_bolen == 1)
                    {
                        gep_b_c = true;
                    }
                    else
                    {
                        gep_b_c = false;
                    }
                    incr.inc_o_bolezn(Convert.ToBoolean(DataObs.tyber_bolen), Convert.ToBoolean(DataObs.vich_bolen), Convert.ToBoolean(DataObs.ippp_bolen), Convert.ToBoolean(DataObs.sahDiab_bolen), Convert.ToBoolean(DataObs.krov_bolen), gep_b_c, Convert.ToBoolean(DataObs.oncolog_bolen), Convert.ToBoolean(DataObs.psih_bolen), Convert.ToBoolean(DataObs.projee_bolen), nDate);
                    bool imun = false;
                    if ((pereb.Checked && !p1.Visible) == true || (vacin.Checked && !p2.Visible) == true)
                    {
                        imun = true;
                    }
                    else
                    {
                        imun = false;
                    }
                    incr.inc_for_vac(imun, (vacin.Checked && !p2.Visible), berem.Checked, age, nDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Const.Const.closeConnection();
                }
                
                DataObs.default_();
                surname.Text = "";
                name.Text = "";
                patronimic.Text = "";
                day_rojd.Text = "";
                montch_rojden.Text = "";
                year_rojd.Text = "";
                men.Checked = false;
                wom.Checked = false;
                day.Text = "";
                month.Text = "";
                year.Text = "";
                room.Text = "";
                grazh_rus.Checked = false;
                grazh_uk.Checked = false;
                grazh_dif.Checked = false;
                othercountry.Text = "";
                bezjnc.Checked = false;
                berem.Checked = false;
                rody.Checked = false;
                day_rod.Text = "";
                month_rod.Text = "";
                year_rod.Text = "";
                rojd_det.Text = "";
                pereb.Checked = false;
                vacin.Checked = false;
                karan.Checked = false;
                p_day.Text = "";
                p_montch.Text = "";
                p_year.Text = "";
                v_day.Text = "";
                v_montch.Text = "";
                v_year.Text = "";
                k_day.Text = "";
                k_montch.Text = "";
                k_year.Text = "";
                label6.Visible = false;
                berem.Visible = false;
                label9.Visible = false;
                rody.Visible = false;
                day_rod.Text = "";
                month_rod.Text = "";
                year_rod.Text = "";
                day_rod.Visible = false;
                month_rod.Visible = false;
                year_rod.Visible = false;
                label12.Visible = false;
                label10.Visible = false;
                rojd_det.Text = "";
                rojd_det.Visible = false;
                }
                catch (Exception ex)
                {
                    if (day_rojd.Text != "" && montch_rojden.Text != "" && year_rojd.Text != "")
                    {

                        label4.Text = "Дата рождения*";
                        label4.ForeColor = System.Drawing.Color.Red;
                        MessageBox.Show("Ошибка: несуществующая дата");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Проверьте корректность введенных вами данных");
            }
        }

        private void dob_osmot_Click(object sender, EventArgs e)
        {
            //dob_osmot.Enabled = false; //как следует включить?
            DataObs.obsledovan = 1;
            FormDobavlenieObs form = new FormDobavlenieObs();
            form.Show();

        }

        private void wom_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true; berem.Visible = true;
            label9.Visible = true; rody.Visible = true;
        }
        //Техническая часть
        private void rody_CheckedChanged(object sender, EventArgs e)
        {
            if (label12.Visible == false)
            {
                label12.Visible = true;
                label10.Visible = true;
                label45.Visible = true;
                label44.Visible = true;
                label43.Visible = true;
                day_rod.Visible = true;
                month_rod.Visible = true;
                year_rod.Visible = true;
                rojd_det.Visible = true;
            }
            else
            {
                label12.Visible = false;
                label10.Visible = false;
                label45.Visible = false;
                label44.Visible = false;
                label43.Visible = false;
                day_rod.Visible = false;
                month_rod.Visible = false;
                year_rod.Visible = false;
                rojd_det.Visible = false;

            }
        }

        private void men_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false; berem.Visible = false;
            label9.Visible = false; rody.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            label45.Visible = false;
            label44.Visible = false;
            label43.Visible = false;
            day_rod.Visible = false;
            month_rod.Visible = false;
            year_rod.Visible = false;
            rojd_det.Visible = false;
        }
        //Выход
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            Hide();
        }

        private void FormDobavlenie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDobavlenie_Load(object sender, EventArgs e)
        {
            DataObs.default_();
        }

        private void karan_CheckedChanged(object sender, EventArgs e)
        {
            if (karan.Checked == true)
            {
                k_day.Visible = true;
                k_montch.Visible = true;
                k_year.Visible = true;
                label34.Visible = true;
                label33.Visible = true;
                label32.Visible = true;

            }
            else
            {
                k_day.Visible = false;
                k_montch.Visible = false;
                k_year.Visible = false;
                label34.Visible = false;
                label33.Visible = false;
                label32.Visible = false;
                k_day.Text = "";
                k_montch.Text = "";
                k_year.Text = "";
                p3.Visible = false;
                t3.Visible = false;

            }
        }

        private void vacin_CheckedChanged(object sender, EventArgs e)
        {
            if (vacin.Checked == true)
            {
                v_day.Visible = true;
                v_montch.Visible = true;
                v_year.Visible = true;
                label31.Visible = true;
                label30.Visible = true;
                label29.Visible = true;

            }
            else
            {
                v_day.Visible = false;
                v_montch.Visible = false;
                v_year.Visible = false;
                label31.Visible = false;
                label30.Visible = false;
                label29.Visible = false;
                v_day.Text = "";
                v_montch.Text = "";
                v_year.Text = "";
                p2.Visible = false;
                t2.Visible = false;

            }
        }

        private void pereb_CheckedChanged(object sender, EventArgs e)
        {
            if (pereb.Checked == true)
            {
                p_day.Visible = true;
                p_montch.Visible = true;
                p_year.Visible = true;
                label26.Visible = true;
                label25.Visible = true;
                label24.Visible = true;

            }
            else
            {
                p_day.Visible = false;
                p_montch.Visible = false;
                p_year.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                p_day.Text = "";
                p_montch.Text = "";
                p_year.Text = "";
                p1.Visible = false;
                t1.Visible = false;

            }
        }

        private void p_year_TextChanged(object sender, EventArgs e)
        {
            if (p_year.TextLength > 4)
            {
                p_year.Text = "";
            }
            if (p_year.Text.Length > 3)
            {
                if (Convert.ToInt32(p_year.Text) > 2000 && Convert.ToInt32(p_year.Text) < 2100)
                {
                    if (p_montch.Text == "")
                    {
                        p_montch.Text = "1";
                    }
                    if (p_day.Text == "")
                    {
                        p_day.Text = "1";
                    }
                    try
                    {
                        DateTime tek = new DateTime(Convert.ToInt32(p_year.Text), Convert.ToInt32(p_montch.Text), Convert.ToInt32(p_day.Text));
                        if ((DateTime.Now - tek).Days > 183)
                        {
                            p1.Visible = true;
                            t1.Visible = true;
                        }
                        else
                        {
                            p1.Visible = false;
                            t1.Visible = false;
                        }
                    }
                    catch
                    {
                        
                        MessageBox.Show("Неккоректная дата Переболел ковид");
                        p_montch.Text = "1";
                        p_day.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Некорректый год");
                    p_year.Text = "2022";
                }

            }


        }

        private void v_year_TextChanged(object sender, EventArgs e)
        {
            if (v_year.TextLength > 4)
            {
                v_year.Text = "";
            }
            if (v_montch.Text == "")
            {
                v_montch.Text = "1";
            }
            if (v_day.Text == "" )
            {
                v_day.Text = "1";
            }
            if (v_year.Text.Length > 3)
            {
                if (Convert.ToInt32(v_year.Text) > 2000 && Convert.ToInt32(v_year.Text) < 2100)
                {
                    try
                    {
                        DateTime tek = new DateTime(Convert.ToInt32(v_year.Text), Convert.ToInt32(v_montch.Text), Convert.ToInt32(v_day.Text));
                        if ((DateTime.Now - tek).Days > 183)
                        {
                            p2.Visible = true;
                            t2.Visible = true;
                        }
                        else
                        {
                            p2.Visible = false;
                            t2.Visible = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Некорректная дата вакцинации ковид");
                        v_montch.Text = "1";
                        v_day.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Некорректый год");
                    v_year.Text = "2022";

                }
            }


        }

        private void k_year_TextChanged(object sender, EventArgs e)
        {
            if (k_year.TextLength > 4)
            {
                k_year.Text = "";
            }
            if (k_montch.Text == "")
            {
                k_montch.Text = "1";
            }
            if (k_day.Text == "")
            {
                k_day.Text = "1";
            }
            if (k_year.Text.Length > 3)
            {
                if (Convert.ToInt32(k_year.Text) > 2000 && Convert.ToInt32(k_year.Text) < 2100)
                {
                    try
                    {
                        DateTime tek = new DateTime(Convert.ToInt32(k_year.Text), Convert.ToInt32(k_montch.Text), Convert.ToInt32(k_day.Text));
                        if ((DateTime.Now - tek).Days > 7)
                        {
                            p3.Visible = true;
                            t3.Visible = true;
                        }
                        else
                        {
                            p3.Visible = false;
                            t3.Visible = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Некорректная дата вакцинации ковид");
                        k_montch.Text = "1";
                        k_day.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Некорректый год");
                    k_year.Text = "2022";

                }
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void day_rojd_TextChanged(object sender, EventArgs e)
        {

            if (day_rojd.TextLength == 2)
            {
                montch_rojden.Focus();
            }
            else if (day_rojd.TextLength > 2)
            {
                day_rojd.Text = "";
            }
        }
        private void montch_rojden_TextChanged(object sender, EventArgs e)
        {
            if (montch_rojden.TextLength == 2)
            {
                year_rojd.Focus();
            }
            else if (montch_rojden.TextLength > 2)
            {
                montch_rojden.Text = "";
            }
        }
        private void year_rojd_TextChanged(object sender, EventArgs e)
        {
            if (year_rojd.TextLength > 4)
            {
                year_rojd.Text = "";
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
        private void month_TextChanged(object sender, EventArgs e)
        {
            if (month.TextLength == 2)
            {
                year.Focus();
            }
            else if (day.TextLength > 2)
            {
                month.Text = "";
            }
        }
        private void year_TextChanged(object sender, EventArgs e)
        {
            if (year.TextLength > 4)
            {
                year.Text = "";
            }
        }

        private void day_rod_TextChanged(object sender, EventArgs e)
        {
            if (day_rod.TextLength == 2)
            {
                month_rod.Focus();
            }
            else if (day_rod.TextLength > 2)
            {
                day_rod.Text = "";
            }
        }

        private void month_rod_TextChanged(object sender, EventArgs e)
        {
            if (month_rod.TextLength == 2)
            {
                year_rod.Focus();
            }
            else if (month_rod.TextLength > 2)
            {
                month_rod.Text = "";
            }
        }

        private void year_rod_TextChanged(object sender, EventArgs e)
        {
            if (year_rod.TextLength > 4)
            {
                year_rod.Text = "";
            }
        }

        private void p_day_TextChanged(object sender, EventArgs e)
        {
            if (p_day.TextLength == 2)
            {
                p_montch.Focus();
            }
            else if (p_day.TextLength > 2)
            {
                p_day.Text = "";
            }
        }

        private void p_montch_TextChanged(object sender, EventArgs e)
        {
            if (p_montch.TextLength == 2)
            {
                p_year.Focus();
            }
            else if (p_montch.TextLength > 2)
            {
                p_montch.Text = "";
            }
        }

        private void v_day_TextChanged(object sender, EventArgs e)
        {
            if (v_day.TextLength == 2)
            {
                v_montch.Focus();
            }
            else if (v_day.TextLength > 2)
            {
                v_day.Text = "";
            }
        }

        private void v_montch_TextChanged(object sender, EventArgs e)
        {
            if (v_montch.TextLength == 2)
            {
                v_year.Focus();
            }
            else if (v_montch.TextLength > 2)
            {
                v_montch.Text = "";
            }
        }

        private void k_day_TextChanged(object sender, EventArgs e)
        {
            if (k_day.TextLength == 2)
            {
                k_montch.Focus();
            }
            else if (k_day.TextLength > 2)
            {
                k_day.Text = "";
            }
        }

        private void k_montch_TextChanged(object sender, EventArgs e)
        {
            if (k_montch.TextLength == 2)
            {
                k_year.Focus();
            }
            else if (k_montch.TextLength > 2)
            {
                k_montch.Text = "";
            }
        }

        private void day_rojd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void montch_rojden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void year_rojd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void day_rod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void month_rod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void year_rod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void p_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void p_montch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void p_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void v_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void v_montch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void v_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void k_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void k_montch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void k_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void t3_Click(object sender, EventArgs e)
        {

        }
    }
}
