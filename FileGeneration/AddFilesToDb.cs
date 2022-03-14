using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileGeneration
{
    public class AddFilesToDb
    {
        
        DbContext dbContext = new DbContext();
        public void AddFilesToDataBase()
        {
            string line;
            string conString = "Server = R0MANGA; Database = webdb; Trusted_Connection = True;";
           using SqlConnection connection = new SqlConnection(conString);
            {
                connection.Open();

                dbContext.openConnection(connection);
                using (StreamReader file = new StreamReader(@"D:\test\Test1.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] fields = line.Split("//");
                        fields = fields.Where(c => !string.IsNullOrEmpty(c)).ToArray();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [Table](randomDate, randomEngSymbols, randomRuSymbols, randomInt, randomDouble) VALUES (@randomDate, @randomEngSymbols, @randomRuSymbols, @randomInt, @randomDouble)", connection);
                        cmd.Parameters.AddWithValue("@randomDate", fields[0].ToString());
                        cmd.Parameters.AddWithValue("@randomEngSymbols", fields[1].ToString());
                        cmd.Parameters.AddWithValue("@randomRuSymbols", fields[2].ToString());
                        cmd.Parameters.AddWithValue("@randomInt", fields[3]);
                        cmd.Parameters.AddWithValue("@randomDouble", float.Parse(fields[4]));
                        cmd.ExecuteNonQuery();


                    }
                }
            }

        }
        


    }
}
