namespace Practico1
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
            bGuardar = new Button();
            bEliminar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lNombre = new Label();
            lApellido = new Label();
            txtConcatenacion = new TextBox();
            btnSalir = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(47, 145);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 23);
            bGuardar.TabIndex = 0;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bEliminar
            // 
            bEliminar.Location = new Point(153, 145);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(75, 23);
            bEliminar.TabIndex = 1;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Location = new Point(63, 100);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(51, 15);
            lNombre.TabIndex = 5;
            lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Location = new Point(63, 46);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(51, 15);
            lApellido.TabIndex = 6;
            lApellido.Text = "Apellido";
            // 
            // txtConcatenacion
            // 
            txtConcatenacion.Location = new Point(272, 51);
            txtConcatenacion.Multiline = true;
            txtConcatenacion.Name = "txtConcatenacion";
            txtConcatenacion.Size = new Size(200, 158);
            txtConcatenacion.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(397, 226);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(484, 24);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            salirToolStripMenuItem1.Size = new Size(180, 22);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(btnSalir);
            Controls.Add(txtConcatenacion);
            Controls.Add(lApellido);
            Controls.Add(lNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(bEliminar);
            Controls.Add(bGuardar);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mi primer Forms";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGuardar;
        private Button bEliminar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lNombre;
        private Label lApellido;
        private TextBox txtConcatenacion;
        private Button btnSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}
