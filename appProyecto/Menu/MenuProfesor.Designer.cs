namespace appProyecto
{
    partial class MenuProfesor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.butEnviarCorreo = new System.Windows.Forms.Button();
            this.dtgAsistencia = new System.Windows.Forms.DataGridView();
            this.IDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qrr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butNota = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butRefrescar = new System.Windows.Forms.Button();
            this.maskedNota3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedNota2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedNota1 = new System.Windows.Forms.MaskedTextBox();
            this.txtGrupoID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarNotas = new System.Windows.Forms.Button();
            this.dtgNotas = new System.Windows.Forms.DataGridView();
            this.dtgEstudiante = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsistencia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.Location = new System.Drawing.Point(141, 21);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(186, 33);
            this.btnAsistencias.TabIndex = 2;
            this.btnAsistencias.Text = "Buscar";
            this.btnAsistencias.UseVisualStyleBackColor = true;
            this.btnAsistencias.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // butEnviarCorreo
            // 
            this.butEnviarCorreo.Location = new System.Drawing.Point(141, 60);
            this.butEnviarCorreo.Name = "butEnviarCorreo";
            this.butEnviarCorreo.Size = new System.Drawing.Size(186, 30);
            this.butEnviarCorreo.TabIndex = 3;
            this.butEnviarCorreo.Text = "Enviar Correo";
            this.butEnviarCorreo.UseVisualStyleBackColor = true;
            this.butEnviarCorreo.Click += new System.EventHandler(this.butEnviarCorreo_Click);
            // 
            // dtgAsistencia
            // 
            this.dtgAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDa,
            this.Nombre,
            this.TipoUsuario,
            this.Nivel,
            this.Genero1,
            this.Fecha,
            this.Correo,
            this.Telefono,
            this.Contra,
            this.Estadoo,
            this.qrr});
            this.dtgAsistencia.Location = new System.Drawing.Point(21, 143);
            this.dtgAsistencia.MultiSelect = false;
            this.dtgAsistencia.Name = "dtgAsistencia";
            this.dtgAsistencia.ReadOnly = true;
            this.dtgAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAsistencia.Size = new System.Drawing.Size(587, 150);
            this.dtgAsistencia.TabIndex = 3;
            // 
            // IDa
            // 
            this.IDa.DataPropertyName = "ID";
            this.IDa.HeaderText = "Identificacion";
            this.IDa.Name = "IDa";
            this.IDa.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCompleto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.DataPropertyName = "IDTipoUsuario";
            this.TipoUsuario.HeaderText = "TipoUsuario";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            this.TipoUsuario.Visible = false;
            // 
            // Nivel
            // 
            this.Nivel.DataPropertyName = "IDNivel";
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            this.Nivel.Visible = false;
            // 
            // Genero1
            // 
            this.Genero1.DataPropertyName = "Genero";
            this.Genero1.HeaderText = "Genero1";
            this.Genero1.Name = "Genero1";
            this.Genero1.ReadOnly = true;
            this.Genero1.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaNacimiento";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoPadre";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TelefonoPadre";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Contra
            // 
            this.Contra.DataPropertyName = "Contraseña";
            this.Contra.HeaderText = "Contra";
            this.Contra.Name = "Contra";
            this.Contra.ReadOnly = true;
            this.Contra.Visible = false;
            // 
            // Estadoo
            // 
            this.Estadoo.DataPropertyName = "Estado";
            this.Estadoo.HeaderText = "Estadoo";
            this.Estadoo.Name = "Estadoo";
            this.Estadoo.ReadOnly = true;
            this.Estadoo.Visible = false;
            // 
            // qrr
            // 
            this.qrr.DataPropertyName = "QR";
            this.qrr.HeaderText = "qrr";
            this.qrr.Name = "qrr";
            this.qrr.ReadOnly = true;
            this.qrr.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnAsistencias);
            this.groupBox1.Controls.Add(this.butEnviarCorreo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo Grupo";
            // 
            // butNota
            // 
            this.butNota.Location = new System.Drawing.Point(157, 71);
            this.butNota.Name = "butNota";
            this.butNota.Size = new System.Drawing.Size(186, 33);
            this.butNota.TabIndex = 4;
            this.butNota.Text = "Nota";
            this.butNota.UseVisualStyleBackColor = true;
            this.butNota.Click += new System.EventHandler(this.butNota_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 527);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtgAsistencia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ausencias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgEstudiante);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dtgNotas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRefrescar);
            this.groupBox2.Controls.Add(this.maskedNota3);
            this.groupBox2.Controls.Add(this.maskedNota2);
            this.groupBox2.Controls.Add(this.maskedNota1);
            this.groupBox2.Controls.Add(this.txtGrupoID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscarNotas);
            this.groupBox2.Controls.Add(this.butNota);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 142);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codigo Grupo";
            // 
            // butRefrescar
            // 
            this.butRefrescar.Location = new System.Drawing.Point(22, 71);
            this.butRefrescar.Name = "butRefrescar";
            this.butRefrescar.Size = new System.Drawing.Size(100, 33);
            this.butRefrescar.TabIndex = 19;
            this.butRefrescar.Text = "Refrescar";
            this.butRefrescar.UseVisualStyleBackColor = true;
            this.butRefrescar.Click += new System.EventHandler(this.butRefrescar_Click);
            // 
            // maskedNota3
            // 
            this.maskedNota3.Location = new System.Drawing.Point(455, 99);
            this.maskedNota3.Mask = "999";
            this.maskedNota3.Name = "maskedNota3";
            this.maskedNota3.Size = new System.Drawing.Size(100, 24);
            this.maskedNota3.TabIndex = 18;
            this.maskedNota3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedNota2
            // 
            this.maskedNota2.Location = new System.Drawing.Point(455, 65);
            this.maskedNota2.Mask = "999";
            this.maskedNota2.Name = "maskedNota2";
            this.maskedNota2.Size = new System.Drawing.Size(100, 24);
            this.maskedNota2.TabIndex = 17;
            this.maskedNota2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedNota1
            // 
            this.maskedNota1.Location = new System.Drawing.Point(455, 32);
            this.maskedNota1.Mask = "000";
            this.maskedNota1.Name = "maskedNota1";
            this.maskedNota1.Size = new System.Drawing.Size(100, 24);
            this.maskedNota1.TabIndex = 16;
            this.maskedNota1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtGrupoID
            // 
            this.txtGrupoID.Location = new System.Drawing.Point(22, 36);
            this.txtGrupoID.Name = "txtGrupoID";
            this.txtGrupoID.Size = new System.Drawing.Size(100, 24);
            this.txtGrupoID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nota 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nota 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nota 1";
            // 
            // btnBuscarNotas
            // 
            this.btnBuscarNotas.Location = new System.Drawing.Point(157, 32);
            this.btnBuscarNotas.Name = "btnBuscarNotas";
            this.btnBuscarNotas.Size = new System.Drawing.Size(186, 33);
            this.btnBuscarNotas.TabIndex = 8;
            this.btnBuscarNotas.Text = "Buscar";
            this.btnBuscarNotas.UseVisualStyleBackColor = true;
            this.btnBuscarNotas.Click += new System.EventHandler(this.btnBuscarNotas_Click);
            // 
            // dtgNotas
            // 
            this.dtgNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTipoUsuario,
            this.IDProfesor,
            this.IDEstudiante,
            this.IDNivel,
            this.Genero,
            this.FechaNacimiento,
            this.CorreoPadre,
            this.TelefonoPadre,
            this.Contraseña,
            this.Estado,
            this.QR,
            this.Nota1,
            this.Nota2,
            this.Nota3});
            this.dtgNotas.Location = new System.Drawing.Point(23, 337);
            this.dtgNotas.Name = "dtgNotas";
            this.dtgNotas.ReadOnly = true;
            this.dtgNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNotas.Size = new System.Drawing.Size(583, 134);
            this.dtgNotas.TabIndex = 5;
            // 
            // dtgEstudiante
            // 
            this.dtgEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dtgEstudiante.Location = new System.Drawing.Point(23, 173);
            this.dtgEstudiante.MultiSelect = false;
            this.dtgEstudiante.Name = "dtgEstudiante";
            this.dtgEstudiante.ReadOnly = true;
            this.dtgEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstudiante.Size = new System.Drawing.Size(583, 134);
            this.dtgEstudiante.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreCompleto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDTipoUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDTipoUsuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDNivel";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDNivel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn5.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CorreoPadre";
            this.dataGridViewTextBoxColumn7.HeaderText = "CorreoPadre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TelefonoPadre";
            this.dataGridViewTextBoxColumn8.HeaderText = "TelefonoPadre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn9.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "QR";
            this.dataGridViewTextBoxColumn11.HeaderText = "QR";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // IDTipoUsuario
            // 
            this.IDTipoUsuario.DataPropertyName = "IDTipoUsuario";
            this.IDTipoUsuario.HeaderText = "IDTipoUsuario";
            this.IDTipoUsuario.Name = "IDTipoUsuario";
            this.IDTipoUsuario.Visible = false;
            // 
            // IDProfesor
            // 
            this.IDProfesor.DataPropertyName = "IDProfesor";
            this.IDProfesor.HeaderText = "IDProfesor";
            this.IDProfesor.Name = "IDProfesor";
            // 
            // IDEstudiante
            // 
            this.IDEstudiante.DataPropertyName = "IDEstudiante";
            this.IDEstudiante.HeaderText = "IDEstudiante";
            this.IDEstudiante.Name = "IDEstudiante";
            // 
            // IDNivel
            // 
            this.IDNivel.DataPropertyName = "IDNivel";
            this.IDNivel.HeaderText = "IDNivel";
            this.IDNivel.Name = "IDNivel";
            this.IDNivel.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.Visible = false;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Visible = false;
            // 
            // CorreoPadre
            // 
            this.CorreoPadre.DataPropertyName = "CorreoPadre";
            this.CorreoPadre.HeaderText = "CorreoPadre";
            this.CorreoPadre.Name = "CorreoPadre";
            this.CorreoPadre.Visible = false;
            // 
            // TelefonoPadre
            // 
            this.TelefonoPadre.DataPropertyName = "TelefonoPadre";
            this.TelefonoPadre.HeaderText = "TelefonoPadre";
            this.TelefonoPadre.Name = "TelefonoPadre";
            this.TelefonoPadre.Visible = false;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = false;
            // 
            // QR
            // 
            this.QR.DataPropertyName = "QR";
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.Visible = false;
            // 
            // Nota1
            // 
            this.Nota1.DataPropertyName = "Nota1";
            this.Nota1.HeaderText = "Nota1";
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.DataPropertyName = "Nota2";
            this.Nota2.HeaderText = "Nota2";
            this.Nota2.Name = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.DataPropertyName = "Nota3";
            this.Nota3.HeaderText = "Nota3";
            this.Nota3.Name = "Nota3";
            // 
            // MenuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 569);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.MenuProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsistencia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button butEnviarCorreo;
        private System.Windows.Forms.DataGridView dtgAsistencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butNota;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarNotas;
        private System.Windows.Forms.DataGridView dtgNotas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qrr;
        private System.Windows.Forms.MaskedTextBox maskedNota3;
        private System.Windows.Forms.MaskedTextBox maskedNota2;
        private System.Windows.Forms.MaskedTextBox maskedNota1;
        private System.Windows.Forms.Button butRefrescar;
        private System.Windows.Forms.DataGridView dtgEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn QR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
    }
}