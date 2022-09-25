using System;

namespace Hizmet_Guncelleme.Tools
{
    class cls_Yol : IDisposable
    {
        public static string SqliteCon = "Data Source=Data/HizmetCRM.db3; Version=3;";
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
