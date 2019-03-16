namespace PANTALLASVENDEDORES
{
    partial class consultaCliente
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
            this.txtcodiconsucli.Location = new System.Drawing.Point(367, 24);
            this.txtcodiconsucli.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodiconsucli.Name = "txtcodiconsucli";
            this.txtcodiconsucli.Size = new System.Drawing.Size(86, 20);
            this.txtcodiconsucli.TabIndex = 0;
            this.txtcodiconsucli.TextChanged += new System.EventHandler(this.txtcodiconsucli_TextChanged);
            // 
            // lblcodigoconcli
            // 
            this.lblcodigoconcli.AutoSize = true;
            this.lblcodigoconcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoconcli.Location = new System.Drawing.Point(16, 30);
            this.lblcodigoconcli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodigoconcli.Name = "lblcodigoconcli";
            this.lblcodigoconcli.Size = new System.Drawing.Size(98, 15);
            this.lblcodigoconcli.TabIndex = 1;
            this.lblcodigoconcli.Text = "Id. de cliente: ";
            this.lblcodigoconcli.Click += new System.EventHandler(this.codigoconcli_Click);
            // 
            // lblnomconsu
            // 
            this.lblnomconsu.AutoSize = true;
            this.lblnomconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomconsu.Location = new System.Drawing.Point(16, 73);
            this.lblnomconsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnomconsu.Name = "lblnomconsu";
            this.lblnomconsu.Size = new System.Drawing.Size(66, 15);
            this.lblnomconsu.TabIndex = 2;
            this.lblnomconsu.Text = "Nombre: ";
            // 
            // lblapellconsu
            // 
            this.lblapellconsu.AutoSize = true;
            this.lblapellconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellconsu.Location = new System.Drawing.Point(212, 72);
            this.lblapellconsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblapellconsu.Name = "lblapellconsu";
            this.lblapellconsu.Size = new System.Drawing.Size(63, 15);
            this.lblapellconsu.TabIndex = 3;
            this.lblapellconsu.Text = "Apellido:";
            // 
            // lblestadoconsu
            // 
            this.lblestadoconsu.AutoSize = true;
            this.lblestadoconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoconsu.Location = new System.Drawing.Point(230, 30);
            this.lblestadoconsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblestadoconsu.Name = "lblestadoconsu";
            this.lblestadoconsu.Size = new System.Drawing.Size(133, 15);
            this.lblestadoconsu.TabIndex = 4;
            this.lblestadoconsu.Text = "Estado de proyecto:";
            // 
            // cmbnombrecon
            // 
            this.cmbnombrecon.FormattingEnabled = true;
            this.cmbnombrecon.Location = new System.Drawing.Point(80, 72);
            this.cmbnombrecon.Margin = new System.Windows.Forms.Padding(2);
            this.cmbnombrecon.Name = "cmbnombrecon";
            this.cmbnombrecon.Size = new System.Drawing.Size(116, 21);
            this.cmbnombrecon.TabIndex = 5;
            // 
            // cmbapellconsu
            // 
            this.cmbapellconsu.FormattingEnabled = true;
            this.cmbapellconsu.Location = new System.Drawing.Point(279, 72);
            this.cmbapellconsu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbapellconsu.Name = "cmbapellconsu";
            this.cmbapellconsu.Size = new System.Drawing.Size(167, 21);
            this.cmbapellconsu.TabIndex = 6;
            // 
            // cmbestadoconsu
            // 
            this.cmbestadoconsu.FormattingEnabled = true;
            this.cmbestadoconsu.Items.AddRange(new object[] {
            "En construcción",
            "Terminado"});
            this.cmbestadoconsu.Location = new System.Drawing.Point(118, 24);
            this.cmbestadoconsu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbestadoconsu.Name = "cmbestadoconsu";
            this.cmbestadoconsu.Size = new System.Drawing.Size(108, 21);
            this.cmbestadoconsu.TabIndex = 7;
            this.cmbestadoconsu.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dtvcliconsu
            // 
            this.dtvcliconsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvcliconsu.Location = new System.Drawing.Point(19, 158);
            this.dtvcliconsu.Margin = new System.Windows.Forms.Padding(2);
            this.dtvcliconsu.Name = "dtvcliconsu";
            this.dtvcliconsu.RowTemplate.Height = 24;
            this.dtvcliconsu.Size = new System.Drawing.Size(556, 59);
            this.dtvcliconsu.TabIndex = 8;
            // 
            // btncliconsu
            // 
            this.btncliconsu.BackColor = System.Drawing.Color.Maroon;
            this.btncliconsu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncliconsu.Location = new System.Drawing.Point(481, 51);
            this.btncliconsu.Margin = new System.Windows.Forms.Padding(2);
            this.btncliconsu.Name = "btncliconsu";
            this.btncliconsu.Size = new System.Drawing.Size(86, 36);
            this.btncliconsu.TabIndex = 9;
            this.btncliconsu.Text = "Consultar";
            this.btncliconsu.UseVisualStyleBackColor = false;
            // 
            // lbltituconsu
            // 
            this.lbltituconsu.AutoSize = true;
            this.lbltituconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituconsu.ForeColor = System.Drawing.Color.Maroon;
            this.lbltituconsu.Location = new System.Drawing.Point(23, 124);
            this.lbltituconsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltituconsu.Name = "lbltituconsu";
            this.lbltituconsu.Size = new System.Drawing.Size(361, 18);
            this.lbltituconsu.TabIndex = 10;
            this.lbltituconsu.Text = "INFORMACIÓN DE CLIENTE SELECCIONADO";
            // 
            // consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 267);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "consultaCliente";
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