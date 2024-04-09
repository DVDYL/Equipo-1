using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices; // importamos librería

namespace Form_Equipo1
{
    public partial class FormBase : Form //Se crea nuevo formularo base para que el resto de los formularios hereden el formato.
    {
        private string tituloBarra;

        public string TituloBarra //Se crea propiedad para que se pueda actualizar el título en cada formulario.
        {
            get { return tituloBarra; }
            set
            {
                tituloBarra = value;
                ActualizarTituloBarra();
            }
        }

        public FormBase() //Se inicializa el formulario.
        {
            InitializeComponent();
        }

        private void ActualizarTituloBarra() //Se crea método, el cual marca lo que sería el tituloBarra
        {
            this.Text = tituloBarra;
        }

        public void btnCerrarForm_Click(object sender, EventArgs e) //Acción al hacer click en el boton de la X
        {
            Application.Exit();
        }

        public void btnMaximizarForm_Click(object sender, EventArgs e) // Acción al apretar en botón maximizar
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarForm.Visible = false;
            btnRestaurarForm.Visible = true;
        }

        public void btnMinimizarForm_Click(object sender, EventArgs e)// Acción al apretar en botón minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void btnRestaurarForm_Click(object sender, EventArgs e)// Acción al apretar en botón restaurar
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurarForm.Visible = false;
            btnMaximizarForm.Visible = true;
        }

        //Se importa código que permite maniobrar la barra superior del formulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public void BarraTituloForm_MouseDown(object sender, MouseEventArgs e) //Se pasan los métodos púbicos para poder tomarlos del resto de los formularios.
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void BarraTituloForm_MouseDoubleClick(object sender, MouseEventArgs e) //Maximizar la ventana al hacer doble click
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BarraTituloForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
