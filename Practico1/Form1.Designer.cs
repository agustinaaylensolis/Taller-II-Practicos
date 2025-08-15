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
            textbox1 = new TextBox();
            textbox2 = new TextBox();
            lNombre = new Label();
            lApellido = new Label();
            textBox3 = new TextBox();
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
            // 
            // bEliminar
            // 
            bEliminar.Location = new Point(153, 145);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(75, 23);
            bEliminar.TabIndex = 1;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // textbox1
            // 
            textbox1.Location = new Point(128, 92);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(100, 23);
            textbox1.TabIndex = 3;
            // 
            // textbox2
            // 
            textbox2.Location = new Point(128, 41);
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(100, 23);
            textbox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(272, 41);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 158);
            textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(textBox3);
            Controls.Add(lApellido);
            Controls.Add(lNombre);
            Controls.Add(textbox2);
            Controls.Add(textbox1);
            Controls.Add(label1);
            Controls.Add(bEliminar);
            Controls.Add(bGuardar);
            Name = "Form1";
            Text = "Mi primer Forms";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGuardar;
        private Button bEliminar;
        private Label label1;
        private TextBox textbox1;
        private TextBox textbox2;
        private Label lNombre;
        private Label lApellido;
        private TextBox textBox3;
    }
}
