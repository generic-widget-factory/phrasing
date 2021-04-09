using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using TechLibrary.Domain;

namespace TechLibrary.Data
{
    /// <summary>
    /// Library to perform Sqlite queries vs. leadDB database
    /// </summary>
    public interface IDataQuery
    {
        Task<List<Agency>> GetAgenciesAsync();
    }

    public class DataQuery : IDataQuery
    {
        /// <summary>
        /// Get all Agencies via Sqlite query
        /// </summary>
        /// <returns></returns>
        public async Task<List<Agency>> GetAgenciesAsync()
        {
            var agencies = new List<Agency>();

            try
            {
                using (SqliteConnection conn = new SqliteConnection("Data Source=leadDB.db;"))
                {
                    conn.Open();
                    var sql = @"select * from agency;";
                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            await Task.Run(() =>
                            {
                                while (reader.Read())
                                {
                                    //var subAmt = 0;
                                    //int.TryParse(reader["subsidyAmount"].ToString(), out subAmt);
                                    var agency = new Agency
                                    {
                                        Id = int.Parse(reader["id"].ToString()),
                                        Address = (string)reader["address"],
                                        ApplySubsidy = int.Parse(reader["applySubsidy"].ToString()),
                                        City = (string)reader["city"],
                                        CompanyName = (string)reader["companyName"],
                                        CreateDate = Convert.ToDateTime(reader["createDate"].ToString()),
                                        Email = (string)reader["email"],
                                        Phone = (string)reader["phone"],
                                        PostalCode = (string)reader["postalCode"],
                                        State = (string)reader["state"],
                                        SubsidyAmount = decimal.Parse(reader["subsidyAmount"].ToString()),
                                    };
                                    agencies.Add(agency);
                                }
                            });
                        }
                    }
                    conn.Close();
                }
            }
            catch (SqliteException e)
            {
                Console.WriteLine(e);
            }

            return agencies;
        }
    }
}
