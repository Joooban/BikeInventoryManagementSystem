using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BikeShopManagement
{
    public partial class Reports : UserControl
    {
        private SqlConnection connection;

        public Reports()
        {
            InitializeComponent();
            Koneksyon koneksyon = new Koneksyon();
            connection = koneksyon.GetConnection();

            try
            {
                LoadMostSoldProducts();
                LoadMostProfitableProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading reports: " + ex.Message);
                // Optionally log the error to a file or other logging mechanism
            }
        }

        private void LoadMostSoldProducts()
        {
            try
            {
                string query = "SELECT TOP 10 ProductName, SUM(QuantitySold) AS TotalQuantity FROM Sales GROUP BY ProductName ORDER BY TotalQuantity DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                mostSoldChart.Series.Clear();
                Series series = new Series("Most Sold Products");
                series.ChartType = SeriesChartType.Line; // Change to Line chart type

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.AddXY(row["ProductName"], row["TotalQuantity"]);
                }

                mostSoldChart.Series.Add(series);
                mostSoldChart.ChartAreas[0].AxisX.Title = "Products";
                mostSoldChart.ChartAreas[0].AxisY.Title = "Quantity Sold";
                mostSoldChart.Titles.Clear();
                mostSoldChart.Titles.Add("Top 10 Most Sold Products");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message);
            }
        }

        private void LoadMostProfitableProducts()
        {
            try
            {
                string query = "SELECT TOP 10 ProductName, SUM(SalePrice) AS TotalProfit FROM Sales GROUP BY ProductName ORDER BY TotalProfit DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                mostProfitableChart.Series.Clear();
                Series series = new Series("Most Profitable Products");
                series.ChartType = SeriesChartType.Bar; // Change to Bar chart type

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.AddXY(row["ProductName"], row["TotalProfit"]);
                }

                mostProfitableChart.Series.Add(series);
                mostProfitableChart.ChartAreas[0].AxisX.Title = "Products";
                mostProfitableChart.ChartAreas[0].AxisY.Title = "Total Profit";
                mostProfitableChart.Titles.Clear();
                mostProfitableChart.Titles.Add("Top 10 Most Profitable Products");

                // Additional properties for better label visibility
                mostProfitableChart.ChartAreas[0].AxisX.Interval = 1; // Ensure all labels appear
                mostProfitableChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate labels for better spacing
                mostProfitableChart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8);

                // Show value labels above bars
                series.IsValueShownAsLabel = true;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error while loading most profitable products: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading most profitable products: " + ex.Message);
            }
        }

        private void mostProfitableChart_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
