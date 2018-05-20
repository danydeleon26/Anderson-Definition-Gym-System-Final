using Anderson_Definition_Gym_System_Final.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anderson_Definition_Gym_System_Final
{
    public partial class formularioPrincipal : Form
    {
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        Conecxiones conecxiones = new Conecxiones();

        public static int id;


        private void formularioPrincipal_Load(object sender, EventArgs e)
        {
            

            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes");

           

        }

        #region boton buscar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes where nombre like '%"+ buscarNombre.Text +"%'");

        }

        #endregion boton buscar 

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region boton Agregar 1

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            formularioAgregar_ActualizarClientes formularioAgregar_ActualizarClientes = new formularioAgregar_ActualizarClientes();


            formularioAgregar_ActualizarClientes.btnAgregar.Text = "Agregar";

            formularioAgregar_ActualizarClientes.Show();

            formularioAgregar_ActualizarClientes.FormClosed += FormularioAgregar_ActualizarClientes_FormClosed;
        }

        private void FormularioAgregar_ActualizarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes");
        }

        #endregion boton Agregar 1

        #region boton Agregar 2

        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {
            formularioAgregar_ActualizarClientes formularioAgregar_ActualizarClientes = new formularioAgregar_ActualizarClientes();
            
            formularioAgregar_ActualizarClientes.btnAgregar.Text = "Agregar";

            formularioAgregar_ActualizarClientes.Show();

            formularioAgregar_ActualizarClientes.FormClosed += FormularioAgregar_ActualizarClientes_FormClosed1;
        }

        private void FormularioAgregar_ActualizarClientes_FormClosed1(object sender, FormClosedEventArgs e)
        {
            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes");
        }

        #endregion boton Agregar 2

        #region boton ELiminar 1

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            conecxiones.conectarConLaBaseDedatos();

            string a = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


            string eliminar = "delete Clientes where id =" + a + "; ";

            conecxiones.Ejecutarsql(eliminar);

            //consultar nuevamente despues de eliminar

            conecxiones.actualizarDataGridView(this.dataGridView1, "select * from Clientes");

            conecxiones.deconectarLaBaseDeDatos();
        }

        #endregion boton ELiminar 1

        #region boton ELiminar 2

        private void radRibbonBarGroup2_Click(object sender, EventArgs e)
        {
            conecxiones.conectarConLaBaseDedatos();

            string a = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


            string eliminar = "delete Clientes where id =" + a + "; ";

            conecxiones.Ejecutarsql(eliminar);

            //consultar nuevamente despues de eliminar

            conecxiones.actualizarDataGridView(this.dataGridView1, "select * from Clientes");

            conecxiones.deconectarLaBaseDeDatos();

        }

        #endregion boton ELiminar 2

        #region boton actualizar 1

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            formularioAgregar_ActualizarClientes formularioAgregar_ActualizarClientes = new formularioAgregar_ActualizarClientes();

            formularioAgregar_ActualizarClientes.Show();

            formularioAgregar_ActualizarClientes.btnAgregar.Text = "Actualizar";

            formularioAgregar_ActualizarClientes.editar = true;

            id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            formularioAgregar_ActualizarClientes.nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            formularioAgregar_ActualizarClientes.apellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            formularioAgregar_ActualizarClientes.edad.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            formularioAgregar_ActualizarClientes.sexo.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            formularioAgregar_ActualizarClientes.direccion2.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            formularioAgregar_ActualizarClientes.telefono.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            formularioAgregar_ActualizarClientes.fecha.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

            formularioAgregar_ActualizarClientes.FormClosing += FormularioAgregar_ActualizarClientes_FormClosing;

            

        }

        private void FormularioAgregar_ActualizarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {

            conecxiones.actualizarDataGridView(this.dataGridView1, "select * from Clientes");

        }

        #endregion boton actualizar 1

        #region boton actualizar 2

        private void radRibbonBarGroup3_Click(object sender, EventArgs e)
        {


            formularioAgregar_ActualizarClientes formularioAgregar_ActualizarClientes = new formularioAgregar_ActualizarClientes();

            formularioAgregar_ActualizarClientes.Show();

            formularioAgregar_ActualizarClientes.btnAgregar.Text = "Actualizar";

            formularioAgregar_ActualizarClientes.editar = true;

            id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            formularioAgregar_ActualizarClientes.nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            formularioAgregar_ActualizarClientes.apellido.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            formularioAgregar_ActualizarClientes.edad.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            formularioAgregar_ActualizarClientes.sexo.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            formularioAgregar_ActualizarClientes.direccion2.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            formularioAgregar_ActualizarClientes.telefono.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            formularioAgregar_ActualizarClientes.fecha.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

            formularioAgregar_ActualizarClientes.FormClosed += FormularioAgregar_ActualizarClientes_FormClosed2;

        }

        private void FormularioAgregar_ActualizarClientes_FormClosed2(object sender, FormClosedEventArgs e)
        {
            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes");
        }

        #endregion boton actualizar 2 



    }
}
