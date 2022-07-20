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
    public partial class eczane_ilac_form : Form
    {
        public eczane_ilac_form()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();
        private void eczane_ilac_form_Load(object sender, EventArgs e)
        {
            string ilac_adi = Convert.ToString(admin_form.eczane.İlac_adi);
            txt_ilacAdi.Text = ilac_adi.Trim();
            txt_ticariAdi.Text = admin_form.eczane.İlac_ticari_ad;
            txt_stokAdedi.Text = Convert.ToString(admin_form.eczane.İlac_stok);
            txt_kid.Text = Convert.ToString(admin_form.eczane.İlac_klinik_ID);
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            admin_form.eczane.İlac_adi = txt_ilacAdi.Text;
            admin_form.eczane.İlac_ticari_ad = txt_ticariAdi.Text;
            admin_form.eczane.İlac_stok = Convert.ToInt32(txt_stokAdedi.Text);
            admin_form.eczane.İlac_klinik_ID = Convert.ToInt32(txt_kid.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_ilacEkle_Click(object sender, EventArgs e)
        {
            txt_ilacAdi.Clear();
            txt_ticariAdi.Clear();
            txt_stokAdedi.Clear();
            txt_kid.Clear();
            label7.Text = "Yeni İlaç Ekle";

            btn_guncelle.Visible = false;
            btn_ilacEkle.Visible = false;

            Button btn_ilacKaydet = new Button();
            btn_ilacKaydet.Text = "Kaydet";
            btn_ilacKaydet.Top = 340;
            btn_ilacKaydet.Left = 179;
            btn_ilacKaydet.Width = 100;
            btn_ilacKaydet.Height = 50;
            btn_ilacKaydet.BackColor = Color.White;
            btn_ilacKaydet.Font = new Font(btn_ilacKaydet.Font, btn_ilacKaydet.Font.Style ^ FontStyle.Bold);
            btn_ilacKaydet.Click += new EventHandler(btn_ilacKaydet_Click);
            this.Controls.Add(btn_ilacKaydet);
        }

        private void btn_ilacKaydet_Click(object sender, EventArgs e)
        {
            Eczane eczane = new Eczane()
            {
                İlac_adi = txt_ilacAdi.Text,
                İlac_ticari_ad = txt_ticariAdi.Text,
                İlac_stok = Convert.ToInt32(txt_stokAdedi.Text),
                İlac_klinik_ID = Convert.ToInt32(txt_kid.Text)


            };

            db.Eczane.Add(eczane);
            db.SaveChanges();
            admin_form admin_Form = new admin_form();

            admin_Form.Show();
            this.Hide();
        }

      
    }
}
