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
    public partial class sekreter_form : Form
    {
        public sekreter_form()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();
        int siraNumarasi = 0;
        private void sekreter_form_Load(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
        
            DataGridSek.DataSource = db.Hasta.ToList();
            
            DataGridSek.Columns["H_ID"].Visible = false;
            DataGridSek.Columns["H_randevu_ID"].Visible = false;
            DataGridSek.Columns["H_tahlil_ID"].Visible = false;
            DataGridSek.Columns["H_d_tarihi"].Visible = false;
            DataGridSek.Columns["H_baba_adi"].Visible = false;
            DataGridSek.Columns["H_anne_adi"].Visible = false;
            DataGridSek.Columns["H_tel"].Visible = false;
            DataGridSek.Columns["H_eposta"].Visible = false;
            DataGridSek.Columns["H_sifre"].Visible = false;
            DataGridSek.Columns["H_yatis_ID"].Visible = false;
            DataGridSek.Columns["H_recete_ID"].Visible = false;
       
            DataGridSek.Columns["D_ID"].Visible = false;
            DataGridSek.Columns["H_nabiz"].Visible = false;
            DataGridSek.Columns["H_tansiyon"].Visible = false;
            DataGridSek.Columns["H_randevu_tarih"].Visible = false;
            DataGridSek.Columns["H_tedavi_durum"].Visible = false;
            DataGridSek.Columns["H_tc"].HeaderText = "TC kimlik numarası";
            DataGridSek.Columns["H_adi"].HeaderText = "Adı";
            DataGridSek.Columns["H_s_adi"].HeaderText = "Soyadı";
            DataGridSek.Columns["H_cinsiyet"].HeaderText = "Cinsiyeti";
            DataGridSek.Columns["H_d_yeri"].HeaderText = "Doğum Yeri";
        }

        private void DataGridSek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
             
                MessageBox.Show(" Tahlil sonuçları : " + DataGridSek.Rows[e.RowIndex].Cells["H_tahlil_sonuc"].Value);

            }
            else if (e.ColumnIndex == 1)//Reçete Yazdırma
            {
                label2.Text = Convert.ToString(DataGridSek.Rows[e.RowIndex].Cells["H_adi"].Value); //Gerekli Bilgileri yazdırmak için kullanmak için labellara attım
                label3.Text = Convert.ToString(DataGridSek.Rows[e.RowIndex].Cells["H_tc"].Value);
                label4.Text = Convert.ToString(DataGridSek.Rows[e.RowIndex].Cells["H_s_adi"].Value);
                label5.Text = Convert.ToString(DataGridSek.Rows[e.RowIndex].Cells["H_recete_ID"].Value);
                //guncellenecekId = Convert.ToInt32(DataGridSek.Rows[e.RowIndex].Cells[3].Value);

                

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show(label2.Text.Trim()+" Adlı Hastanın Reçetesini Yazdırmak İstediğinize Eminmisiniz ?", "REÇETE YAZDIRMA", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)//message boxdan eveete tıklandığında
                {
                    printDocument1.Print();//yazdırma işlemi aktif olacak
                }
                else
                {
                    MessageBox.Show("İPTAL EDİLDİ");
                }

            }

            
            else if (e.ColumnIndex == 2)
            {
                siraNumarasi += 1;
                MessageBox.Show(" Sıra Numaranız : " + siraNumarasi);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            // DataGridSek.DataSource = db.Hasta.Where(x => x.H_tc == hastatctxt.Text).ToList();
            DataGridSek.DataSource = db.Hasta.Where(x =>
          x.H_tc.Contains(hastatctxt.Text)
          
          ).ToList();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //Randevu İşlemleri Butonu
        {
            hasta_kayit_form hasta_Kayit_Form = new hasta_kayit_form();
            hasta_Kayit_Form.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//Yazdırma İşlemi
        {
            try
            {
                Font font = new Font("Arial", 14);//Font Belirlendi
                SolidBrush firca = new SolidBrush(Color.Black);//Yazı Rengi
                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("ddd.MM.yyyy HH:mm:ss")}", font, firca, 50, 170);//Bugünün tarihi
                Image image = new Bitmap(Properties.Resources.saglikBakanlıgı, 150, 100);//Resim
                Image image2 = new Bitmap(Properties.Resources.saglikBakanlıgı, 150, 100);

                e.Graphics.DrawImage(image, +50, +20);//resim sol 
                e.Graphics.DrawImage(image2, +650, +20);//Resim sağ
                font = new Font("Arial", 20, FontStyle.Bold);//Tekrar font belirlendi
                e.Graphics.DrawString("REÇETE", font, firca, 350, 65);
                e.Graphics.DrawString("Hasta Bilgileri", font, firca, 330, 290);
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------", font, firca, 0, 310);


                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("Tc", font, firca, 60, 350);
                e.Graphics.DrawString("Ad Soyad", font, firca, 400, 350);
                e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------", font, firca, 0, 380);
                e.Graphics.DrawString("İlaç Adı", font, firca, 60, 450);

                font = new Font("Arial", 15);
                e.Graphics.DrawString(label3.Text, font, firca, 150, 350);//Hasta tc
                e.Graphics.DrawString(label2.Text.Trim()+" "+label4.Text.Trim(), font, firca, 550, 350);//hasta adı soyadı
                e.Graphics.DrawString(label5.Text, font, firca, 150, 450);//İlaçlar , reçete
            }
            catch (Exception)
            {


            }
        }
    }
}
