using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ErrorProvider errorP1 = new ErrorProvider();

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDesde.Text) || string.IsNullOrWhiteSpace(textBoxHasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(textBoxDesde.Text, out int desde) || !int.TryParse(textBoxHasta.Text, out int hasta))
                {
                    MessageBox.Show("Por favor, ingrese números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listBoxResultado.Items.Clear();
                for (int i = desde; i <= hasta; i++)
                {
                    listBoxResultado.Items.Add(i);
                }
            }
        }

        private void textBoxDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validaN = Validar_Txt.validarNumeros(e);
            if (!validaN)
            {
                errorP1.SetError(textBoxDesde, "Solo se permiten números");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private void textBoxHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validaN = Validar_Txt.validarNumeros(e);
            if (!validaN)
            {
                errorP1.SetError(textBoxHasta, "Solo se permiten números");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            GenerarLista("pares");
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            GenerarLista("impares");
        }



        // Genera la lista de números de acuerdo al tipo ingresado
        private void GenerarLista(string tipo)
        {
            listBoxResultado.Items.Clear();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textBoxDesde.Text) || string.IsNullOrWhiteSpace(textBoxHasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir los valores a enteros
            if (!int.TryParse(textBoxDesde.Text, out int desde) || !int.TryParse(textBoxHasta.Text, out int hasta))
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asegurarse de que el rango sea válido
            if (desde > hasta)
            {
                MessageBox.Show("El número inicial debe ser menor o igual al número final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            listBoxResultado.Items.Add($"=== NÚMEROS {tipo.ToUpper()} ===");

            for (int i = desde; i <= hasta; i++)
            {
                bool agregar = false;

                if (tipo == "pares")
                {
                    agregar = (i % 2 == 0);
                }
                else if (tipo == "impares")
                {
                    agregar = (i % 2 != 0);
                }
                else if (tipo == "primos")
                {
                    bool esPrimo = EsPrimo(i);
                    Debug.WriteLine($"Número {i}: {esPrimo}");
                    agregar = esPrimo;
                }

                if (agregar)
                {
                    listBoxResultado.Items.Add($"{i}");
                    
                }
            }

            
        }

        // Función optimizada para verificar números primos
        private bool EsPrimo(int numero)
        {
            // Casos especiales
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            // Verificar divisibilidad desde 3 hasta sqrt(numero)
            int limite = (int)Math.Sqrt(numero);
            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            GenerarLista("primos");
        }
    }
}
