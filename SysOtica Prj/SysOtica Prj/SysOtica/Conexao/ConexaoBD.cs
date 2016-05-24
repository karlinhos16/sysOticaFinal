using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public class ConexaoBD : IConexaoBD
    {

        public SqlConnection cone = new SqlConnection();

        string connectionStringSqlServer = @"Data Source=DESKTOP-KA9UELE\SQLEXPRESS;Initial Catalog=sysOtica   ;UId=sysotica ;Password=12345";

        public ConnectionState State { get; internal set; }

        //DESKTOP-KA9UELE\SQLEXPRESS
        //@"Data Source=PC-DAYSE\SQLEXPRESS;Initial Catalog=sysOtica   ;UId=sysotica ;Password=12345";
        //MRX-PC\MSSQLSERVERSYSOT

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