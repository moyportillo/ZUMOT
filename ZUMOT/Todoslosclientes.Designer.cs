namespace PANTALLASVENDEDORES
{
    partial class Todoslosclientes
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
            this.lbltitutodocli = new System.Windows.Forms.Label();
            this.dgvtodocli = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodocli)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitutodocli
            // 
            this.lbltitutodocli.AutoSize = true;
            this.lbltitutodocli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitutodocli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitutodocli.Location = new System.Drawing.Point(35, 31);
            this.lbltitutodocli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitutodocli.Name = "lbltitutodocli";
            this.lbltitutodocli.Size = new System.Drawing.Size(305, 26);
            this.lbltitutodocli.TabIndex = 0;
            this.lbltitutodocli.Text = "CLIENTES REGISTRADOS";
            // 
            // dgvtodocli
            // 
            this.dgvtodocli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtodocli.Location = new System.Drawing.Point(32, 77);
            this.dgvtodocli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvtodocli.Name = "dgvtodocli";
            this.dgvtodocli.RowTemplate.Height = 24;
            this.dgvtodocli.Size = new System.Drawing.Size(672, 221);
            this.dgvtodocli.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 120);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar nuevo cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Todoslosclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(911, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtodocli);
            this.Controls.Add(this.lbltitutodocli);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Todoslosclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de registros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodocli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitutodocli;
        private System.Windows.Forms.DataGridView dgvtodocli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}