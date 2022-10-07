using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forms.Menuchki
{
    public partial class FormPass : Form
    {
        public FormPass()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string par = Const.Const.stroka_parol;
                if (textBox1.Text != "")
                {
                    par += "password=" + textBox1.Text;   
                }

                MySqlConnection connection = new MySqlConnection(par);
                Const.Const.openConnection(connection);
                Const.Const.closeConnection(connection);
                Const.Const.stroka_parol = par;
                string path = @"passw.txt";
                // Open the file to read from.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(""+par);
                }
                this.Hide();
                MainForm form1 = new MainForm();
                form1.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Пароль не верный");
            }
        }



    }
}
