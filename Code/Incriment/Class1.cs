using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Hotel.Class1_Incriment
{
    class Class1
    {
        MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);

        

        public void incriment_for_Razm_prib(bool beremen, int age, int rojdeno, string date, bool grazhd_RF, bool vacinir, bool bezhen)
        {
            Const.Const.openConnection(connection);
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT `Ключ`" +
                    " FROM `svodnaya_tablica_po_razmeshcheniyu_pribyvshih`" +
                    " WHERE `Дата` = '" + date + "';", Const.Const.getConnection(connection));
            reader = command.ExecuteReader();

            int key = 0;
            while (reader.Read())
            {
                key = Convert.ToInt32(reader["Ключ"]);
            }
            Const.Const.closeConnection(connection);
            //
            //ДОБАВЛЯЮТСЯ КО ВСЕМ, ДОРАБОТАТЬ ПРИ ПОЯВЛЕНИИ НОВЫХ СУБЪЕКТОВ РФ
            //
            Const.Const .openConnection(connection);
            command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET" +
               " `Кол_приб_Всего` = `Кол_приб_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
            command.ExecuteNonQuery();
            try
            {
                
                if (age < 18)
                {
                    command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET `Кол_приб_Из_них_детей` = `Кол_приб_Из_них_детей` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (grazhd_RF == true)
                {
                    command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET `Кол_приб_втм_Приб_гражд_РФ_Всего` = `Кол_приб_втм_Приб_гражд_РФ_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                    if (age < 18)
                    {
                        command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET `Кол_приб_втм_Приб_гражд_РФ_детей` = `Кол_приб_втм_Приб_гражд_РФ_детей` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                }
                if (vacinir == true)
                {
                    command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET `Кол_приб_Свед_о_вакц_от_Covid_Вакц` = `Кол_приб_Свед_о_вакц_от_Covid_Вакц` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                else
                {
                    command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET `Кол_приб_Свед_о_вакц_от_Covid_Невак` = `Кол_приб_Свед_о_вакц_от_Covid_Невак` + 1;", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (bezhen == true)
                {
                    command = new MySqlCommand("UPDATE `svodnaya_tablica_po_razmeshcheniyu_pribyvshih` SET `Кол_приб_Присвоен_статус_беженца` = `Кол_приб_Присвоен_статус_беженца` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }

   
            }
            catch
            {
            }
            Const.Const.closeConnection(connection);
        }

        public void inc_o_bolezn(bool tubercul, bool VICH, bool IPPP, bool Sugar_diabet, bool blood, bool Gepatit_b_c, bool oncolog, bool psihycal, bool other, string date)
        {
            Const.Const.openConnection(connection);
            try
            {
                MySqlDataReader reader = null;
                
                MySqlCommand command = new MySqlCommand("SELECT `Ключ`" +
                        " FROM `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan`" +
                        " WHERE `Дата` = '" + date + "';", Const.Const.getConnection(connection));
                reader = command.ExecuteReader();

                int key = 0;
                while (reader.Read())
                {
                    key = Convert.ToInt32(reader["Ключ"]);
                }
                //
                //ДОБАВЛЯЮТСЯ КО ВСЕМ, ДОРАБОТАТЬ ПРИ ПОЯВЛЕНИИ НОВЫХ СУБЪЕКТОВ РФ
                //
                Const.Const.closeConnection(connection);
                Const.Const.openConnection(connection);
                command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Число_обследованных` = `Число_обследованных` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                command.ExecuteNonQuery().ToString();
                if (tubercul == true)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Туберкулёз` = `Вз_Туберкулёз` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (VICH)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Вич` = `Вз_Вич` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (IPPP)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_ИППП` = `Вз_ИППП` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (Sugar_diabet)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Сахарный_диабет` = `Вз_Сахарный_диабет` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (blood)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Болезни_системы_кровообращения` = `Вз_Болезни_системы_кровообращения` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (Gepatit_b_c)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Гепатит_B_C` = `Вз_Гепатит_B_C` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (oncolog)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Онкологические_заболевания` = `Вз_Онкологические_заболевания` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (psihycal)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Психические_растройства` = `Вз_Психические_растройства` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }
                if (other)
                {
                    command = new MySqlCommand("UPDATE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` SET `Вз_Прочие_заболевания` = `Вз_Прочие_заболевания` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                }

                
            }
            catch
            {
            }
            Const.Const.closeConnection(connection);
        }

        public void inc_for_vac(bool imun, bool vac, bool beremen, int age, string date)
        {
            Const.Const.openConnection(connection);
            try
            {
                MySqlDataReader reader = null;
               
                MySqlCommand command = new MySqlCommand("SELECT `Ключ`" +
                        " FROM `svedeniya_o_vakcinacii_pribyvshih`" +
                        " WHERE `Дата` = '" + date + "';", Const.Const.getConnection(connection));
                reader = command.ExecuteReader();

                int key = 0;
                while (reader.Read())
                {
                    key = Convert.ToInt32(reader["Ключ"]);
                }
                Const.Const.closeConnection(connection);
                Const.Const.openConnection(connection);
                //
                //ДОБАВЛЯЮТСЯ КО ВСЕМ, ДОРАБОТАТЬ ПРИ ПОЯВЛЕНИИ НОВЫХ СУБЪЕКТОВ РФ
                //


                if (imun)
                {
                    command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Иммун_Всего` = `Иммун_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                    if (age < 18)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Иммун_Детей_Всего` = `Иммун_Детей_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                        if (age < 1)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Иммун_Детей_до_1_года` = `Иммун_Детей_до_1_года` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }
                    if (beremen)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Иммун_Беременных_женщин` = `Иммун_Беременных_женщин` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                }
                if (vac)
                {
                    command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Вак_но_от_Covid_Всего` = `Вак_но_от_Covid_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                    if (age < 18)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Вак_но_от_Covid_Детей_Всего` = `Вак_но_от_Covid_Детей_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                        if (age < 1)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Вак_но_от_Covid_Детей_до_1_года` = `Вак_но_от_Covid_Детей_до_1_года` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }
                    if (beremen)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_vakcinacii_pribyvshih` SET `Вак_но_от_Covid_Беременных_женщин` = `Вак_но_от_Covid_Беременных_женщин` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                }


            }
            catch
            {

            }
            Const.Const.closeConnection(connection);
        }

        public void inc_for_hospit(int age, bool beremen, bool ranen, bool kraine_tyazh, bool tyazh, bool leghk, string date)
        {
            Const.Const.openConnection(connection);

            try
            {
                MySqlCommand command = null;
                Const.Const.openConnection(connection);
                //
                //ДОБАВЛЯЮТСЯ КО ВСЕМ, ДОРАБОТАТЬ ПРИ ПОЯВЛЕНИИ НОВЫХ СУБЪЕКТОВ РФ
                //
                if (age >= 6570)
                {
                    command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Вс_Взрослые_Всего` = `Гос_Вс_Взрослые_Всего` + 1 where `Дата` =current_date() ;", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                    if (ranen)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Вс_Взрослые_втч_раненых` = `Гос_Вс_Взрослые_втч_раненых` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                    if (beremen)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Вс_Взрослые_втч_берем_женщин` = `Гос_Вс_Взрослые_втч_берем_женщин` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                    if (kraine_tyazh)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_край_тяж_Взрос_Всего` = `Гос_Из_них_край_тяж_Взрос_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();

                        if (ranen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_край_тяж_Взрос_втч_ранен` = `Гос_Из_них_край_тяж_Взрос_втч_ранен` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                        if (beremen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_край_тяж_Взрос_втч_берем` = `Гос_Из_них_край_тяж_Взрос_втч_берем` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }

                    if (tyazh)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_тяж_Взрос_Всего` = `Гос_Из_них_тяж_Взрос_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();

                        if (ranen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_тяж_Взрос_втч_раненых` = `Гос_Из_них_тяж_Взрос_втч_раненых` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                        if (beremen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_тяж_Взрос_втч_берем_жен` = `Гос_Из_них_тяж_Взрос_втч_берем_жен` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }

                    if (leghk)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_лёгк_Взрос_Всего` = `Гос_Из_них_лёгк_Взрос_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();

                        if (ranen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_лёгк_Взрос_втч_ранен` = `Гос_Из_них_лёгк_Взрос_втч_ранен` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                        if (beremen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_лёгк_Взрос_втч_берем_жен` = `Гос_Из_них_лёгк_Взрос_втч_берем_жен` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }
                }
                if (age < 6570 )
                {
                    command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Вс_Дети_Всего` = `Гос_Вс_Дети_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery().ToString();
                    if (ranen)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Вс_Дети_втч_раненых` = `Гос_Вс_Дети_втч_раненых` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                    if (age < 365)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Вс_Дети_втч_до_1_года` = `Гос_Вс_Дети_втч_до_1_года` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                    }
                    if (kraine_tyazh)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_край_тяж_Дети_Всего` = `Гос_Из_них_край_тяж_Дети_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                        if (ranen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_край_тяж_Дети_втч_ранен` = `Гос_Из_них_край_тяж_Дети_втч_ранен` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                        if (age < 365)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_край_тяж_Дети_втч_до_1г` = `Гос_Из_них_край_тяж_Дети_втч_до_1г` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }

                    if (tyazh)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_тяж_Дети_Всего` = `Гос_Из_них_тяж_Дети_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                        if (ranen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_тяж_Дети_втч_раненых` = `Гос_Из_них_тяж_Дети_втч_раненых` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                        if (age < 365)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_тяж_Дети_втч_до_1_года` = `Гос_Из_них_тяж_Дети_втч_до_1_года` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }
                    if (leghk)
                    {
                        command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_лёгк_Дети_Всего` = `Гос_Из_них_лёгк_Дети_Всего` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                        command.ExecuteNonQuery().ToString();
                        if (ranen)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_лёгк_Дети_втч_раненых` = `Гос_Из_них_лёгк_Дети_втч_раненых` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                        if (age < 365)
                        {
                            command = new MySqlCommand("UPDATE `svedeniya_o_gospitalizacii_pribyvshih` SET `Гос_Из_них_лёгк_Дети_втч_до_1_года` = `Гос_Из_них_лёгк_Дети_втч_до_1_года` + 1 where `Дата` =current_date();", Const.Const.getConnection(connection));
                            command.ExecuteNonQuery().ToString();
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Const.Const.closeConnection(connection);
        }
    }
}
