using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class MovieRepository
    {
        private string ConnectionString = "Server=(localdb)\\MsSQLLocalDB;Database=MovieRentalManagement;Trusted_Connection=true;TrustedServerCertificate=true;";
        public void CreateMovie(string movieId, string title, string director, string rentalPrice)
        {
            try
            {
                using (SqlConnection connection= new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Movies(MovieId, Title, Director, RentalPrice)VALUES(@MovieId, @Title , @Director, @RentalPrice)";
                    using (SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.Parameters.AddWithValue("@Title",title);
                        cmd.Parameters.AddWithValue("@Director",director);
                        cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }

        public void ReadMovies(string movieId, string title, string director, string rentalPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Movies";
                    using (SqlCommand cmd = new SqlCommand(query, connection)) ;
                    using SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    while (reader.Read())
                    {
                        return $"MovieId:{ [movieId]},title:{ [title]},Director:{ [director]},RentalPrice:{ [rentalPrice]}";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            
        }

        public void UpdateMovie(string movieId, string title, string director, string rentalPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Movies SET MovieID=@MovieId , Title=@Title , Director=@Director , RentalPrice=@RentalPrice WHERE MovieId=@MovieId";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Director", director);
                        cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            Console.WriteLine("Successfully Updated");
                        }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }

        public void DeleteMovie(string movieId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "DELETE Movies  WHERE MovieId=@MovieId";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            Console.WriteLine("Successfully Deleted");
                        }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }

        public void CapitalizeTitle(string title)
        {
           var words = title.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > 0)
                {
                    string word = words[i][0].ToString().ToUpper() + words[i][1].ToString().ToLower();
                }
            }
            
     
        }
    }
}
