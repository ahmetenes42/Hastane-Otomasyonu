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
    public partial class dotor_form : Form
    {
        public dotor_form()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();
        Doktor doktor1 = new Doktor();
        int guncellenecekId = 0;
        private void dotor_form_Load(object sender, EventArgs e)
        {
             hasta_list_dvg.DataSource = db.Hasta.Where(x => x.H_randevu_tarih == dtp_randevutarih.Text && x.D_ID== giris_form.id).ToList();
            label5.Text ="Hoşgeldin "+ giris_form.doktorKadi;
 

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
 
            hasta_list_panel.Visible = true;
            hasta_list_panel.Location = new Point(12, 112);
            label2.Text = "Tarih: " + tarih.ToShortDateString();
            hasta_bilgi_panel.Visible = false;
            Personel personel = new Personel();

            Doktor doktor = new Doktor();

            label12.Text = giris_form.doktorKadi.Trim() + "  Adlı Doktorun Hastaları Listeleniyor";
            label4.Text = "Listelenen Hasta Sayısı:" + hasta_list_dvg.RowCount.ToString();


            //



            hasta_list_dvg.Columns["H_ID"].Visible = false;
            hasta_list_dvg.Columns["H_tahlil_ID"].Visible = false;
            hasta_list_dvg.Columns["H_tahlil_sonuc"].Visible = false;// tahlil sonuç verilerinin bulunduğu kısım
            hasta_list_dvg.Columns["H_d_yeri"].Visible = false;
            hasta_list_dvg.Columns["H_baba_adi"].Visible = false;
            hasta_list_dvg.Columns["H_anne_adi"].Visible = false;
            hasta_list_dvg.Columns["H_tel"].Visible = false;
            hasta_list_dvg.Columns["H_eposta"].Visible = false;
            hasta_list_dvg.Columns["H_sifre"].Visible = false;
            hasta_list_dvg.Columns["H_yatis_ID"].Visible = false;
            // hasta_list_dvg.Columns["H_recete_ID"].Visible = false;
            hasta_list_dvg.Columns["H_randevu_ID"].Visible = false;
            hasta_list_dvg.Columns["D_ID"].Visible = false;
            hasta_list_dvg.Columns["H_nabiz"].Visible = false;
            hasta_list_dvg.Columns["H_tansiyon"].Visible = false;
            //hasta_list_dvg.Columns["H_randevu_tarih"].Visible = false;
            hasta_list_dvg.Columns["H_tedavi_durum"].Visible = false;
            hasta_list_dvg.Columns["H_tc"].HeaderText = "TC Kimlik No";
            hasta_list_dvg.Columns["H_adi"].HeaderText = "Ad";
            hasta_list_dvg.Columns["H_s_adi"].HeaderText = "Soyadı";
            hasta_list_dvg.Columns["H_cinsiyet"].HeaderText = "Cinsiyet";
            hasta_list_dvg.Columns["H_d_tarihi"].HeaderText = "Doğum Tarihi";

        }

        private void hasta_list_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//Tahlil isteme button
            {
                Hasta hasta = new Hasta();
                hasta_list_dvg.Rows[e.RowIndex].Cells["H_tahlil_ID"].Value = 1;
                db.SaveChanges();
                 MessageBox.Show("Tahlil İstenmiştir");

            }
            else if (e.ColumnIndex == 1)// Yatış ver button
            {

                hasta_list_dvg.Rows[e.RowIndex].Cells["H_yatis_ID"].Value = 1;
                MessageBox.Show(Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_adi"].Value) + "adlı hastaya yatış verilmiştir. ");
            }
            else if (e.ColumnIndex == 2)// Hasta bilgi button
            {
                hasta_list_panel.Visible = false;
                hasta_bilgi_panel.Visible = true;
                hasta_bilgi_panel.Location = new Point(12, 112);

                string isim = Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_adi"].Value);
                tcno_txt.Text = Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_tc"].Value);
                isim_sisim1_txt.Text = isim.TrimEnd() + " " + Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_s_adi"].Value);
                tahlil_sonuc_txt.Text = Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_tahlil_sonuc"].Value);
                guncellenecekId = Convert.ToInt32(hasta_list_dvg.Rows[e.RowIndex].Cells[3].Value);

                //string[] tahliller = { Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_tahlil_sonuc"].Value).Replace(',','\n')};
                //foreach (string tahliltemiz in tahliller)
                //{
                //    tahlil_sonuc_txt.Text = tahliltemiz;
                //    tahlil_sonuc_list.Items.Add(tahliltemiz);
                //}
                //string tahliltemiz = Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_tahlil_sonuc"].Value).Replace(',',"");


                //tahlil_sonuc_txt.Text = ;//Convert.ToString(hasta_list_dvg.Rows[e.RowIndex].Cells["H_tahlil_sonuc"].Value);
            }

        }


        
        private void recete_btn_Click(object sender, EventArgs e)
        {
            recete_btn.Visible = false;
            // recete_btn.Text = "REÇETE YAZ";
            recete_lbl.Visible = true;
            recete_txt.Visible = true;
            recete_onay_btn.Visible = true;
        }

        private void recete_onay_btn_Click(object sender, EventArgs e)
        {
            Hasta hasta = db.Hasta.Find(guncellenecekId);

            hasta.H_recete_ID = Convert.ToString(recete_txt.Text);
            hasta.H_gecmis_randevu_tarih = hasta.H_randevu_tarih;
            hasta.H_randevu_tarih = 0.ToString();
            db.SaveChanges();
            ////hasta_list_dvg.Rows[e.RowIndex].Cells["H_recete_ID"].Value = recete_txt.Text;
            //printDocument1.Print();
            MessageBox.Show(" Reçeteyi onayladınız. ");
            
            recete_txt.Clear();
        }

        private void anamenu_hbilgi_btn_Click(object sender, EventArgs e)
        {
            hasta_list_panel.Visible = true;
            hasta_list_panel.Location = new Point(12, 112);
            hasta_bilgi_panel.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_hastalist_yenile_Click(object sender, EventArgs e)
        {
            //Hasta hasta = new Hasta();

            //if (hasta_list_dvg.col != 0)
            //{
            //    hasta_list_dvg.Columns["H_tahlil_sonuc"].
            //}
            //hasta_list_dvg.DataSource = db.Hasta.ToList();

            //dgw_hasta_list.DataSource = db.Hasta.Where(x => x.H_yatis_ID == 1).ToList();
        }

        private void doktorlistesii_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hasta hasta = new Hasta();

            //DateTime bugun = DateTime.Today;

            //string buguns = bugun.ToString("u");
            //String bugunyeni = Convert.ToString(buguns);
            //string bugunyeni1 = bugunyeni.Substring(0, bugunyeni.Length - 10);

            //// label4.Text = bugun.ToString();
            //// label1.Text = bugunyeni1.ToString();
            //// hasta_list_dvg.DataSource = db.Hasta.Where(x => x.D_ID == 19).ToList();
            //// hasta_list_dvg.DataSource = db.Hasta.ToList();//& x.H_randevu_tarih == bugun
            ////SELECT convert(varchar, getdate(), 23)

            //// hasta_list_dvg.DataSource = db.Hasta.Where(x => x.H_randevu_tarih == dtp_randevutarih.Value).ToList();

            //int doktorID = doktorlistesii_cbox.SelectedIndex + 1; ;
            //hasta_list_dvg.DataSource = db.Hasta.Where(x => x.D_ID == doktorID).ToList();
           // hasta_list_dvg.DataSource = db.Hasta.Where(x => x.H_randevu_tarih == dtp_randevutarih.Text && x.D_ID==doktorID).ToList();
            label4.Text = "Listelenen Hasta Sayısı:" + hasta_list_dvg.RowCount.ToString();

        
            //
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //try
            //{
            //    Font font = new Font("Arial", 14);
            //    SolidBrush firca = new SolidBrush(Color.Black);
            //    e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("ddd.MM.yyyy HH:mm:ss")}", font, firca, 50, 170);
            //    Image image = new Bitmap(Properties.Resources.saglikBakanlıgı, 150, 100);
            //    Image image2 = new Bitmap(Properties.Resources.saglikBakanlıgı, 150, 100);

            //    e.Graphics.DrawImage(image,  + 50,  + 20);
            //    e.Graphics.DrawImage(image2, +650, +20);
            //    font = new Font("Arial", 20, FontStyle.Bold);
            //    e.Graphics.DrawString("REÇETE", font, firca, 350, 65);
            //    e.Graphics.DrawString("Hasta Bilgileri", font, firca, 330, 290);
            //    e.Graphics.DrawString("-----------------------------------------------------------------------------------------", font, firca, 0, 310);


            //    font = new Font("Arial", 15, FontStyle.Bold);
            //    e.Graphics.DrawString("Tc", font, firca, 60, 350);
            //    e.Graphics.DrawString("Ad Soyad", font, firca, 400, 350);
            //    e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------", font, firca, 0, 380);
            //    e.Graphics.DrawString("İlaç Adı", font, firca, 60, 450);

            //    font = new Font("Arial", 15);
            //    e.Graphics.DrawString(tcno_txt.Text, font, firca, 150, 350);
            //    e.Graphics.DrawString(isim_sisim1_txt.Text, font, firca, 550, 350);
            //    e.Graphics.DrawString(recete_txt.Text, font, firca, 150, 450);
            //}
            //catch (Exception)
            //{

               
            //}
        }

        private void dtp_randevutarih_ValueChanged(object sender, EventArgs e)
        {
            hasta_list_dvg.DataSource = db.Hasta.Where(x => x.H_randevu_tarih == dtp_randevutarih.Text && x.D_ID == giris_form.id).ToList();
            label4.Text = "Listelenen Hasta Sayısı:" + hasta_list_dvg.RowCount.ToString();
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            if (tarih>dtp_randevutarih.Value)
            {
                label10.Text = "Geçmiş Randevulara Bakıyorsunuz";

            }
            else
            {
                label10.Text = "";
            }
        }

        private void btn_butunHastaListele_Click(object sender, EventArgs e)
        {
            hasta_list_dvg.DataSource = db.Hasta.Where(x => x.D_ID == giris_form.id).ToList();

        }
    }
}
