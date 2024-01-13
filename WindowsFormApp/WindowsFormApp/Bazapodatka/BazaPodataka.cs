using MySql.Data.MySqlClient;

namespace Bazapodataka
{
    public static class BazaPodataka
    {
        public static string Connection = "server=localhost;user=jbiscan;database=mydb;port=3307;password=1234";
        public static MySqlConnection con = new MySqlConnection(Connection);

        // komanda
        public static MySqlCommand cmd;
        public static void NapisiUpit(string upit)
        {
            cmd = new MySqlCommand(upit, con);
        }

        //reader
        public static MySqlDataReader reader;
        public static MySqlDataReader PozoviReadera()
        {
            return reader = cmd.ExecuteReader();
        }

        public static void OtvoriVezu()
        {
            con.Open();
        }

        public static void ZatvoriVezu()
        {
            reader.Close();
            cmd.Dispose();
            con.Close();
        }
    }
}
