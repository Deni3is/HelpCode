using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
namespace Hotel.Dobavlenie
{
    class Init
    {
        MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);

        public void init_dobavlenie(string name, string surname, string patr,
            DateTime dayrojdenia, int gender,
            DateTime daypostuplenia, int room, string grazdanstvo, int bezh,
            int berem, int rojdPVR, DateTime datarodov, int rojdenoVPVR,
            int covid, DateTime datecovid,
            int vacincovid, DateTime datevacin,
            int karantin, DateTime dateKarantin
           )
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `hotel`.`patient` (`Фамилия`, `Имя`, `Отчество`, `Дата_рождения`, `Пол`, `Дата_поступления_в_ПВР`, " +
                "`Номер_комнаты`, `Гражданство`, `Беженец`, `Беременность`, `Прошли_роды_в_ПВР`, " +
                "`Дата_родов`, `Родилось_детей_в_ПВР`, `Переболел_covid`, `Дата_постановки_диагноза_covid`, " +
                "`Вакцинирован_от_covid`, `Дата_вакцинации_от_covid`, `Карантин`, `Дата_начала_карантина`, `ИППП_болен`, `ИППП_дата`, " +
                "`Туберкулез_болен`, `Туберкулез_дата`,  `Гепатит_B_болен`, `Гепатит_B_дата`, `Гепатит_C_болен`, `Гепатит_C_дата`, " +
                "`ВИЧ_инфекция_болен`, `ВИЧ_инфекция_дата`, `АРВТ`,  `Сахарный_диабет_болен`, `Сахарный_диабет_дата`, `Психические_расстройства_болен`, " +
                "`Психические_расстройства_дата`, `Онкологические_заболевания_болен`, `Онкологические_заболевания_дата`,  `Болезни_системы_кровообращения_болен`, " +
                "`Болезни_системы_кровообращения_дата`, `Прочие_заболевания_болен`, `Прочие_заболевания_дата`, `Какие_прочие_заболевания`,`Ограниченные_возможности_болен`,`Ограниченные_возможности_коммент`,`Ограниченные_возможности_дата`) " +
                "VALUES (@sur, @name, @otchestvo, @datarojd, @pol, @datapostuplenia, @room, @grazdan, @bezhen, @berem, @rodilPVR, @datarodov,@rodelosPVR, @bolelcovid, @datasnyatia,@vacin, @datavacin, @karan, @datakaran, " +
                " @ipp_bol,@data1,  @tub_bol,@data2,  @gep_b_bol,@data3,  @gep_c_bol,@data4, @vich_bol,@data5,@arvt,  @sahar_bol,@data6,  @psih_bol,@data7," +
                "  @oncol_bol,@data8, @blood_bol,@data9, @projiezab_bol,@data10, @projie_info, @ogran, @ogran_info,@data11)", Const.Const.getConnection(connection));
            //Строки
            command.Parameters.Add("@sur", MySqlDbType.String).Value = surname;
            command.Parameters.Add("@name", MySqlDbType.String).Value = name;
            command.Parameters.Add("@otchestvo", MySqlDbType.String).Value = patr;
            command.Parameters.Add("@grazdan", MySqlDbType.String).Value = grazdanstvo;
            //Даты 
            command.Parameters.Add("@datarojd", MySqlDbType.DateTime).Value = dayrojdenia;
            command.Parameters.Add("@datapostuplenia", MySqlDbType.DateTime).Value = daypostuplenia;
            command.Parameters.Add("@datarodov", MySqlDbType.DateTime).Value = datarodov;
            command.Parameters.Add("@datasnyatia", MySqlDbType.DateTime).Value = datecovid;
            command.Parameters.Add("@datavacin", MySqlDbType.DateTime).Value = datevacin;
            command.Parameters.Add("@datakaran", MySqlDbType.DateTime).Value = dateKarantin;
            //Числа
            command.Parameters.Add("@pol", MySqlDbType.Int32).Value = gender;
            command.Parameters.Add("@room", MySqlDbType.Int32).Value = room;
            command.Parameters.Add("@bezhen", MySqlDbType.Int32).Value = bezh;
            command.Parameters.Add("@berem", MySqlDbType.Int32).Value = berem;
            command.Parameters.Add("@rodilPVR", MySqlDbType.Int32).Value = rojdPVR;
            command.Parameters.Add("@rodelosPVR", MySqlDbType.Int32).Value = rojdenoVPVR;
            command.Parameters.Add("@bolelcovid", MySqlDbType.Int32).Value = covid;
            command.Parameters.Add("@vacin", MySqlDbType.Int32).Value = vacincovid;
            command.Parameters.Add("@karan", MySqlDbType.Int32).Value = karantin;
            //В случае быстрого осмотра
            //Числа БУЛ
            command.Parameters.Add("@ipp_bol", MySqlDbType.Int32).Value = DataObs.ippp_bolen;
            command.Parameters.Add("@tub_bol", MySqlDbType.Int32).Value = DataObs.tyber_bolen;
            command.Parameters.Add("@gep_b_bol", MySqlDbType.Int32).Value = DataObs.gepatB_bolen;
            command.Parameters.Add("@gep_c_bol", MySqlDbType.Int32).Value = DataObs.gepatC_bolen;
            command.Parameters.Add("@vich_bol", MySqlDbType.Int32).Value = DataObs.vich_bolen;
            command.Parameters.Add("@sahar_bol", MySqlDbType.Int32).Value = DataObs.sahDiab_bolen;
            command.Parameters.Add("@psih_bol", MySqlDbType.Int32).Value = DataObs.psih_bolen;
            command.Parameters.Add("@oncol_bol", MySqlDbType.Int32).Value = DataObs.oncolog_bolen;
            command.Parameters.Add("@blood_bol", MySqlDbType.Int32).Value = DataObs.krov_bolen;
            command.Parameters.Add("@projiezab_bol", MySqlDbType.Int32).Value = DataObs.projee_bolen;
            command.Parameters.Add("@projie_info", MySqlDbType.String).Value = DataObs.zabolevan;
            command.Parameters.Add("@ogran", MySqlDbType.Int32).Value = DataObs.ogran_vozm;
            command.Parameters.Add("@ogran_info", MySqlDbType.String).Value = DataObs.diagnoz_ogr;
            //Даты
            command.Parameters.Add("@data1", MySqlDbType.Date).Value = DataObs.ippp_data;
            command.Parameters.Add("@data2", MySqlDbType.Date).Value = DataObs.tyber_data;
            command.Parameters.Add("@data3", MySqlDbType.Date).Value = DataObs.gepatB_data;
            command.Parameters.Add("@data4", MySqlDbType.Date).Value = DataObs.gepatC_data;
            command.Parameters.Add("@data5", MySqlDbType.Date).Value = DataObs.vich_data;
            command.Parameters.Add("@data6", MySqlDbType.Date).Value = DataObs.sahDiab_data;
            command.Parameters.Add("@data7", MySqlDbType.Date).Value = DataObs.psih_data;
            command.Parameters.Add("@data8", MySqlDbType.Date).Value = DataObs.oncolog_data;
            command.Parameters.Add("@data9", MySqlDbType.Date).Value = DataObs.krov_data;
            command.Parameters.Add("@data10", MySqlDbType.Date).Value = DataObs.projie_data;
            command.Parameters.Add("@data11", MySqlDbType.Date).Value = DataObs.ogrn_data;

