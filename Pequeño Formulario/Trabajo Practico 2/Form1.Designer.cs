namespace Trabajo_Practico_2
{
    partial class PequeñoFormulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PequeñoFormulario));
            LNyA = new Label();
            LModificar = new Label();
            LDNI = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TGuardar = new Button();
            TEliminar = new Button();
            tbxDni = new TextBox();
            tbxApellido = new TextBox();
            tbxNombre = new TextBox();
            panel1 = new Panel();
            checkBoxMaster = new CheckBox();
            checkBoxVisa = new CheckBox();
            checkBoxNaranja = new CheckBox();
            LTarjeta = new Label();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            btnSalir = new Button();
            LNuevoCliente = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.BackColor = SystemColors.ButtonShadow;
            LNyA.Location = new Point(17, 1);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.ButtonShadow;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(156, 1);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.BackColor = SystemColors.ButtonShadow;
            LDNI.Location = new Point(28, 44);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(27, 15);
            LDNI.TabIndex = 2;
            LDNI.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.ButtonShadow;
            LApellido.Location = new Point(28, 80);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.ButtonShadow;
            LNombre.Location = new Point(28, 120);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // TGuardar
            // 
            TGuardar.Image = (Image)resources.GetObject("TGuardar.Image");
            TGuardar.Location = new Point(13, 329);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(80, 85);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = (Image)resources.GetObject("TEliminar.Image");
            TEliminar.Location = new Point(137, 329);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(80, 85);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(123, 36);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(100, 23);
            tbxDni.TabIndex = 10;
            tbxDni.KeyPress += tbxDni_KeyPress;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(123, 77);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(100, 23);
            tbxApellido.TabIndex = 11;
            tbxApellido.KeyPress += tbxApellido_KeyPress_1;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(123, 117);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(100, 23);
            tbxNombre.TabIndex = 12;
            tbxNombre.KeyPress += tbxNombre_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(checkBoxMaster);
            panel1.Controls.Add(tbxDni);
            panel1.Controls.Add(tbxApellido);
            panel1.Controls.Add(LNyA);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(checkBoxVisa);
            panel1.Controls.Add(checkBoxNaranja);
            panel1.Controls.Add(LTarjeta);
            panel1.Controls.Add(LDNI);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 264);
            panel1.TabIndex = 13;
            // 
            // checkBoxMaster
            // 
            checkBoxMaster.AutoSize = true;
            checkBoxMaster.Location = new Point(129, 223);
            checkBoxMaster.Name = "checkBoxMaster";
            checkBoxMaster.Size = new Size(85, 19);
            checkBoxMaster.TabIndex = 8;
            checkBoxMaster.Text = "Mastercard";
            checkBoxMaster.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisa
            // 
            checkBoxVisa.AutoSize = true;
            checkBoxVisa.Location = new Point(130, 200);
            checkBoxVisa.Name = "checkBoxVisa";
            checkBoxVisa.Size = new Size(47, 19);
            checkBoxVisa.TabIndex = 7;
            checkBoxVisa.Text = "Visa";
            checkBoxVisa.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaranja
            // 
            checkBoxNaranja.AutoSize = true;
            checkBoxNaranja.Location = new Point(130, 175);
            checkBoxNaranja.Name = "checkBoxNaranja";
            checkBoxNaranja.Size = new Size(67, 19);
            checkBoxNaranja.TabIndex = 6;
            checkBoxNaranja.Text = "Naranja";
            checkBoxNaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjeta
            // 
            LTarjeta.AutoSize = true;
            LTarjeta.Location = new Point(28, 156);
            LTarjeta.Name = "LTarjeta";
            LTarjeta.Size = new Size(99, 15);
            LTarjeta.TabIndex = 5;
            LTarjeta.Text = "Tarjeta de Crédito";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 82);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Location = new Point(284, 196);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 15;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Checked = true;
            RBMujer.Location = new Point(382, 196);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 16;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(344, 329);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 85);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // LNuevoCliente
            // 
            LNuevoCliente.AutoSize = true;
            LNuevoCliente.BackColor = SystemColors.Control;
            LNuevoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoCliente.ForeColor = SystemColors.Highlight;
            LNuevoCliente.Location = new Point(157, 9);
            LNuevoCliente.Name = "LNuevoCliente";
            LNuevoCliente.Size = new Size(137, 25);
            LNuevoCliente.TabIndex = 18;
            LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // PequeñoFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 437);
            Controls.Add(LNuevoCliente);
            Controls.Add(btnSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(panel1);
            Name = "PequeñoFormulario";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNyA;
        private Label LModificar;
        private Label LDNI;
        private Label LApellido;
        private Label LNombre;
        private Button TGuardar;
        private Button TEliminar;
        private TextBox tbxDni;
        private TextBox tbxApellido;
        private TextBox tbxNombre;
        private Panel panel1;
        private CheckBox checkBoxVisa;
        private CheckBox checkBoxNaranja;
        private Label LTarjeta;
        private CheckBox checkBoxMaster;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Button btnSalir;
        private Label LNuevoCliente;
    }
}
