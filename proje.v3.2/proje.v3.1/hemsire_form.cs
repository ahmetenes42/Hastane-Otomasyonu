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
    public partial class hemsire_form : Form
    {
        public hemsire_form()
        {
            InitializeComponent();

        }
        HastaneEntities db = new HastaneEntities(); // Veritabanı çağırıldı
        public static Hasta hasta = new Hasta();
        private void hasta_list_btn_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında hasta list forma yonlendirildi
            hasta_list_form hasta_List_Form = new hasta_list_form();
            hasta_List_Form.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // form kapatıldı
            Application.Exit();
        }

        private void hemsire_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            taburcu_olan_hastalar taburcu_Olan_Hastalar = new taburcu_olan_hastalar();
            taburcu_Olan_Hastalar.Show();
            this.Hide();
        }
    }
}
