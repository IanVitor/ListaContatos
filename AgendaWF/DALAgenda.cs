using System.Data.SQLite;
using System.Data;

namespace AgendaWF
{
    public class DALAgenda
    {
        public static string path = Directory.GetCurrentDirectory() + "//banco.sqlite";
        private static SQLiteConnection conn;

        private static SQLiteConnection dbConnection()
        {
            conn = new SQLiteConnection("Data Source="+path);
            conn.Open();
            return conn;
        }

        public static void criarBancoSQLite()
        {
            try
            {
                if(!File.Exists(path))
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch
            {
                throw;
            }
        }

        public static void criarTabelaSQLite()
        {
            try
            {
                using(var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Contatos(id int, nome varchar(50), email varchar(80))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getContatos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos";
                    da = new SQLiteDataAdapter(cmd.CommandText, dbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getContato(string nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos WHERE nome like '%"+nome+"%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, dbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(Contato contato)
        {
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Contatos(id, nome, email) VALUES (@id, @nome, @email)";
                    cmd.Parameters.AddWithValue("@id", contato.Id);
                    cmd.Parameters.AddWithValue("@nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@email", contato.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Contato contato)
        {
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Contatos SET nome=@nome, email=@email WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", contato.Id);
                    cmd.Parameters.AddWithValue("@nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@email", contato.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Contatos WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
