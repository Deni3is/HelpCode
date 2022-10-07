using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Work_Dock
{
    static class dat
    {
        static MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);
        public static string day1;
        public static string month1;
        public static string year1;
        public static string day2;
        public static string month2;
        public static string year2;
        static public void schitivanie(string dateName, string dateStart, string dateEnd)
        {
            MySqlDataReader reader = null;
            Const.Const.openConnection(connection);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT `Субъект_РФ`,sum(`Число_обследованных`) as Число_обследованных," +
                    " sum(`Вз_Туберкулёз`) as Вз_Туберкулёз, sum(`Вз_Вич`) as Вз_Вич," +
                "sum(`Вз_ИППП`) as Вз_ИППП, sum(`Вз_Сахарный_диабет`) as Вз_Сахарный_диабет, sum(`Вз_Болезни_системы_кровообращения`) as Вз_Болезни_системы_кровообращения, sum(`Вз_Гепатит_B_C`) as Вз_Гепатит_B_C," +
                "sum(`Вз_Онкологические_заболевания`) as Вз_Онкологические_заболевания, sum(`Вз_Психические_растройства`) as Вз_Психические_растройства," +
                "sum(`Вз_Прочие_заболевания`) as Вз_Прочие_заболевания FROM `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` WHERE " +
               dateName + " >= '" + dateStart + "' AND " + dateName + "<= '" + dateEnd + "' ;", Const.Const.getConnection(connection));
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datedate.chislo_obs += Convert.ToInt32(reader["Число_обследованных"]);
                    datedate.hpv += Convert.ToInt32(reader["Вз_Вич"]);
                    datedate.ippp += Convert.ToInt32(reader["Вз_ИППП"]);
                    datedate.shugar += Convert.ToInt32(reader["Вз_Сахарный_диабет"]);
                    datedate.blood += Convert.ToInt32(reader["Вз_Болезни_системы_кровообращения"]);
                    datedate.gep += Convert.ToInt32(reader["Вз_Гепатит_B_C"]);
                    datedate.onc += Convert.ToInt32(reader["Вз_Онкологические_заболевания"]);
                    datedate.psyho += Convert.ToInt32(reader["Вз_Психические_растройства"]);
                    datedate.tyber += Convert.ToInt32(reader["Вз_Туберкулёз"]);
                    datedate.other += Convert.ToInt32(reader["Вз_Прочие_заболевания"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Const.Const.closeConnection(connection);

        }
        static public void schitivanie2(string dateName, string dateStart, string dateEnd)
        {
            MySqlDataReader reader = null;
            Const.Const.openConnection(connection);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT  `Именование_субъекта_РФ`, `Наим_мед_организации`," +
                    "sum(`Гос_Вс_Взрослые_Всего`) as Гос_Вс_Взрослые_Всего, sum(`Гос_Вс_Взрослые_втч_раненых`) as Гос_Вс_Взрослые_втч_раненых, sum(`Гос_Вс_Взрослые_втч_берем_женщин`) as Гос_Вс_Взрослые_втч_берем_женщин, " +
                    "sum(`Гос_Вс_Дети_Всего`) as Гос_Вс_Дети_Всего, sum(`Гос_Вс_Дети_втч_раненых`) as Гос_Вс_Дети_втч_раненых, sum(`Гос_Вс_Дети_втч_до_1_года`) as Гос_Вс_Дети_втч_до_1_года," +
                    " sum(`Гос_Из_них_край_тяж_Взрос_Всего`) as Гос_Из_них_край_тяж_Взрос_Всего, sum(`Гос_Из_них_край_тяж_Взрос_втч_ранен`) as Гос_Из_них_край_тяж_Взрос_втч_ранен, sum(`Гос_Из_них_край_тяж_Взрос_втч_берем`) as Гос_Из_них_край_тяж_Взрос_втч_берем," +
                    " sum(`Гос_Из_них_край_тяж_Дети_Всего`) as Гос_Из_них_край_тяж_Дети_Всего, sum(`Гос_Из_них_край_тяж_Дети_втч_ранен`) as Гос_Из_них_край_тяж_Дети_втч_ранен, sum(`Гос_Из_них_край_тяж_Дети_втч_до_1г`) as Гос_Из_них_край_тяж_Дети_втч_до_1г," +
                    " sum(`Гос_Из_них_тяж_Взрос_Всего`) as Гос_Из_них_тяж_Взрос_Всего, sum(`Гос_Из_них_тяж_Взрос_втч_раненых`) as Гос_Из_них_тяж_Взрос_втч_раненых, sum(`Гос_Из_них_тяж_Взрос_втч_берем_жен`) as Гос_Из_них_тяж_Взрос_втч_берем_жен," +
                    " sum(`Гос_Из_них_тяж_Дети_Всего`) as Гос_Из_них_тяж_Дети_Всего, sum(`Гос_Из_них_тяж_Дети_втч_раненых`) as Гос_Из_них_тяж_Дети_втч_раненых, sum(`Гос_Из_них_тяж_Дети_втч_до_1_года`) as Гос_Из_них_тяж_Дети_втч_до_1_года, " +
                    "sum(`Гос_Из_них_лёгк_Взрос_Всего`) as Гос_Из_них_лёгк_Взрос_Всего, sum(`Гос_Из_них_лёгк_Взрос_втч_ранен`) as Гос_Из_них_лёгк_Взрос_втч_ранен, sum(`Гос_Из_них_лёгк_Взрос_втч_берем_жен`) as Гос_Из_них_лёгк_Взрос_втч_берем_жен," +
                    " sum(`Гос_Из_них_лёгк_Дети_Всего`) as Гос_Из_них_лёгк_Дети_Всего, sum(`Гос_Из_них_лёгк_Дети_втч_раненых`) as Гос_Из_них_лёгк_Дети_втч_раненых, sum(`Гос_Из_них_лёгк_Дети_втч_до_1_года`) as Гос_Из_них_лёгк_Дети_втч_до_1_года" +
                    " FROM hotel.svedeniya_o_gospitalizacii_pribyvshih WHERE " +
                   dateName + " >= '" + dateStart + "' AND " + dateName + "<= '" + dateEnd + "' ;", Const.Const.getConnection(connection));


                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datedate.syb = Convert.ToString(reader["Именование_субъекта_РФ"]);
                    datedate.med = Convert.ToString(reader["Наим_мед_организации"]);
                    datedate.all_vzr += Convert.ToInt32(reader["Гос_Вс_Взрослые_Всего"]);
                    datedate.all_vzr_ran += Convert.ToInt32(reader["Гос_Вс_Взрослые_втч_раненых"]);
                    datedate.all_vzr_berem += Convert.ToInt32(reader["Гос_Вс_Взрослые_втч_берем_женщин"]);
                    datedate.all_det += Convert.ToInt32(reader["Гос_Вс_Дети_Всего"]);
                    datedate.all_det_ran += Convert.ToInt32(reader["Гос_Вс_Дети_втч_раненых"]);
                    datedate.all_det_1 += Convert.ToInt32(reader["Гос_Вс_Дети_втч_до_1_года"]);
                    datedate.kr_tyazh_all_vzr += Convert.ToInt32(reader["Гос_Из_них_край_тяж_Взрос_Всего"]);
                    datedate.kr_tyazh_ran += Convert.ToInt32(reader["Гос_Из_них_край_тяж_Взрос_втч_ранен"]);
                    datedate.kr_tyazh_ber += Convert.ToInt32(reader["Гос_Из_них_край_тяж_Взрос_втч_берем"]);
                    datedate.kr_tyazh_det += Convert.ToInt32(reader["Гос_Из_них_край_тяж_Дети_Всего"]);
                    datedate.kr_tyazh_det_ran += Convert.ToInt32(reader["Гос_Из_них_край_тяж_Дети_втч_ранен"]);
                    datedate.kr_tyazh_det_1 += Convert.ToInt32(reader["Гос_Из_них_край_тяж_Дети_втч_до_1г"]);
                    datedate.tyazh_all_vzr += Convert.ToInt32(reader["Гос_Из_них_тяж_Взрос_Всего"]);
                    datedate.tyazh_ran += Convert.ToInt32(reader["Гос_Из_них_тяж_Взрос_втч_раненых"]);
                    datedate.tyazh_ber += Convert.ToInt32(reader["Гос_Из_них_тяж_Взрос_втч_берем_жен"]);
                    datedate.tyazh_det += Convert.ToInt32(reader["Гос_Из_них_тяж_Дети_Всего"]);
                    datedate.tyazh_det_ran += Convert.ToInt32(reader["Гос_Из_них_тяж_Дети_втч_раненых"]);
                    datedate.tyazh_det_1 += Convert.ToInt32(reader["Гос_Из_них_тяж_Дети_втч_до_1_года"]);
                    datedate.leg_tyazh_all_vzr += Convert.ToInt32(reader["Гос_Из_них_лёгк_Взрос_Всего"]);
                    datedate.leg_tyazh_ran += Convert.ToInt32(reader["Гос_Из_них_лёгк_Взрос_втч_ранен"]);
                    datedate.leg_tyazh_ber += Convert.ToInt32(reader["Гос_Из_них_лёгк_Взрос_втч_берем_жен"]);
                    datedate.leg_tyazh_det += Convert.ToInt32(reader["Гос_Из_них_лёгк_Дети_Всего"]);
                    datedate.leg_tyazh_det_ran += Convert.ToInt32(reader["Гос_Из_них_лёгк_Дети_втч_раненых"]);
                    datedate.leg_tyazh_det_1 += Convert.ToInt32(reader["Гос_Из_них_лёгк_Дети_втч_до_1_года"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Const.Const.closeConnection(connection);

        }
        static public void schitivanie3(string dateName, string dateStart, string dateEnd)
        {
            MySqlDataReader reader = null;
            Const.Const.openConnection(connection);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT `Наименование_субъекта_РФ`, `Наименование_муп_субъекта_РФ`, " +
                    " sum(`Иммун_Всего`) as Иммун_Всего,  sum(`Иммун_Детей_Всего`) as Иммун_Детей_Всего,  sum(`Иммун_Детей_до_1_года`) as Иммун_Детей_до_1_года,  sum(`Иммун_Беременных_женщин`) as Иммун_Беременных_женщин, " +
                    " sum(`Вак_но_от_Covid_Всего`) as Вак_но_от_Covid_Всего,  sum(`Вак_но_от_Covid_Детей_Всего`) as Вак_но_от_Covid_Детей_Всего,  sum(`Вак_но_от_Covid_Детей_до_1_года`) as Вак_но_от_Covid_Детей_до_1_года,  sum(`Вак_но_от_Covid_Беременных_женщин`) as Вак_но_от_Covid_Беременных_женщин " +
                    "FROM hotel.svedeniya_o_vakcinacii_pribyvshih WHERE " +
                   dateName + " >= '" + dateStart + "' AND " + dateName + "<= '" + dateEnd + "' ;", Const.Const.getConnection(connection));
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    datedate.imun_all += Convert.ToInt32(reader["Иммун_Всего"]);
                    datedate.imun_deti += Convert.ToInt32(reader["Иммун_Детей_Всего"]);
                    datedate.imun_det_1 += Convert.ToInt32(reader["Иммун_Детей_до_1_года"]);
                    datedate.imun_berm += Convert.ToInt32(reader["Иммун_Беременных_женщин"]);
                    datedate.vakc_all += Convert.ToInt32(reader["Вак_но_от_Covid_Всего"]);
                    datedate.vakc_det += Convert.ToInt32(reader["Вак_но_от_Covid_Детей_Всего"]);
                    datedate.vakc_det_1 += Convert.ToInt32(reader["Вак_но_от_Covid_Детей_до_1_года"]);
                    datedate.vakc_berem += Convert.ToInt32(reader["Вак_но_от_Covid_Беременных_женщин"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Const.Const.closeConnection(connection);


        }
        static public void schitivanie4(string dateName, string dateStart, string dateEnd)
        {
            MySqlDataReader reader = null;
            Const.Const.openConnection(connection);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT sum(`Кол_приб_Всего`) as Кол_приб_Всего , sum(`Кол_приб_Из_них_детей`) as Кол_приб_Из_них_детей, sum(`Кол_приб_втм_Приб_гражд_РФ_Всего`) as Кол_приб_втм_Приб_гражд_РФ_Всего,sum(`Кол_приб_втм_Приб_гражд_РФ_детей`) as Кол_приб_втм_Приб_гражд_РФ_детей," +
                    " sum(`Кол_приб_Свед_о_вакц_от_Covid_Вакц`) as Кол_приб_Свед_о_вакц_от_Covid_Вакц, sum(`Кол_приб_Свед_о_вакц_от_Covid_Невак`) as Кол_приб_Свед_о_вакц_от_Covid_Невак," +
                "sum(`Кол_приб_Присвоен_статус_беженца`) as Кол_приб_Присвоен_статус_беженца, sum(`ПВР_ПВР_вс_Количество_ПВР`) as ПВР_ПВР_вс_Количество_ПВР, sum(`ПВР_ПВР_вс_Макс_вмест_по_всем_ПВР`) as ПВР_ПВР_вс_Макс_вмест_по_всем_ПВР," +
                "sum(`ПВР_Разв_ПВР_Разм_Всего`) as ПВР_Разв_ПВР_Разм_Всего, sum(`ПВР_Разв_ПВР_Разм_Детей_Всего`) as ПВР_Разв_ПВР_Разм_Детей_Всего, sum(`ПВР_Разв_ПВР_Разм_Детей_до_1_года`) as ПВР_Разв_ПВР_Разм_Детей_до_1_года," +
                 "sum(`ПВР_Разв_ПВР_Разм_С_огран_возм_Вс`) as ПВР_Разв_ПВР_Разм_С_огран_возм_Вс, sum(`ПВР_Разв_ПВР_Разм_С_огран_возм_Дет`) as ПВР_Разв_ПВР_Разм_С_огран_возм_Дет, sum(`ПВР_Разв_ПВР_Разм_Берем_женщин`) as ПВР_Разв_ПВР_Разм_Берем_женщин," +
                 "sum(`ПВР_Разв_ПВР_Обрат_за_мед_пом_Всего`) as ПВР_Разв_ПВР_Обрат_за_мед_пом_Всего, sum(`ПВР_Разв_ПВР_Обрат_мед_пом_Детей_Вс`) as ПВР_Разв_ПВР_Обрат_мед_пом_Детей_Вс, sum(`ПВР_Разв_ПВР_Обрат_мед_пом_Дет_до_1г`) as ПВР_Разв_ПВР_Обрат_мед_пом_Дет_до_1г," +
                 "sum(`ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Вс`) as ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Вс, sum(`ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Дет`) as ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Дет, sum(`ПВР_Разв_ПВР_Обрат_мед_пом_Берем_жн`) as ПВР_Разв_ПВР_Обрат_мед_пом_Берем_жн," +
                "sum(`ПВР_Разв_ПВР_Проведено_родов`) as ПВР_Разв_ПВР_Проведено_родов, sum(`ПВР_Разв_ПВР_Родилось_детей`) as ПВР_Разв_ПВР_Родилось_детей " +
                 "FROM hotel.svodnaya_tablica_po_razmeshcheniyu_pribyvshih WHERE " +
                   dateName + " >='" + dateStart + "' AND " + dateName + "<= '" + dateEnd + "' ;", Const.Const.getConnection(connection));
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datedate.prib_all += Convert.ToInt32(reader["Кол_приб_Всего"]);
                    datedate.prib_all_det += Convert.ToInt32(reader["Кол_приб_Из_них_детей"]);
                    datedate.prib_all_rf += Convert.ToInt32(reader["Кол_приб_втм_Приб_гражд_РФ_Всего"]);
                    datedate.prib_all_rf_det += Convert.ToInt32(reader["Кол_приб_втм_Приб_гражд_РФ_детей"]);
                    datedate.vakc += Convert.ToInt32(reader["Кол_приб_Свед_о_вакц_от_Covid_Вакц"]);
                    datedate.nevakc += Convert.ToInt32(reader["Кол_приб_Свед_о_вакц_от_Covid_Невак"]);
                    datedate.bejen += Convert.ToInt32(reader["Кол_приб_Присвоен_статус_беженца"]);
                    datedate.kol_pvr += Convert.ToInt32(reader["ПВР_ПВР_вс_Количество_ПВР"]);
                    datedate.vmest_pvr += Convert.ToInt32(reader["ПВР_ПВР_вс_Макс_вмест_по_всем_ПВР"]);
                    datedate.razmesh_all += Convert.ToInt32(reader["ПВР_Разв_ПВР_Разм_Всего"]);
                    datedate.razmesh_det += Convert.ToInt32(reader["ПВР_Разв_ПВР_Разм_Детей_Всего"]);
                    datedate.razmesh_det_1 += Convert.ToInt32(reader["ПВР_Разв_ПВР_Разм_Детей_до_1_года"]);
                    datedate.razmesh_all_ogr += Convert.ToInt32(reader["ПВР_Разв_ПВР_Разм_С_огран_возм_Вс"]);
                    datedate.razmesh_all_ogr_det += Convert.ToInt32(reader["ПВР_Разв_ПВР_Разм_С_огран_возм_Дет"]);
                    datedate.razmesh_berem += Convert.ToInt32(reader["ПВР_Разв_ПВР_Разм_Берем_женщин"]);
                    datedate.obr_all += Convert.ToInt32(reader["ПВР_Разв_ПВР_Обрат_за_мед_пом_Всего"]);
                    datedate.obr_det += Convert.ToInt32(reader["ПВР_Разв_ПВР_Обрат_мед_пом_Детей_Вс"]);
                    datedate.obr_det_1 += Convert.ToInt32(reader["ПВР_Разв_ПВР_Обрат_мед_пом_Дет_до_1г"]);
                    datedate.obr_ogr += Convert.ToInt32(reader["ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Вс"]);
                    datedate.obr_ogr_det += Convert.ToInt32(reader["ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Дет"]);
                    datedate.obr_berem += Convert.ToInt32(reader["ПВР_Разв_ПВР_Обрат_мед_пом_Берем_жн"]);
                    datedate.rody += Convert.ToInt32(reader["ПВР_Разв_ПВР_Проведено_родов"]);
                    datedate.rody_det += Convert.ToInt32(reader["ПВР_Разв_ПВР_Родилось_детей"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Const.Const.closeConnection(connection);

        }


        static public string num_card, IPPP_obsl, IPPP_bolen, IPPP_date, IPPP_komment,
        Tubercul_obsl, Tubercul_bolen, Tubercul_date, Tubercul_komment, Gepatit_B_obsl, Gepatit_B_bolen, Gepatit_B_date, Gepatit_B_komment,
        Gepatit_C_obsl, Gepatit_C_bolen, Gepatit_C_date, Gepatit_C_komment,
        VICH_infection_obsl, VICH_infection_bolen, VICH_infection_date, VICH_infection_komment,
        Sahar_diabet_obsl, Sahar_diabet_bolen, Sahar_diabet_date, Sahar_diabet_komment,
        Psih_rastr_obsl, Psih_rastr_bolen, Psih_rastr_date, Psih_rastr_komment,
        Onkol_zabol_obsl, Onkol_zabol_bolen, Onkol_zabol_date, Onkol_zabol_komment,
        Bol_syst_krov_obsl, Bol_syst_krov_bolen, Bol_syst_krov_date, Bol_syst_krov_komment,
        Proch_zabol_obsl, Proch_zabol_bolen, Proch_zabol_date, Proch_zabol_kakie;



        static public void people()
        {
            MySqlDataReader reader = null;

            MySqlCommand command = new MySqlCommand("SELECT `Номер_Карточки`," +
                "`ИППП_обследование`, `ИППП_болен`, `ИППП_дата`, `ИППП_комментарий`," +
                "`Туберкулез_обследование`, `Туберкулез_болен`, `Туберкулез_дата`, `Туберкулёз_комментарий`," +
                "`Гепатит_B_обследование`, `Гепатит_B_болен`, `Гепатит_B_дата`, `Гепатит_В_комментарий`," +
                "`Гепатит_C_обследование`, `Гепатит_C_болен`, `Гепатит_C_дата`, `Гепатит_С_комментарий`," +
                "`ВИЧ_инфекция_обследование`, `ВИЧ_инфекция_болен`, `ВИЧ_инфекция_дата`, `ВИЧ_комментарий`," +
                "`Сахарный_диабет_обследование`, `Сахарный_диабет_болен`, `Сахарный_диабет_дата`, `Сахар_комментарий`," +
                "`Психические_расстройства_обследование`, `Психические_расстройства_болен`, `Психические_расстройства_дата`, `Псих_комментарий`," +
                "`Онкологические_заболевания_обследование`, `Онкологические_заболевания_болен`, `Онкологические_заболевания_дата`, `Онкология_коммент`," +
                "`Болезни_системы_кровообращения_обследование`, `Болезни_системы_кровообращения_болен`, `Болезни_системы_кровообращения_дата`, `Болезни_крови_коммент`," +
                "`Прочие_заболевания_обследование`, `Прочие_заболевания_болен`, `Прочие_заболевания_дата`, `Какие_прочие_заболевания` FROM `list_bolezney` WHERE" +
                "`Номер_Карточки` = @fam", Const.Const.getConnection(connection)); //тут изменить fam на что либо
            command.Parameters.Add("@fam", MySqlDbType.VarChar).Value = Forms.FromPC.Findpeople.num_card; //тут так же изменить
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                num_card = Convert.ToString(reader["Номер_карточки"]);

                IPPP_obsl = Convert.ToString(reader["ИППП_обследование"]);
                IPPP_bolen = Convert.ToString(reader["ИППП_болен"]);
                IPPP_date = Convert.ToString(reader["ИППП_дата"]);
                IPPP_komment = Convert.ToString(reader["ИППП_комментарий"]);

                Tubercul_obsl = Convert.ToString(reader["Туберкулез_обследование"]);
                Tubercul_bolen = Convert.ToString(reader["Туберкулез_болен"]);
                Tubercul_date = Convert.ToString(reader["Туберкулез_дата"]);
                Tubercul_komment = Convert.ToString(reader["Туберкулёз_комментарий"]);

                Gepatit_B_obsl = Convert.ToString(reader["Гепатит_B_обследование"]);
                Gepatit_B_bolen = Convert.ToString(reader["Гепатит_B_болен"]);
                Gepatit_B_date = Convert.ToString(reader["Гепатит_B_дата"]);
                Gepatit_B_komment = Convert.ToString(reader["Гепатит_В_комментарий"]);

                Gepatit_C_obsl = Convert.ToString(reader["Гепатит_C_обследование"]);
                Gepatit_C_bolen = Convert.ToString(reader["Гепатит_C_болен"]);
                Gepatit_C_date = Convert.ToString(reader["Гепатит_C_дата"]);
                Gepatit_C_komment = Convert.ToString(reader["Гепатит_С_комментарий"]);

                VICH_infection_obsl = Convert.ToString(reader["ВИЧ_инфекция_обследование"]);
                VICH_infection_bolen = Convert.ToString(reader["ВИЧ_инфекция_болен"]);
                VICH_infection_date = Convert.ToString(reader["ВИЧ_инфекция_дата"]);
                VICH_infection_komment = Convert.ToString(reader["ВИЧ_комментарий"]);

                Sahar_diabet_obsl = Convert.ToString(reader["Сахарный_диабет_обследование"]);
                Sahar_diabet_bolen = Convert.ToString(reader["Сахарный_диабет_болен"]);
                Sahar_diabet_date = Convert.ToString(reader["Сахарный_диабет_дата"]);
                Sahar_diabet_komment = Convert.ToString(reader["Сахар_комментарий"]);

                Psih_rastr_obsl = Convert.ToString(reader["Психические_расстройства_обследование"]);
                Psih_rastr_bolen = Convert.ToString(reader["Психические_расстройства_болен"]);
                Psih_rastr_date = Convert.ToString(reader["Психические_расстройства_дата"]);
                Psih_rastr_komment = Convert.ToString(reader["Псих_комментарий"]);

                Onkol_zabol_obsl = Convert.ToString(reader["Онкологические_заболевания_обследование"]);
                Onkol_zabol_bolen = Convert.ToString(reader["Онкологические_заболевания_болен"]);
                Onkol_zabol_date = Convert.ToString(reader["Онкологические_заболевания_дата"]);
                Onkol_zabol_komment = Convert.ToString(reader["Онкология_коммент"]);

                Bol_syst_krov_obsl = Convert.ToString(reader["Болезни_системы_кровообращения_обследование"]);
                Bol_syst_krov_bolen = Convert.ToString(reader["Болезни_системы_кровообращения_болен"]);
                Bol_syst_krov_date = Convert.ToString(reader["Болезни_системы_кровообращения_дата"]);
                Bol_syst_krov_komment = Convert.ToString(reader["Болезни_крови_коммент"]);

                Proch_zabol_obsl = Convert.ToString(reader["Прочие_заболевания_обследование"]);
                Proch_zabol_bolen = Convert.ToString(reader["Прочие_заболевания_болен"]);
                Proch_zabol_date = Convert.ToString(reader["Прочие_заболевания_дата"]);
                Proch_zabol_kakie = Convert.ToString(reader["Какие_прочие_заболевания"]);

            }
        }
    }


}
