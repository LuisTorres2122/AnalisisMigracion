using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigracionVista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCita_MouseHover(object sender, EventArgs e)
        {
            btnCita.BackColor = Color.White;
            btnCita.ForeColor = Color.FromArgb(45, 118, 179);
        }

        private void btnCita_MouseLeave(object sender, EventArgs e)
        {
            btnCita.BackColor = Color.FromArgb(45, 118, 179);
            btnCita.ForeColor = Color.White;
        }

        private void btnCancelarcita_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarcita.BackColor = Color.FromArgb(45, 118, 179);
            btnCancelarcita.ForeColor = Color.White;
        }

        private void btnCancelarcita_MouseHover(object sender, EventArgs e)
        {
            btnCancelarcita.BackColor = Color.White;
            btnCancelarcita.ForeColor = Color.FromArgb(45, 118, 179);
        }

        private void btnvalidacion_MouseHover(object sender, EventArgs e)
        {
            btnvalidacion.BackColor = Color.White;
            btnvalidacion.ForeColor = Color.FromArgb(45, 118, 179);
        }

        private void btnvalidacion_MouseLeave(object sender, EventArgs e)
        {
            btnvalidacion.BackColor = Color.FromArgb(45, 118, 179);
            btnvalidacion.ForeColor = Color.White;
        }

        private void btnentregapasaporte_MouseHover(object sender, EventArgs e)
        {
            btnentregapasaporte.BackColor = Color.White;
            btnentregapasaporte.ForeColor = Color.FromArgb(45, 118, 179);
        }

        private void btnentregapasaporte_MouseLeave(object sender, EventArgs e)
        {
            btnentregapasaporte.BackColor = Color.FromArgb(45, 118, 179);
            btnentregapasaporte.ForeColor = Color.White;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            pbxPrincipal.Visible = false;
            Cita cita = new Cita();
            cita.MdiParent = this;
            cita.Show();
        }

        private void btnCancelarcita_Click(object sender, EventArgs e)
        {
            pbxPrincipal.Visible = false;
            Cancelar_cita ccita = new Cancelar_cita();
            ccita.MdiParent = this;
            ccita.Show();
        }

        private void btnvalidacion_Click(object sender, EventArgs e)
        {
            pbxPrincipal.Visible = false;
            Validacion validacion = new Validacion();
            validacion.MdiParent = this;
            validacion.Show();
        }

        private void btnentregapasaporte_Click(object sender, EventArgs e)
        {
            pbxPrincipal.Visible = false;
            Entrega entrega = new Entrega();
            entrega.MdiParent = this;
            entrega.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            pbxPrincipal.Visible = false;
            Registro registro = new Registro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void btnRegistro_MouseHover(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.White;
            btnRegistro.ForeColor = Color.FromArgb(45, 118, 179);
        }

        private void btnRegistro_MouseLeave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.FromArgb(45, 118, 179);
            btnRegistro.ForeColor = Color.White;
        }

    }
}
