using System;
using System.Drawing;
using System.Runtime.InteropServices; // importamos librería
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Ventana : Form //Se crea nuevo formularo base para que el resto de los formularios hereden el formato.
    {

        protected Label tituloVentana; // Cambiado a protected para que sea accesible desde clases derivadas

        public Ventana()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        // Método para modificar el texto del Label TituloVentana
        public void ModificarTextoTituloVentana(string nuevoTexto)
        {
            tituloVentana.Text = nuevoTexto;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Obtener el tamaño del formulario
            int borderWidth = 2; // Ancho del borde en píxeles
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Dibujar el borde
            ControlPaint.DrawBorder(e.Graphics, new Rectangle(0, 0, width, height), Color.Black, borderWidth, ButtonBorderStyle.Solid, Color.Black, borderWidth, ButtonBorderStyle.Solid, Color.Black, borderWidth, ButtonBorderStyle.Solid, Color.Black, borderWidth, ButtonBorderStyle.Solid);
        } // Dibuja un Borde Negro a la Ventana

        public void Boton_Cerrar_Click(object sender, EventArgs e) // Acción al hacer click en el botón de la X
        {
            // Mostrar un cuadro de diálogo de confirmación al usuario
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?\n\nLos cambios que no se hayan guardado se perderán.", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Si el usuario confirma, salir de la aplicación
                Application.Exit();
            }
            // Si el usuario elige no salir, no se hace nada
        }

        public void Boton_Minimizar_Click(object sender, EventArgs e)// Acción al apretar en botón minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Se importa código que permite maniobrar la barra superior del formulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void BarraTituloForm_MouseDown(object sender, MouseEventArgs e) // Se pasan los métodos púbicos para poder tomarlos del resto de los formularios.
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }

}
