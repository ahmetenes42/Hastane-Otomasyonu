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
    public partial class hasta_list_form : Form
    {
        public hasta_list_form()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();

        private void btn_hemsire_cikis_Click(object sender, EventArgs e)
        {


        }

        private void hasta_list_form_Load(object sender, EventArgs e) // form ilk açıldığında yapılacak işlemler
        {

            label13.Text = DateTime.Now.ToLongDateString();
            Hasta hasta = new Hasta();
            dgw_hasta_list.DataSource = db.Hasta.Where(x => x.H_yatis_ID == 1).ToList(); // yatış id si 1 olan yani yatan hastaları getiriyoruz

            dgw_hasta_list.Columns["H_ID"].Visible = false;
            dgw_hasta_list.Columns["H_tahlil_ID"].Visible = false;

            dgw_hasta_list.Columns["H_recete_ID"].Visible = false;
            dgw_hasta_list.Columns["D_ID"].Visible = false;
            dgw_hasta_list.Columns["H_randevu_ID"].Visible = false;
            dgw_hasta_list.Columns["H_tc"].HeaderText = " Tc";
            dgw_hasta_list.Columns["H_adi"].HeaderText = " Adı";
            dgw_hasta_list.Columns["H_s_adi"].HeaderText = " Soyadı";
            dgw_hasta_list.Columns["H_cinsiyet"].HeaderText = "Cinsiyet";
            dgw_hasta_list.Columns["H_d_yeri"].HeaderText = "Doğum Yeri";
            dgw_hasta_list.Columns["H_d_tarihi"].HeaderText = "Doğum Tarihi";
            dgw_hasta_list.Columns["H_anne_adi"].HeaderText = " Anne Adı";
            dgw_hasta_list.Columns["H_baba_adi"].HeaderText = " Baba Adı";
            dgw_hasta_list.Columns["H_tel"].HeaderText = " Telefon";
            dgw_hasta_list.Columns["H_eposta"].HeaderText = " E-Posta";
            dgw_hasta_list.Columns["H_sifre"].HeaderText = " Şifre";
            dgw_hasta_list.Columns["H_yatis_ID"].HeaderText = " Yatış Kodu";
            dgw_hasta_list.Columns["H_tedavi_durum"].HeaderText = "Tedavi Kodu";
            dgw_hasta_list.Columns["H_tansiyon"].HeaderText = "Tansiyon";
            dgw_hasta_list.Columns["H_nabiz"].HeaderText = "Nabız";
            dgw_hasta_list.Columns["H_randevu_tarih"].HeaderText = "Randevu Tarihi";
            int tedavi = Convert.ToInt32(hasta.H_tedavi_durum); // tedavi olan hastaları yeşil olarak tedeavi edildi şeklinde göstermek için değişkene atıldı

            if (tedavi == 1)
            {
                checkBox_tedavi.Checked = true;
                checkBox_tedavi.ForeColor = Color.Green;
            }
            else
            {
                checkBox_tedavi.Text = "Tedavi Edilmedi";
                checkBox_tedavi.ForeColor = Color.Red;
               
            }

        }

        int guncellenecekId = 0;
        private void dgw_hasta_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }
        private void GirisleriSifirla()
        {
            guncellenecekId = 0;
            txt_ara.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_tc.Clear();
            txt_nabiz.Clear();
            txt_tansiyonB.Clear();

        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            // textboxtan hasta aratma işlemi
            dgw_hasta_list.DataSource = db.Hasta.Where(x =>
          x.H_adi.Contains(txt_ara.Text)
          || x.H_s_adi.Contains(txt_ara.Text)
          || x.H_tc.Contains(txt_ara.Text)
          ).ToList();
        }

        private void dgw_hasta_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void btn_hastalist_yenile_Click(object sender, EventArgs e)
        {
           
        }




        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_taburcu_Click(object sender, EventArgs e)
        {

        }

        private void btn_hemsire_cikis_Click_1(object sender, EventArgs e)
        {
            // geri butonuna basıldığında hemşire formuna yönlendirildi
            hemsire_form hemsire_Form = new hemsire_form();
            hemsire_Form.Show();
            this.Hide();
        }

        private void dgw_hasta_list_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // taburcu işlemleri
            {



                //    }
                label1.Visible = true;
                txt_ad.Visible = true;
                txt_ad.Enabled = false;
                label2.Visible = true;
                txt_soyad.Visible = true;
                txt_soyad.Enabled = false;
                label3.Visible = true;
                txt_tc.Visible = true;
                txt_tc.Enabled = false;
                label4.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                txt_cinsiyet.Visible = true;
                txt_cinsiyet.Enabled = false;
                txt_telefon.Visible = true;
                txt_telefon.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                combo_doktor.Visible = true;
                txt_yatis.Visible = true;
                comboIlac.Visible = true;

                btn_guncelle.Visible = false;
                txt_yatis.Enabled = false;
                btn_guncelle.Visible = false;
                btn_taburcu.Visible = true;
                groupBox3.Location = new Point(439, 333);

                Hasta hasta = new Hasta();

                int ilacid = 0;
                ilacid = Convert.ToInt32(dgw_hasta_list.Rows[e.RowIndex].Cells[23].Value.ToString());

                comboIlac.DataSource = db.Eczane
              .Where(x => x.İlac_ID == ilacid)
              .ToList();
                comboIlac.DisplayMember = "İlac_adi"; // sqlde adı neyse onu aldık
                comboIlac.ValueMember = "İlac_ID"; //id tutmak için

                int id = 0;
                id = Convert.ToInt32(dgw_hasta_list.Rows[e.RowIndex].Cells[17].Value.ToString());

                combo_doktor.DataSource = db.Doktor
               .Where(x => x.D_ID == id)
               .ToList();
                combo_doktor.DisplayMember = "D_ad_soyad";
                combo_doktor.ValueMember = "D_ID";

                txt_yatis.Text = "10 GÜN";

                try
                {

                    guncellenecekId = Convert.ToInt32(dgw_hasta_list.Rows[e.RowIndex].Cells[2].Value); //veritabanından hastaları getirip textboxa yazdık
                    txt_tc.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_ad.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txt_soyad.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txt_cinsiyet.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[6].Value.ToString();



                    if (txt_cinsiyet.Text == "E")
                    {
                        txt_cinsiyet.Text = "ERKEK";
                    }
                    if (txt_cinsiyet.Text == "K")
                    {
                        txt_cinsiyet.Text = "BAYAN";
                    }

                    txt_telefon.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[11].Value.ToString();



                }
                catch (Exception)
                {
                    GirisleriSifirla();
                }

            }

            if (e.ColumnIndex == 1)
            {
                label1.Visible = true;
                txt_ad.Visible = true;
                txt_ad.Enabled = false;
                label2.Visible = true;
                txt_soyad.Visible = true;
                txt_soyad.Enabled = false;
                label3.Visible = true;
                txt_tc.Visible = true;
                txt_tc.Enabled = false;
                label4.Visible = true;
                txt_nabiz.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                txt_tansiyonB.Visible = true;
                checkBox_tedavi.Visible = true;
                btn_guncelle.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                txt_cinsiyet.Visible = true;
                txt_cinsiyet.Enabled = false;
                txt_telefon.Visible = true;
                txt_telefon.Enabled = false;
                btn_guncelle.Visible = true;
                btn_taburcu.Visible = false;

                try //veritabanından hastaları getirip textboxa yazdık
                {
                    guncellenecekId = Convert.ToInt32(dgw_hasta_list.Rows[e.RowIndex].Cells[2].Value);
                    txt_tc.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_ad.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txt_soyad.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txt_nabiz.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[18].Value.ToString();
                    txt_tansiyonB.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[21].Value.ToString();
                    txt_cinsiyet.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (txt_cinsiyet.Text == "E")
                    {
                        txt_cinsiyet.Text = "ERKEK";
                    }
                    if (txt_cinsiyet.Text == "K")
                    {
                        txt_cinsiyet.Text = "BAYAN";
                    }

                    txt_telefon.Text = dgw_hasta_list.Rows[e.RowIndex].Cells[11].Value.ToString();


                }
                catch (Exception)
                {
                    GirisleriSifirla();
                }
            }

        }

        private void btn_hastalist_yenile_Click_1(object sender, EventArgs e)
        {
            dgw_hasta_list.DataSource = db.Hasta.Where(x => x.H_yatis_ID == 1).ToList(); // yenileme butonuna tıklayınca olan işlem
        }

        private void btn_taburcu_Click_1(object sender, EventArgs e)
        {
            if (checkBox_onay.Checked == true)//  Taburcu için onay verildiğinde
            {
                Hasta hasta = db.Hasta.Find(guncellenecekId);
                hasta.H_yatis_ID = 0;
                hasta.H_taburcu_tarih = dateTimePicker1.Value.ToShortDateString();
               // hasta.H_taburcu_tarih = label13.Text;
                db.SaveChanges();

                hemsire_form hemsire_Form = new hemsire_form();
                hemsire_Form.Show();
                this.Hide();
                MessageBox.Show("Kayıt Başarıyla Taburcu Edildi.", "TABURCU ONAYI");
                
                dgw_hasta_list.DataSource = db.Hasta.Where(x => x.H_yatis_ID == 1).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen Taburcu İşlemini Onaylayınız.", "TABURCU ONAYI");
                checkBox_onay.ForeColor = Color.Red;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //hasta güncelleme

            Hasta hasta = db.Hasta.Find(guncellenecekId);
            hasta.H_nabiz = Convert.ToInt32(txt_nabiz.Text);
            hasta.H_tansiyon = txt_tansiyonB.Text;
            if (checkBox_tedavi.Checked)

            {
                hasta.H_tedavi_durum = 1;
            }
            else
            {
                hasta.H_tedavi_durum = 0;
            }

            db.SaveChanges();

            hemsire_form hemsire_Form = new hemsire_form();
            hemsire_Form.Show();
            this.Hide();
            MessageBox.Show("Kayıt Güncellendi", "HASTA BİLGİLERİ ONAY");
        }

        private void txt_ara_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
