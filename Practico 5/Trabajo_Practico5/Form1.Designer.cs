namespace Trabajo_Practico5
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            radioButtonHombre = new RadioButton();
            radioButtonMujer = new RadioButton();
            btnGuardar = new Button();
            txtBoxFoto = new TextBox();
            txtBoxSaldo = new TextBox();
            btnFoto = new Button();
            lSexo = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBoxApellido = new TextBox();
            txtBoxNombre = new TextBox();
            lSaldo = new Label();
            lFechaNac = new Label();
            lApellido = new Label();
            lNombre = new Label();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            FechaNac = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.avatar;
            pictureBox1.Location = new Point(626, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 232);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.Controls.Add(radioButtonHombre);
            panel1.Controls.Add(radioButtonMujer);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtBoxFoto);
            panel1.Controls.Add(txtBoxSaldo);
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(lSexo);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtBoxApellido);
            panel1.Controls.Add(txtBoxNombre);
            panel1.Controls.Add(lSaldo);
            panel1.Controls.Add(lFechaNac);
            panel1.Controls.Add(lApellido);
            panel1.Controls.Add(lNombre);
            panel1.Location = new Point(34, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 366);
            panel1.TabIndex = 1;
            // 
            // radioButtonHombre
            // 
            radioButtonHombre.AutoSize = true;
            radioButtonHombre.Font = new Font("Papyrus", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonHombre.ForeColor = SystemColors.ButtonHighlight;
            radioButtonHombre.Location = new Point(249, 188);
            radioButtonHombre.Name = "radioButtonHombre";
            radioButtonHombre.Size = new Size(81, 28);
            radioButtonHombre.TabIndex = 16;
            radioButtonHombre.TabStop = true;
            radioButtonHombre.Text = "Hombre";
            radioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonMujer
            // 
            radioButtonMujer.AutoSize = true;
            radioButtonMujer.Font = new Font("Papyrus", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonMujer.ForeColor = SystemColors.ButtonHighlight;
            radioButtonMujer.Location = new Point(150, 188);
            radioButtonMujer.Name = "radioButtonMujer";
            radioButtonMujer.Size = new Size(66, 28);
            radioButtonMujer.TabIndex = 15;
            radioButtonMujer.TabStop = true;
            radioButtonMujer.Text = "Mujer";
            radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.floppy_disc1;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(185, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 44);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBoxFoto
            // 
            txtBoxFoto.Location = new Point(126, 264);
            txtBoxFoto.Name = "txtBoxFoto";
            txtBoxFoto.Size = new Size(243, 23);
            txtBoxFoto.TabIndex = 13;
            // 
            // txtBoxSaldo
            // 
            txtBoxSaldo.Location = new Point(126, 234);
            txtBoxSaldo.Name = "txtBoxSaldo";
            txtBoxSaldo.Size = new Size(244, 23);
            txtBoxSaldo.TabIndex = 12;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(31, 263);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(75, 23);
            btnFoto.TabIndex = 11;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // lSexo
            // 
            lSexo.AutoSize = true;
            lSexo.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSexo.ForeColor = SystemColors.ButtonHighlight;
            lSexo.Location = new Point(28, 183);
            lSexo.Name = "lSexo";
            lSexo.Size = new Size(70, 33);
            lSexo.TabIndex = 9;
            lSexo.Text = "Sexo:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(244, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(86, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(126, 83);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(244, 23);
            txtBoxApellido.TabIndex = 6;
            txtBoxApellido.KeyPress += txtBoxApellido_KeyPress;
            txtBoxApellido.Leave += txtBoxApellido_Leave;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(126, 33);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(244, 23);
            txtBoxNombre.TabIndex = 5;
            txtBoxNombre.KeyPress += txtBoxNombre_KeyPress;
            txtBoxNombre.Leave += txtBoxNombre_Leave;
            // 
            // lSaldo
            // 
            lSaldo.AutoSize = true;
            lSaldo.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSaldo.ForeColor = SystemColors.ButtonHighlight;
            lSaldo.Location = new Point(28, 227);
            lSaldo.Name = "lSaldo";
            lSaldo.Size = new Size(78, 33);
            lSaldo.TabIndex = 3;
            lSaldo.Text = "Saldo:";
            // 
            // lFechaNac
            // 
            lFechaNac.AutoSize = true;
            lFechaNac.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lFechaNac.ForeColor = SystemColors.ButtonHighlight;
            lFechaNac.Location = new Point(28, 139);
            lFechaNac.Name = "lFechaNac";
            lFechaNac.Size = new Size(210, 33);
            lFechaNac.TabIndex = 2;
            lFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lApellido.ForeColor = SystemColors.ButtonHighlight;
            lApellido.Location = new Point(28, 76);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(98, 33);
            lApellido.TabIndex = 1;
            lApellido.Text = "Apellido:";
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.ForeColor = SystemColors.ButtonHighlight;
            lNombre.Location = new Point(28, 26);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(92, 33);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, FechaNac, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView1.Location = new Point(34, 396);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(855, 116);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // FechaNac
            // 
            FechaNac.HeaderText = "Fecha Nacimiento";
            FechaNac.Name = "FechaNac";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.Resizable = DataGridViewTriState.True;
            Saldo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7971;
            ClientSize = new Size(947, 516);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Formulario con DataGrid";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lFechaNac;
        private Label lApellido;
        private Label lNombre;
        private Label lSaldo;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxApellido;
        private TextBox txtBoxNombre;
        private Button btnGuardar;
        private TextBox txtBoxFoto;
        private TextBox txtBoxSaldo;
        private Button btnFoto;
        private Label lSexo;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private RadioButton radioButtonHombre;
        private RadioButton radioButtonMujer;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn FechaNac;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewLinkColumn Ruta;
    }
}
