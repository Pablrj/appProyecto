namespace appProyecto.Mantenimientos
{
    partial class frmBuscarMat
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstMat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(57, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 29);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstMat
            // 
            this.lstMat.BackColor = System.Drawing.SystemColors.Info;
            this.lstMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMat.FormattingEnabled = true;
            this.lstMat.ItemHeight = 16;
            this.lstMat.Location = new System.Drawing.Point(21, 12);
            this.lstMat.Name = "lstMat";
            this.lstMat.Size = new System.Drawing.Size(155, 180);
            this.lstMat.TabIndex = 4;
            // 
            // frmBuscarMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 249);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstMat);
            this.Name = "frmBuscarMat";
            this.Text = "frmBuscarMat";
            this.Load += new System.EventHandler(this.frmBuscarMat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstMat;
    }
}