using SiGIProV1.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Vistas
{
    public partial class HomeAdministrador : Form
    {

        public HomeAdministrador(string user)
        {
            InitializeComponent();
            new ControladorHome().nombreUsuario(labelSaludo, user);

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
