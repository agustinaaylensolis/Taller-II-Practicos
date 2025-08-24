namespace WinFormsApp1
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
            LDesde = new Label();
            LHasta = new Label();
            textBoxDesde = new TextBox();
            textBoxHasta = new TextBox();
            listBoxResultado = new ListBox();
            LLista = new Label();
            button1 = new Button();
            btnPares = new Button();
            btnImpares = new Button();
            btnPrimos = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(31, 49);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(42, 15);
            LDesde.TabIndex = 0;
            LDesde.Text = "Desde:";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(31, 92);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(40, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta:";
            // 
            // textBoxDesde
            // 
            textBoxDesde.Location = new Point(79, 46);
            textBoxDesde.Name = "textBoxDesde";
            textBoxDesde.Size = new Size(100, 23);
            textBoxDesde.TabIndex = 2;
            textBoxDesde.KeyPress += textBoxDesde_KeyPress;
            // 
            // textBoxHasta
            // 
            textBoxHasta.Location = new Point(77, 89);
            textBoxHasta.Name = "textBoxHasta";
            textBoxHasta.Size = new Size(100, 23);
            textBoxHasta.TabIndex = 3;
            textBoxHasta.KeyPress += textBoxHasta_KeyPress;
            // 
            // listBoxResultado
            // 
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.ItemHeight = 15;
            listBoxResultado.Location = new Point(216, 49);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(185, 184);
            listBoxResultado.TabIndex = 4;
            // 
            // LLista
            // 
            LLista.AutoSize = true;
            LLista.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LLista.Location = new Point(148, 9);
            LLista.Name = "LLista";
            LLista.Size = new Size(161, 25);
            LLista.TabIndex = 5;
            LLista.Text = "Lista de Números";
            // 
            // button1
            // 
            button1.Location = new Point(50, 136);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 6;
            button1.Text = "Generar Función";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPares
            // 
            btnPares.Location = new Point(46, 178);
            btnPares.Name = "btnPares";
            btnPares.Size = new Size(122, 23);
            btnPares.TabIndex = 10;
            btnPares.Text = "Números Pares";
            btnPares.UseVisualStyleBackColor = true;
            btnPares.Click += btnPares_Click;
            // 
            // btnImpares
            // 
            btnImpares.Location = new Point(46, 207);
            btnImpares.Name = "btnImpares";
            btnImpares.Size = new Size(122, 23);
            btnImpares.TabIndex = 11;
            btnImpares.Text = "Números Impares";
            btnImpares.UseVisualStyleBackColor = true;
            btnImpares.Click += btnImpares_Click;
            // 
            // btnPrimos
            // 
            btnPrimos.Location = new Point(46, 236);
            btnPrimos.Name = "btnPrimos";
            btnPrimos.Size = new Size(122, 23);
            btnPrimos.TabIndex = 12;
            btnPrimos.Text = "Números Primos";
            btnPrimos.UseVisualStyleBackColor = true;
            btnPrimos.Click += btnPrimos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnPrimos);
            panel1.Controls.Add(btnImpares);
            panel1.Controls.Add(btnPares);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(LLista);
            panel1.Controls.Add(listBoxResultado);
            panel1.Controls.Add(textBoxHasta);
            panel1.Controls.Add(textBoxDesde);
            panel1.Controls.Add(LHasta);
            panel1.Controls.Add(LDesde);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 285);
            panel1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 313);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Formulario4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LDesde;
        private Label LHasta;
        private TextBox textBoxDesde;
        private TextBox textBoxHasta;
        private ListBox listBoxResultado;
        private Label LLista;
        private Button button1;
        private Button btnPares;
        private Button btnImpares;
        private Button btnPrimos;
        private Panel panel1;
    }
}
