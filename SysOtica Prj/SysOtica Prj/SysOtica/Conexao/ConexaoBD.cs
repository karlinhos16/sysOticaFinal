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
        string connectionStringSqlServer = @"Data Source=MRX-PC\MSSQLSERVERSYSOT ;Initial Catalog= sysOtica ;UId= root ;Password= 123456";
        //MRX-PC\MSSQLSERVERSYSOT Leo
        //DESKTOP-G6CQ56U Dayse

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