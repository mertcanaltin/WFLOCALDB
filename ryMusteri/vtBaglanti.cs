using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryMusteri
{
    public class vtBaglanti
    {
        public static string vtAdres = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" 
            + Environment.CurrentDirectory + "\\data\\musteri.mdf;Integrated Security = True;";
            //"Data Source=localhost;Initial Catalog=musteri;" +"Integrated Security=true;";

        //public static string vtAdres = "Data Source=localhost;Initial Catalog=musteri;" +
        //    "User ID=sa;Password=mmyo;";
    }
}
