namespace Programacion
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.grpbInicio = new System.Windows.Forms.GroupBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUduario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pctbLogo = new System.Windows.Forms.PictureBox();
            this.grpbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbInicio
            // 
            this.grpbInicio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpbInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpbInicio.Controls.Add(this.btnVer);
            this.grpbInicio.Controls.Add(this.lblContraseña);
            this.grpbInicio.Controls.Add(this.lblUduario);
            this.grpbInicio.Controls.Add(this.txtUsuario);
            this.grpbInicio.Controls.Add(this.btnCerrar);
            this.grpbInicio.Controls.Add(this.txtContraseña);
            this.grpbInicio.Controls.Add(this.btnIngresar);
            this.grpbInicio.Location = new System.Drawing.Point(225, 145);
            this.grpbInicio.Name = "grpbInicio";
            this.grpbInicio.Size = new System.Drawing.Size(349, 231);
            this.grpbInicio.TabIndex = 5;
            this.grpbInicio.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(292, 77);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(28, 21);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "...";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(50, 78);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(80, 15);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUduario
            // 
            this.lblUduario.AutoSize = true;
            this.lblUduario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUduario.Location = new System.Drawing.Point(75, 50);
            this.lblUduario.Name = "lblUduario";
            this.lblUduario.Size = new System.Drawing.Size(57, 15);
            this.lblUduario.TabIndex = 4;
            this.lblUduario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(142, 49);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(120, 165);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Location = new System.Drawing.Point(142, 77);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(144, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(120, 124);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(97, 35);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pctbLogo
            // 
            this.pctbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctbLogo.BackgroundImage = global::Programacion.Properties.Resources.seguro_de_salud__1_;
            this.pctbLogo.Location = new System.Drawing.Point(333, 12);
            this.pctbLogo.Name = "pctbLogo";
            this.pctbLogo.Size = new System.Drawing.Size(128, 127);
            this.pctbLogo.TabIndex = 6;
            this.pctbLogo.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctbLogo);
            this.Controls.Add(this.grpbInicio);
            this.Name = "InicioSesion";
            this.Text = "Inicio de sesión";
            this.grpbInicio.ResumeLayout(false);
            this.grpbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInicio;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUduario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pctbLogo;
    }
}