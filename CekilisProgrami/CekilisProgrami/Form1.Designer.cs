namespace CekilisProgrami
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxbListe = new System.Windows.Forms.RichTextBox();
            this.lblCekilisListesi = new System.Windows.Forms.Label();
            this.lblSart = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btnCekilis = new System.Windows.Forms.Button();
            this.btnYeniCekilis = new System.Windows.Forms.Button();
            this.nbxSayi = new System.Windows.Forms.NumericUpDown();
            this.lblKatilan = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxbListe
            // 
            this.rtxbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxbListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtxbListe.Location = new System.Drawing.Point(379, 96);
            this.rtxbListe.Name = "rtxbListe";
            this.rtxbListe.Size = new System.Drawing.Size(360, 377);
            this.rtxbListe.TabIndex = 1;
            this.rtxbListe.Text = "";
            this.rtxbListe.TextChanged += new System.EventHandler(this.rtxbListe_TextChanged);
            // 
            // lblCekilisListesi
            // 
            this.lblCekilisListesi.AutoSize = true;
            this.lblCekilisListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilisListesi.ForeColor = System.Drawing.Color.White;
            this.lblCekilisListesi.Location = new System.Drawing.Point(374, 23);
            this.lblCekilisListesi.Name = "lblCekilisListesi";
            this.lblCekilisListesi.Size = new System.Drawing.Size(176, 29);
            this.lblCekilisListesi.TabIndex = 2;
            this.lblCekilisListesi.Text = "Çekiliş Listesi";
            // 
            // lblSart
            // 
            this.lblSart.AutoSize = true;
            this.lblSart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSart.ForeColor = System.Drawing.Color.White;
            this.lblSart.Location = new System.Drawing.Point(375, 66);
            this.lblSart.Name = "lblSart";
            this.lblSart.Size = new System.Drawing.Size(350, 24);
            this.lblSart.TabIndex = 3;
            this.lblSart.Text = "Her Satıra Bir İsim Gelecek Şekilde Yazın";
            // 
            // dgvListe
            // 
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(13, 96);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 47;
            this.dgvListe.Size = new System.Drawing.Size(361, 377);
            this.dgvListe.TabIndex = 4;
            // 
            // btnCekilis
            // 
            this.btnCekilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilis.ForeColor = System.Drawing.Color.Maroon;
            this.btnCekilis.Location = new System.Drawing.Point(115, 66);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(118, 25);
            this.btnCekilis.TabIndex = 6;
            this.btnCekilis.Text = "Çekilişi Başlat";
            this.btnCekilis.UseVisualStyleBackColor = true;
            this.btnCekilis.Click += new System.EventHandler(this.btnCekilis_Click);
            // 
            // btnYeniCekilis
            // 
            this.btnYeniCekilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniCekilis.ForeColor = System.Drawing.Color.Maroon;
            this.btnYeniCekilis.Location = new System.Drawing.Point(239, 66);
            this.btnYeniCekilis.Name = "btnYeniCekilis";
            this.btnYeniCekilis.Size = new System.Drawing.Size(134, 25);
            this.btnYeniCekilis.TabIndex = 7;
            this.btnYeniCekilis.Text = "Yeni Çekiliş";
            this.btnYeniCekilis.UseVisualStyleBackColor = true;
            this.btnYeniCekilis.Click += new System.EventHandler(this.btnYeniCekilis_Click);
            // 
            // nbxSayi
            // 
            this.nbxSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nbxSayi.ForeColor = System.Drawing.Color.Maroon;
            this.nbxSayi.Location = new System.Drawing.Point(13, 67);
            this.nbxSayi.Name = "nbxSayi";
            this.nbxSayi.Size = new System.Drawing.Size(96, 23);
            this.nbxSayi.TabIndex = 8;
            this.nbxSayi.ValueChanged += new System.EventHandler(this.nbxSayi_ValueChanged);
            // 
            // lblKatilan
            // 
            this.lblKatilan.AutoSize = true;
            this.lblKatilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKatilan.ForeColor = System.Drawing.Color.White;
            this.lblKatilan.Location = new System.Drawing.Point(8, 9);
            this.lblKatilan.Name = "lblKatilan";
            this.lblKatilan.Size = new System.Drawing.Size(156, 25);
            this.lblKatilan.TabIndex = 9;
            this.lblKatilan.Text = "Katılan Sayısı";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.ForeColor = System.Drawing.Color.White;
            this.lblSayi.Location = new System.Drawing.Point(185, 9);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(25, 25);
            this.lblSayi.TabIndex = 10;
            this.lblSayi.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(516, 495);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(223, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/onurgoz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(751, 524);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblKatilan);
            this.Controls.Add(this.nbxSayi);
            this.Controls.Add(this.btnYeniCekilis);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.lblSart);
            this.Controls.Add(this.lblCekilisListesi);
            this.Controls.Add(this.rtxbListe);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Çekiliş Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxbListe;
        private System.Windows.Forms.Label lblCekilisListesi;
        private System.Windows.Forms.Label lblSart;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Button btnYeniCekilis;
        private System.Windows.Forms.NumericUpDown nbxSayi;
        private System.Windows.Forms.Label lblKatilan;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

