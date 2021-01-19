using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using crud.Logica;
using crud.Datos;

namespace crud.Presentacion
{
    public partial class sentencias_linq : Form
    {
        public sentencias_linq()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sentencias_linq_Load(object sender, EventArgs e)
        {

            llenarcombo();
        }

        private void llenarcombo()
        {
            DataTable datos = new DataTable();
            dunidades funcion = new dunidades();
            Type t = typeof(String);
            datos = funcion.mostrar();

            string[] columnNames = (from col in datos.Columns.Cast<DataColumn>()
                                    select col.ColumnName).ToArray();
            cbdatos.DataSource = columnNames.ToList();
            lbtipo.Text = datos.Columns[0].DataType.ToString();

        }

        private void consultas(bool ma, bool me, bool ig)
        {
            DataTable datos = new DataTable();
            dunidades funcion = new dunidades();
            datos = funcion.mostrar();
            if (ma == true)
            {
                var relleno = datos.AsEnumerable().Where
                                (x=>x.Field<int>(cbdatos.Text)>int.Parse(tbcon.Text)).AsDataView();
                dgvanidado.DataSource = relleno;
            }
            if (me == true)
            {
                var relleno = datos.AsEnumerable().Where
                                (x => x.Field<int>(cbdatos.Text) < int.Parse(tbcon.Text)).AsDataView();
                dgvanidado.DataSource = relleno;
            }
            if (ig == true)
            {
                var relleno = datos.AsEnumerable().Where
                                (x => x.Field<int>(cbdatos.Text) == int.Parse(tbcon.Text)).AsDataView();
                dgvanidado.DataSource = relleno;
            }
         
        }

        private void cbdatos_TextChanged(object sender, EventArgs e)
        {
            lbres.Text = "Tabla a utilizar "+cbdatos.Text;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ma = chbmayor.Checked;
            bool me = chbmenor.Checked;
            bool ig = chbigual.Checked;
            if (ma == true && me == true || me == true && ig == true || ma == true && ig == true || ma == true && me == true && ig == true)
            {
                MessageBox.Show("Sea Seleccionado mas de una casilla", "Elija solo una");
            }
            else 
            {
                consultas(ma, me, ig);
            }
        }
    }
}
