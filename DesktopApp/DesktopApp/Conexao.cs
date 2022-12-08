using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DesktopApp
{
    public class Conexao
    {
        static private string server = "localhost";
        static private string database = "sistema_rh";
        static private string password = "";
        static private string user = "root";
        static private string strConn = $"server={server}; UserId={user}; password={password}; database={database};";

        MySqlConnection cn;

        private bool Conectar()
        {
            bool result;
            try
            {
                cn = new MySqlConnection(strConn);
                cn.Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        private bool Desconectar()
        {
            try
            {
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Executa(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, cn);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable Retorna(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
