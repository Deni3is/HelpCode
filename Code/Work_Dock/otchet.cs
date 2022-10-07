using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Work_Dock
{
    static class otchet
    {


        static public void obshci(string dat1,string dat2) {


            var helper = new Dock_helper.Word_Helper("test_tabl.docx");
            var items = new Dictionary<string, string>
            {
            {"{с}",       " "+dat1},
            {"{по}",           " "+dat2},
            {"{провед_род}",       " "+datedate.rody},
            {"{род_дет}",           " "+datedate.rody_det},
            {"{всего_приб}",        " "+datedate.prib_all},
            {"{всего_приб_детей}",      " "+datedate.prib_all_det},
            {"{всего_приб_рф}",         " "+datedate.prib_all_rf},
            {"{всего_приб_рф_детей}",   " "+datedate.prib_all_rf_det},
            {"{вакц}",          " "+datedate.vakc},
            {"{невакц}",            " "+datedate.nevakc},
            {"{бежен}",         " "+datedate.bejen},
            {"{кол_пвр}",           " "+datedate.kol_pvr},
            {"{вмес_пвр}",          " "+datedate.vmest_pvr},
            {"{резмещ_всего}",      " "+datedate.razmesh_all},
            {"{резмещ_детей}",      " "+datedate.razmesh_det},
            {"{резмещ_детей_до_1}",     " "+datedate.razmesh_det_1},
            {"{размещ_всего_с_огр}",    " "+datedate.razmesh_all_ogr},
            {"{размещ_всего_с_огр_детей }", " "+datedate.razmesh_all_ogr_det},
            {"{размещ_берем}",      " "+datedate.razmesh_berem},
            {"{обр_всего}",         " "+datedate.obr_all},
            {"{обр_детей}",         " "+datedate.obr_det},
            {"{обр_детей_до_1}",        " "+datedate.obr_det_1},
            {"{обр_с_огр}",         " "+datedate.obr_ogr},
            {"{обр_с_огр_детей}",       " "+datedate.obr_ogr_det},
            {"{обр_берем}",         " "+datedate.obr_berem},
            //Информация о выявленных заболеваниях у граждан, вынуждено покинувших территорию Украины
            {"{число_обсл}",        " "+datedate.chislo_obs},
            {"{вич}",           " "+datedate.hpv},
            {"{иппп}",          " "+datedate.ippp},
            {"{сах_диаб}",         " "+datedate.shugar},
            {"{кровооб}",           " "+datedate.blood},
            {"{геп}",           " "+datedate.gep},
            {"{онкол}",         " "+datedate.onc},
            {"{псих}",          " "+datedate.psyho},
            {"{тубер}",         " "+datedate.tyber},
            {"{проч}",          " "+datedate.other},
            //Сведения о вакцинации прибывших с юго-восточных районов Донецкой и Луганской областей Украины
            {"{имун_всего}",        " "+datedate.imun_all},
            {"{имун_дети}",         " "+datedate.imun_deti},
            {"{имун_дети_до_1}",        " "+datedate.imun_det_1},
            {"{имун_берем}",        " "+datedate.imun_berm},
            {"{вакц_дети}",         " "+datedate.vakc_det},
            {"{вакц_дети_до_1}",        " "+datedate.vakc_det_1},
            {"{вакц_берем}",        " "+datedate.vakc_berem},
            //Сведения о госпитализации прибывших с юго-восточных районов Донецкой и Луганской областей Украины
            {"{субъект}",           datedate.syb},
            {"{мед_орг}",           datedate.med},
            {"{всего_взр}",         " "+datedate.all_vzr},
            {"{всего_взр_ран}",     " "+datedate.all_vzr_ran},
            {"{всего_взр_бер}",     " "+datedate.all_vzr_berem},
            {"{всего_дети}",        " "+datedate.all_det},
            {"{всего_дети_ран}",        " "+datedate.all_det_ran},
            {"{всего_дети_до_1}",       " "+datedate.all_det_1},
            {"{кр_тяж_всего_взрос}",    " "+datedate.kr_tyazh_all_vzr},
            {"{кр_тяж_ран}",        " "+datedate.kr_tyazh_ran},
            {"{кр_тяж_бер}",        " "+datedate.kr_tyazh_ber},
            {"{кр_тяж_дет}",        " "+datedate.kr_tyazh_det},
            {"{кр_тяж_ран_дет}",        " "+datedate.kr_tyazh_det_ran},
            {"{кр_тяж_дети_1}}",        " "+datedate.kr_tyazh_det_1},
            {"{тяж_всего_взрос}",       " "+datedate.tyazh_all_vzr},
            {"{тяж_ран}",           " "+datedate.tyazh_ran},
            {"{тяж_бер}",           " "+datedate.tyazh_ber},
            {"{тяж_дет}",           " "+datedate.tyazh_det},
            {"{тяж_ран_дет}",       " "+datedate.tyazh_det_ran},
            {"{тяж_дети_1}}",       " "+datedate.tyazh_det_1},
            {"{лег_всего_взрос}",       " "+datedate.leg_tyazh_all_vzr},
            {"{легл_ран}",          " "+datedate.leg_tyazh_ran},
            {"{лег_бер}",           " "+datedate.leg_tyazh_ber},
            {"{лег_дет}",           " "+datedate.leg_tyazh_det},
            {"{лег_ран_дет}",       " "+datedate.leg_tyazh_det_ran},
            {"{лег_дети_1}}",       " "+datedate.leg_tyazh_det_1}
            };
            helper.Process(items);
            

        }

    }
}
