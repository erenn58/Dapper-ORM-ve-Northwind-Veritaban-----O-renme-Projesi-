using Dapper;
using Project5_DapperNorthwind.dto.CategoryDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     SqlConnection connection =new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB5project20;Integrated Security = True");
        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "Select * From Categories";
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select Count(*)From  Categories ";
            var count=await connection.ExecuteScalarAsync<int>(query);
            lblcategorycount.Text="Toplam Kategori Sayısı: "+ count;

            string query2 = "Select Count(*) From Products";
            var productcount=await connection.ExecuteScalarAsync<int>(query2);
            lblproductcount.Text = "Toplam Ürün Sayısı:" + productcount;
        }

        private async  void btncratecategory_Click(object sender, EventArgs e)
        {
            string query = "Insert Into Categories(CategoryName,Description) Values (@p1,@p2)";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", txtcategoryname.Text);
            parameters.Add("@p2", txtcatedes.Text);
            await connection.ExecuteAsync(query,parameters);
        }

        private async void  btncategoryDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Categories Where CategoryId=@categoryId";
            var parameters=new DynamicParameters();
            parameters.Add("@categoryId", txtcategoryıd.Text);
            await connection.ExecuteAsync(query, parameters);
        }
    }
}
