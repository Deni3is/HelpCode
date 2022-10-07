

using System;

namespace Hotel.Dobavlenie
{
    static class DataObs
    {
        public static int obsledovan;

        public static int ippp_bolen;
        public static int tyber_bolen;
        public static int gepatB_bolen;
        public static int gepatC_bolen;
        public static int vich_bolen;
        public static int sahDiab_bolen;
        public static int psih_bolen;
        public static int oncolog_bolen;
        public static int krov_bolen;

        public static int vich_arvt;


        public static DateTime ippp_data;
        public static DateTime tyber_data;
        public static DateTime gepatB_data;
        public static DateTime gepatC_data;
        public static DateTime vich_data;
        public static DateTime sahDiab_data;
        public static DateTime psih_data;
        public static DateTime oncolog_data;
        public static DateTime krov_data;

        public static int ranen;
        public static string diagnoz_ran;

        public static int projee_bolen;
        public static string zabolevan;
        public static DateTime projie_data;

        public static int ogran_vozm;
        public static string diagnoz_ogr;
        public static DateTime ogrn_data;

        public static void default_()
        {
            obsledovan = 0;
            ippp_bolen = 0;
            tyber_bolen = 0;
            gepatB_bolen = 0;
            gepatC_bolen = 0;
            vich_bolen = 0;
            sahDiab_bolen = 0;
            psih_bolen = 0;
            oncolog_bolen = 0;
            krov_bolen = 0;
            ranen = 0;
            diagnoz_ran = "";
            projee_bolen = 0;
            zabolevan = "";
            ogran_vozm = 0;
            diagnoz_ogr = "";


        }
    }

    
}
