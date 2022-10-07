using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class FormObsledovanie : Form
    {

        private void CheckYear(DateTime year,TextBox t1, TextBox t2, TextBox t3)
        {
            DateTime tempdate = new DateTime(1800, 1, 1); //раньше данной даты только системные значения
            if (DateTime.Compare(year, tempdate) > 0) //возраст наступает позже (т.е. человек моложе) чем временное время
            {
                t1.Text = year.Day.ToString();
                t2.Text = year.Month.ToString();
                t3.Text = year.Year.ToString();

            }

        }


        MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);
        private void funccheck() {

            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT ИППП_обследование,ИППП_болен,ИППП_дата,ИППП_комментарий,Психические_расстройства_обследование,Психические_расстройства_болен,Психические_расстройства_дата,Псих_комментарий," +
            "Сахарный_диабет_обследование,Сахарный_диабет_болен,Сахарный_диабет_дата,Сахар_комментарий," +
            "Онкологические_заболевания_обследование,Онкологические_заболевания_болен,Онкологические_заболевания_дата,Онкология_коммент," +
            "Болезни_системы_кровообращения_обследование,Болезни_системы_кровообращения_болен,Болезни_системы_кровообращения_дата,Болезни_крови_коммент," +
            "Туберкулез_обследование,Туберкулез_болен,Туберкулез_дата,Туберкулез_комментарий,Гепатит_B_обследование," +
            "Гепатит_B_болен,Гепатит_B_дата,Гепатит_В_комментарий,Гепатит_C_обследование,Гепатит_C_болен,Гепатит_C_дата, " +
            "Гепатит_С_комментарий,ВИЧ_инфекция_обследование,ВИЧ_инфекция_болен,ВИЧ_инфекция_дата,ВИЧ_комментарий," +
            "Сахарный_диабет_болен,Сахарный_диабет_дата,Сахар_комментарий,Психические_расстройства_обследование,Психические_расстройства_болен," +
            "Прочие_заболевания_обследование,Прочие_заболевания_болен,Прочие_заболевания_дата,Какие_прочие_заболевания,АРВТ " +
            "FROM hotel.patient WHERE `Номер_Карточки` = @key ", Const.Const.getConnection(connection));
            command.Parameters.Add("@key", MySqlDbType.String).Value = Const.IspolzData.num_card;
            Const.Const.openConnection(connection);
            reader = command.ExecuteReader();
            DateTime tuber_data=new DateTime(), gep_b_data= new DateTime(), gep_c_data= new DateTime(), vich_data= new DateTime(), other_data= new DateTime();
            DateTime ippp_data = new DateTime(), psih_data = new DateTime(), sahar_data = new DateTime(), oncol_data = new DateTime(), blood_data = new DateTime();

            while (reader.Read())
            {
                iob.Checked = Convert.ToInt32(reader["ИППП_обследование"]) == 1 ? true : false;
                ibol.Checked = Convert.ToInt32(reader["ИППП_болен"]) == 1 ? true : false;
                ippp_data = Convert.ToDateTime(reader["ИППП_дата"]);
                ippp_zab.Text = Convert.ToString(reader["ИППП_комментарий"]);

                pob.Checked = Convert.ToInt32(reader["Психические_расстройства_обследование"]) == 1 ? true : false;
                pbol.Checked = Convert.ToInt32(reader["Психические_расстройства_болен"]) == 1 ? true : false;
                psih_data = Convert.ToDateTime(reader["Психические_расстройства_дата"]);
                psih_zab.Text = Convert.ToString(reader["Псих_комментарий"]);
                
                shob.Checked = Convert.ToInt32(reader["Сахарный_диабет_обследование"]) == 1 ? true : false;
                shbol.Checked = Convert.ToInt32(reader["Сахарный_диабет_болен"]) == 1 ? true : false;
                sahar_data = Convert.ToDateTime(reader["Сахарный_диабет_дата"]);
                sahar_zab.Text = Convert.ToString(reader["Сахар_комментарий"]);
                
                oob.Checked = Convert.ToInt32(reader["Онкологические_заболевания_обследование"]) == 1 ? true : false;
                obol.Checked = Convert.ToInt32(reader["Онкологические_заболевания_болен"]) == 1 ? true : false;
                oncol_data = Convert.ToDateTime(reader["Онкологические_заболевания_дата"]);
                oncol_zab.Text = Convert.ToString(reader["Онкология_коммент"]);
                
                blob.Checked = Convert.ToInt32(reader["Болезни_системы_кровообращения_обследование"]) == 1 ? true : false;
                blbol.Checked = Convert.ToInt32(reader["Болезни_системы_кровообращения_болен"]) == 1 ? true : false;
                blood_data = Convert.ToDateTime(reader["Болезни_системы_кровообращения_дата"]);
                blood_zab.Text = Convert.ToString(reader["Болезни_крови_коммент"]);
                //
                tob.Checked = Convert.ToInt32(reader["Туберкулез_обследование"])==1?true:false;
                tbol.Checked = Convert.ToInt32(reader["Туберкулез_болен"]) == 1 ? true : false;
                tuber_data = Convert.ToDateTime(reader["Туберкулез_дата"]);
                tuber_zab.Text = Convert.ToString(reader["Туберкулез_комментарий"]);

                gepbob.Checked = Convert.ToInt32(reader["Гепатит_B_обследование"]) == 1 ? true : false;
                gepbbol.Checked = Convert.ToInt32(reader["Гепатит_B_болен"]) == 1 ? true : false;
                gep_b_data = Convert.ToDateTime(reader["Гепатит_B_дата"]);
                gepb_zab.Text = Convert.ToString(reader["Гепатит_В_комментарий"]);

                gepcob.Checked = Convert.ToInt32(reader["Гепатит_C_обследование"]) == 1 ? true : false;
                gepcbol.Checked = Convert.ToInt32(reader["Гепатит_C_болен"]) == 1 ? true : false;
                gep_c_data = Convert.ToDateTime(reader["Гепатит_C_дата"]);
                gepc_zab.Text = Convert.ToString(reader["Гепатит_С_комментарий"]);

                vob.Checked = Convert.ToInt32(reader["ВИЧ_инфекция_обследование"]) == 1 ? true : false;
                vbol.Checked = Convert.ToInt32(reader["ВИЧ_инфекция_болен"]) == 1 ? true : false;
                vich_data = Convert.ToDateTime(reader["ВИЧ_инфекция_дата"]);
                hpv_zab.Text = Convert.ToString(reader["ВИЧ_комментарий"]);
                //АРВТ
                dob_arvt.Checked = Convert.ToInt32(reader["АРВТ"]) == 1 ? true : false;

                projob.Checked = Convert.ToInt32(reader["Прочие_заболевания_обследование"]) == 1 ? true : false;
                projbol.Checked = Convert.ToInt32(reader["Прочие_заболевания_болен"]) == 1 ? true : false;
                other_data = Convert.ToDateTime(reader["Прочие_заболевания_дата"]);
                other_zab.Text = Convert.ToString(reader["Какие_прочие_заболевания"]);
            }
            Const.Const.closeConnection(connection);
            CheckYear(tuber_data, dt, mt, yt);
            CheckYear(gep_b_data, bd, bm, by);
            CheckYear(gep_c_data, cd, cm, cy);
            CheckYear(vich_data, vd, vm, vy);
            CheckYear(other_data, pm, pd, py);
            //
            CheckYear(ippp_data, id, im, iy);
            CheckYear(psih_data, psd, psm, psy);
            CheckYear(sahar_data, sd, sm, sy);
            CheckYear(oncol_data, od, om, oy);
            CheckYear(blood_data, blm, bld, bly);

        }
        public FormObsledovanie()
        {
            InitializeComponent();
            
            if (Const.IspolzData.obsledovan && Const.IspolzData.num_card!="0")
            {
                button1.Visible = false;
                num_card.Text = Const.IspolzData.num_card;
                num_card.ReadOnly = true;
                funccheck();
            }
            else
            {

                MySqlDataReader reader = null;
                MySqlCommand command = new MySqlCommand("SELECT max(Номер_карточки) FROM hotel.patient", Const.Const.getConnection(connection));
                Const.Const.openConnection(connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    num_card.Text = (Convert.ToInt32(reader["max(Номер_карточки)"]) + 1) + "";
                }
                Const.Const.closeConnection(connection);

            }
        }

        private void Prinyat3_Click(object sender, EventArgs e)
        {
            if (num_card.Text != "")
            {

                int num = Convert.ToInt32(num_card.Text);
                int tubo=0,vicho=0,gepbo=0,gepco=0,projeeo=0,ipppo=0,saharo=0,psiho=0,oncolo=0,bloodo=0;
                int tubb=0, vichb=0, gepbb=0, gepcb=0, projeeb=0, ipppb = 0, saharb = 0, psihb = 0, oncolb = 0, bloodb = 0;
                tubo=tob.Checked ?1:0;
                vicho = vob.Checked ? 1 : 0;
                gepbo = gepbob.Checked ? 1 : 0;
                gepco = gepcob.Checked ? 1 : 0;
                projeeo = projob.Checked ? 1 : 0;

                ipppo = iob.Checked ? 1 : 0;
                saharo = shob.Checked ? 1 : 0;
                psiho = pob.Checked ? 1 : 0;
                oncolo = oob.Checked ? 1 : 0;
                bloodo = blob.Checked ? 1 : 0;

                tubb = tbol.Checked ? 1 : 0;
                vichb = vbol.Checked ? 1 : 0;
                gepbb = gepbbol.Checked ? 1 : 0;
                gepcb = gepcbol.Checked ? 1 : 0;
                projeeb = projbol.Checked ? 1 : 0;

                ipppb = ibol.Checked ? 1 : 0;
                saharb = shbol.Checked ? 1 : 0;
                psihb = pbol.Checked ? 1 : 0;
                oncolb = obol.Checked ? 1 : 0;
                bloodb = blbol.Checked ? 1 : 0;


                DateTime datt = new DateTime();
                if (yt.Text != "" && mt.Text != "" && dt.Text != "")
                {
                    try
                    {
                        datt = new DateTime(Convert.ToInt32(yt.Text), Convert.ToInt32(mt.Text), Convert.ToInt32(dt.Text));
                        l3.Text = "год";
                        l1.ForeColor = System.Drawing.Color.Black;
                        l2.ForeColor = System.Drawing.Color.Black;
                        l3.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        l3.Text = "год*";
                        l1.ForeColor = System.Drawing.Color.Red;
                        l2.ForeColor = System.Drawing.Color.Red;
                        l3.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datv = new DateTime();
                if (vy.Text != "" && vm.Text != "" && vd.Text != "")
                {
                    try
                    {
                        datv = new DateTime(Convert.ToInt32(vy.Text), Convert.ToInt32(vm.Text), Convert.ToInt32(vd.Text));
                        l6.Text = "год";
                        l4.ForeColor = System.Drawing.Color.Black;
                        l5.ForeColor = System.Drawing.Color.Black;
                        l6.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        l6.Text = "год*";
                        l4.ForeColor = System.Drawing.Color.Red;
                        l5.ForeColor = System.Drawing.Color.Red;
                        l6.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datb = new DateTime();
                if (by.Text != "" && bm.Text != "" && bd.Text != "")
                {
                    try
                    {
                        datb = new DateTime(Convert.ToInt32(by.Text), Convert.ToInt32(bm.Text), Convert.ToInt32(bd.Text));
                        l9.Text = "год";
                        l7.ForeColor = System.Drawing.Color.Black;
                        l8.ForeColor = System.Drawing.Color.Black;
                        l9.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        l9.Text = "год*";
                        l7.ForeColor = System.Drawing.Color.Red;
                        l8.ForeColor = System.Drawing.Color.Red;
                        l9.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datc = new DateTime();
                if (cy.Text != "" && cm.Text != "" && cd.Text !="")
                {
                    try
                    {
                        datc = new DateTime(Convert.ToInt32(cy.Text), Convert.ToInt32(cm.Text), Convert.ToInt32(cd.Text));
                        l12.Text = "год";
                        l10.ForeColor = System.Drawing.Color.Black;
                        l11.ForeColor = System.Drawing.Color.Black;
                        l12.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        l12.Text = "год*";
                        l10.ForeColor = System.Drawing.Color.Red;
                        l11.ForeColor = System.Drawing.Color.Red;
                        l12.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datp = new DateTime();
                if (py.Text != "" && pm.Text !="" && pd.Text !="")
                {
                    try
                    {
                        datp = new DateTime(Convert.ToInt32(py.Text), Convert.ToInt32(pm.Text), Convert.ToInt32(pd.Text));
                        l15.Text = "год";
                        l13.ForeColor = System.Drawing.Color.Black;
                        l14.ForeColor = System.Drawing.Color.Black;
                        l15.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        l15.Text = "год*";
                        l13.ForeColor = System.Drawing.Color.Red;
                        l14.ForeColor = System.Drawing.Color.Red;
                        l15.ForeColor = System.Drawing.Color.Red;
                    }
                }


                DateTime datippp = new DateTime();
                if (iy.Text != "" && im.Text !="" && id.Text !="")
                {
                    try
                    {
                        datippp = new DateTime(Convert.ToInt32(iy.Text), Convert.ToInt32(im.Text), Convert.ToInt32(id.Text));
                        label3.Text = "год";
                        label3.ForeColor = System.Drawing.Color.Black;
                        label6.ForeColor = System.Drawing.Color.Black;
                        label7.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        label3.Text = "год*";
                        label3.ForeColor = System.Drawing.Color.Red;
                        label6.ForeColor = System.Drawing.Color.Red;
                        label7.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datpsih = new DateTime();
                if (psy.Text != "" && psm.Text !="" && psd.Text !="")
                {
                    try
                    {
                        datpsih = new DateTime(Convert.ToInt32(psy.Text), Convert.ToInt32(psm.Text), Convert.ToInt32(psd.Text));
                        label2.Text = "год";
                        label2.ForeColor = System.Drawing.Color.Black;
                        label8.ForeColor = System.Drawing.Color.Black;
                        label9.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        label2.Text = "год*";
                        label2.ForeColor = System.Drawing.Color.Red;
                        label8.ForeColor = System.Drawing.Color.Red;
                        label9.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datsah = new DateTime();
                if (sy.Text != "" && sm.Text !="" && sd.Text !="")
                {
                    try
                    {
                        datsah = new DateTime(Convert.ToInt32(sy.Text), Convert.ToInt32(sm.Text), Convert.ToInt32(sd.Text));
                        label1.Text = "год";
                        label1.ForeColor = System.Drawing.Color.Black;
                        label10.ForeColor = System.Drawing.Color.Black;
                        label13.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        label1.Text = "год*";
                        label1.ForeColor = System.Drawing.Color.Red;
                        label10.ForeColor = System.Drawing.Color.Red;
                        label13.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datonc = new DateTime();
                if (oy.Text != "" && om.Text !="" && od.Text !="")
                {
                    try
                    {
                        datonc = new DateTime(Convert.ToInt32(oy.Text), Convert.ToInt32(om.Text), Convert.ToInt32(od.Text));
                        label4.Text = "год";
                        label4.ForeColor = System.Drawing.Color.Black;
                        label14.ForeColor = System.Drawing.Color.Black;
                        label15.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        label4.Text = "год*";
                        label4.ForeColor = System.Drawing.Color.Red;
                        label14.ForeColor = System.Drawing.Color.Red;
                        label15.ForeColor = System.Drawing.Color.Red;
                    }
                }
                DateTime datblood = new DateTime();
                if (bly.Text != "" && blm.Text !="" && bld.Text !="")
                {
                    try
                    {
                        datblood = new DateTime(Convert.ToInt32(bly.Text), Convert.ToInt32(blm.Text), Convert.ToInt32(bld.Text));
                        label5.Text = "год";
                        label5.ForeColor = System.Drawing.Color.Black;
                        label22.ForeColor = System.Drawing.Color.Black;
                        label33.ForeColor = System.Drawing.Color.Black;
                    }
                    catch
                    {
                        label5.Text = "год*";
                        label5.ForeColor = System.Drawing.Color.Red;
                        label22.ForeColor = System.Drawing.Color.Red;
                        label33.ForeColor = System.Drawing.Color.Red;
                    }
                }




                Dobavlenie.Init init = new Dobavlenie.Init();
                init.initobs(num, tubo, tubb, datt, tuber_zab.Text,
                    vicho, vichb, datv, hpv_zab.Text, dob_arvt.Checked == true ? 1 : 0,
                    gepbo, gepbb, datb, gepb_zab.Text,
                    gepco, gepcb, datc, gepc_zab.Text,
                    projeeo, projeeb, datp, other_zab.Text,
                    ipppo, ipppb, datippp, ippp_zab.Text,
                    saharo, saharb, datsah, sahar_zab.Text,
                    psiho, psihb, datpsih, psih_zab.Text,
                    oncolo, oncolb, datonc, oncol_zab.Text,
                    bloodo, bloodb, datblood, blood_zab.Text);


            }
            else
            {
                MessageBox.Show("Введите номер карточки");
            }
            Hide();
            Forms.FormSearch form = new Forms.FormSearch();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Forms.FormSearch form = new Forms.FormSearch();
            form.Show();
        }

        private void FormObsledovanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //tub
        private void tub()
        {
            dt.Visible = true;
            mt.Visible = true;
            yt.Visible = true;
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
        }
        private void tubmin()
        {
            dt.Visible = false;
            mt.Visible = false;
            yt.Visible = false;
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            dt.Text ="";
            mt.Text = "";
            yt.Text = "";
        }
        private void tob_CheckedChanged(object sender, EventArgs e)
        {
            if (tob.Checked)
            {
                tbol.Checked = false;
                tub();
            }
            else
            {
                tubmin();
            }
        }

        private void tbol_CheckedChanged(object sender, EventArgs e)
        {
            if (tbol.Checked)
            {
                tob.Checked = false;
                tub();
            }
            else
            {
                tubmin();
            }
        }
        //vic
        private void vic()
        {
            vd.Visible = true;
            vm.Visible = true;
            vy.Visible = true;
            l4.Visible = true;
            l5.Visible = true;
            l6.Visible = true;
        }
        private void vicmin()
        {
            vd.Visible = false;
            vm.Visible = false;
            vy.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            vd.Text = "";
            vm.Text = "";
            vy.Text = "";
        }
        private void vob_CheckedChanged(object sender, EventArgs e)
        {
            if (vob.Checked)
            {
                vbol.Checked = false;
                vic();
            }
            else
            {
                vicmin();
            }
        }
        private void vbol_CheckedChanged(object sender, EventArgs e)
        {
            if (vbol.Checked)
            {
                vob.Checked = false;
                vic();
            }
            else
            {
                vicmin();
            }
        }
        //bgep
        private void bgep()
        {
            bd.Visible = true;
            bm.Visible = true;
            by.Visible = true;
            l7.Visible = true;
            l8.Visible = true;
            l9.Visible = true;
        }
        private void bgepmin()
        {
            bd.Visible = false;
            bm.Visible = false;
            by.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            bd.Text = "";
            bm.Text = "";
            by.Text = "";
        }
        private void gepbob_CheckedChanged(object sender, EventArgs e)
        {
            if (gepbob.Checked)
            {
                gepbbol.Checked = false;
                bgep();
            }
            else
            {
                bgepmin();
            }
        }
        private void gepbbol_CheckedChanged(object sender, EventArgs e)
        {
            if (gepbbol.Checked)
            {
                gepbob.Checked = false;
                bgep();
            }
            else
            {
                bgepmin();
            }
        }
        //cgep
        private void cgep()
        {
            cd.Visible = true;
            cm.Visible = true;
            cy.Visible = true;
            l10.Visible = true;
            l11.Visible = true;
            l12.Visible = true;
        }
        private void cgepmin()
        {
            cd.Visible = false;
            cm.Visible = false;
            cy.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            cd.Text = "";
            cm.Text = "";
            cy.Text = "";
        }
        private void gepcob_CheckedChanged(object sender, EventArgs e)
        {
            if (gepcob.Checked)
            {
                gepcbol.Checked = false;
                cgep();
            }
            else
            {
                cgepmin();
            }
        }
        private void gepcbol_CheckedChanged(object sender, EventArgs e)
        {
            if (gepcbol.Checked)
            {
                gepcob.Checked = false;
                cgep();
            }
            else
            {
                cgepmin();
            }
        }
        //proj
        private void proj()
        {
            pd.Visible = true;
            pm.Visible = true;
            py.Visible = true;
            l13.Visible = true;
            l14.Visible = true;
            l15.Visible = true;
            l16.Visible = true;
            other_zab.Visible = true;
        }
        private void projmin()
        {
            pd.Visible = false;
            pm.Visible = false;
            py.Visible = false;
            l13.Visible = false;
            l14.Visible = false;
            l15.Visible = false;
            l16.Visible = false;
            pd.Text = "";
            pm.Text = "";
            py.Text = "";
            other_zab.Text = "";
            other_zab.Visible = false;
        }
        private void projob_CheckedChanged(object sender, EventArgs e)
        {
            if (projob.Checked)
            {
                projbol.Checked = false;
                proj();
            }
            else
            {
                projmin();
            }
        }
        private void projbol_CheckedChanged(object sender, EventArgs e)
        {
            if (projbol.Checked)
            {
                projob.Checked = false;
                proj();
            }
            else
            {
                projmin();
            }
        }
        private void ippp()
        {
            id.Visible = true;
            im.Visible = true;
            iy.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label3.Visible = true;
        }
        private void ipppmin()
        {
            id.Visible = false;
            im.Visible = false;
            iy.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label3.Visible = false;
            id.Text = "";
            im.Text = "";
            iy.Text = "";
        }
        private void ibol_CheckedChanged(object sender, EventArgs e)
        {
            if (ibol.Checked)
            {
                iob.Checked = false;
                ippp();
            }
            else
            {
                ipppmin();
            }
        }

        private void iob_CheckedChanged(object sender, EventArgs e)
        {
            if (iob.Checked)
            {
                ibol.Checked = false;
                ippp();
            }
            else
            {
                ipppmin();
            }
        }
        private void psih()
        {
            psd.Visible = true;
            psm.Visible = true;
            psy.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label2.Visible = true;
        }
        private void psihmin()
        {
            psd.Visible = false;
            psm.Visible = false;
            psy.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label2.Visible = false;
            psd.Text = "";
            psm.Text = "";
            psy.Text = "";
        }

        private void pob_CheckedChanged(object sender, EventArgs e)
        {
            if (pob.Checked)
            {
                pbol.Checked = false;
                psih();
            }
            else
            {
                psihmin();
            }
        }

        private void pbol_CheckedChanged(object sender, EventArgs e)
        {
            if (pbol.Checked)
            {
                pob.Checked = false;
                psih();
            }
            else
            {
                psihmin();
            }
        }
        
        private void sah()
        {
            sd.Visible = true;
            sm.Visible = true;
            sy.Visible = true;
            label10.Visible = true;
            label13.Visible = true;
            label1.Visible = true;

        }
        private void sahmin()
        {
            sd.Visible = false;
            sm.Visible = false;
            sy.Visible = false;
            label10.Visible = false;
            label13.Visible = false;
            label1.Visible = false;
            sd.Text = "";
            sm.Text = "";
            sy.Text = "";

        }
        private void shob_CheckedChanged(object sender, EventArgs e)
        {
            if (shob.Checked)
            {
                shbol.Checked = false;
                sah();
            }
            else
            {
                sahmin();
            }
        }
        private void shbol_CheckedChanged(object sender, EventArgs e)
        {
            if (shbol.Checked)
            {
                shob.Checked = false;
                sah();
            }
            else
            {
                sahmin();
            }
        }
        private void oncol()
        {
            od.Visible = true;
            om.Visible = true;
            oy.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label4.Visible = true;
        }
        private void oncolmin()
        {
            od.Visible = false;
            om.Visible = false;
            oy.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label4.Visible = false;
            od.Text = "";
            om.Text = "";
            oy.Text = "";

        }
        private void oob_CheckedChanged(object sender, EventArgs e)
        {
            if (oob.Checked)
            {
                obol.Checked = false;
                oncol();
            }
            else
            {
                oncolmin();
            }
        }
        private void obol_CheckedChanged(object sender, EventArgs e)
        {
            if (obol.Checked)
            {
                oob.Checked = false;
                oncol();
            }
            else
            {
                oncolmin();
            }
        }
        private void blood()
        {
            bld.Visible = true;
            blm.Visible = true;
            bly.Visible = true;
            label22.Visible = true;
            label33.Visible = true;
            label5.Visible = true;
        }
        private void bloodmin()
        {
            bld.Visible = false;
            blm.Visible = false;
            bly.Visible = false;
            label22.Visible = false;
            label33.Visible = false;
            label5.Visible = false;
            label35.Visible = false;
            bld.Text = "";
            blm.Text = "";
            bly.Text = "";

        }

        private void blob_CheckedChanged(object sender, EventArgs e)
        {
            if (blob.Checked)
            {
                blbol.Checked = false;
                blood();
            }
            else
            {
                bloodmin();
            }
        }

        private void blbol_CheckedChanged(object sender, EventArgs e)
        {
            if (blbol.Checked)
            {
                blob.Checked = false;
                blood();
            }
            else
            {
                bloodmin();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(num_card.Text) != 0)
                {


                    if (num_card.Text != "")
                    {
                        Dobavlenie.Init init = new Dobavlenie.Init();
                        Const.IspolzData.num_card = num_card.Text;
                        init.updateobs(Convert.ToInt32(num_card.Text), FromPC.Findpeople.key);
                        Const.IspolzData.obsledovan = true;
                        FormObsledovanie form = new FormObsledovanie();
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("измените номер карточки");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dt_TextChanged(object sender, EventArgs e)
        {
            if (dt.TextLength == 2)
            {
                mt.Focus();
            }
            else if (dt.TextLength > 2)
            {
                dt.Text = "";
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            if (id.TextLength == 2)
            {
                im.Focus();
            }
            else if (id.TextLength > 2)
            {
                id.Text = "";
            }
        }

        private void bd_TextChanged(object sender, EventArgs e)
        {
            if (bd.TextLength == 2)
            {
                bm.Focus();
            }
            else if (bd.TextLength > 2)
            {
                bd.Text = "";
            }
        }

        private void psd_TextChanged(object sender, EventArgs e)
        {
            if (psd.TextLength == 2)
            {
                psm.Focus();
            }
            else if (psd.TextLength > 2)
            {
                psd.Text = "";
            }
        }

        private void pd_TextChanged(object sender, EventArgs e)
        {
            if (pd.TextLength == 2)
            {
                pm.Focus();
            }
            else if (pd.TextLength > 2)
            {
                pd.Text = "";
            }
        }

        private void vd_TextChanged(object sender, EventArgs e)
        {
            if (vd.TextLength == 2)
            {
                vm.Focus();
            }
            else if (vd.TextLength > 2)
            {
                vd.Text = "";
            }
        }

        private void sd_TextChanged(object sender, EventArgs e)
        {
            if (sd.TextLength == 2)
            {
                sm.Focus();
            }
            else if (sd.TextLength > 2)
            {
                sd.Text = "";
            }
        }

        private void cd_TextChanged(object sender, EventArgs e)
        {
            if (cd.TextLength == 2)
            {
                cm.Focus();
            }
            else if (cd.TextLength > 2)
            {
                cd.Text = "";
            }
        }

        private void od_TextChanged(object sender, EventArgs e)
        {
            if (od.TextLength == 2)
            {
               om.Focus();
            }
            else if (od.TextLength > 2)
            {
                od.Text = "";
            }
        }

        private void bld_TextChanged(object sender, EventArgs e)
        {
            if (bld.TextLength == 2)
            {
                blm.Focus();
            }
            else if (bld.TextLength > 2)
            {
                bld.Text = "";
            }
        }

        private void dt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void yt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void im_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void iy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void by_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void psd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void psm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void psy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void py_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void vd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void vm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void vy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void sd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void sm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void od_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void om_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void oy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bld_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void blm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mt_TextChanged(object sender, EventArgs e)
        {
            if (mt.TextLength == 2)
            {
                yt.Focus();
            }
            else if (mt.TextLength > 2)
            {
                mt.Text = "";
            }
        }

        private void im_TextChanged(object sender, EventArgs e)
        {
            if (im.TextLength == 2)
            {
                iy.Focus();
            }
            else if (im.TextLength > 2)
            {
                im.Text = "";
            }
        }

        private void bm_TextChanged(object sender, EventArgs e)
        {
            if (bm.TextLength == 2)
            {
                by.Focus();
            }
            else if (bm.TextLength > 2)
            {
                bm.Text = "";
            }
        }

        private void psm_TextChanged(object sender, EventArgs e)
        {
            if (psm.TextLength == 2)
            {
                psy.Focus();
            }
            else if (psm.TextLength > 2)
            {
                psm.Text = "";
            }
        }

        private void pm_TextChanged(object sender, EventArgs e)
        {
            if (pm.TextLength == 2)
            {
                py.Focus();
            }
            else if (pm.TextLength > 2)
            {
                pm.Text = "";
            }
        }

        private void vm_TextChanged(object sender, EventArgs e)
        {
            if (vm.TextLength == 2)
            {
                vy.Focus();
            }
            else if (vm.TextLength > 2)
            {
                vm.Text = "";
            }
        }

        private void sm_TextChanged(object sender, EventArgs e)
        {
            if (sm.TextLength == 2)
            {
                sy.Focus();
            }
            else if (sm.TextLength > 2)
            {
                sm.Text = "";
            }
        }

        private void cm_TextChanged(object sender, EventArgs e)
        {
            if (cm.TextLength == 2)
            {
                cy.Focus();
            }
            else if (cm.TextLength > 2)
            {
                cm.Text = "";
            }
        }

        private void om_TextChanged(object sender, EventArgs e)
        {
            if (om.TextLength == 2)
            {
                oy.Focus();
            }
            else if (om.TextLength > 2)
            {
                om.Text = "";
            }
        }

        private void blm_TextChanged(object sender, EventArgs e)
        {
            if (blm.TextLength == 2)
            {
                bly.Focus();
            }
            else if (blm.TextLength > 2)
            {
                blm.Text = "";
            }
        }

        private void yt_TextChanged(object sender, EventArgs e)
        {
            if (yt.TextLength > 4)
            {
                yt.Text = "";
            }
        }

        private void iy_TextChanged(object sender, EventArgs e)
        {
            if (iy.TextLength > 4)
            {
                iy.Text = "";
            }
        }

        private void by_TextChanged(object sender, EventArgs e)
        {
            if (by.TextLength > 4)
            {
                by.Text = "";
            }
        }

        private void psy_TextChanged(object sender, EventArgs e)
        {
            if (psy.TextLength > 4)
            {
                psy.Text = "";
            }
        }

        private void py_TextChanged(object sender, EventArgs e)
        {
            if (py.TextLength > 4)
            {
                py.Text = "";
            }
        }

        private void vy_TextChanged(object sender, EventArgs e)
        {
            if (vy.TextLength > 4)
            {
                vy.Text = "";
            }
        }

        private void sy_TextChanged(object sender, EventArgs e)
        {
            if (sy.TextLength > 4)
            {
                sy.Text = "";
            }
        }

        private void cy_TextChanged(object sender, EventArgs e)
        {
            if (cy.TextLength > 4)
            {
                cy.Text = "";
            }
        }

        private void oy_TextChanged(object sender, EventArgs e)
        {
            if (oy.TextLength > 4)
            {
                oy.Text = "";
            }
        }

        private void bly_TextChanged(object sender, EventArgs e)
        {
            if (bly.TextLength > 4)
            {
                bly.Text = "";
            }
        }
    }

}
