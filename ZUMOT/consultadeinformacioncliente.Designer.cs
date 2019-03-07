namespace PANTALLASVENDEDORES
{
    partial class consultadeinformacioncliente
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
            this.txtcodiconsucli = new System.Windows.Forms.TextBox();
            this.lblcodigoconcli = new System.Windows.Forms.Label();
            this.lblnomconsu = new System.Windows.Forms.Label();
            this.lblapellconsu = new System.Windows.Forms.Label();
            this.lblestadoconsu = new System.Windows.Forms.Label();
            this.cmbnombrecon = new System.Windows.Forms.ComboBox();
            this.cmbapellconsu = new System.Windows.Forms.ComboBox();
            this.cmbestadoconsu = new System.Windows.Forms.ComboBox();
            this.dtvcliconsu = new System.Windows.Forms.DataGridView();
            this.btncliconsu = new System.Windows.Forms.Button();
            this.lbltituconsu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvcliconsu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodiconsucli
            // 
            this.txtcodiconsucli.Location = new System.Drawing.Point(141, 36);
            this.txtcodiconsucli.Name = "txtcodiconsucli";
            this.txtcodiconsucli.Size = new System.Drawing.Size(114, 22);
            this.txtcodiconsucli.TabIndex = 0;
            // 
            // lblcodigoconcli
            // 
            this.lblcodigoconcli.AutoSize = true;
            this.lblcodigoconcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoconcli.Location = new System.Drawing.Point(22, 37);
            this.lblcodigoconcli.Name = "lblcodigoconcli";
            this.lblcodigoconcli.Size = new System.Drawing.Size(113, 18);
            this.lblcodigoconcli.TabIndex = 1;
            this.lblcodigoconcli.Text = "Id. de cliente: ";
            this.lblcodigoconcli.Click += new System.EventHandler(this.codigoconcli_Click);
            // 
            // lblnomconsu
            // 
            this.lblnomconsu.AutoSize = true;
            this.lblnomconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomconsu.Location = new System.Drawing.Point(22, 90);
            this.lblnomconsu.Name = "lblnomconsu";
            this.lblnomconsu.Size = new System.Drawing.Size(78, 18);
            this.lblnomconsu.TabIndex = 2;
            this.lblnomconsu.Text = "Nombre: ";
            // 
            // lblapellconsu
            // 
            this.lblapellconsu.AutoSize = true;
            this.lblapellconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellconsu.Location = new System.Drawing.Point(282, 89);
            this.lblapellconsu.Name = "lblapellconsu";
            this.lblapellconsu.Size = new System.Drawing.Size(72, 18);
            this.lblapellconsu.TabIndex = 3;
            this.lblapellconsu.Text = "Apellido:";
            // 
            // lblestadoconsu
            // 
            this.lblestadoconsu.AutoSize = true;
            this.lblestadoconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoconsu.Location = new System.Drawing.Point(272, 38);
            this.lblestadoconsu.Name = "lblestadoconsu";
            this.lblestadoconsu.Size = new System.Drawing.Size(160, 18);
            this.lblestadoconsu.TabIndex = 4;
            this.lblestadoconsu.Text = "Estado de proyecto:";
            // 
            // cmbnombrecon
            // 
            this.cmbnombrecon.FormattingEnabled = true;
            this.cmbnombrecon.Location = new System.Drawing.Point(106, 89);
            this.cmbnombrecon.Name = "cmbnombrecon";
            this.cmbnombrecon.Size = new System.Drawing.Size(153, 24);
            this.cmbnombrecon.TabIndex = 5;
            // 
            // cmbapellconsu
            // 
            this.cmbapellconsu.FormattingEnabled = true;
            this.cmbapellconsu.Location = new System.Drawing.Point(360, 88);
            this.cmbapellconsu.Name = "cmbapellconsu";
            this.cmbapellconsu.Size = new System.Drawing.Size(221, 24);
            this.cmbapellconsu.TabIndex = 6;
            // 
            // cmbestadoconsu
            // 
            this.cmbestadoconsu.FormattingEnabled = true;
            this.cmbestadoconsu.Items.AddRange(new object[] {
            "En construcción",
            "Terminado"});
            this.cmbestadoconsu.Location = new System.Drawing.Point(438, 36);
            this.cmbestadoconsu.Name = "cmbestadoconsu";
            this.cmbestadoconsu.Size = new System.Drawing.Size(143, 24);
            this.cmbestadoconsu.TabIndex = 7;
            this.cmbestadoconsu.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dtvcliconsu
            // 
            this.dtvcliconsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvcliconsu.Location = new System.Drawing.Point(25, 195);
            this.dtvcliconsu.Name = "dtvcliconsu";
            this.dtvcliconsu.RowTemplate.Height = 24;
            this.dtvcliconsu.Size = new System.Drawing.Size(741, 73);
            this.dtvcliconsu.TabIndex = 8;
            // 
            // btncliconsu
            // 
            this.btncliconsu.BackColor = System.Drawing.Color.Maroon;
            this.btncliconsu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncliconsu.Location = new System.Drawing.Point(641, 63);
            this.btncliconsu.Name = "btncliconsu";
            this.btncliconsu.Size = new System.Drawing.Size(114, 44);
            this.btncliconsu.TabIndex = 9;
            this.btncliconsu.Text = "Consultar";
            this.btncliconsu.UseVisualStyleBackColor = false;
            // 
            // lbltituconsu
            // 
            this.lbltituconsu.AutoSize = true;
            this.lbltituconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituconsu.ForeColor = System.Drawing.Color.Maroon;
            this.lbltituconsu.Location = new System.Drawing.Point(31, 152);
            this.lbltituconsu.Name = "lbltituconsu";
            this.lbltituconsu.Size = new System.Drawing.Size(446, 24);
            this.lbltituconsu.TabIndex = 10;
            this.lbltituconsu.Text = "INFORMACIÓN DE CLIENTE SELECCIONADO";
            // 
            // consultadeinformacioncliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 329);
            this.Controls.Add(this.lbltituconsu);
            this.Controls.Add(this.btncliconsu);
            this.Controls.Add(this.dtvcliconsu);
            this.Controls.Add(this.cmbestadoconsu);
            this.Controls.Add(this.cmbapellconsu);
            this.Controls.Add(this.cmbnombrecon);
            this.Controls.Add(this.lblestadoconsu);
            this.Controls.Add(this.lblapellconsu);
            this.Controls.Add(this.lblnomconsu);
            this.Controls.Add(this.lblcodigoconcli);
            this.Controls.Add(this.txtcodiconsucli);
            this.Name = "consultadeinformacioncliente";
            this.Text = "Consulta por cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtvcliconsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodiconsucli;
        private System.Windows.Forms.Label lblcodigoconcli;
        private System.Windows.Forms.Label lblnomconsu;
        private System.Windows.Forms.Label lblapellconsu;
        private System.Windows.Forms.Label lblestadoconsu;
        private System.Windows.Forms.ComboBox cmbnombrecon;
        private System.Windows.Forms.ComboBox cmbapellconsu;
        private System.Windows.Forms.ComboBox cmbestadoconsu;
        private System.Windows.Forms.DataGridView dtvcliconsu;
        private System.Windows.Forms.Button btncliconsu;
        private System.Windows.Forms.Label lbltituconsu;
    }
}