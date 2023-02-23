namespace Programacion
{
    partial class FormularioDeRequisitos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblnacimiento = new System.Windows.Forms.Label();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblocupacion = new System.Windows.Forms.Label();
            this.lblescolaridad = new System.Windows.Forms.Label();
            this.lbleps = new System.Windows.Forms.Label();
            this.lblregimen = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblemergencia = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtocupacion = new System.Windows.Forms.TextBox();
            this.txtescolaridad = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbsubsidiado = new System.Windows.Forms.RadioButton();
            this.rbcontributivo = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nudnumero = new System.Windows.Forms.NumericUpDown();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.nudtelefono = new System.Windows.Forms.NumericUpDown();
            this.nudcontacto = new System.Windows.Forms.NumericUpDown();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.pctbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcontacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(254, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Requisitos Pacientes";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(21, 89);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(145, 15);
            this.lbltipo.TabIndex = 1;
            this.lbltipo.Text = "Tipo de Identificación";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre Completo";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(21, 122);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(148, 15);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero Identificación";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(21, 147);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(54, 15);
            this.lblgenero.TabIndex = 4;
            this.lblgenero.Text = "Género";
            // 
            // lblnacimiento
            // 
            this.lblnacimiento.AutoSize = true;
            this.lblnacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnacimiento.Location = new System.Drawing.Point(21, 178);
            this.lblnacimiento.Name = "lblnacimiento";
            this.lblnacimiento.Size = new System.Drawing.Size(143, 15);
            this.lblnacimiento.TabIndex = 5;
            this.lblnacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadocivil.Location = new System.Drawing.Point(21, 210);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(82, 15);
            this.lblestadocivil.TabIndex = 6;
            this.lblestadocivil.Text = "Estado Civil";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(21, 245);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(164, 15);
            this.lbldireccion.TabIndex = 7;
            this.lbldireccion.Text = "Dirección de Residencia";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.Location = new System.Drawing.Point(21, 281);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(148, 15);
            this.lblciudad.TabIndex = 8;
            this.lblciudad.Text = "Ciudad de Residencia";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(429, 52);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(123, 15);
            this.lbltelefono.TabIndex = 9;
            this.lbltelefono.Text = "Teléfono Contacto";
            // 
            // lblocupacion
            // 
            this.lblocupacion.AutoSize = true;
            this.lblocupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocupacion.Location = new System.Drawing.Point(429, 99);
            this.lblocupacion.Name = "lblocupacion";
            this.lblocupacion.Size = new System.Drawing.Size(75, 15);
            this.lblocupacion.TabIndex = 10;
            this.lblocupacion.Text = "Ocupación";
            // 
            // lblescolaridad
            // 
            this.lblescolaridad.AutoSize = true;
            this.lblescolaridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescolaridad.Location = new System.Drawing.Point(429, 147);
            this.lblescolaridad.Name = "lblescolaridad";
            this.lblescolaridad.Size = new System.Drawing.Size(119, 15);
            this.lblescolaridad.TabIndex = 11;
            this.lblescolaridad.Text = "Nivel Escolaridad";
            // 
            // lbleps
            // 
            this.lbleps.AutoSize = true;
            this.lbleps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleps.Location = new System.Drawing.Point(429, 178);
            this.lbleps.Name = "lbleps";
            this.lbleps.Size = new System.Drawing.Size(34, 15);
            this.lbleps.TabIndex = 12;
            this.lbleps.Text = "EPS";
            // 
            // lblregimen
            // 
            this.lblregimen.AutoSize = true;
            this.lblregimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregimen.Location = new System.Drawing.Point(429, 223);
            this.lblregimen.Name = "lblregimen";
            this.lblregimen.Size = new System.Drawing.Size(65, 15);
            this.lblregimen.TabIndex = 13;
            this.lblregimen.Text = "Régimen";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(429, 267);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(44, 15);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "Email";
            // 
            // lblemergencia
            // 
            this.lblemergencia.AutoSize = true;
            this.lblemergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemergencia.Location = new System.Drawing.Point(429, 311);
            this.lblemergencia.Name = "lblemergencia";
            this.lblemergencia.Size = new System.Drawing.Size(217, 15);
            this.lblemergencia.TabIndex = 15;
            this.lblemergencia.Text = "Contacto en caso de emergencia";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(190, 210);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 20);
            this.txtestado.TabIndex = 20;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(191, 281);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(100, 20);
            this.txtciudad.TabIndex = 21;
            // 
            // txtocupacion
            // 
            this.txtocupacion.Location = new System.Drawing.Point(606, 92);
            this.txtocupacion.Name = "txtocupacion";
            this.txtocupacion.Size = new System.Drawing.Size(100, 20);
            this.txtocupacion.TabIndex = 23;
            // 
            // txtescolaridad
            // 
            this.txtescolaridad.Location = new System.Drawing.Point(606, 140);
            this.txtescolaridad.Name = "txtescolaridad";
            this.txtescolaridad.Size = new System.Drawing.Size(100, 20);
            this.txtescolaridad.TabIndex = 24;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(606, 260);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 27;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(191, 240);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(99, 20);
            this.txtdireccion.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 20);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(149, 147);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(82, 17);
            this.rbMasculino.TabIndex = 31;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemenino.Location = new System.Drawing.Point(259, 147);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(79, 17);
            this.rbfemenino.TabIndex = 32;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbsubsidiado
            // 
            this.rbsubsidiado.AutoSize = true;
            this.rbsubsidiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsubsidiado.Location = new System.Drawing.Point(606, 219);
            this.rbsubsidiado.Name = "rbsubsidiado";
            this.rbsubsidiado.Size = new System.Drawing.Size(87, 17);
            this.rbsubsidiado.TabIndex = 33;
            this.rbsubsidiado.TabStop = true;
            this.rbsubsidiado.Text = "Subsidiado";
            this.rbsubsidiado.UseVisualStyleBackColor = true;
            // 
            // rbcontributivo
            // 
            this.rbcontributivo.AutoSize = true;
            this.rbcontributivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcontributivo.Location = new System.Drawing.Point(697, 219);
            this.rbcontributivo.Name = "rbcontributivo";
            this.rbcontributivo.Size = new System.Drawing.Size(93, 17);
            this.rbcontributivo.TabIndex = 34;
            this.rbcontributivo.TabStop = true;
            this.rbcontributivo.Text = "Contributivo";
            this.rbcontributivo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SURA",
            "NUEVA EPS",
            "SISBEN",
            "COOSALUD",
            "SAVIA SALUD",
            "OTRA"});
            this.comboBox1.Location = new System.Drawing.Point(606, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "RC",
            "TI",
            "CC",
            "CE"});
            this.comboBox2.Location = new System.Drawing.Point(191, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(56, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // nudnumero
            // 
            this.nudnumero.Location = new System.Drawing.Point(191, 115);
            this.nudnumero.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudnumero.MaximumSize = new System.Drawing.Size(100, 0);
            this.nudnumero.MinimumSize = new System.Drawing.Size(20, 0);
            this.nudnumero.Name = "nudnumero";
            this.nudnumero.Size = new System.Drawing.Size(100, 20);
            this.nudnumero.TabIndex = 38;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnregistrar.Location = new System.Drawing.Point(388, 383);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(116, 23);
            this.btnregistrar.TabIndex = 39;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncancelar.Location = new System.Drawing.Point(520, 383);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(116, 23);
            this.btncancelar.TabIndex = 40;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // nudtelefono
            // 
            this.nudtelefono.Location = new System.Drawing.Point(606, 50);
            this.nudtelefono.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudtelefono.Name = "nudtelefono";
            this.nudtelefono.Size = new System.Drawing.Size(120, 20);
            this.nudtelefono.TabIndex = 41;
            // 
            // nudcontacto
            // 
            this.nudcontacto.Location = new System.Drawing.Point(652, 311);
            this.nudcontacto.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudcontacto.Name = "nudcontacto";
            this.nudcontacto.Size = new System.Drawing.Size(120, 20);
            this.nudcontacto.TabIndex = 42;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(190, 177);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 43;
            // 
            // pctbLogo
            // 
            this.pctbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctbLogo.BackgroundImage = global::Programacion.Properties.Resources.seguro_de_salud__1_;
            this.pctbLogo.Location = new System.Drawing.Point(1, 322);
            this.pctbLogo.Name = "pctbLogo";
            this.pctbLogo.Size = new System.Drawing.Size(125, 128);
            this.pctbLogo.TabIndex = 56;
            this.pctbLogo.TabStop = false;
            // 
            // FormularioDeRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.pctbLogo);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.nudcontacto);
            this.Controls.Add(this.nudtelefono);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.nudnumero);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbcontributivo);
            this.Controls.Add(this.rbsubsidiado);
            this.Controls.Add(this.rbfemenino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtescolaridad);
            this.Controls.Add(this.txtocupacion);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblemergencia);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblregimen);
            this.Controls.Add(this.lbleps);
            this.Controls.Add(this.lblescolaridad);
            this.Controls.Add(this.lblocupacion);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblciudad);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblestadocivil);
            this.Controls.Add(this.lblnacimiento);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormularioDeRequisitos";
            this.Text = "Formulario de requisitos";
            ((System.ComponentModel.ISupportInitialize)(this.nudnumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcontacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblnacimiento;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblocupacion;
        private System.Windows.Forms.Label lblescolaridad;
        private System.Windows.Forms.Label lbleps;
        private System.Windows.Forms.Label lblregimen;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblemergencia;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtocupacion;
        private System.Windows.Forms.TextBox txtescolaridad;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbsubsidiado;
        private System.Windows.Forms.RadioButton rbcontributivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown nudnumero;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.NumericUpDown nudtelefono;
        private System.Windows.Forms.NumericUpDown nudcontacto;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.PictureBox pctbLogo;
    }
}

