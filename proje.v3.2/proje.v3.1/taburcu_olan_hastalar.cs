using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje.v3._1
{
    public partial class taburcu_olan_hastalar : Form
    {
        public taburcu_olan_hastalar()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();

        private void button1_Click(object sender, EventArgs e)
        {

            //textBox1.Text = time.ToShortDateString();
           // dataGridView1.DataSource = db.Hasta.Where(x => x.H_taburcu_tarih == textBox1.Text).ToList();
            dataGridView1.DataSource = db.Hasta.Where(x => x.H_taburcu_tarih == dateTimePicker1.Text).ToList();
            if (dataGridView1.RowCount==0)
            {
                MessageBox.Show("Bu Tarihte Hasta Taburcu Olmamış");
               
            }
            label2.Text ="Toplam listelenen hasta sayısı :"+ dataGridView1.RowCount.ToString();

 

        }

        private void btn_sekreter_geri_Click(object sender, EventArgs e)
        {
            hemsire_form hemsire_Form = new hemsire_form();
            hemsire_Form.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            if (tarih<dateTimePicker1.Value)
            {
                MessageBox.Show("İleri Tarihi Seçemezssiniz !!");
                dateTimePicker1.Value = tarih;
            }
        }

        private void taburcu_olan_hastalar_Load(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
        
            label1.Text = " Bugünün Tarihi: " + tarih.ToShortDateString();
            dataGridView1.DataSource = db.Hasta.Where(x => x.H_yatis_ID==0) .ToList();

            dataGridView1.Columns["H_ID"].Visible = false;
            dataGridView1.Columns["H_tahlil_ID"].Visible = false;
            dataGridView1.Columns["H_tahlil_sonuc"].Visible = false;// tahlil sonuç verilerinin bulunduğu kısım
            dataGridView1.Columns["H_d_yeri"].Visible = false;
            dataGridView1.Columns["H_baba_adi"].Visible = false;
            dataGridView1.Columns["H_anne_adi"].Visible = false;
            dataGridView1.Columns["H_tel"].Visible = false;
            dataGridView1.Columns["H_eposta"].Visible = false;
            dataGridView1.Columns["H_sifre"].Visible = false;
            dataGridView1.Columns["H_yatis_ID"].Visible = false;
            // hasta_list_dvg.Columns["H_recete_ID"].Visible = false;
            dataGridView1.Columns["H_randevu_ID"].Visible = false;
            //dataGridView1.Columns["D_ID"].Visible = false;
            dataGridView1.Columns["H_nabiz"].Visible = false;
            dataGridView1.Columns["H_tansiyon"].Visible = false;
            //hasta_list_dvg.Columns["H_randevu_tarih"].Visible = false;
            dataGridView1.Columns["H_tedavi_durum"].Visible = false;
            dataGridView1.Columns["H_ilac_ID"].Visible = false;
            dataGridView1.Columns["H_tc"].HeaderText = "TC Kimlik No";
            dataGridView1.Columns["H_adi"].HeaderText = "Ad";
            dataGridView1.Columns["H_s_adi"].HeaderText = "Soyadı";
            dataGridView1.Columns["H_cinsiyet"].HeaderText = "Cinsiyet";
            dataGridView1.Columns["H_d_tarihi"].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns["H_recete_ID"].HeaderText = "Kullandığı İlaç";
            dataGridView1.Columns["H_randevu_tarih"].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns["H_randevu_saat"].HeaderText = "Randevu Saati ";
            dataGridView1.Columns["H_taburcu_tarih"].HeaderText = "Taburcu Tarihi ";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doktor doktor = new Doktor();
            combo_doktor.Visible = true;
            label3.Visible = true;
            int id = 0;
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString());
            combo_doktor.DataSource = db.Doktor
           .Where(x => x.D_ID == id)
           .ToList();
            combo_doktor.DisplayMember = "D_ad_soyad";
            combo_doktor.ValueMember = "D_ID";
            if (e.ColumnIndex == 0)
            {
               
              
            }
        }
    }
}
