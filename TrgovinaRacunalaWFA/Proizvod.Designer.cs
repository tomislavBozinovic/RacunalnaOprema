
namespace TrgovinaRacunalaWFA
{
    partial class Proizvod
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSveProizvode = new System.Windows.Forms.Button();
            this.btnPretraziProizvod = new System.Windows.Forms.Button();
            this.btnIzbrisiProizvod = new System.Windows.Forms.Button();
            this.btnDodajNoviProizvod = new System.Windows.Forms.Button();
            this.btnPromijeniPodatkeProizvoda = new System.Windows.Forms.Button();
            this.txtProizvodNaziv = new System.Windows.Forms.TextBox();
            this.txtProizvodCijena = new System.Windows.Forms.TextBox();
            this.txtKategorijaID = new System.Windows.Forms.TextBox();
            this.txtIdPretragaProizvod = new System.Windows.Forms.TextBox();
            this.txtProizvodGarancija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.kategorijaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROIZVOD";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.BackgroundColor = System.Drawing.Color.White;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 170);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(643, 339);
            this.dgvProizvodi.TabIndex = 1;
            this.dgvProizvodi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvodi_MouseClick);
            // 
            // btnPrikaziSveProizvode
            // 
            this.btnPrikaziSveProizvode.Location = new System.Drawing.Point(12, 127);
            this.btnPrikaziSveProizvode.Name = "btnPrikaziSveProizvode";
            this.btnPrikaziSveProizvode.Size = new System.Drawing.Size(151, 37);
            this.btnPrikaziSveProizvode.TabIndex = 3;
            this.btnPrikaziSveProizvode.Text = "Prikazi Sve";
            this.btnPrikaziSveProizvode.UseVisualStyleBackColor = true;
            this.btnPrikaziSveProizvode.Click += new System.EventHandler(this.btnPrikaziSveProizvode_Click);
            // 
            // btnPretraziProizvod
            // 
            this.btnPretraziProizvod.Location = new System.Drawing.Point(355, 127);
            this.btnPretraziProizvod.Name = "btnPretraziProizvod";
            this.btnPretraziProizvod.Size = new System.Drawing.Size(147, 37);
            this.btnPretraziProizvod.TabIndex = 4;
            this.btnPretraziProizvod.Text = "Pretrazi Proizvod";
            this.btnPretraziProizvod.UseVisualStyleBackColor = true;
            this.btnPretraziProizvod.Click += new System.EventHandler(this.btnPretraziProizvod_Click);
            // 
            // btnIzbrisiProizvod
            // 
            this.btnIzbrisiProizvod.Location = new System.Drawing.Point(508, 127);
            this.btnIzbrisiProizvod.Name = "btnIzbrisiProizvod";
            this.btnIzbrisiProizvod.Size = new System.Drawing.Size(147, 37);
            this.btnIzbrisiProizvod.TabIndex = 5;
            this.btnIzbrisiProizvod.Text = "Izbrisi Proizvod";
            this.btnIzbrisiProizvod.UseVisualStyleBackColor = true;
            this.btnIzbrisiProizvod.Click += new System.EventHandler(this.btnIzbrisiProizvod_Click);
            // 
            // btnDodajNoviProizvod
            // 
            this.btnDodajNoviProizvod.Location = new System.Drawing.Point(710, 456);
            this.btnDodajNoviProizvod.Name = "btnDodajNoviProizvod";
            this.btnDodajNoviProizvod.Size = new System.Drawing.Size(172, 53);
            this.btnDodajNoviProizvod.TabIndex = 6;
            this.btnDodajNoviProizvod.Text = "Dodaj Novi Proizvod";
            this.btnDodajNoviProizvod.UseVisualStyleBackColor = true;
            this.btnDodajNoviProizvod.Click += new System.EventHandler(this.btnDodajNoviProizvod_Click);
            // 
            // btnPromijeniPodatkeProizvoda
            // 
            this.btnPromijeniPodatkeProizvoda.Location = new System.Drawing.Point(921, 456);
            this.btnPromijeniPodatkeProizvoda.Name = "btnPromijeniPodatkeProizvoda";
            this.btnPromijeniPodatkeProizvoda.Size = new System.Drawing.Size(172, 53);
            this.btnPromijeniPodatkeProizvoda.TabIndex = 7;
            this.btnPromijeniPodatkeProizvoda.Text = "Promijeni Podatke Proizvoda";
            this.btnPromijeniPodatkeProizvoda.UseVisualStyleBackColor = true;
            this.btnPromijeniPodatkeProizvoda.Click += new System.EventHandler(this.btnPromijeniPodatkeProizvoda_Click);
            // 
            // txtProizvodNaziv
            // 
            this.txtProizvodNaziv.Location = new System.Drawing.Point(842, 307);
            this.txtProizvodNaziv.Name = "txtProizvodNaziv";
            this.txtProizvodNaziv.Size = new System.Drawing.Size(285, 22);
            this.txtProizvodNaziv.TabIndex = 8;
            // 
            // txtProizvodCijena
            // 
            this.txtProizvodCijena.Location = new System.Drawing.Point(842, 351);
            this.txtProizvodCijena.Name = "txtProizvodCijena";
            this.txtProizvodCijena.Size = new System.Drawing.Size(285, 22);
            this.txtProizvodCijena.TabIndex = 9;
            // 
            // txtKategorijaID
            // 
            this.txtKategorijaID.Location = new System.Drawing.Point(842, 265);
            this.txtKategorijaID.Name = "txtKategorijaID";
            this.txtKategorijaID.Size = new System.Drawing.Size(285, 22);
            this.txtKategorijaID.TabIndex = 10;
            // 
            // txtIdPretragaProizvod
            // 
            this.txtIdPretragaProizvod.Location = new System.Drawing.Point(236, 134);
            this.txtIdPretragaProizvod.Name = "txtIdPretragaProizvod";
            this.txtIdPretragaProizvod.Size = new System.Drawing.Size(113, 22);
            this.txtIdPretragaProizvod.TabIndex = 11;
            // 
            // txtProizvodGarancija
            // 
            this.txtProizvodGarancija.Location = new System.Drawing.Point(842, 393);
            this.txtProizvodGarancija.Name = "txtProizvodGarancija";
            this.txtProizvodGarancija.Size = new System.Drawing.Size(285, 22);
            this.txtProizvodGarancija.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Proizvod Garancija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Proizvod Naziv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Proizvod Cijena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kategorija ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(842, 212);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(285, 24);
            this.cbKategorije.TabIndex = 19;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            // 
            // kategorijaModelBindingSource
            // 
            this.kategorijaModelBindingSource.DataSource = typeof(TrgovinaRacunalaWFA.Modeli.KategorijaModel);
            // 
            // Proizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 521);
            this.Controls.Add(this.cbKategorije);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProizvodGarancija);
            this.Controls.Add(this.txtIdPretragaProizvod);
            this.Controls.Add(this.txtKategorijaID);
            this.Controls.Add(this.txtProizvodCijena);
            this.Controls.Add(this.txtProizvodNaziv);
            this.Controls.Add(this.btnPromijeniPodatkeProizvoda);
            this.Controls.Add(this.btnDodajNoviProizvod);
            this.Controls.Add(this.btnIzbrisiProizvod);
            this.Controls.Add(this.btnPretraziProizvod);
            this.Controls.Add(this.btnPrikaziSveProizvode);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.label1);
            this.Name = "Proizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvod";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnPrikaziSveProizvode;
        private System.Windows.Forms.Button btnPretraziProizvod;
        private System.Windows.Forms.Button btnIzbrisiProizvod;
        private System.Windows.Forms.Button btnDodajNoviProizvod;
        private System.Windows.Forms.Button btnPromijeniPodatkeProizvoda;
        private System.Windows.Forms.TextBox txtProizvodNaziv;
        private System.Windows.Forms.TextBox txtProizvodCijena;
        private System.Windows.Forms.TextBox txtKategorijaID;
        private System.Windows.Forms.TextBox txtIdPretragaProizvod;
        private System.Windows.Forms.TextBox txtProizvodGarancija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource kategorijaModelBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKategorije;
    }
}