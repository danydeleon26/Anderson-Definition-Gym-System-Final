using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anderson_Definition_Gym_System_Final.forms
{
    public partial class formularioAgregar_ActualizarClientes : Form
    {
        public formularioAgregar_ActualizarClientes()
        {
            InitializeComponent();
        }


        Conecxiones conecxiones = new Conecxiones();

        formularioPrincipal formularioPrincipal = new formularioPrincipal();


        #region metodo limpiar

        public void limpiar()
        {
            nombre.Text = "";
            apellido.Text = "";
            edad.Text = "";
            direccion2.Text = "";
            telefono.Text = "";
        }



        #endregion



        private void formularioAgregar_ActualizarClientes_Load(object sender, EventArgs e)
        {

            //llenar el combobox de sexos
            sexo.Items.Add("Hombre");
            sexo.Items.Add("Mujer");
            sexo.SelectedIndex = 0;

        }

        #region botonCerrar

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            limpiar();
        }

        #endregion botonCerrar

        #region botonAgregar

        private void btnAgregar_Click(object sender, EventArgs e)
        {



            try
            {
                conecxiones.conectarConLaBaseDedatos();

                string insertar = "insert into Clientes (nombre,apellido,edad,sexo,direccion,telefono,[fecha de inscripcion]) values ('" + nombre.Text + "','" + apellido.Text + "',+" + edad.Text + ",'" + sexo.SelectedItem.ToString() + "','" + direccion2.Text + "'," + telefono.Text + ",'" + fecha.Value.ToShortDateString() + "');";

                conecxiones.Ejecutarsql(insertar);

                //consultar nuevamente despues de la insercion para actualizar el dg despues de la insercion

                limpiar();

                conecxiones.deconectarLaBaseDeDatos();

            }


            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

            conecxiones.actualizarDataGridView(formularioPrincipal.dataGridView1, "select * from Clientes");

            this.Visible = false;



        }

        #endregion botonAgregar

    }
}
