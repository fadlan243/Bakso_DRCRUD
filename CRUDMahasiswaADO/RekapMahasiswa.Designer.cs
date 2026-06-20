namespace CRUDMahasiswaADO
{
    partial class RekapMahasiswa
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
            this.lblRekap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRekap
            // 
            this.lblRekap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRekap.Location = new System.Drawing.Point(255, 23);
            this.lblRekap.Name = "lblRekap";
            this.lblRekap.Size = new System.Drawing.Size(269, 39);
            this.lblRekap.TabIndex = 0;
            this.lblRekap.Text = "Rekap Data Mahasiswa";
            this.lblRekap.Click += new System.EventHandler(this.lblRekap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tahun Masuk";
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Location = new System.Drawing.Point(110, 75);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(121, 28);
            this.cmbProdi.TabIndex = 3;
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(400, 78);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalMasuk.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(645, 75);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 37);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(645, 492);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 38);
            this.btnCetak.TabIndex = 6;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(701, 311);
            this.dataGridView1.TabIndex = 7;
            // 
            // RekapMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRekap);
            this.Name = "RekapMahasiswa";
            this.Text = "RekapMahasiswa";
            this.Load += new System.EventHandler(this.RekapMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRekap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}