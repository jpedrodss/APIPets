using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIPets.Context
{
    public class ClinicaContext
    {
        SqlConnection con = new SqlConnection();

        public ClinicaContext()
        {
            con.ConnectionString = @"Data Source=JoaoPedro\SQLEXPRESS;Initial Catalog=ClinicaVeterinaria;User ID=sa;Password=sa132;";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public SqlConnection Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            return con;
        }
    }
}
