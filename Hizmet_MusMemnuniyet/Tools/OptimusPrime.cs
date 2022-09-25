using System;
using System.Data;
using System.Data.SqlClient;
using Hizmet_MusMemnuniyet.Properties;

namespace Hizmet_MusMemnuniyet.Tools
{
    class OptimusPrime : IDisposable
    {
        private static string Conico = "Data Source=.; Database=HizmetCRM_DB; Trusted_Connection=true;";

        public static string SqliteCon = "Data Source=Data/HizmetCRM.db3; Version=3;";

        //public static string OptimusGeliyorKacin(string _strProgramAdi)
        //{
        //    SqlConnection con = new SqlConnection(Conico);
        //    string versiyon = "0,0";
        //    SqlCommand com = new SqlCommand("select MAX(Versiyon) from aGelisimsoft_Program_Guncelleme where IsActive=1 and Program=@P", con);
        //    com.Parameters.AddWithValue("@P", _strProgramAdi);
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }
        //    SqlDataReader dr = com.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        while (dr.Read())
        //        {
        //            versiyon = dr[0].ToString();
        //        }
        //    }
        //    con.Close();
        //    com.Dispose();
        //    dr.Close();
        //    return versiyon;
        //}
        public static DataTable OptimusGeliyorEkibiIle(string _strProgramAdi, string _strProgramVer)
        {
            SqlConnection con = new SqlConnection(Conico);
            SqlDataAdapter com = new SqlDataAdapter("select Tarih,Versiyon,Aciklama from aGelisimsoft_Program_Guncelleme where IsActive=1 and Program=@P and Versiyon > @PVer", con);
            com.SelectCommand.Parameters.AddWithValue("@P",_strProgramAdi);
            com.SelectCommand.Parameters.AddWithValue("@PVer", _strProgramVer);
            DataTable dt = new DataTable();
            com.Fill(dt);
            return dt;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
