using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfSysOtica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }

        SqlConnection conn;
        SqlCommand comm;
        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "MRX-PC\\MSSQLSERVERSYSOT";
            connStringBuilder.InitialCatalog = "SysOtica";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;


            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();

        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Cliente GetCliente(Cliente c)
        {
            Cliente cliente = new Cliente();
            try
            {
                comm.CommandText = "SELECT * FROM cliente WHERE cl_id = @cl_id";
                comm.Parameters.AddWithValue("cl_id", c.cl_id);
                comm.CommandType = System.Data.CommandType.Text;

                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cliente.cl_id = Convert.ToInt32(reader[0]);
                     cliente.cl_nome = reader[1].ToString();
                     cliente.cl_datanascimento = Convert.ToDateTime(reader[2]);
                     cliente.cl_cpf = reader[3].ToString();
                     cliente.cl_rg = reader[4].ToString();
                     cliente.cl_telefone = reader[5].ToString();
                     cliente.cl_celular = reader[6].ToString();
                     cliente.cl_telefone2 = reader[7].ToString();
                     cliente.cl_cep = reader[8].ToString();
                     cliente.cl_endereco = reader[9].ToString();
                     cliente.cl_numero = reader[10].ToString();
                     cliente.cl_bairro = reader[11].ToString();
                     cliente.cl_cidade = reader[12].ToString();
                     cliente.cl_uf = reader[13].ToString();
                     cliente.cl_email = reader[14].ToString();
                     cliente.cl_nomepai = reader[15].ToString();
                     cliente.cl_nomemae = reader[16].ToString();
                     cliente.cl_profissao = reader[17].ToString();
                     cliente.cl_observacoes = reader[18].ToString();

                }
                return cliente;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }



    }
}
