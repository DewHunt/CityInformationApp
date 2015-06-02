using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInformationApp
{
    class City
    {
        public int cityId;
        public string cityName;
        public string cityAbout;
        public string country;
        public string searchData;
        public string searchVariable;
        public string buttonName;
        public bool clearTextMode = false;

        public List<City> showAllCityList = new List<City>();

        public string connectionString = @"server = EINSTINE; Database = CityInfoDB; Integrated Security = true";
        public void SaveCityInfo()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            if (cityName.Length < 4)
            {
                MessageBox.Show("City Name Must be in 4 Characters....");
            }
            else
            {
                if (buttonName == "Update")
                {
                    string updateQuery = "UPDATE cityinfo SET about ='" + cityAbout + "', country ='" + country + "' WHERE id = '" + searchData + "'";

                    SqlCommand updatwCommand = new SqlCommand(updateQuery, connection);

                    connection.Open();
                    int rowAffected = updatwCommand.ExecuteNonQuery();
                    connection.Close();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully!");
                        clearTextMode = true;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!");
                    }
                }
                else
                {
                    string cityNameExists = "SELECT * FROM cityinfo WHERE cityname = '" + cityName + "'";

                    SqlCommand cityNameExistsCommand = new SqlCommand(cityNameExists, connection);

                    connection.Open();
                    SqlDataReader productCodeExistsReader = cityNameExistsCommand.ExecuteReader();
                    bool cityNameStatus = productCodeExistsReader.HasRows;
                    connection.Close();

                    if (cityNameStatus)
                    {
                        MessageBox.Show(cityName + ", Already Saved in Database, Try with another");
                    }
                    else
                    {
                        string saveQuery = "INSERT INTO cityinfo VALUES ('" + cityName + "','" + cityAbout +
                                           "','" + country + "')";
                        SqlCommand saveCommand = new SqlCommand(saveQuery, connection);

                        connection.Open();
                        int rowAffected = saveCommand.ExecuteNonQuery();
                        connection.Close();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Data Sasve Successfully...");
                            clearTextMode = true;
                        }
                        else
                        {
                            MessageBox.Show("Data Not Saved");
                        }
                    }
                }
            }
        }

        public void ShowAllcityInfo()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string showAllCityQuery = "SELECT * FROM cityinfo";
            SqlCommand showAllCityCommand = new SqlCommand(showAllCityQuery, connection);

            connection.Open();
            SqlDataReader showAllCityReader = showAllCityCommand.ExecuteReader();

            while (showAllCityReader.Read())
            {
                City showCity = new City();
                showCity.cityId = Convert.ToInt32(showAllCityReader["id"].ToString());
                showCity.cityName = showAllCityReader["cityname"].ToString();
                showCity.cityAbout = showAllCityReader["about"].ToString();
                showCity.country = showAllCityReader["country"].ToString();

                showAllCityList.Add(showCity);
            }
            showAllCityReader.Close();
            connection.Close();
        }

        public void SearchCityInfo()
        {
            //searcButtonStatus = false;
            SqlConnection connection = new SqlConnection(connectionString);

            string searchCityQuery = "SELECT * FROM cityinfo WHERE "+searchVariable+" LIKE '%"+searchData+"%'";
            SqlCommand searchCityCommand = new SqlCommand(searchCityQuery, connection);

            connection.Open();
            SqlDataReader searchCityReader = searchCityCommand.ExecuteReader();
            bool searchStatus = searchCityReader.HasRows;

            if (searchStatus)
            {
                while (searchCityReader.Read())
                {
                    City showCity = new City();
                    showCity.cityId = Convert.ToInt32(searchCityReader["id"].ToString());
                    showCity.cityName = searchCityReader["cityname"].ToString();
                    showCity.cityAbout = searchCityReader["about"].ToString();
                    showCity.country = searchCityReader["country"].ToString();

                    showAllCityList.Add(showCity);
                }
            }
            else
            {
                MessageBox.Show("Data not Found...");
            }
            searchCityReader.Close();
            connection.Close();
        }
    }
}
