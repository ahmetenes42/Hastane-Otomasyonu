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

    public partial class admin_form : Form

    {
        HastaneEntities db = new HastaneEntities();
        public static Eczane eczane = new Eczane();

        public admin_form()
        {
            InitializeComponent();
        }
        int guncellenecekId = 0;
        private void admin_form_Load(object sender, EventArgs e)
        {

            ///
            admin_form admin_Form = new admin_form();
            admin_Form.Size = new Size(791, 461);
            giris_panel.Location = new Point(12, 112);
            giris_panel.Visible = true;
            personel_add_panel.Visible = false;
            personel_edit_panel.Visible = false;
            personel_list_panel.Visible = false;
            izin_panel.Visible = false;
            eczane_panel.Visible = false;
            giris_form giris_Form = new giris_form();
            giris_Form.Hide();

            ///


            Eczane eczane = new Eczane();
            dataGridView1.DataSource = db.Eczane.ToList();
            dataGridView1.Columns["İlac_ID"].Visible = false;
            dataGridView1.Columns["İlac_klinik_id"].Visible = false;
            dataGridView1.Columns["İlac_adi"].HeaderText = "İlaç Adı";
            ///
            //Personel personel = new Personel();
            //personellist_dgv.DataSource = db.Personel.ToList();
            //personellist_dgv.Columns["P_ID"].Visible = false;
            //personellist_dgv.Columns["P_yetki"].Visible = false;
            //personellist_dgv.Columns["P_izingun"].Visible = false;
            //personellist_dgv.Columns["P_sifre"].Visible = false;
            //personellist_dgv.Columns["P_tc"].HeaderText = "TC kimlik no";
            //personellist_dgv.Columns["P_adi"].HeaderText = "Ad";
            //personellist_dgv.Columns["P_s_adi"].HeaderText = "Soyad";
            //personellist_dgv.Columns["P_anne_adi"].HeaderText = "Anne Adı";
            //personellist_dgv.Columns["P_baba_adi"].HeaderText = "Baba Adı";
            //personellist_dgv.Columns["P_d_yeri"].HeaderText = "Doğum Yeri";
            //personellist_dgv.Columns["P_d_tarihi"].HeaderText = "Doğum Tarihi";
            //personellist_dgv.Columns["P_birim_ID"].HeaderText = "Birim ID";
            //personellist_dgv.Columns["P_klinik_ID"].HeaderText = "Klinik ID";
            //personellist_dgv.Columns["P_eposta"].HeaderText = "E posta Adresi";
            //personellist_dgv.Columns["P_tel"].HeaderText = "Telefon Numarası";
            //personellist_dgv.Columns["P_cinsiyet"].HeaderText = "Cinsiyet";
            ///


        }
        private void personel_add_btn_Click(object sender, EventArgs e)
        {
            giris_panel.Visible = false;
            personel_add_panel.Visible = true;
            personel_add_panel.Location = new Point(12, 112);

        }
        private void anamenu_btn1_Click(object sender, EventArgs e)// personel ekleme ana menü dönüş butonu
        {
            giris_panel.Visible = true;
            personel_add_panel.Visible = false;
        }
        private void personel_list_btn_Click(object sender, EventArgs e)
        {
            giris_panel.Visible = false;
            personel_list_panel.Visible = true;
            personel_list_panel.Location = new Point(12, 112);

            Personel personel = new Personel();
            personellist_dgv.DataSource = db.Personel.ToList();
            personellist_dgv.Columns["P_ID"].Visible = false;
            personellist_dgv.Columns["P_yetki"].Visible = false;
            personellist_dgv.Columns["P_izingun"].Visible = false;
            personellist_dgv.Columns["P_sifre"].Visible = false;
            personellist_dgv.Columns["P_tc"].HeaderText = "TC kimlik no";
            personellist_dgv.Columns["P_adi"].HeaderText = "Ad";
            personellist_dgv.Columns["P_s_adi"].HeaderText = "Soyad";
            personellist_dgv.Columns["P_anne_adi"].HeaderText = "Anne Adı";
            personellist_dgv.Columns["P_baba_adi"].HeaderText = "Baba Adı";
            personellist_dgv.Columns["P_d_yeri"].HeaderText = "Doğum Yeri";
            personellist_dgv.Columns["P_birim_ID"].HeaderText = "Birim ID";
            personellist_dgv.Columns["P_klinik_ID"].HeaderText = "Klinik ID";
            personellist_dgv.Columns["P_eposta"].HeaderText = "E posta Adresi";
            personellist_dgv.Columns["P_tel"].HeaderText = "Telefon Numarası";
            personellist_dgv.Columns["P_cinsiyet"].HeaderText = "Cinsiyet";

        }
        private void anamenu_btn_Click(object sender, EventArgs e)// personel listeleme sayfası ana menü dönüş butonu
        {
            giris_panel.Visible = true;
            personel_list_panel.Visible = false;
        }
        private void ana_menu_btn2_Click(object sender, EventArgs e)// izin işlemleri ana menü dönüş butonu
        {
            giris_panel.Visible = true;
            izin_panel.Visible = false;
        }
        private void ecza_btn_Click(object sender, EventArgs e)
        {
            giris_panel.Visible = false;
            eczane_panel.Visible = true;
            eczane_panel.Location = new Point(12, 112);
        }
        private void ana_menu_btn3_Click(object sender, EventArgs e)// eczane ana menü dönüş butonu
        {
            giris_panel.Visible = true;
            eczane_panel.Visible = false;
        }
        private void anamenu_btn4_Click(object sender, EventArgs e)
        {

            giris_panel.Visible = true;
            personel_edit_panel.Visible = false;

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kydt_btn_Click(object s8ender, EventArgs e)//yeni personel kaydı için
        {
            if (tcno_txt.Text == "" || isim_txt.Text == "" || sisim_txt.Text == "" || dyeri_txt.Text == "" || anneadi_txt.Text == "" || babaadi_txt.Text == "" ||
                eposta_txt.Text == "" || telno_txt.Text == "" || sifre_txt.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz giriniz. ");
            }
            else
            {
                
                Personel personelnew = new Personel()

                {
                    P_tc = tcno_txt.Text,
                    P_adi = isim_txt.Text,
                    P_s_adi = sisim_txt.Text,
                    P_d_yeri = dyeri_txt.Text,
                    p_cinsiyet = cinsiyet1,
                    P_anne_adi = anneadi_txt.Text,
                    P_baba_adi = babaadi_txt.Text,
                    P_eposta = eposta_txt.Text,
                    P_tel = telno_txt.Text,
                    P_birim_ID = brim_cbox.SelectedIndex,
                    P_klinik_ID = klinik_cbox.SelectedIndex+1,
                    P_sifre = sifre_txt.Text

                };
              
                if (brim_cbox.Text=="Doktor")//Eğer combobaxdan doktor seçildiyse 
                {
                  
                    Doktor doktor = new Doktor() {//Doktor tablosuna atıyoruz
                        D_ad_soyad = isim_txt.Text+" "+sisim_txt.Text,
                        P_ID = klinik_cbox.SelectedIndex + 1,//ilk kayıtı 1 den başlatıyoruz
                        D_k_adi = isim_txt.Text + "42",
                        D_sifte = sifre_txt.Text
                    };
                    db.Doktor.Add(doktor);
                    db.SaveChanges();
                }
                
                db.Personel.Add(personelnew);
                
                db.SaveChanges();
                MessageBox.Show("Kaydetme işlemi başarılı bir şekilde gerçekleşmiştir.", "Hastane Otamasyonu");

                tcno_txt.Clear();
                isim_txt.Clear();
                sisim_txt.Clear();
                dyeri_txt.Clear();
                kadin_rbtb.Checked = true;
                anneadi_txt.Clear();
                babaadi_txt.Clear();
                eposta_txt.Clear();
                telno_txt.Clear();
                sifre_txt.Clear();

                giris_panel.Visible = true;
                personel_list_panel.Visible = false;
            }

        }
        private void kaydet2_btn_Click(object sender, EventArgs e)//personel bilgilerini güncelleme
        {
            {
                Personel personeledit = new Personel()
                {
                    P_tc = tcno2_txt.Text,
                    P_adi = isim2_txt.Text,
                    P_s_adi = sisim2_txt.Text,
                    P_d_yeri = dyeri2_txt.Text,

                    p_cinsiyet = cinsiyet2,
                    P_anne_adi = anneadi2_txt.Text,
                    P_baba_adi = babaadi2_txt.Text,
                    P_eposta = eposta2_txt.Text,
                    P_tel = telno2_txt.Text,
                    P_birim_ID = birim2_cbox.SelectedIndex,
                    P_klinik_ID = klinik2_cbox.SelectedIndex,
                    P_sifre = sifre2_txt.Text

                };
                db.Personel.Add(personeledit);
                db.SaveChanges();
                MessageBox.Show("personel bilgileri güncellenmiştir.");

                giris_panel.Visible = true;
                personel_edit_panel.Visible = false;

            }
        }
        private void brim_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brim_cbox.SelectedIndex == 1)
            {
                klinik_cbox.DataSource = db.Polikinlik.ToList();
                klinik_cbox.DisplayMember = "Polik_adi";
                klinik_cbox.ValueMember = "Polik_ID";

                klinik_lbl.Visible = true;
                klinik_cbox.Visible = true;
                klinik_lbl.Location = new Point(424, 204);
                klinik_cbox.Location = new Point(581, 204);
                sifre_lbl.Location = new Point(424, 234);
                sifre_txt.Location = new Point(581, 234);
            }
            else
            {
                klinik_lbl.Visible = false;
                klinik_cbox.Visible = false;
                klinik_lbl.Location = new Point(424, 234);
                klinik_cbox.Location = new Point(581, 234);
                sifre_lbl.Location = new Point(424, 204);
                sifre_txt.Location = new Point(581, 204);
            }




        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["İlac_ID"].Value;
                eczane = db.Eczane.Find(id);

                eczane_ilac_form eczane_İlac_Form = new eczane_ilac_form();
                DialogResult result = eczane_İlac_Form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Eczane.ToList();
                }

            }
            else if (e.ColumnIndex == 1)
            {
                string ilacAdi = dataGridView1.Rows[e.RowIndex].Cells["İlac_adi"].Value
                    + "";

                DialogResult result = MessageBox.Show(ilacAdi.Trim() + " isimli ilacı silmek istediğinize emin misiniz?"
                    , "Silme Onayı"
                    , MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["İlac_ID"].Value;
                    Eczane eczane = db.Eczane.Find(id);
                    db.Eczane.Remove(eczane);

                    db.SaveChanges();

                    dataGridView1.DataSource = db.Eczane.ToList();
                }

            }
            dataGridView1.DataSource = db.Eczane.ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime izinaldigitarih = dateTimePicker1.Value;
            DateTime izinbitistarih = dateTimePicker2.Value;
            DateTime BugunTarih = DateTime.Now;
            TimeSpan ts = izinbitistarih - izinaldigitarih;
            izinligun_txt.Text = ts.Days.ToString();
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden Sonra Veya Aynı Olamaz Olamaz.");
            }
        }

        public static Personel Personel = new Personel();
        private void personellist_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {//personel bilgilerini düzenleme ekranı açılır.
                guncellenecekId = Convert.ToInt32(personellist_dgv.Rows[e.RowIndex].Cells[3].Value);
                int id = (int)personellist_dgv.Rows[e.RowIndex].Cells["P_ID"].Value;
                Personel = db.Personel.Find(id);

                personel_edit_panel.Visible = true;
                personel_edit_panel.Location = new Point(12, 112);
                personel_list_panel.Visible = false;

                Personel personel = new Personel();
                // personel düzenleme kısmı
                tcno2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_tc"].Value);
                isim2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_adi"].Value);
                sisim2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_s_adi"].Value);
                dyeri2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_d_yeri"].Value);
                anneadi2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_anne_adi"].Value);
                babaadi2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_baba_adi"].Value);

                if (personellist_dgv.Rows[e.RowIndex].Cells["P_cinsiyet"].Value == "k")
                {
                    kadin2_rbtn.Checked = true;
                    cinsiyet2 = "k";
                }
                if (personellist_dgv.Rows[e.RowIndex].Cells["P_cinsiyet"].Value == "e")
                {
                    erkek2_rbtn.Checked = true;
                    cinsiyet2 = "e";
                }

                eposta2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_eposta"].Value);
                telno2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_tel"].Value);
                birim2_cbox.SelectedIndex = Convert.ToInt16(personellist_dgv.Rows[e.RowIndex].Cells["P_birim_ID"].Value);
                klinik2_cbox.SelectedIndex = Convert.ToInt16(personellist_dgv.Rows[e.RowIndex].Cells["P_klinik_ID"].Value);
                sifre2_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_sifre"].Value);

                db.SaveChanges();


            }
            else if (e.ColumnIndex == 1)
            {//personel silme işlemini gerçekleştirir.
                string adSoyad = personellist_dgv.Rows[e.RowIndex].Cells["P_adi"].Value
                                    + " "
                                    + personellist_dgv.Rows[e.RowIndex].Cells["P_s_adi"].Value;

                DialogResult result = MessageBox.Show(adSoyad.Trim() + " isimli kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = (int)personellist_dgv.Rows[e.RowIndex].Cells["P_ID"].Value;
                    Personel personel = db.Personel.Find(id);
                    db.Personel.Remove(personel);

                    db.SaveChanges();

                    personellist_dgv.DataSource = db.Personel.ToList();
                }
            }
            else if (e.ColumnIndex == 2)
            {//izin işlemleri sayfasına yönlendirir.
                izin_panel.Visible = true;
                izin_panel.Location = new Point(12, 112);
                personel_list_panel.Visible = false;
                kalangun_txt.Text = Convert.ToString(personellist_dgv.Rows[e.RowIndex].Cells["P_izingun"].Value);
            }

        }
        private void eczane_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string cinsiyet1 = "k";
        private void kadin_rbtb_CheckedChanged(object sender, EventArgs e)
        {
            if (kadin_rbtb.Checked == true)
            {

                cinsiyet1 = "k";
            }
        }
        private void erkek_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (erkek_rbtn.Checked == true)
            {
                cinsiyet1 = "e";
            }
        }
        string cinsiyet2;
        private void kadin2_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (kadin2_rbtn.Checked == true)
            {
                cinsiyet2 = "k";
            }
        }
        private void erkek2_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (erkek2_rbtn.Checked == true)
            {
                cinsiyet2 = "e";
            }

        }

        private void izinver_btn_Click(object sender, EventArgs e)
        {
            int kalangun = Convert.ToInt32(kalangun_txt.Text);
            int izinligun = Convert.ToInt32(izinligun_txt.Text);
            if (kalangun > izinligun)
            {
                // kalangun_txt.Text = Convert.ToString(kalangun - izinligun);
                //  kalangun_txt.Text = Convert.ToInt32(personellist_dgv.Rows[e.RowIndex].Cells["P_izingun"].Value);

                //Personel personel = db.Personel.Find(guncellenecekId);

                // personel.P_izingun = Convert.ToInt32( kalangun_txt.Text);
                kalangun_txt.Text = Convert.ToString(kalangun - izinligun);



                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Bu kadar izin hakkınız kalmamıştır");
            }
        }

        private void tcno_txt_TextChanged(object sender, EventArgs e)
        {
            var personel = db.Personel.Where(x => x.P_tc == tcno_txt.Text).ToList();
            if (personel.Count==1)
            {
                MessageBox.Show(tcno_txt.Text + "Bu TC kimlik numarasıyla bir kayıt vardır lütfen kontrol ediniz.");
            }
        }

        private void tcno2_txt_TextChanged(object sender, EventArgs e)
        {
            var personel = db.Personel.Where(x => x.P_tc == tcno2_txt.Text).ToList();
            if (personel.Count==1)
            {
                MessageBox.Show(tcno2_txt.Text + "Bu TC kimlik numarasıyla bir kayıt vardır lütfen kontrol ediniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gecmis gecmis = new gecmis();
            gecmis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personellist_dgv.DataSource = db.Personel.Where(x => x.P_birim_ID == comboBox1.SelectedIndex +1);
        }
    }
}
