using Clase4_05_2024.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4_05_2024
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
            
        }

        private void BotonDeprueba_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxFacultad_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            FrmRegistro Frmreg = new FrmRegistro();
            Frmreg.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int intentar = 0;
        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            String usr =  textBoxUsuario.Text.ToLower();
            String pwd = textBox1.Text.ToLower();
            if (usr == null || pwd == null)
            {
                MessageBox.Show("No se puede dejar en blanco");
            }
            else
            {
                    if (usr.Equals("admin") && pwd.Equals("admin"))
                    {
                        FrmRegistro registro = new FrmRegistro();
                        registro.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y Contraseña Erroneos");
                        textBox1.Text = "";
                        textBoxUsuario.Text = "";
                        intentar++;
                    }
                if (intentar == 3)
                {
                    MessageBox.Show("Numero de intentos permitidos superados");
                    buttonIngresar.Enabled = false;
                }
            }
        }
    }
}
// No se, se bugueo