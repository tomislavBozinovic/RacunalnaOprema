
namespace TrgovinaRacunalaWFA
{
    partial class Racun
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
            this.cbPartneri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartnerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremiRacun = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.btnStavkeRacuna = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtRacunId = new System.Windows.Forms.TextBox();
            this.btnPrikaziSveRacune = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRacunPretragaId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPretraziRacun = new System.Windows.Forms.Button();
            this.btnIzbrisiRacun = new System.Windows.Forms.Button();
            this.btnPromijeniPodatke = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPartnerPopust = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrojRacunaPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraziBroj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPartneri
            // 
            this.cbPartneri.FormattingEnabled = true;
            this.cbPartneri.Location = new System.Drawing.Point(854, 64);
            this.cbPartneri.Name = "cbPartneri";
            this.cbPartneri.Size = new System.Drawing.Size(169, 24);
            this.cbPartneri.TabIndex = 0;
            this.cbPartneri.SelectedIndexChanged += new System.EventHandler(this.cbPartneri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "RACUN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberi Partnera";
            // 
            // txtPartnerId
            // 
            this.txtPartnerId.Location = new System.Drawing.Point(854, 109);
            this.txtPartnerId.Name = "txtPartnerId";
            this.txtPartnerId.Size = new System.Drawing.Size(169, 22);
            this.txtPartnerId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Partner ID";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(855, 200);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.Size = new System.Drawing.Size(169, 22);
            this.txtBrojRacuna.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj Racuna";
            // 
            // btnSpremiRacun
            // 
            this.btnSpremiRacun.Location = new System.Drawing.Point(646, 306);
            this.btnSpremiRacun.Name = "btnSpremiRacun";
            this.btnSpremiRacun.Size = new System.Drawing.Size(186, 73);
            this.btnSpremiRacun.TabIndex = 7;
            this.btnSpremiRacun.Text = "Spremi Racun";
            this.btnSpremiRacun.UseVisualStyleBackColor = true;
            this.btnSpremiRacun.Click += new System.EventHandler(this.btnSpremiRacun_Click);
            // 
            // dgvRacun
            // 
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacun.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(12, 160);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.RowHeadersWidth = 51;
            this.dgvRacun.RowTemplate.Height = 24;
            this.dgvRacun.Size = new System.Drawing.Size(624, 301);
            this.dgvRacun.TabIndex = 8;
            this.dgvRacun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRacun_MouseClick);
            // 
            // btnStavkeRacuna
            // 
            this.btnStavkeRacuna.Location = new System.Drawing.Point(646, 385);
            this.btnStavkeRacuna.Name = "btnStavkeRacuna";
            this.btnStavkeRacuna.Size = new System.Drawing.Size(186, 73);
            this.btnStavkeRacuna.TabIndex = 9;
            this.btnStavkeRacuna.Text = "Stavke Racuna";
            this.btnStavkeRacuna.UseVisualStyleBackColor = true;
            this.btnStavkeRacuna.Click += new System.EventHandler(this.btnStavkeRacuna_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(800, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(855, 249);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(169, 22);
            this.txtDatum.TabIndex = 12;
            // 
            // txtRacunId
            // 
            this.txtRacunId.Location = new System.Drawing.Point(915, 24);
            this.txtRacunId.Name = "txtRacunId";
            this.txtRacunId.Size = new System.Drawing.Size(108, 22);
            this.txtRacunId.TabIndex = 13;
            // 
            // btnPrikaziSveRacune
            // 
            this.btnPrikaziSveRacune.Location = new System.Drawing.Point(12, 106);
            this.btnPrikaziSveRacune.Name = "btnPrikaziSveRacune";
            this.btnPrikaziSveRacune.Size = new System.Drawing.Size(127, 46);
            this.btnPrikaziSveRacune.TabIndex = 14;
            this.btnPrikaziSveRacune.Text = "Prikazi Sve Racune";
            this.btnPrikaziSveRacune.UseVisualStyleBackColor = true;
            this.btnPrikaziSveRacune.Click += new System.EventHandler(this.btnPrikaziSveRacune_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(831, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "RacunID";
            // 
            // txtRacunPretragaId
            // 
            this.txtRacunPretragaId.Location = new System.Drawing.Point(238, 129);
            this.txtRacunPretragaId.Name = "txtRacunPretragaId";
            this.txtRacunPretragaId.Size = new System.Drawing.Size(100, 22);
            this.txtRacunPretragaId.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID";
            // 
            // btnPretraziRacun
            // 
            this.btnPretraziRacun.Location = new System.Drawing.Point(344, 106);
            this.btnPretraziRacun.Name = "btnPretraziRacun";
            this.btnPretraziRacun.Size = new System.Drawing.Size(143, 45);
            this.btnPretraziRacun.TabIndex = 18;
            this.btnPretraziRacun.Text = "Pretrazi Racun";
            this.btnPretraziRacun.UseVisualStyleBackColor = true;
            this.btnPretraziRacun.Click += new System.EventHandler(this.btnPretraziRacun_Click);
            // 
            // btnIzbrisiRacun
            // 
            this.btnIzbrisiRacun.Location = new System.Drawing.Point(493, 106);
            this.btnIzbrisiRacun.Name = "btnIzbrisiRacun";
            this.btnIzbrisiRacun.Size = new System.Drawing.Size(143, 45);
            this.btnIzbrisiRacun.TabIndex = 19;
            this.btnIzbrisiRacun.Text = "Izbrisi Racun";
            this.btnIzbrisiRacun.UseVisualStyleBackColor = true;
            this.btnIzbrisiRacun.Click += new System.EventHandler(this.btnIzbrisiRacun_Click);
            // 
            // btnPromijeniPodatke
            // 
            this.btnPromijeniPodatke.Location = new System.Drawing.Point(838, 306);
            this.btnPromijeniPodatke.Name = "btnPromijeniPodatke";
            this.btnPromijeniPodatke.Size = new System.Drawing.Size(186, 73);
            this.btnPromijeniPodatke.TabIndex = 20;
            this.btnPromijeniPodatke.Text = "Promijeni Podatke";
            this.btnPromijeniPodatke.UseVisualStyleBackColor = true;
            this.btnPromijeniPodatke.Click += new System.EventHandler(this.btnPromijeniPodatke_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(745, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Partner Popust";
            // 
            // txtPartnerPopust
            // 
            this.txtPartnerPopust.Location = new System.Drawing.Point(854, 155);
            this.txtPartnerPopust.Name = "txtPartnerPopust";
            this.txtPartnerPopust.Size = new System.Drawing.Size(125, 22);
            this.txtPartnerPopust.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(985, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "%";
            // 
            // txtBrojRacunaPretraga
            // 
            this.txtBrojRacunaPretraga.Location = new System.Drawing.Point(238, 66);
            this.txtBrojRacunaPretraga.Name = "txtBrojRacunaPretraga";
            this.txtBrojRacunaPretraga.Size = new System.Drawing.Size(100, 22);
            this.txtBrojRacunaPretraga.TabIndex = 24;
            // 
            // btnPretraziBroj
            // 
            this.btnPretraziBroj.Location = new System.Drawing.Point(353, 61);
            this.btnPretraziBroj.Name = "btnPretraziBroj";
            this.btnPretraziBroj.Size = new System.Drawing.Size(85, 27);
            this.btnPretraziBroj.TabIndex = 25;
            this.btnPretraziBroj.Text = "Broj Racuna Pretraga";
            this.btnPretraziBroj.UseVisualStyleBackColor = true;
            this.btnPretraziBroj.Click += new System.EventHandler(this.btnPretraziBroj_Click);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 476);
            this.Controls.Add(this.btnPretraziBroj);
            this.Controls.Add(this.txtBrojRacunaPretraga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPartnerPopust);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPromijeniPodatke);
            this.Controls.Add(this.btnIzbrisiRacun);
            this.Controls.Add(this.btnPretraziRacun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRacunPretragaId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrikaziSveRacune);
            this.Controls.Add(this.txtRacunId);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStavkeRacuna);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnSpremiRacun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartnerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPartneri);
            this.Name = "Racun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racun";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPartneri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartnerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremiRacun;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Button btnStavkeRacuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnPrikaziSveRacune;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtRacunId;
        private System.Windows.Forms.TextBox txtRacunPretragaId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPretraziRacun;
        private System.Windows.Forms.Button btnIzbrisiRacun;
        private System.Windows.Forms.Button btnPromijeniPodatke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartnerPopust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrojRacunaPretraga;
        private System.Windows.Forms.Button btnPretraziBroj;
    }
}