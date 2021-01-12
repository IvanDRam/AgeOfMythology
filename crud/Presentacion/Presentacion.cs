using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using crud.Datos;
using crud.Logica;

namespace crud.Presentacion
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pninsertar.Visible = false;
            pnactualizar.Visible = false;
            pnborrar.Visible = false;
            pninicio.Visible = false;
            pnmostrar.Visible = true;
            DataTable datos;
            dunidades funcion= new dunidades();
            datos = funcion.mostrar();
            dtlistado.DataSource=datos;
        }

        private void pnactualizar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pninsertar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pinsertar_Click(object sender, EventArgs e)
        {
            pninsertar.Visible = true;
            pnactualizar.Visible = false;
            pnborrar.Visible = false;
            pninicio.Visible = false;
            pnmostrar.Visible = false;
        }

        private void pactualizar_Click(object sender, EventArgs e)
        {
            pninsertar.Visible = false;
            pnactualizar.Visible = true;
            pnborrar.Visible = false;
            pninicio.Visible = false;
            pnmostrar.Visible = false;
        }

        private void pborrar_Click(object sender, EventArgs e)
        {
            pninsertar.Visible = false;
            pnactualizar.Visible = false;
            pnborrar.Visible = true;
            pninicio.Visible = false;
            pnmostrar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbnombrei.Text == "" || tbcostoi.Text == "" || tbp_ri.Text == "" || tbvelocidadi.Text == "" || tbc_pi.Text == "" || tba_mi.Text == "" || tba_conti.Text == "" || tba_cori.Text == "" || tba_proyeci.Text == "" || tbd_corti.Text == "" || tbd_perfi.Text == "" || tbd_perfi.Text == "" || tbcivilizacioni.Text == "" || tbedadi.Text == "" || tbtipoi.Text == "")
            {
                MessageBox.Show("Algun Dato esta vacio", "Rellene el campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                insertar_unidad();
            }
        }

        private void insertar_unidad()
        {
            lunidades dt = new lunidades();
            dunidades funcion = new dunidades();
            dt.Nombre = tbnombrei.Text;
            dt.Costo = tbcostoi.Text;
            dt.Puntos_resis =int.Parse(tbp_ri.Text);
            dt.Velocidad = float.Parse(tbvelocidadi.Text);
            dt.Coste_poblacion= int.Parse(tbc_pi.Text);
            dt.Alcance_max= int.Parse(tba_mi.Text);
            dt.Arm_anticontundente= int.Parse(tba_conti.Text);
            dt.Arm_anticortante= int.Parse(tba_cori.Text);
            dt.Arm_antiproyectiles= int.Parse(tba_proyeci.Text);
            dt.Dam_cortante= int.Parse(tbd_corti.Text);
            dt.Dam_perforante= int.Parse(tbd_perfi.Text);
            dt.Dam_demoledor = int.Parse(tbd_demoi.Text);
            dt.Civilizacion = tbcivilizacioni.Text;
            dt.Edad = tbedadi.Text;
            dt.Tipo = tbtipoi.Text;
            if (funcion.insertar(dt))
            {
                MessageBox.Show("Usuario Registrado","Registro aumentado");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            lunidades dt = new lunidades();
            dunidades funcion = new dunidades();
            dt.Unidad = int.Parse(tbborrarb.Text);
            if (funcion.borrar(dt))
            {
                MessageBox.Show("Usuario Borrado con Exito", "Aceptar");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lunidades dt = new lunidades();
            dunidades funcion = new dunidades();
            dt.Unidad =int.Parse(tbunidada.Text);
            dt.Nombre = tbnombrea.Text;
            dt.Costo = tbcostoa.Text;
            dt.Puntos_resis = int.Parse(tbp_ra.Text);
            dt.Velocidad = float.Parse(tbvelocidada.Text);
            dt.Coste_poblacion = int.Parse(tbc_pa.Text);
            dt.Alcance_max = int.Parse(tba_ma.Text);
            dt.Arm_anticontundente = int.Parse(tba_contuna.Text);
            dt.Arm_anticortante = int.Parse(tba_corta.Text);
            dt.Arm_antiproyectiles = int.Parse(tba_proyecta.Text);
            dt.Dam_cortante = int.Parse(tbd_cortaa.Text);
            dt.Dam_perforante = int.Parse(tbd_perfa.Text);
            dt.Dam_demoledor = int.Parse(tbd_demolea.Text);
            dt.Civilizacion = tbcivilizaciona.Text;
            dt.Edad = tbedada.Text;
            dt.Tipo = tbtipoa.Text;
            if (funcion.actualizar(dt))
            {
                MessageBox.Show("Usuario Actualizado", "Aceptar");
            }

        }
    }
}
