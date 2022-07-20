namespace proje.v3._1
{
    partial class laborant_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laborant_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tahlil_list_panel = new System.Windows.Forms.Panel();
            this.lbl_tahlil_liste = new System.Windows.Forms.Label();
            this.tahlil_liste_dgv = new System.Windows.Forms.DataGridView();
            this.sonuc_gir = new System.Windows.Forms.DataGridViewImageColumn();
            this.tahlil_sonuc_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.anamenu_hbilgi_btn = new System.Windows.Forms.Button();
            this.tahlil_kaydet_btn = new System.Windows.Forms.Button();
            this.tahlil_sonuc_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tahlil_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tahlil_liste_dgv)).BeginInit();
            this.tahlil_sonuc_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 100);
            this.panel1.TabIndex = 39;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnCikis.Location = new System.Drawing.Point(748, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(40, 40);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "saglikBakanlıgı1.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.label9.Location = new System.Drawing.Point(174, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(462, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "HASTANE OTOMASYONU ";
            // 
            // tahlil_list_panel
            // 
            this.tahlil_list_panel.Controls.Add(this.lbl_tahlil_liste);
            this.tahlil_list_panel.Controls.Add(this.tahlil_liste_dgv);
            this.tahlil_list_panel.Location = new System.Drawing.Point(23, 170);
            this.tahlil_list_panel.Name = "tahlil_list_panel";
            this.tahlil_list_panel.Size = new System.Drawing.Size(756, 291);
            this.tahlil_list_panel.TabIndex = 40;
            // 
            // lbl_tahlil_liste
            // 
            this.lbl_tahlil_liste.AutoSize = true;
            this.lbl_tahlil_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tahlil_liste.Location = new System.Drawing.Point(315, 13);
            this.lbl_tahlil_liste.Name = "lbl_tahlil_liste";
            this.lbl_tahlil_liste.Size = new System.Drawing.Size(166, 25);
            this.lbl_tahlil_liste.TabIndex = 43;
            this.lbl_tahlil_liste.Text = "TAHLİL LİSTESİ";
            // 
            // tahlil_liste_dgv
            // 
            this.tahlil_liste_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tahlil_liste_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tahlil_liste_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sonuc_gir});
            this.tahlil_liste_dgv.Location = new System.Drawing.Point(12, 52);
            this.tahlil_liste_dgv.Name = "tahlil_liste_dgv";
            this.tahlil_liste_dgv.RowHeadersWidth = 45;
            this.tahlil_liste_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tahlil_liste_dgv.Size = new System.Drawing.Size(732, 220);
            this.tahlil_liste_dgv.TabIndex = 42;
            this.tahlil_liste_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_tahlil_liste_CellContentClick);
            // 
            // sonuc_gir
            // 
            this.sonuc_gir.HeaderText = "Sonuç Gir";
            this.sonuc_gir.Image = global::proje.v3._1.Properties.Resources.duzenle;
            this.sonuc_gir.MinimumWidth = 6;
            this.sonuc_gir.Name = "sonuc_gir";
            // 
            // tahlil_sonuc_panel
            // 
            this.tahlil_sonuc_panel.Controls.Add(this.label1);
            this.tahlil_sonuc_panel.Controls.Add(this.anamenu_hbilgi_btn);
            this.tahlil_sonuc_panel.Controls.Add(this.tahlil_kaydet_btn);
            this.tahlil_sonuc_panel.Controls.Add(this.tahlil_sonuc_txt);
            this.tahlil_sonuc_panel.Location = new System.Drawing.Point(57, 118);
            this.tahlil_sonuc_panel.Name = "tahlil_sonuc_panel";
            this.tahlil_sonuc_panel.Size = new System.Drawing.Size(756, 291);
            this.tahlil_sonuc_panel.TabIndex = 41;
            this.tahlil_sonuc_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.tahlil_sonuc_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tahlil Sonuçlarını Giriniz : ";
            // 
            // anamenu_hbilgi_btn
            // 
            this.anamenu_hbilgi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anamenu_hbilgi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anamenu_hbilgi_btn.Location = new System.Drawing.Point(515, 187);
            this.anamenu_hbilgi_btn.Name = "anamenu_hbilgi_btn";
            this.anamenu_hbilgi_btn.Size = new System.Drawing.Size(195, 48);
            this.anamenu_hbilgi_btn.TabIndex = 40;
            this.anamenu_hbilgi_btn.Text = "Ana Menüye Gitmek İçin Basın";
            this.anamenu_hbilgi_btn.UseVisualStyleBackColor = true;
            this.anamenu_hbilgi_btn.Click += new System.EventHandler(this.anamenu_hbilgi_btn_Click);
            // 
            // tahlil_kaydet_btn
            // 
            this.tahlil_kaydet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahlil_kaydet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahlil_kaydet_btn.Location = new System.Drawing.Point(18, 187);
            this.tahlil_kaydet_btn.Name = "tahlil_kaydet_btn";
            this.tahlil_kaydet_btn.Size = new System.Drawing.Size(127, 48);
            this.tahlil_kaydet_btn.TabIndex = 39;
            this.tahlil_kaydet_btn.Text = "Kaydet";
            this.tahlil_kaydet_btn.UseVisualStyleBackColor = true;
            this.tahlil_kaydet_btn.Click += new System.EventHandler(this.tahlil_kaydet_btn_Click);
            // 
            // tahlil_sonuc_txt
            // 
            this.tahlil_sonuc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahlil_sonuc_txt.Location = new System.Drawing.Point(18, 55);
            this.tahlil_sonuc_txt.Multiline = true;
            this.tahlil_sonuc_txt.Name = "tahlil_sonuc_txt";
            this.tahlil_sonuc_txt.Size = new System.Drawing.Size(243, 101);
            this.tahlil_sonuc_txt.TabIndex = 0;
            // 
            // laborant_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(791, 485);
            this.Controls.Add(this.tahlil_sonuc_panel);
            this.Controls.Add(this.tahlil_list_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "laborant_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laborant_form";
            this.Load += new System.EventHandler(this.laborant_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tahlil_list_panel.ResumeLayout(false);
            this.tahlil_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tahlil_liste_dgv)).EndInit();
            this.tahlil_sonuc_panel.ResumeLayout(false);
            this.tahlil_sonuc_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel tahlil_list_panel;
        private System.Windows.Forms.Label lbl_tahlil_liste;
        private System.Windows.Forms.DataGridView tahlil_liste_dgv;
        private System.Windows.Forms.Panel tahlil_sonuc_panel;
        private System.Windows.Forms.TextBox tahlil_sonuc_txt;
        private System.Windows.Forms.Button tahlil_kaydet_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anamenu_hbilgi_btn;
        private System.Windows.Forms.DataGridViewImageColumn sonuc_gir;
    }
}