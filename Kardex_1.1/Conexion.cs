using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kardex_1._1
{
    class Conexion
    {
        public static SqlConnection ObtnerConexion()
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=DSPM-VDA23\\SQLEXPRESS;Initial Catalog=Kardex_policial;Integrated Security=True");
            cn.Open();

            return cn;

        }
    }
}
