namespace Practico3
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
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            BGuardar = new Button();
            BEliminar = new Button();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(30, 41);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.Control;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(169, 41);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(30, 91);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(30, 141);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(30, 190);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(30, 255);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 5;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(152, 255);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 6;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // TDni
            // 
            TDni.Location = new Point(109, 88);
            TDni.Name = "TDni";
            TDni.Size = new Size(118, 23);
            TDni.TabIndex = 7;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(109, 138);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(118, 23);
            TApellido.TabIndex = 8;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(109, 187);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(118, 23);
            TNombre.TabIndex = 9;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 351);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Button BGuardar;
        private Button BEliminar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
    }
}
