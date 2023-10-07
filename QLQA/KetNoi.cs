using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLQA
{
    public class KetNoi
    {
        public string constr = @"Data Source=DESKTOP-ELCA4P1\NAMTRUONG;Initial Catalog=QLQDAN;Integrated Security=True";
        public SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(constr);
        }

        public DataTable LayDuLieu(string q)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, conn);
                DataTable tb = new DataTable();
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }

        public bool ThucThi(string q)
        {
            int r = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                r = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return r > 0;
        }
    }
}
