using System;
using System.IO;
using System.Windows.Forms;

namespace Hotel
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Dobavlenie.DataObs.default_();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            try
            {
                string path = "passw.txt";
                if (File.Exists(path))
                {
                    string s;
                    using (StreamReader sr = File.OpenText(path))
                    {
                        if ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if (s != "")
                    {
                        Const.Const.stroka_parol = s;
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        Application.Run(new Forms.Menuchki.FormPass());
                    }
                }
                else
                {
                    Application.Run(new Forms.Menuchki.FormPass());
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
