using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace OrientedModel_Crud_Operations
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string password = "Admin123!";
            string id = "felixadmin";
            string connectionString = $"Server=tcp:sqldatabase-edenborgh.database.windows.net,1433;Initial Catalog=SqlDatabase_WithData;Persist Security Info=False;User ID={id};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            cn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string cname = textBox_CompanyName.Text;
            decimal listprice = decimal.Parse(textBox_listPrice.Text);

            string productNumber = "PN" + random.Next(1000, 9999).ToString(); // Random product number
            string[] colors = { "Red", "Green", "Blue", "Black", "White" };
            string color = colors[random.Next(colors.Length)]; // Random color
            decimal standardCost = (decimal)(random.NextDouble() * 100); // Random standard cost between 0 and 100
            string[] sizes = { "S", "M", "L", "XL" };
            string size = sizes[random.Next(sizes.Length)]; // Random size
            decimal weight = (decimal)(random.NextDouble() * 10); // Random weight between 0 and 10
            int productCategoryID = random.Next(1, 10); // Random category ID between 1 and 9
            int productModelID = random.Next(1, 10); // Random model ID between 1 and 9
            DateTime sellStartDate = DateTime.Now; // Example start date
            byte[] thumbnailPhoto = new byte[0]; // Example thumbnail photo
            string thumbnailPhotoFileName = "example.jpg"; // Example thumbnail photo file name
            Guid rowguid = Guid.NewGuid(); // Example rowguid
            DateTime modifiedDate = DateTime.Now; // Example modified date

            cmd.Parameters.Clear();
            // Adjust the column names in the INSERT statement as per your table definition
            cmd.CommandText = @"INSERT INTO SalesLT.Product 
                        (Name, ProductNumber, Color, StandardCost, ListPrice, Size, Weight, ProductCategoryID, ProductModelID, SellStartDate, ThumbNailPhoto, ThumbnailPhotoFileName, rowguid, ModifiedDate) 
                        VALUES 
                        (@cname, @productNumber, @color, @standardCost, @listprice, @size, @weight, @productCategoryID, @productModelID, @sellStartDate, @thumbnailPhoto, @thumbnailPhotoFileName, @rowguid, @modifiedDate)";

            cmd.Parameters.AddWithValue("@cname", cname);
            cmd.Parameters.AddWithValue("@productNumber", productNumber);
            cmd.Parameters.AddWithValue("@color", color);
            cmd.Parameters.AddWithValue("@standardCost", standardCost);
            cmd.Parameters.AddWithValue("@listprice", listprice);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@weight", weight);
            cmd.Parameters.AddWithValue("@productCategoryID", productCategoryID);
            cmd.Parameters.AddWithValue("@productModelID", productModelID);
            cmd.Parameters.AddWithValue("@sellStartDate", sellStartDate);
            cmd.Parameters.AddWithValue("@thumbnailPhoto", thumbnailPhoto);
            cmd.Parameters.AddWithValue("@thumbnailPhotoFileName", thumbnailPhotoFileName);
            cmd.Parameters.AddWithValue("@rowguid", rowguid);
            cmd.Parameters.AddWithValue("@modifiedDate", modifiedDate);

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();

            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Product Added Successfully.... Success");
        }

        private void button_Preview_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
        SELECT * 
        FROM SalesLT.Product
        ORDER BY ProductID DESC
        OFFSET 0 ROWS
        FETCH NEXT 10 ROWS ONLY";

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select listprice from SalesLT.Product where Name = @cname";
            cmd.Parameters.AddWithValue("@cname", textBox_CompanyName.Text);

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();

            decimal listprice;
            listprice = (decimal)cmd.ExecuteScalar();
            textBox_listPrice.Text = listprice.ToString();
            cn.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string cname = textBox_CompanyName.Text;
            decimal listprice = decimal.Parse(textBox_listPrice.Text);

            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE SalesLT.Product SET ListPrice = @listprice WHERE Name = @cname";
            cmd.Parameters.AddWithValue("@listprice", listprice);
            cmd.Parameters.AddWithValue("@cname", cname);

            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();

            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Company Data Updated.... Success");
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            string cname = textBox_CompanyName.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete from SalesLT.Product where Name = @cname";
            cmd.Parameters.AddWithValue("@cname", cname);

            if(cn.State == System.Data.ConnectionState.Closed)
                cn.Open();

            cmd.ExecuteNonQuery(); 
            cn.Close();

            MessageBox.Show("Company Records Removed... Success");
            textBox_CompanyName.Clear();
            textBox_listPrice.Clear();
        }
    }
}
