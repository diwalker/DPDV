using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPDV
{
    class conexao
    {
        public string conec = "Data Source=D:\\Backup\\Projects\\DPDV\\banco\\dpdv.db;Version=3;";


        public SQLiteConnection con = null;

        public void AbrirConexao()
        {
            con = new SQLiteConnection(conec);
            con.Open();
        }

        public void FecharConexao()
        {
            con = new SQLiteConnection(conec);
            con.Close();
            con.Dispose();
            
        }
    }
}
