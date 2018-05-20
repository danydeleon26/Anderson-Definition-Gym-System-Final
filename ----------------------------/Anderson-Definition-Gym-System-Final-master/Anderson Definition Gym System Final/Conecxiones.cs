using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Anderson_Definition_Gym_System_Final
{
    class Conecxiones
    {

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=andersonGym;Integrated Security=True");


        #region Conectar con la base de datos

        public void conectarConLaBaseDedatos()

        {
            if (conn.State != ConnectionState.Open)

            {
                conn.Open();

            }




        }

        #endregion conectar con la base de datos


        #region deconectar la base de datos

        public void deconectarLaBaseDeDatos()
        {

            conn.Close();

        }

        #endregion deconectar la base datos

        #region ejecutarsql

        public void Ejecutarsql(string consulta)

        {
            try
            {

                SqlCommand com = new SqlCommand(consulta, conn);

                int filasafectadas = com.ExecuteNonQuery();

                if (filasafectadas > 0)
                {
                    MessageBox.Show("La operacion se ha realizado correctamente", "la base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("No se ha conectado con la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        #region actualizar Data Grid View

        public void actualizarDataGridView(DataGridView dg, string consulta)

        {

            conectarConLaBaseDedatos();


            System.Data.DataSet ds = new System.Data.DataSet();

            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(consulta, conn);

            da.Fill(ds, "Clientes");

            dg.DataSource = ds;
            dg.DataMember = "Clientes";


            deconectarLaBaseDeDatos();
        }


        #endregion actualizar Data Grid View









    }
}
