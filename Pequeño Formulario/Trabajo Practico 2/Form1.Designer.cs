namespace Trabajo_Practico_2
{
    partial class Form1
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
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(12, 29);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(143, 29);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(12, 63);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(27, 15);
            LDNI.TabIndex = 2;
            LDNI.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 99);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(12, 137);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(31, 191);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Location = new Point(126, 191);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(137, 55);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(100, 23);
            tbxDni.TabIndex = 10;
            tbxDni.KeyPress += tbxDni_KeyPress;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(137, 91);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(100, 23);
            tbxApellido.TabIndex = 11;
            tbxApellido.KeyPress += tbxApellido_KeyPress_1;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(137, 134);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(100, 23);
            tbxNombre.TabIndex = 12;
            tbxNombre.KeyPress += tbxNombre_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 257);
            Controls.Add(tbxNombre);
            Controls.Add(tbxApellido);
            Controls.Add(tbxDni);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDNI);
            Controls.Add(LModificar);
            Controls.Add(LNyA);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
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
    }
}
