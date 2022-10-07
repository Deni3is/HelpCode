using System;
using System.Windows.Forms;

namespace Hotel.Dobavlenie
{
    public partial class FormDobavlenieObs : Form
    {
        public FormDobavlenieObs()
        {
            InitializeComponent();
        }

        private void Prinyat3_Click(object sender, EventArgs e)
        {
            //Болен
            DataObs.ippp_bolen = dob_ippp_bol.Checked ? 1 : 0;
            DataObs.tyber_bolen = dob_tyber_bol.Checked ? 1 : 0;
            DataObs.gepatB_bolen = dob_gep_b_bol.Checked ? 1 : 0;
            DataObs.gepatC_bolen = dob_gep_c_bol.Checked ? 1 : 0;
            DataObs.vich_bolen = dob_vich_bol.Checked ? 1 : 0;
            DataObs.sahDiab_bolen = dob_sugar_bol.Checked ? 1 : 0;
            DataObs.psih_bolen = dob_psyho_bol.Checked ? 1 : 0;
            DataObs.oncolog_bolen = dob_onc_bol.Checked ? 1 : 0;
            DataObs.krov_bolen = dob_blood_bol.Checked ? 1 : 0;
            //Даты 
            try
            {
                DataObs.ippp_data = dob_ippp_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_ippp_year.Text), 1, 1);
                DataObs.tyber_data = dob_tyb_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_tyb_year.Text), 1, 1);
                DataObs.gepatB_data = dob_gep_b_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_gep_b_year.Text), 1, 1);
                DataObs.gepatC_data = dob_gep_c_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_gep_c_year.Text), 1, 1);
                DataObs.vich_data = dob_vich_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_vich_year.Text), 1, 1);
                DataObs.sahDiab_data = dob_sugar_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_sugar_year.Text), 1, 1);
                DataObs.psih_data = dob_psyho_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_psyho_year.Text), 1, 1);
                DataObs.oncolog_data = dob_onc_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_onc_year.Text), 1, 1);
                DataObs.krov_data = dob_blood_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_blood_year.Text), 1, 1);
                //Остальное
                DataObs.projee_bolen = dob_other_bol.Checked ? 1 : 0;
                DataObs.zabolevan = dob_other_diag.Text;
                DataObs.projie_data = dob_other_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_other_year.Text), 1, 1);
                DataObs.ogran_vozm = dob_ogr_vozm.Checked ? 1 : 0;
                DataObs.diagnoz_ogr = dob_ogr_diag.Text;
                DataObs.ogrn_data = dob_ogr_year.Text == "" ? DateTime.MinValue : new DateTime(Convert.ToInt32(dob_ogr_year.Text), 1, 1);
                DataObs.vich_arvt = dob_arvt.Checked ? 1 : 0;
                Hide(); 
            }
            catch
            {
                MessageBox.Show("Ошибка при вводе даты");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataObs.obsledovan = 0;
            Hide();
        }

        private void FormDobavlenieObs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormDobavlenieObs_Load(object sender, EventArgs e)
        {

        }

        private void dob_ippp_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_ippp_bol.Checked)
            {
                dob_ippp_year.Visible = true;
                l1.Visible = true;
            }
            else
            {
                dob_ippp_year.Visible = false;
                l1.Visible = false;
            }
        }

        private void dob_tyber_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_tyber_bol.Checked)
            {
                dob_tyb_year.Visible = true;
                l2.Visible = true;
            }
            else
            {
                dob_tyb_year.Visible = false;
                l2.Visible = false;
            }
        }

        private void dob_gep_b_bol_CheckedChanged(object sender, EventArgs e)
        {
            
            if (dob_gep_b_bol.Checked)
            {
                dob_gep_b_year.Visible = true;
                l3.Visible = true;
            }
            else
            {
                dob_gep_b_year.Visible = false;
                l3.Visible = false;
            }
        }

        private void dob_psyho_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_psyho_bol.Checked)
            {
                dob_psyho_year.Visible = true;
                l4.Visible = true;
            }
            else
            {
                dob_psyho_year.Visible = false;
                l4.Visible = false;
            }
        }

        private void dob_onc_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_onc_bol.Checked)
            {
                dob_onc_year.Visible = true;
                l5.Visible = true;
            }
            else
            {
                dob_onc_year.Visible = false;
                l5.Visible = false;
            }
        }

        private void dob_gep_c_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_gep_c_bol.Checked)
            {
                dob_gep_c_year.Visible = true;
                l6.Visible = true;
            }
            else
            {
                dob_gep_c_year.Visible = false;
                l6.Visible = false;
            }
        }

        private void dob_sugar_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_sugar_bol.Checked)
            {
                dob_sugar_year.Visible = true;
                l7.Visible = true;
            }
            else
            {
                dob_sugar_year.Visible = false;
                l7.Visible = false;
            }
        }

        private void dob_vich_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_vich_bol.Checked)
            {
                dob_vich_year.Visible = true;
                l8.Visible = true;
                dob_arvt.Visible = true;
            }
            else
            {
                dob_vich_year.Visible = false;
                l8.Visible = false;
                dob_arvt.Visible = false;

            }
        }

        private void dob_blood_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_blood_bol.Checked)
            {
                dob_blood_year.Visible = true;
                l9.Visible = true;
            }
            else
            {
                dob_blood_year.Visible = false;
                l9.Visible = false;
            }
        }

        private void dob_ogr_vozm_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_ogr_vozm.Checked)
            {
                label2.Visible = true;
                dob_ogr_diag.Visible = true;
                label13.Visible = true;
                dob_ogr_year.Visible = true;

            }
            else
            {
                label2.Visible = false;
                dob_ogr_diag.Visible = false;
                label13.Visible = false;
                dob_ogr_year.Visible = false;
            }
        }

        private void dob_other_bol_CheckedChanged(object sender, EventArgs e)
        {
            if (dob_other_bol.Checked)
            {
                label37.Visible = true;
                dob_other_diag.Visible = true;
                label11.Visible = true;
                dob_other_year.Visible = true;

            }
            else
            {
                label37.Visible = false;
                dob_other_diag.Visible = false;
                label11.Visible = false;
                dob_other_year.Visible = false;
            }
        }

        private void dob_ippp_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_tyb_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_gep_b_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_psyho_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_onc_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_gep_c_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_sugar_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_vich_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_blood_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_ogr_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_other_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dob_ippp_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_ippp_year.TextLength > 4)
            {
                dob_ippp_year.Text = "";
            }
        }

        private void dob_tyb_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_tyb_year.TextLength > 4)
            {
                dob_tyb_year.Text = "";
            }
        }

        private void dob_gep_b_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_gep_b_year.TextLength > 4)
            {
                dob_gep_b_year.Text = "";
            }
        }

        private void dob_ogr_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_ogr_year.TextLength > 4)
            {
                dob_ogr_year.Text = "";
            }
        }

        private void dob_psyho_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_psyho_year.TextLength > 4)
            {
                dob_psyho_year.Text = "";
            }
        }

        private void dob_onc_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_onc_year.TextLength > 4)
            {
                dob_onc_year.Text = "";
            }
        }

        private void dob_gep_c_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_gep_c_year.TextLength > 4)
            {
                dob_gep_c_year.Text = "";
            }
        }

        private void dob_sugar_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_sugar_year.TextLength > 4)
            {
                dob_sugar_year.Text = "";
            }
        }

        private void dob_vich_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_vich_year.TextLength > 4)
            {
                dob_vich_year.Text = "";
            }
        }

        private void dob_blood_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_blood_year.TextLength > 4)
            {
                dob_blood_year.Text = "";
            }
        }

        private void dob_other_year_TextChanged(object sender, EventArgs e)
        {
            if (dob_other_year.TextLength > 4)
            {
                dob_other_year.Text = "";
            }
        }
    }
}
