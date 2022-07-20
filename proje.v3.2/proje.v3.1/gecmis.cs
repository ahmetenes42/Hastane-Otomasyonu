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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();
        private void gecmis_Load(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktorlistesii_cbox.DataSource = db.Doktor.ToList();
            doktorlistesii_cbox.DisplayMember = "D_ad_soyad";
            doktorlistesii_cbox.ValueMember = "D_ID";
            
            
        }

        private void doktorlistesii_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            int doktorID = doktorlistesii_cbox.SelectedIndex + 1; ;
            dataGridView1.DataSource = db.Hasta.Where(x => x.H_randevu_tarih == 0.ToString() && x.D_ID == doktorID).ToList();
            label2.Text = "Listelenen Hasta Sayısı: " + dataGridView1.RowCount.ToString();

            //Geçmiş Hasta Randevusu için
            //dataGridView1.DataSource = db.Hasta.Where(x => x.H_gecmis_randevu_tarih == dateTimePicker1.Text).ToList();
            
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(doktorlistesii_cbox.Text + "Adlı Doktorun Geçmiş Hastası Yok");
            }

        }

        private void btn_sekreter_geri_Click(object sender, EventArgs e)
        {
            admin_form admin_Form = new admin_form();
            admin_Form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
