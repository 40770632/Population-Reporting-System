using System;
using MySql.Data.MySqlClient;

/// <summary>
/// Handles all database interactions for the Population Reporting System.
/// </summary>
public class DatabaseClass
{
    // Connection string to connect to MySQL database
    private string connectionString = "server=localhost;database=world;user=root;password=;";

    /// <summary>
    /// Retrieves a list of countries sorted by population (largest to smallest).
    /// </summary>
    public void GetCountriesByPopulation()
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "SELECT Code, Name, Continent, Region, Population, Capital FROM country ORDER BY Population DESC;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n Countries Ordered by Population:");
                        Console.WriteLine("------------------------------------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine($"Code: {reader["Code"]}, Name: {reader["Name"]}, " +
                                              $"Continent: {reader["Continent"]}, Region: {reader["Region"]}, " +
                                              $"Population: {reader["Population"]}, Capital: {reader["Capital"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error fetching country data: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// Retrieves the top N populated cities in a specific continent.
    /// </summary>
    public void GetTopCitiesInContinent(string continent, int topN)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                // Check if the continent exists before proceeding
                string checkQuery = "SELECT COUNT(*) FROM country WHERE Continent = @Continent;";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Continent", continent);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        Console.WriteLine("\n Continent not found! Please check the spelling and try again.");
                        return;
                    }
                }

                // Retrieve top N cities in the specified continent
                string query = "SELECT city.Name, city.CountryCode, city.Population FROM city " +
                               "JOIN country ON city.CountryCode = country.Code " +
                               "WHERE country.Continent = @Continent ORDER BY city.Population DESC LIMIT @TopN;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Continent", continent);
                    cmd.Parameters.AddWithValue("@TopN", topN);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine($"\n🏙️ Top {topN} Cities in {continent}:");
                        Console.WriteLine("------------------------------------------------------");

                        bool hasData = false;

                        while (reader.Read())
                        {
                            hasData = true;
                            Console.WriteLine($"Name: {reader["Name"]}, Country: {reader["CountryCode"]}, Population: {reader["Population"]}");
                        }

                        if (!hasData)
                        {
                            Console.WriteLine("\n❌ No cities found for this continent.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error fetching city data: " + ex.Message);
            }
        }
    }

            catch (Exception ex)
            {
                Console.WriteLine(" Error fetching language data: " + ex.Message);
            }
        }
    }
}
