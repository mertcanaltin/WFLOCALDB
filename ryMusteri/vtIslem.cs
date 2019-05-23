using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryMusteri
{
    public class vtIslem
    {
        #region Tanımlama
         static SqlConnection musConn = new SqlConnection(vtBaglanti.vtAdres);
         static SqlDataAdapter musAdp;
         static SqlCommand musCmd = new SqlCommand();
        #endregion
        #region Kullanıcı Tanımlı Metod
        public static DataTable veriGetir(string sorgu)
        {
            DataTable musTablo = new DataTable();
            musTablo.Clear();
            musAdp = new SqlDataAdapter(sorgu, musConn);
            musAdp.Fill(musTablo);
            return musTablo;
        }

        public static void komutCalistir(string sorgu)
        {
            try
            {
                if (musConn.State == ConnectionState.Closed)
                    musConn.Open();
                musCmd.Connection = musConn;
                musCmd.CommandText = sorgu;
                musCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Bilgi",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                musConn.Close();
            }
        }
        #endregion
    }
}
