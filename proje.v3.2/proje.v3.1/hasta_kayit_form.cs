using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje.v3._1
{
    public partial class hasta_kayit_form : Form
    {
        public hasta_kayit_form()
        {
            InitializeComponent();
        }

        HastaneEntities db = new HastaneEntities();
        Polikinlik polikinlik = new Polikinlik();
        DialogResult dialog = new DialogResult();

        int guncellenecekId = 0;
        int sayac = 0;
        private void hasta_kayit_form_Load(object sender, EventArgs e)
        {
            comboPolikinlik.DataSource = db.Polikinlik.ToList();
            comboPolikinlik.DisplayMember = "Polik_adi";
            comboPolikinlik.ValueMember = "Polik_ID";

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;

            dateTimePicker1.Value = tarih;


        }
        private void btn_sekreter_geri_Click(object sender, EventArgs e)
        {
            sekreter_form sekreter_Form = new sekreter_form();
            sekreter_Form.Show();
            this.Hide();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            // textboxtan hasta aratma işlemi
            dgw_hasta_list.DataSource = db.Hasta.Where(x =>

           x.H_tc.Contains(txtAra.Text)
          ).ToList();

            dgw_hasta_list.Columns["H_ID"].Visible = false;
            dgw_hasta_list.Visible = true;
        }

        private void dgw_hasta_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                groupBox1.Visible = true;
                comboDoktor.Visible = true;
                comboPolikinlik.Visible = true;
                btn_randevu.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                comboBox1.Visible = true;
                dateTimePicker1.Visible = true;
                label14.Visible = false;
                label19.Visible = false;
                label12.Visible = false;
                label20.Visible = false;
                label11.Visible = false;
                label22.Visible = false;
                label13.Visible = false;
                label21.Visible = false;

                guncellenecekId = Convert.ToInt32(dgw_hasta_list.Rows[e.RowIndex].Cells[1].Value);

                try
                {  
                    label15.Text  = dgw_hasta_list.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label16.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label17.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label18.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[10].Value.ToString();

                }
                catch (Exception)
                {
                
                }

            }
        }

        private void comboPolikinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            label14.Visible = true;
            label19.Visible = true;
            int id = 1;
            try
            {
                id = (int)comboPolikinlik.SelectedValue;

            }
            catch (Exception) { }

            comboDoktor.DataSource = db.Doktor
                .Where(x => x.P_ID == id)
                .ToList();

            comboDoktor.DisplayMember = "D_ad_soyad";
            comboDoktor.ValueMember = "D_ID";
            sayac = comboPolikinlik.SelectedIndex + 1;
           label19.Text= comboPolikinlik.Text;
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "--Lütfen Saat Seçiniz--")
            {
                MessageBox.Show("Lütfen Saat Seçiniz");


            }
            else { dialog = MessageBox.Show(comboPolikinlik.Text.Trim() + " Polikinliğinden  " + comboDoktor.Text.Trim() + " Adlı Doktora Saat: " + comboBox1.Text.Trim() + " 'a  " + dateTimePicker1.Value.ToShortDateString() + " Tarihine Randevu Almak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question); }

            
            if (dialog == DialogResult.Yes)
            {
                Hasta hasta = db.Hasta.Find(guncellenecekId);
                if (sayac == 1)
                {
                    hasta.D_ID = comboDoktor.SelectedIndex + sayac;
                }
                
                else { hasta.D_ID = comboDoktor.SelectedIndex + sayac + 1; }
                hasta.H_randevu_tarih = dateTimePicker1.Value.ToShortDateString();
                hasta.H_randevu_saat = comboBox1.Text;

                sekreter_form sekreter_Form = new sekreter_form();
                sekreter_Form.Show();
                this.Hide();
                MessageBox.Show("Randevu Başarılı Şekilde Verildi ", "RANDEVU ONAY");
                db.SaveChanges();
            }
            if (dialog == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi !","Uyarı");
            }
           



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            if (tarih>dateTimePicker1.Value)
            {
                MessageBox.Show("Geçmiş Tarihi Seçemezssiniz");
                dateTimePicker1.Value = tarih;
            }
            else
            {
                label12.Visible = true;
                label20.Visible = true;

                label20.Text = dateTimePicker1.Value.ToShortDateString();
               
            }
        }

        private void comboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
            label22.Visible = true;
            label22.Text = comboDoktor.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Visible = true;
            label21.Visible = true;

            label21.Text = comboBox1.Text;
        }
    }
}
