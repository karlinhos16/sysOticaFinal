using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public class ConexaoBD : IConexaoBD
    {

        public SqlConnection cone = new SqlConnection();
        string connectionStringSqlServer = @"Data Source=DESKTOP-KA9UELE\SQLEXPRESS ;Initial Catalog= SysOtica ;UId= sysotica ;Password= 123456";
        //DESKTOP-KA9UELE\SQLEXPRESS
        public void AbrirConexao()
        {
            this.cone = new SqlConnection(connectionStringSqlServer);
            this.cone.Open();
        }
        public void FecharConexao()
        {
            this.cone.Close();
            this.cone.Dispose();
        }
    }
}