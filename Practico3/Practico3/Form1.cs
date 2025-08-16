namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text)
                || string.IsNullOrWhiteSpace(TApellido.Text)
                || string.IsNullOrWhiteSpace(TNombre.Text)
                )
            {
                MessageBox.Show("Debe completar todos los campos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                LModificar.Text = $"{TNombre.Text} {TApellido.Text}";
            }  
        }
    }
}
