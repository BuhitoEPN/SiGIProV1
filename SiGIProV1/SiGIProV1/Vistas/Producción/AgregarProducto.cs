using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Vistas.Producción
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            EscogerMateriaPrima escgoermateriaprima = new EscogerMateriaPrima();
            escgoermateriaprima.ShowDialog();
        }
    }
}
