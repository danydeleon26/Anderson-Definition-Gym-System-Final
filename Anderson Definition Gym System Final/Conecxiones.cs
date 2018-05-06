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
            conn.Open();

        }

        #endregion conectar con la base de datos


        #region deconectar la base de datos

        public void deconectarLaBaseDeDatos()
        {

            conn.Close();

        }

        #endregion deconectar la base datos

    
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
