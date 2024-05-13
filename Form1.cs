using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;

namespace WindowsFormsApp1
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

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido a mi App");
        }

        private void btnaccion_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFacultad_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.ToLower();
            string contraseña = textBoxContrasena.Text.ToLower();
            int intentos = 0;   
            int MaxIntentos = 3;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("No puede dejar campos en blanco");
                return;
            }

            if (usuario == "admin" && contraseña == "admin")
            {
                FMR_Registro registro = new FMR_Registro();
                textBoxUsuario.Text = string.Empty;
                textBoxContrasena.Text = string.Empty;
                registro.Show();
            }
            else
            {
                intentos++;

                if (intentos >= MaxIntentos)
                {
                    MessageBox.Show("Se han agotado los intentos. El botón se deshabilitará.");
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El Usuario y Contraseña son Incorrectos");
                    textBoxUsuario.Text = string.Empty;
                    textBoxContrasena.Text = string.Empty;
                }
            }
        }
    }
}