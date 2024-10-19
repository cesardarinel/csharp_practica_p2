using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Configuration; // Necesario para leer app.config

namespace ProyectosDiversos
{
    public class Conexion
    {
        private SqlConnection conectar;

        public  Conexion() {
            string stringconexion = "server=DESKTOP-MDEV8MC\\SQLEXPRESS;database=p2;Integrated Security=true";
            // "server=SERVIDORSQL\\SQLEXPRESS;database=p2;User Id=sa;Password=123456;Integrated Security=true";
            conectar = new SqlConnection(stringconexion);
           
        }
        private SqlConnection GetConexion()
        {
           conectar.Open();
           return conectar;
        }
        public DataTable ExecuteQuery(string sql, SqlParameter[] parametros = null)
        {
            using (SqlConnection conectar = GetConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conectar))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    DataTable table = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    desconectar();
                    return table;
                }
            }
        }
        public void Eliminar(string sql)
        {
            using (SqlConnection conectar = GetConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conectar))
                {
                    cmd.ExecuteNonQuery();
                    desconectar();
                }
            }
        }
        public void ExecuteNonQuery(string sql, SqlParameter[] parametros=null)
        {
            using (SqlConnection conectar = GetConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conectar))
                {
                    if (parametros != null) { 
                        cmd.Parameters.AddRange(parametros);
                    }
                    cmd.ExecuteNonQuery();
                    desconectar();
                }
            }
        }

        public int ObtenerNextId(string nombreTabla, string nombreColumnaId)
        {
            string sql = $"SELECT isnull(MAX({nombreColumnaId}),0)+1 FROM {nombreTabla}";
            DataTable result = ExecuteQuery(sql);
            if (result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToInt32(result.Rows[0][0]);
            }
            return 0; // Retorna 0 si no hay registros
        }
        private void desconectar()
        {
            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool ValidarCredenciales(string usuario, string contrasena)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM usuario WHERE nom_usu = @usuario AND cla_usu = @contrasena";
                SqlParameter[] parametros = {
            new SqlParameter("@usuario", usuario),
            new SqlParameter("@contrasena", contrasena)
        };

                DataTable result = ExecuteQuery(sql, parametros);
                if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
                {
                    return true; // Credenciales válidas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar credenciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false; // Credenciales no válidas
        }

    }
}
