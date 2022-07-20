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
    public partial class laborant_form : Form
    {
        public laborant_form()
        {
            InitializeComponent();
        }
        HastaneEntities db = new HastaneEntities();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void laborant_form_Load(object sender, EventArgs e)
        {
            tahlil_sonuc_txt.Text = "Kalsiyum:"+ Environment.NewLine + "Potasyum:"+ Environment.NewLine+"Bilurubin:"+ Environment.NewLine+"Fosfor:"+ Environment.NewLine+"Hemotokrit"+ Environment.NewLine+"Hemoglobin:";
            tahlil_list_panel.Visible = true;
            tahlil_list_panel.Location = new Point(12, 112);
            tahlil_sonuc_panel.Visible = false;

            tahlil_liste_dgv.DataSource = db.Hasta.ToList();//& x.H_randevu_tarih == bugun

            tahlil_liste_dgv.Columns["H_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_tahlil_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_tahlil_sonuc"].Visible = false;// tahlil sonuç verilerinin bulunduğu kısım
            tahlil_liste_dgv.Columns["H_d_yeri"].Visible = false;
            tahlil_liste_dgv.Columns["H_baba_adi"].Visible = false;
            tahlil_liste_dgv.Columns["H_anne_adi"].Visible = false;
            tahlil_liste_dgv.Columns["H_tel"].Visible = false;
            tahlil_liste_dgv.Columns["H_eposta"].Visible = false;
            tahlil_liste_dgv.Columns["H_sifre"].Visible = false;
            tahlil_liste_dgv.Columns["H_yatis_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_recete_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_randevu_ID"].Visible = false;
            tahlil_liste_dgv.Columns["D_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_nabiz"].Visible = false;
            tahlil_liste_dgv.Columns["H_tansiyon"].Visible = false;
            tahlil_liste_dgv.Columns["H_randevu_tarih"].Visible = false;
            tahlil_liste_dgv.Columns["H_tedavi_durum"].Visible = false;
            tahlil_liste_dgv.Columns["H_d_tarihi"].Visible=false;
            tahlil_liste_dgv.Columns["H_ilac_ID"].Visible = false;
            //
            tahlil_liste_dgv.Columns["H_tc"].HeaderText = "TC Kimlik No";
            tahlil_liste_dgv.Columns["H_adi"].HeaderText = "Ad";
            tahlil_liste_dgv.Columns["H_s_adi"].HeaderText = "Soyadı";
            tahlil_liste_dgv.Columns["H_cinsiyet"].HeaderText = "Cinsiyet";
        }
        int guncellenecekId = 0;
        private void dataGV_tahlil_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                tahlil_sonuc_panel.Visible = true;
                tahlil_sonuc_panel.Location=new Point(12, 112);
                tahlil_list_panel.Visible = false;
                guncellenecekId = Convert.ToInt32(tahlil_liste_dgv.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void tahlil_kaydet_btn_Click(object sender, EventArgs e)
        {

            Hasta hasta = db.Hasta.Find(guncellenecekId);

            hasta.H_tahlil_sonuc = tahlil_sonuc_txt.Text;



            db.SaveChanges();
           // tahlil_sonuc_txt.Text = "-Kalsiyum:-   -Potasyum:-  -Bilurubin:-  -Fosfor:-  -Hemotokrit:-  -Hemoglobin:-";


            //db.SaveChanges();
            // tahlil_sonuc_txt.Text
            ///
            tahlil_list_panel.Visible = true;
            tahlil_list_panel.Location = new Point(12, 112);
            tahlil_sonuc_panel.Visible =false;

            tahlil_liste_dgv.DataSource = db.Hasta.ToList();//& x.H_randevu_tarih == bugun

            tahlil_liste_dgv.Columns["H_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_tahlil_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_tahlil_sonuc"].Visible = false;// tahlil sonuç verilerinin bulunduğu kısım
            tahlil_liste_dgv.Columns["H_d_yeri"].Visible = false;
            tahlil_liste_dgv.Columns["H_baba_adi"].Visible = false;
            tahlil_liste_dgv.Columns["H_anne_adi"].Visible = false;
            tahlil_liste_dgv.Columns["H_tel"].Visible = false;
            tahlil_liste_dgv.Columns["H_eposta"].Visible = false;
            tahlil_liste_dgv.Columns["H_sifre"].Visible = false;
            tahlil_liste_dgv.Columns["H_yatis_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_recete_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_randevu_ID"].Visible = false;
            tahlil_liste_dgv.Columns["D_ID"].Visible = false;
            tahlil_liste_dgv.Columns["H_nabiz"].Visible = false;
            tahlil_liste_dgv.Columns["H_tansiyon"].Visible = false;
            tahlil_liste_dgv.Columns["H_randevu_tarih"].Visible = false;
            tahlil_liste_dgv.Columns["H_tedavi_durum"].Visible = false;
            tahlil_liste_dgv.Columns["H_d_tarihi"].Visible = false;
  
            //
            tahlil_liste_dgv.Columns["H_tc"].HeaderText = "TC Kimlik No";
            tahlil_liste_dgv.Columns["H_adi"].HeaderText = "Ad";
            tahlil_liste_dgv.Columns["H_s_adi"].HeaderText = "Soyadı";
            tahlil_liste_dgv.Columns["H_cinsiyet"].HeaderText = "Cinsiyet";
        }

        private void anamenu_hbilgi_btn_Click(object sender, EventArgs e)
        {
            tahlil_list_panel.Visible = true;
            tahlil_list_panel.Location = new Point(12, 112);
            tahlil_sonuc_panel.Visible = false;
        }

        private void tahlil_sonuc_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
