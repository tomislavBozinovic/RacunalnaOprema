
namespace TrgovinaRacunalaWFA
{
    partial class Partneri
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
            this.dgvPartneri = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSvePartnere = new System.Windows.Forms.Button();
            this.btnPretraziPartnera = new System.Windows.Forms.Button();
            this.btnIzbrisiPartnera = new System.Windows.Forms.Button();
            this.txtIdPretragaPartnera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImePartnera = new System.Windows.Forms.TextBox();
            this.txtPopustPartnera = new System.Windows.Forms.TextBox();
            this.btnDodajPartnera = new System.Windows.Forms.Button();
            this.btnPromijeniPodatke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartneri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARTNERI";
            // 
            // dgvPartneri
            // 
            this.dgvPartneri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartneri.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartneri.Location = new System.Drawing.Point(12, 187);
            this.dgvPartneri.Name = "dgvPartneri";
            this.dgvPartneri.RowHeadersWidth = 51;
            this.dgvPartneri.RowTemplate.Height = 24;
            this.dgvPartneri.Size = new System.Drawing.Size(440, 251);
            this.dgvPartneri.TabIndex = 1;
            this.dgvPartneri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPartneri_MouseClick);
            // 
            // btnPrikaziSvePartnere
            // 
            this.btnPrikaziSvePartnere.Location = new System.Drawing.Point(118, 134);
            this.btnPrikaziSvePartnere.Name = "btnPrikaziSvePartnere";
            this.btnPrikaziSvePartnere.Size = new System.Drawing.Size(224, 47);
            this.btnPrikaziSvePartnere.TabIndex = 2;
            this.btnPrikaziSvePartnere.Text = "Prikazi Sve";
            this.btnPrikaziSvePartnere.UseVisualStyleBackColor = true;
            this.btnPrikaziSvePartnere.Click += new System.EventHandler(this.btnPrikaziSvePartnere_Click);
            // 
            // btnPretraziPartnera
            // 
            this.btnPretraziPartnera.Location = new System.Drawing.Point(599, 147);
            this.btnPretraziPartnera.Name = "btnPretraziPartnera";
            this.btnPretraziPartnera.Size = new System.Drawing.Size(150, 47);
            this.btnPretraziPartnera.TabIndex = 3;
            this.btnPretraziPartnera.Text = "Pretrazi Partnera";
            this.btnPretraziPartnera.UseVisualStyleBackColor = true;
            this.btnPretraziPartnera.Click += new System.EventHandler(this.btnPretraziPartnera_Click);
            // 
            // btnIzbrisiPartnera
            // 
            this.btnIzbrisiPartnera.Location = new System.Drawing.Point(764, 147);
            this.btnIzbrisiPartnera.Name = "btnIzbrisiPartnera";
            this.btnIzbrisiPartnera.Size = new System.Drawing.Size(150, 47);
            this.btnIzbrisiPartnera.TabIndex = 4;
            this.btnIzbrisiPartnera.Text = "Izbrisi Partnera";
            this.btnIzbrisiPartnera.UseVisualStyleBackColor = true;
            this.btnIzbrisiPartnera.Click += new System.EventHandler(this.btnIzbrisiPartnera_Click);
            // 
            // txtIdPretragaPartnera
            // 
            this.txtIdPretragaPartnera.Location = new System.Drawing.Point(482, 172);
            this.txtIdPretragaPartnera.Name = "txtIdPretragaPartnera";
            this.txtIdPretragaPartnera.Size = new System.Drawing.Size(111, 22);
            this.txtIdPretragaPartnera.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime Partnera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Popust";
            // 
            // txtImePartnera
            // 
            this.txtImePartnera.Location = new System.Drawing.Point(634, 246);
            this.txtImePartnera.Name = "txtImePartnera";
            this.txtImePartnera.Size = new System.Drawing.Size(249, 22);
            this.txtImePartnera.TabIndex = 7;
            // 
            // txtPopustPartnera
            // 
            this.txtPopustPartnera.Location = new System.Drawing.Point(634, 290);
            this.txtPopustPartnera.Name = "txtPopustPartnera";
            this.txtPopustPartnera.Size = new System.Drawing.Size(249, 22);
            this.txtPopustPartnera.TabIndex = 7;
            // 
            // btnDodajPartnera
            // 
            this.btnDodajPartnera.Location = new System.Drawing.Point(482, 381);
            this.btnDodajPartnera.Name = "btnDodajPartnera";
            this.btnDodajPartnera.Size = new System.Drawing.Size(207, 57);
            this.btnDodajPartnera.TabIndex = 8;
            this.btnDodajPartnera.Text = "Dodaj Partnera";
            this.btnDodajPartnera.UseVisualStyleBackColor = true;
            this.btnDodajPartnera.Click += new System.EventHandler(this.btnDodajPartnera_Click);
            // 
            // btnPromijeniPodatke
            // 
            this.btnPromijeniPodatke.Location = new System.Drawing.Point(703, 381);
            this.btnPromijeniPodatke.Name = "btnPromijeniPodatke";
            this.btnPromijeniPodatke.Size = new System.Drawing.Size(207, 57);
            this.btnPromijeniPodatke.TabIndex = 8;
            this.btnPromijeniPodatke.Text = "Promijeni Podatke";
            this.btnPromijeniPodatke.UseVisualStyleBackColor = true;
            this.btnPromijeniPodatke.Click += new System.EventHandler(this.btnPromijeniPodatke_Click);
            // 
            // Partneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 478);
            this.Controls.Add(this.btnPromijeniPodatke);
            this.Controls.Add(this.btnDodajPartnera);
            this.Controls.Add(this.txtPopustPartnera);
            this.Controls.Add(this.txtImePartnera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPretragaPartnera);
            this.Controls.Add(this.btnIzbrisiPartnera);
            this.Controls.Add(this.btnPretraziPartnera);
            this.Controls.Add(this.btnPrikaziSvePartnere);
            this.Controls.Add(this.dgvPartneri);
            this.Controls.Add(this.label1);
            this.Name = "Partneri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partneri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartneri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPartneri;
        private System.Windows.Forms.Button btnPrikaziSvePartnere;
        private System.Windows.Forms.Button btnPretraziPartnera;
        private System.Windows.Forms.Button btnIzbrisiPartnera;
        private System.Windows.Forms.TextBox txtIdPretragaPartnera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImePartnera;
        private System.Windows.Forms.TextBox txtPopustPartnera;
        private System.Windows.Forms.Button btnDodajPartnera;
        private System.Windows.Forms.Button btnPromijeniPodatke;
    }
}