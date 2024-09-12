using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        
        private List<Usuario> usuariosRegistrados = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(nombres) && !string.IsNullOrEmpty(apellidos))
            {
                Usuario nuevoUsuario = new Usuario(user, password, nombres, apellidos, fechaNacimiento);
                usuariosRegistrados.Add(nuevoUsuario);
                lblMensaje.Text = "Usuario registrado con éxito.";
            }
            else
            {
                lblMensaje.Text = "Usuario y contraseña no deben estar vacíos.";
            }

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;
            bool encontrado = false;

            foreach (Usuario usuario in usuariosRegistrados)
            {
                if (usuario.User == user && usuario.Password == password)
                {
                    encontrado = true;
                    lstPersonas.Items.Add($"{usuario.Nombres} {usuario.Apellidos} - Edad: {usuario.CalcularEdad()} años");
                    break;
                }
            }

            if (encontrado)
            {
                lblMensaje.Text = "Usuario encontrado.";
            }
            else
            {
                lblMensaje.Text = "Usuario no encontrado.";
            }




        }
    }
}
