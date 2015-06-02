using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInformationApp
{
    public partial class CityInformationUI : Form
    {
        public CityInformationUI()
        {
            InitializeComponent();
        }

        City cityinfo = new City();
        private void saveButton_Click(object sender, EventArgs e)
        {
            cityinfo.cityName = cityNameTextBox.Text;
            cityinfo.cityAbout = aboutTextBox.Text;
            cityinfo.country = countryTextBox.Text;

            cityinfo.SaveCityInfo();

            if (cityinfo.clearTextMode)
            {
                ClearTextBox();
                cityinfo.ShowAllcityInfo();
                LoadListBox();
            }
        }

        private void ClearTextBox()
        {
            cityNameTextBox.Clear();
            aboutTextBox.Clear();
            countryTextBox.Clear();
        }

        private void LoadListBox()
        {
            int serial = 1;

            showListView.Items.Clear();

            foreach (var show in cityinfo.showAllCityList)
            {
                ListViewItem item = new ListViewItem(serial.ToString());
                item.SubItems.Add(show.cityName);
                item.SubItems.Add(show.cityAbout);
                item.SubItems.Add(show.country);

                showListView.Items.Add(item);
                serial++;
            }

            cityinfo.showAllCityList = new List<City>();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchcityRadioButton.Checked == true)
            {
                cityinfo.searchData = searchTextBox.Text;
                cityinfo.searchVariable = "cityname";
                cityinfo.SearchCityInfo();

                showListView.Items.Clear();
            }
            else
            {
                if (searchCountryRadioButton.Checked == true)
                {
                    cityinfo.searchData = searchTextBox.Text;
                    cityinfo.searchVariable = "country";
                    cityinfo.SearchCityInfo();

                    showListView.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Please select an Option From Radio Buuton...");
                }
            }
            LoadListBox();
        }

        private void CityInformationUI_Load(object sender, EventArgs e)
        {
            cityinfo.ShowAllcityInfo();
            LoadListBox();
        }

        private void showListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = showListView.SelectedItems[0];

            int id = int.Parse(item.Text.ToString());

            cityinfo.searchData = id.ToString();
            cityinfo.searchVariable = "id";

            cityinfo.SearchCityInfo();

            foreach (var show in cityinfo.showAllCityList)
            {
                cityNameTextBox.Text = show.cityName;
                aboutTextBox.Text = show.cityAbout;
                countryTextBox.Text = show.country;
            }

            cityinfo.buttonName = saveButton.Text = "Update";
            cityNameTextBox.Enabled = false;

            cityinfo.showAllCityList = new List<City>();
        }
    }
}
