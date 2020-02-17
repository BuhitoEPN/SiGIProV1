using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControladorInterfaz
    {

        //Volver al panel escritorio:
        public void OpenChildForm(Form childForm, Form currentChildForm, Panel panelEscritorio)
        {

            if (currentChildForm != null)
            {
                //Permite abrir solo un formulario:
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
