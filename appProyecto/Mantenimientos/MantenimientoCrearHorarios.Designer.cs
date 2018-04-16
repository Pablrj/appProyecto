namespace appProyecto.Mantenimientos
{
    partial class MantenimientoCrearHorarios
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.butCrearHorariosGrupos = new System.Windows.Forms.Button();
            this.listGrupos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(189, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Grupos";
            // 
            // butCrearHorariosGrupos
            // 
            this.butCrearHorariosGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCrearHorariosGrupos.Location = new System.Drawing.Point(274, 29);
            this.butCrearHorariosGrupos.Name = "butCrearHorariosGrupos";
            this.butCrearHorariosGrupos.Size = new System.Drawing.Size(202, 79);
            this.butCrearHorariosGrupos.TabIndex = 2;
            this.butCrearHorariosGrupos.Text = "Crear horarios Grupos";
            this.butCrearHorariosGrupos.UseVisualStyleBackColor = true;
            this.butCrearHorariosGrupos.Click += new System.EventHandler(this.butCrearHorariosGrupos_Click);
            // 
            // listGrupos
            // 
            this.listGrupos.FormattingEnabled = true;
            this.listGrupos.Location = new System.Drawing.Point(29, 137);
            this.listGrupos.Name = "listGrupos";
            this.listGrupos.Size = new System.Drawing.Size(447, 147);
            this.listGrupos.TabIndex = 3;
            // 
            // MantenimientoCrearHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 327);
            this.Controls.Add(this.listGrupos);
            this.Controls.Add(this.butCrearHorariosGrupos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "MantenimientoCrearHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoCrearHorarios";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCrearHorariosGrupos;
        private System.Windows.Forms.ListBox listGrupos;
    }
}