using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace metal_archives
{
    class DbManagment
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["metal_archives.Properties.Settings.metal_archivesConnectionString"].ConnectionString;

        public void insertToTable(string name, string genre, string country, string year, string logoSrc, string photoSrc)
        {
            SqlConnection con = new SqlConnection(connectionString);
            {
                SqlCommand query = new SqlCommand("INSERT INTO FavBands (Name, Genre, Country, Year, LogoSrc, PhotoSrc) " +
                                "VALUES (@name, @genre, @country, @year, @logoSrc, @photoSrc)", con);
                query.Parameters.AddWithValue("@name", name);
                query.Parameters.AddWithValue("@genre", genre);
                query.Parameters.AddWithValue("@country", country);
                query.Parameters.AddWithValue("@year", year);
                query.Parameters.AddWithValue("@logoSrc", logoSrc);
                query.Parameters.AddWithValue("@photoSrc", photoSrc);

                try
                {
                    con.Open();
                    query.ExecuteNonQuery();
                    MessageBox.Show(name + ": dodano do ulubionych");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Wystapil blad");
                }
                finally
                {
                    con.Close();
                }

            }
        }

        public DataTable displayData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM FavBands";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
            
        }

        public void delete(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE FROM FavBands WHERE Id = '" + id + "'";
            try {
                con.Open();
                cmd.ExecuteNonQuery();
            } catch (SqlException)
            {
                MessageBox.Show("Wystapil blad");
            } finally
            {
                con.Close();
            }
        }

        public void update (int id, string genre)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE FavBands SET Genre = '" + genre + "' WHERE Id = '" + id + "'";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            } catch (SqlException)
            {
                MessageBox.Show("Wystapil blad");
            } finally
            {
                con.Close();
            }
            
        }
    
        public List<string> showBand(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);  
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM FavBands WHERE Id = '" + id + "'";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> bandInfo = new List<string>();

            while (reader.Read())
            {
                bandInfo.Add(reader["Name"].ToString());
                bandInfo.Add(reader["Genre"].ToString());
                bandInfo.Add(reader["Country"].ToString());
                bandInfo.Add(reader["Year"].ToString());
                bandInfo.Add(reader["LogoSrc"].ToString());
                bandInfo.Add(reader["PhotoSrc"].ToString());
            }

            return bandInfo;
        }

        public string TestDBConnection()
        {

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            con.Close();
            return "Connection Open ! ";

        }

    }


}

