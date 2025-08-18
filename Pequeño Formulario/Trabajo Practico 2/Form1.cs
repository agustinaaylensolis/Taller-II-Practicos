using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Trabajo_Practico_2.Properties;

namespace Trabajo_Practico_2
{
    public partial class Peque�oFormulario : Form
    {
        public Peque�oFormulario()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ErrorProvider errorP1 = new ErrorProvider();
        private void tbxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validaN = Validar_Txt.validarNumeros(e);
            if (!validaN)
            {
                errorP1.SetError(tbxDni, "Solo se permiten numeros");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private void tbxApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            bool validaL = Validar_Txt.validarLetras(e);
            if (!validaL)
            {
                errorP1.SetError(tbxApellido, "Solo se permiten letras");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validaL = Validar_Txt.validarLetras(e);
            if (!validaL)
            {
                errorP1.SetError(tbxNombre, "Solo se permiten letras");
            }
            else
            {
                errorP1.Clear();
            }
        }


        private void TGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxDni.Text)
                || string.IsNullOrWhiteSpace(tbxApellido.Text)
                || string.IsNullOrWhiteSpace(tbxNombre.Text)
                )
            {
                MessageBox.Show("Debe completar todos los campos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("�Seguro que desea ingresar un nuevo cliente", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente:" + " " + $"{tbxNombre.Text} {tbxApellido.Text}" + " " + "se ingres� correctamente", "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LModificar.Text = $"{tbxNombre.Text} {tbxApellido.Text}";


                }
                else if (ask == DialogResult.No)
                {

                    MessageBox.Show("Ingreso cancelado", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LModificar.Text = string.Empty;
                    tbxDni.Clear();
                    tbxApellido.Clear();
                    tbxNombre.Clear();
                    tbxDni.Focus();

                }

            }


        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Est� a punto de eliminar al cliente" + " " + $"{tbxNombre.Text} {tbxApellido.Text}", "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El cliente:" + " " + $"{tbxNombre.Text} {tbxApellido.Text}" + " " + "se elimin� correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxDni.Clear();
                tbxApellido.Clear();
                tbxNombre.Clear();
                tbxDni.Focus();

            }
            else if (ask == DialogResult.No)
            {

            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                pictureBox1.Image = Properties.Resources.usuaria;
            }

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                pictureBox1.Image = Properties.Resources.usuario;
            }
        }
    }
}
