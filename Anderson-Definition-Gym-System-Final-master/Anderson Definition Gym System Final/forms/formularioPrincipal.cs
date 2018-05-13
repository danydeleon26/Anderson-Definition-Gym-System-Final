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

        
            


        private void formularioPrincipal_Load(object sender, EventArgs e)
        {
            

            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes");
            
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            conecxiones.actualizarDataGridView(dataGridView1, "select * from Clientes where nombre like '%"+ buscarNombre.Text +"%'");

        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            formularioAgregar_ActualizarClientes formularioAgregar_ActualizarClientes = new formularioAgregar_ActualizarClientes();

            formularioAgregar_ActualizarClientes.Show();
        }


        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {
            formularioAgregar_ActualizarClientes formularioAgregar_ActualizarClientes = new formularioAgregar_ActualizarClientes();

            formularioAgregar_ActualizarClientes.Show();
        }
    }
}