            command.Parameters.Add("@arvt", MySqlDbType.Int32).Value = DataObs.vich_arvt;

            Const.Const.openConnection(connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь инициализирован");
            }
            else
            {
                MessageBox.Show("Произошла ошибка передачи данных");
            }
            Const.Const.closeConnection(connection);
        }

        public void dateforforms1()
        {
            Const.Const.openConnection(connection);
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT `Номер_карточки`,`Пол`," +
                    " `Дата_рождения`, `Дата_поступления_в_ПВР`," +
                "`Номер_комнаты`, `Гражданство`, `Беженец`, `Беременность`,`Дата_родов`, `Родилось_детей_в_ПВР`," +
                "`Переболел_covid`, `Дата_постановки_диагноза_covid`,`Вакцинирован_от_covid`, `Дата_вакцинации_от_covid`, " +
                "`Карантин`, `Дата_начала_карантина`,`Ограниченные_возможности_коммент` FROM hotel.patient WHERE `Фамилия` = @fam AND `Имя` = @name AND `Отчество` = @otchestvo ", Const.Const.getConnection(connection));
                command.Parameters.Add("@fam", MySqlDbType.VarChar).Value = Forms.FromPC.Findpeople.famil;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Forms.FromPC.Findpeople.name;
                command.Parameters.Add("@otchestvo", MySqlDbType.VarChar).Value = Forms.FromPC.Findpeople.otchestvo;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Forms.FromPC.Findpeople.num_card = Convert.ToInt32(reader["Номер_карточки"]);
                    Forms.FromPC.Findpeople.pol = Convert.ToString(reader["Пол"]);
                    Forms.FromPC.Findpeople.day_rojd = Convert.ToString(reader["Дата_рождения"]);
                    Forms.FromPC.Findpeople.day_postup = Convert.ToString(reader["Дата_поступления_в_ПВР"]);
                    Forms.FromPC.Findpeople.room = Convert.ToString(reader["Номер_комнаты"]);
                    Forms.FromPC.Findpeople.grajd = Convert.ToString(reader["Гражданство"]);
                    Forms.FromPC.Findpeople.beznc = Convert.ToString(reader["Беженец"]);
                    Forms.FromPC.Findpeople.berem = Convert.ToString(reader["Беременность"]);
                    Forms.FromPC.Findpeople.day_rodov = Convert.ToString(reader["Дата_родов"]);
                    Forms.FromPC.Findpeople.rodi_PVR_detei = Convert.ToString(reader["Родилось_детей_в_ПВР"]);
                    Forms.FromPC.Findpeople.bol_covid = Convert.ToString(reader["Переболел_covid"]);
                    Forms.FromPC.Findpeople.day_bol_covid = Convert.ToString(reader["Дата_постановки_диагноза_covid"]);
                    Forms.FromPC.Findpeople.vacin_covid = Convert.ToString(reader["Вакцинирован_от_covid"]);
                    Forms.FromPC.Findpeople.day_vacin_covid = Convert.ToString(reader["Дата_вакцинации_от_covid"]);
                    Forms.FromPC.Findpeople.karan = Convert.ToString(reader["Карантин"]);
                    Forms.FromPC.Findpeople.day_karan = Convert.ToString(reader["Дата_начала_карантина"]);
                    Forms.FromPC.Findpeople.ogr_vozm = Convert.ToString(reader["Ограниченные_возможности_коммент"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Const.Const.closeConnection(connection);

        }

        public void initobs(int num_card, int tubo, int tubb, DateTime dattub, string tub
           , int vico, int vicb, DateTime datvic, string vic, int arvt
           , int gepbo, int gepbb, DateTime datgepb, string gepb
           , int gepco, int gepcb, DateTime datgepc, string gepc
           , int projo, int projb, DateTime datproj, string proj

           , int ippp_bol, int ippp_obs, DateTime ippp_dat, string ippp_kom
            , int sahar_bol, int sahar_obs, DateTime sahar_dat, string sahar_kom
            , int psih_bol, int psih_obs, DateTime psih_date, string psih_kom
            , int oncol_bol, int oncol_obs, DateTime oncol_dat, string oncol_kom
            , int blood_bol, int blood_obs , DateTime blood_dat, string blood_kom


           )
        {
            MySqlCommand command = new MySqlCommand("UPDATE `hotel`.`patient` SET `Номер_Карточки`= @num," +
                " `Туберкулез_обследование`= @tubo,`Туберкулез_болен`= @tubb, `Туберкулез_дата`=@dattub,`Туберкулез_комментарий`=@tub," +
                " `ВИЧ_инфекция_обследование`=@vico, `ВИЧ_инфекция_болен`=@vicb, `ВИЧ_инфекция_дата`=@datvic, `ВИЧ_комментарий`=@vic," +
                " `Гепатит_B_обследование`=@gepbo, `Гепатит_B_болен`=@gepbb, `Гепатит_B_дата`=@datgepb, `Гепатит_В_комментарий`=@gepb," +
                " `Гепатит_C_обследование`=@gepco, `Гепатит_C_болен`=@gepcb, `Гепатит_C_дата`=@datgepc, `Гепатит_С_комментарий`=@gepc," +
                " `Прочие_заболевания_обследование`=@projo, `Прочие_заболевания_болен`=@projb, `Прочие_заболевания_дата`=@datproj, `Какие_прочие_заболевания`=@proj," +
                " `АРВТ`= @arvt," +
                " `ИППП_болен`= @ippp_bol,`ИППП_дата`= @data1, `ИППП_обследование`=@ipppo,`ИППП_комментарий`= @ippp_kom," +
                " `Сахарный_диабет_болен`= @sahar_bol,`Сахарный_диабет_дата`= @data3,`Сахарный_диабет_обследование`= @sahar_obs,`Сахар_комментарий`= @sahar_kom," +
                " `Психические_расстройства_болен`= @psih_bol,`Психические_расстройства_дата`= @data7, `Психические_расстройства_обследование`= @psih_obs, `Псих_комментарий`= @psih_kom," +
                " `Онкологические_заболевания_обследование`= @oncol_obs, `Онкологические_заболевания_болен`= @oncol_bol, `Онкологические_заболевания_дата`= @oncol_dat, `Онкология_коммент`= @oncol_kom," +
                " `Болезни_системы_кровообращения_болен`= @blood_bol, `Болезни_системы_кровообращения_дата`= @blood_dat, `Болезни_системы_кровообращения_обследование`= @blood_obs, `Болезни_крови_коммент`= @blood_kom " +
                " WHERE `Ключ` = @key;", Const.Const.getConnection(connection));

            command.Parameters.Add("@ippp_bol", MySqlDbType.Int32).Value = ippp_bol;
            command.Parameters.Add("@ipppo", MySqlDbType.Int32).Value = ippp_obs;
            command.Parameters.Add("@data1", MySqlDbType.Date).Value = ippp_dat;
            command.Parameters.Add("@ippp_kom", MySqlDbType.String).Value = ippp_kom;

            command.Parameters.Add("@sahar_bol", MySqlDbType.Int32).Value = sahar_bol;
            command.Parameters.Add("@data3", MySqlDbType.Date).Value = sahar_dat;
            command.Parameters.Add("@sahar_obs", MySqlDbType.Int32).Value = sahar_obs;
            command.Parameters.Add("@sahar_kom", MySqlDbType.String).Value = sahar_kom;

            command.Parameters.Add("@psih_bol", MySqlDbType.Int32).Value = psih_bol;
            command.Parameters.Add("@data7", MySqlDbType.Date).Value = psih_date;
            command.Parameters.Add("@psih_obs", MySqlDbType.Int32).Value = psih_obs;
            command.Parameters.Add("@psih_kom", MySqlDbType.String).Value = psih_kom;

            command.Parameters.Add("@oncol_obs", MySqlDbType.Int32).Value = oncol_obs;
            command.Parameters.Add("@oncol_bol", MySqlDbType.Int32).Value = oncol_bol;
            command.Parameters.Add("@oncol_dat", MySqlDbType.Date).Value = oncol_dat;
            command.Parameters.Add("@oncol_kom", MySqlDbType.String).Value = oncol_kom;

            command.Parameters.Add("@blood_bol", MySqlDbType.Int32).Value = blood_bol;
            command.Parameters.Add("@blood_dat", MySqlDbType.Date).Value = blood_dat;
            command.Parameters.Add("@blood_obs", MySqlDbType.Int32).Value = blood_obs;
            command.Parameters.Add("@blood_kom", MySqlDbType.String).Value = blood_kom;


            //Строки
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = num_card;
            command.Parameters.Add("@tubo", MySqlDbType.Int32).Value = tubo;
            command.Parameters.Add("@tubb", MySqlDbType.Int32).Value = tubb;
            command.Parameters.Add("@dattub", MySqlDbType.Date).Value = dattub;
            command.Parameters.Add("@tub", MySqlDbType.String).Value = tub;
            command.Parameters.Add("@vico", MySqlDbType.Int32).Value = vico;
            command.Parameters.Add("@vicb", MySqlDbType.Int32).Value = vicb;
            command.Parameters.Add("@datvic", MySqlDbType.Date).Value = datvic;
            command.Parameters.Add("@vic", MySqlDbType.String).Value = vic;
            command.Parameters.Add("@arvt", MySqlDbType.Int32).Value = arvt;
            command.Parameters.Add("@gepbo", MySqlDbType.Int32).Value = gepbo;
            command.Parameters.Add("@gepbb", MySqlDbType.Int32).Value = gepbb;
            command.Parameters.Add("@datgepb", MySqlDbType.Date).Value = datgepb;
            command.Parameters.Add("@gepb", MySqlDbType.String).Value = gepb;
            command.Parameters.Add("@gepco", MySqlDbType.Int32).Value = gepco;
            command.Parameters.Add("@gepcb", MySqlDbType.Int32).Value = gepcb;
            command.Parameters.Add("@datgepc", MySqlDbType.Date).Value = datgepc;
            command.Parameters.Add("@gepc", MySqlDbType.String).Value = gepc;
            command.Parameters.Add("@projo", MySqlDbType.Int32).Value = projo;
            command.Parameters.Add("@projb", MySqlDbType.Int32).Value = projb;
            command.Parameters.Add("@datproj", MySqlDbType.Date).Value = datproj;
            command.Parameters.Add("@proj", MySqlDbType.String).Value = proj;
            command.Parameters.Add("@key", MySqlDbType.String).Value = Forms.FromPC.Findpeople.key;

            Const.Const.openConnection(connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь обновлен");
            }
            else
            {
                MessageBox.Show("Произошла ошибка передачи данных");
            }
            Const.Const.closeConnection(connection);
        }
        public void updateobs(int num_card, int key)
        {
            Const.Const.openConnection(connection);
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE hotel.patient SET Номер_карточки=  @num_card WHERE Ключ= @key", Const.Const.getConnection(connection));
                command.Parameters.Add("@num_card", MySqlDbType.Int32).Value = num_card;
                command.Parameters.Add("@key", MySqlDbType.Int32).Value = key;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Номер карточки привязан, данные о заболеваниях обновлены");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка передачи данных");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Const.Const.closeConnection(connection);


        }

        public void NewDayInPVR(string SubRFName, string PVRName)
        {
            try
            {

                Const.Const.openConnection(connection);
                DateTime NowDate = DateTime.Today;
                MySqlDataAdapter SqlAdapter = new MySqlDataAdapter("SELECT `Ключ`" +
                        " FROM hotel.`informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan`" +
                        " WHERE `Дата` = current_date();", Const.Const.getConnection(connection));
                DataSet dataset = new DataSet();
                SqlAdapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count == 0) //не существует записей на текущую дату
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan`( `Субъект_РФ`, `Число_обследованных`,`Вз_Туберкулёз`," +
                        " `Вз_Вич`, `Вз_ИППП`, `Вз_Сахарный_диабет`, `Вз_Болезни_системы_кровообращения`, `Вз_Гепатит_B_C`, `Вз_Онкологические_заболевания`, `Вз_Психические_растройства`, " +
                        "`Вз_Прочие_заболевания`, `Дата`) VALUES ('"+SubRFName+"','0','0','0','0','0','0','0','0','0','0',current_date());" +
                        "INSERT INTO `svedeniya_o_gospitalizacii_pribyvshih`(`Именование_субъекта_РФ`, `Наим_мед_организации`, `Гос_Вс_Взрослые_Всего`," +
                        " `Гос_Вс_Взрослые_втч_раненых`, `Гос_Вс_Взрослые_втч_берем_женщин`, `Гос_Вс_Дети_Всего`, `Гос_Вс_Дети_втч_раненых`, `Гос_Вс_Дети_втч_до_1_года`," +
                        " `Гос_Из_них_край_тяж_Взрос_Всего`, `Гос_Из_них_край_тяж_Взрос_втч_ранен`, `Гос_Из_них_край_тяж_Взрос_втч_берем`, `Гос_Из_них_край_тяж_Дети_Всего`," +
                        " `Гос_Из_них_край_тяж_Дети_втч_ранен`, `Гос_Из_них_край_тяж_Дети_втч_до_1г`, `Гос_Из_них_тяж_Взрос_Всего`, `Гос_Из_них_тяж_Взрос_втч_раненых`, " +
                        "`Гос_Из_них_тяж_Взрос_втч_берем_жен`, `Гос_Из_них_тяж_Дети_Всего`, `Гос_Из_них_тяж_Дети_втч_раненых`, `Гос_Из_них_тяж_Дети_втч_до_1_года`," +
                        " `Гос_Из_них_лёгк_Взрос_Всего`, `Гос_Из_них_лёгк_Взрос_втч_ранен`, `Гос_Из_них_лёгк_Взрос_втч_берем_жен`, `Гос_Из_них_лёгк_Дети_Всего`," +
                        " `Гос_Из_них_лёгк_Дети_втч_раненых`, `Гос_Из_них_лёгк_Дети_втч_до_1_года`, `Дата`)" +
                        " VALUES ('" + SubRFName + "','" + PVRName + "','0','0','0','0','0','0','0','0','0','0','0','0','0'," +
                        "'0','0','0','0','0','0','0','0','0','0','0',current_date());" +
                        "INSERT INTO `svedeniya_o_vakcinacii_pribyvshih`(`Наименование_субъекта_РФ`, `Наименование_муп_субъекта_РФ`," +
                       " `Иммун_Всего`, `Иммун_Детей_Всего`, `Иммун_Детей_до_1_года`, `Иммун_Беременных_женщин`, `Вак_но_от_Covid_Всего`, `Вак_но_от_Covid_Детей_Всего`," +
                       " `Вак_но_от_Covid_Детей_до_1_года`, `Вак_но_от_Covid_Беременных_женщин`, `Дата`) VALUES " +
                       "('" + SubRFName + "','" + PVRName + "','0','0','0','0','0','0','0','0',current_date());" +
                       "INSERT INTO `svodnaya_tablica_po_razmeshcheniyu_pribyvshih`(`Наименование_субъекта_РФ`, `Наим_муниц_образования_субъекта_РФ`, `Кол_приб_Всего`," +
                       " `Кол_приб_Из_них_детей`, `Кол_приб_втм_Приб_гражд_РФ_Всего`, `Кол_приб_втм_Приб_гражд_РФ_детей`, `Кол_приб_Свед_о_вакц_от_Covid_Вакц`, " +
                       "`Кол_приб_Свед_о_вакц_от_Covid_Невак`, `Кол_приб_Присвоен_статус_беженца`, `ПВР_ПВР_вс_Количество_ПВР`, `ПВР_ПВР_вс_Макс_вмест_по_всем_ПВР`, " +
                       "`ПВР_Разв_ПВР_Разм_Всего`, `ПВР_Разв_ПВР_Разм_Детей_Всего`, `ПВР_Разв_ПВР_Разм_Детей_до_1_года`, `ПВР_Разв_ПВР_Разм_С_огран_возм_Вс`, " +
                       "`ПВР_Разв_ПВР_Разм_С_огран_возм_Дет`, `ПВР_Разв_ПВР_Разм_Берем_женщин`, `ПВР_Разв_ПВР_Обрат_за_мед_пом_Всего`, `ПВР_Разв_ПВР_Обрат_мед_пом_Детей_Вс`," +
                       " `ПВР_Разв_ПВР_Обрат_мед_пом_Дет_до_1г`, `ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Вс`, `ПВР_Разв_ПВР_Обрат_мед_пом_С_огр_Дет`, `ПВР_Разв_ПВР_Обрат_мед_пом_Берем_жн`," +
                       " `ПВР_Разв_ПВР_Проведено_родов`, `ПВР_Разв_ПВР_Родилось_детей`, `Дата`) VALUES ('" + SubRFName + "','" + PVRName + "','0','0','0','0','0','0','0','0','0','0','0','0'" +
                       ",'0','0','0','0','0','0','0','0','0','0','0',current_date());", Const.Const.getConnection(connection));
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Const.Const.closeConnection(connection);
            }
        }

    }






}
