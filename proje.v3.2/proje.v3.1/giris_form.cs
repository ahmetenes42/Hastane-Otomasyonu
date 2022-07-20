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
    public partial class giris_form : Form
    {
        public giris_form()
        {
            InitializeComponent();
        }
       public static string doktorKadi = "";
        public static int id =0;
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HastaneEntities db = new HastaneEntities();
            Personel personel = new Personel();

            //Tek tek adı şifresi ve birim id si kontrol ediyoruz ona göre gideceği sisteme atıyoruz
            var Admin = db.Personel.Where(x => x.P_birim_ID == 0 && x.P_adi == textBox1.Text && x.P_sifre == textBox2.Text).ToList();
            if (Admin.Count() == 1)
            {
                admin_form admin_Form = new admin_form();
                admin_Form.Show();
                this.Hide();
            }

            var Hemsire = db.Personel.Where(x => x.P_birim_ID == 2 && x.P_adi == textBox1.Text && x.P_sifre == textBox2.Text).ToList();

            if (Hemsire.Count() == 1)
            {
                hemsire_form hemsire_Form = new hemsire_form();
                hemsire_Form.Show();
                this.Hide();
            }

            //public int doktorıd =  
            var doktor = db.Doktor.Where(x => x.D_k_adi == textBox1.Text && x.D_sifte == textBox2.Text).ToList();
            if (doktor.Count() == 1)
            {
                
                dataGridView1.DataSource =doktor.ToList();//Doktorun id sini almak için yukardaki var değerindeki doktor dgw ye düşüyor

                id = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());//id sini alıyorum

                doktorKadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();//id sini alıyorum
                dotor_form dotor_Form = new dotor_form();
                dotor_Form.Show();
                this.Hide();
            }
            var sekereter = db.Personel.Where(x => x.P_birim_ID == 3 && x.P_adi == textBox1.Text && x.P_sifre == textBox2.Text).ToList();
            if (sekereter.Count() == 1)
            {
                sekreter_form sekreter_Form = new sekreter_form();
                sekreter_Form.Show();
                this.Hide();
            }

            var laborant = db.Personel.Where(x => x.P_birim_ID == 4 && x.P_adi == textBox1.Text && x.P_sifre == textBox2.Text).ToList();
            if (laborant.Count() == 1)
            {
                laborant_form laborant_Form = new laborant_form();
                laborant_Form.Show();
                this.Hide();
            }

            
        }

        private void giris_form_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
}
