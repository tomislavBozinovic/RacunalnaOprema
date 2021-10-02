
namespace TrgovinaRacunalaWFA
{
    partial class Stavka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProizvodi = new System.Windows.Forms.ComboBox();
            this.cbKolicina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.txtRacunId = new System.Windows.Forms.TextBox();
            this.RacunID = new System.Windows.Forms.Label();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPrikaziStavkeRacuna = new System.Windows.Forms.Button();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAVKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Proizvod";
            // 
            // cbProizvodi
            // 
            this.cbProizvodi.FormattingEnabled = true;
            this.cbProizvodi.Location = new System.Drawing.Point(83, 152);
            this.cbProizvodi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProizvodi.Name = "cbProizvodi";
            this.cbProizvodi.Size = new System.Drawing.Size(262, 21);
            this.cbProizvodi.TabIndex = 2;
            // 
            // cbKolicina
            // 
            this.cbKolicina.FormattingEnabled = true;
            this.cbKolicina.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbKolicina.Location = new System.Drawing.Point(83, 189);
            this.cbKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKolicina.Name = "cbKolicina";
            this.cbKolicina.Size = new System.Drawing.Size(81, 21);
            this.cbKolicina.TabIndex = 3;
            this.cbKolicina.SelectedIndexChanged += new System.EventHandler(this.cbKolicina_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kolicina";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(83, 225);
            this.txtUkupnaCijena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(262, 20);
            this.txtUkupnaCijena.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kategorija";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(83, 111);
            this.cbKategorija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(262, 21);
            this.cbKategorija.TabIndex = 8;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // txtRacunId
            // 
            this.txtRacunId.Location = new System.Drawing.Point(83, 76);
            this.txtRacunId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRacunId.Name = "txtRacunId";
            this.txtRacunId.Size = new System.Drawing.Size(81, 20);
            this.txtRacunId.TabIndex = 9;
            // 
            // RacunID
            // 
            this.RacunID.AutoSize = true;
            this.RacunID.Location = new System.Drawing.Point(20, 78);
            this.RacunID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RacunID.Name = "RacunID";
            this.RacunID.Size = new System.Drawing.Size(50, 13);
            this.RacunID.TabIndex = 10;
            this.RacunID.Text = "RacunID";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(9, 267);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(111, 36);
            this.btnDodajStavku.TabIndex = 11;
            this.btnDodajStavku.Text = "Dodaj Stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(659, 267);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(140, 36);
            this.btnIzlaz.TabIndex = 12;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPrikaziStavkeRacuna
            // 
            this.btnPrikaziStavkeRacuna.Location = new System.Drawing.Point(131, 267);
            this.btnPrikaziStavkeRacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrikaziStavkeRacuna.Name = "btnPrikaziStavkeRacuna";
            this.btnPrikaziStavkeRacuna.Size = new System.Drawing.Size(111, 36);
            this.btnPrikaziStavkeRacuna.TabIndex = 13;
            this.btnPrikaziStavkeRacuna.Text = "Prikazi Stavke Racuna";
            this.btnPrikaziStavkeRacuna.UseVisualStyleBackColor = true;
            this.btnPrikaziStavkeRacuna.Click += new System.EventHandler(this.btnPrikaziStavkeRacuna_Click);
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeRacuna.BackgroundColor = System.Drawing.Color.White;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(359, 10);
            this.dgvStavkeRacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.RowHeadersWidth = 51;
            this.dgvStavkeRacuna.RowTemplate.Height = 24;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(441, 253);
            this.dgvStavkeRacuna.TabIndex = 14;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(247, 267);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(111, 35);
            this.btnPdf.TabIndex = 15;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Stavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 314);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.btnPrikaziStavkeRacuna);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.RacunID);
            this.Controls.Add(this.txtRacunId);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKolicina);
            this.Controls.Add(this.cbProizvodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stavka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavka";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProizvodi;
        private System.Windows.Forms.ComboBox cbKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.TextBox txtRacunId;
        private System.Windows.Forms.Label RacunID;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPrikaziStavkeRacuna;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Button btnPdf;
    }
}