using System.Windows.Forms;

namespace Trabajo_Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Papyrus", 12, FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Papyrus", 12, FontStyle.Bold);
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }


        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*";
            openFileDialog1.Title = "Seleccionar una imagen";
            // Mostrar el cuadro de diálogo y verificar si se seleccionó un archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog1.FileName;
                // Mostrar la imagen en el PictureBox
                pictureBox1.ImageLocation = rutaArchivo;
                // Mostrar la ruta del archivo en el TextBox
                txtBoxFoto.Text = rutaArchivo;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        ErrorProvider errorP1 = new ErrorProvider();

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validaN = Validar_Txt.validarLetras(e);
            if (!validaN)
            {
                errorP1.SetError(txtBoxNombre, "Solo se permiten letras");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private void txtBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validaN = Validar_Txt.validarLetras(e);
            if (!validaN)
            {
                errorP1.SetError(txtBoxApellido, "Solo se permiten letras");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            // Convertir la primera letra a mayúscula y el resto a minúscula
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        private void txtBoxNombre_Leave(object sender, EventArgs e)
        {
            txtBoxNombre.Text = CapitalizeFirstLetter(txtBoxNombre.Text);
        }

        private void txtBoxApellido_Leave(object sender, EventArgs e)
        {
            txtBoxApellido.Text = CapitalizeFirstLetter(txtBoxApellido.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(txtBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSaldo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!radioButtonMujer.Checked && !radioButtonHombre.Checked)
            {
                MessageBox.Show("Por favor, seleccione un género.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Determinar el género seleccionado
            string genero = radioButtonMujer.Checked ? "Mujer" : "Hombre";
            Image imagen = Image.FromFile(txtBoxFoto.Text);

            int rowIndex = dataGridView1.Rows.Add(
                txtBoxNombre.Text,
                txtBoxApellido.Text,
                dateTimePicker1.Value.ToShortDateString(),
                genero,
                "eliminar",
                txtBoxSaldo.Text,
                imagen,     // Imagen
                txtBoxFoto.Text // Ruta de la foto
            );
            decimal saldoCliente = Convert.ToDecimal(txtBoxSaldo.Text);
            if (saldoCliente < 50)
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimpiarCampos()
        {
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";
            txtBoxFoto.Text = "";
            pictureBox1.Image = null;
            dateTimePicker1.Value = DateTime.Now;
            radioButtonMujer.Checked = false;
            radioButtonHombre.Checked = false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Obtener la fila que se quiere eliminar
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Obtener los datos de la fila para el mensaje de confirmación
                string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";
                string apellido = fila.Cells["Apellido"].Value?.ToString() ?? "";
                // Confirmar la eliminación
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el registro de {nombre} {apellido}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
               
                // Verificar que la celda "Sexo" existe y obtener su valor
                if (fila.Cells["Sexo"].Value != null)
                {
                    string sexo = fila.Cells["Sexo"].Value.ToString();

                    // Marcar el RadioButton correspondiente
                    if (sexo.Equals("Hombre", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButtonHombre.Checked = true;
                        radioButtonMujer.Checked = false;
                    }
                    else if (sexo.Equals("Mujer", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButtonMujer.Checked = true;
                        radioButtonHombre.Checked = false;
                    }
                }

            }
        }
    }
}