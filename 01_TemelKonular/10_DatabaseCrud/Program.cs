using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region baslık
            //Crud --> Create-Read-Update-Delete

            //Console.Write("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("-------------------------");

            #endregion

            #region kategori Ekleme İşlemi
            //Console.Write("Eklemek İştediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;initial catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into tbl_category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("Kategori başarıyla eklendi!");

            #endregion


            #region Ürün Ekleme İşlemi

            // string productName;
            // decimal productPrice;
            //// bool productStatus;

            // Console.Write("Eklemek istediğiniz ürün adı: ");
            // productName = Console.ReadLine();
            // Console.Write("Ürün Fiyatı: ");
            // productPrice = decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS; initial catalog=EğitimKampiDb;integrated security=true");
            // connection.Open();
            // SqlCommand command = new SqlCommand("insert into tbl_product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // command.ExecuteNonQuery();
            // connection.Close();
            // Console.Write("Ürün eklemesi başarılı");


            #endregion


            #region Ürün listeleme
            //SqlConnection connection = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS; initial catalog=EğitimKampiDb;integrated security=true");
            //SqlCommand command = new SqlCommand("select * from tbl_product",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS; initial catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("delete from tbl_product where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Silme işlemi yapıldı!");

            #endregion


            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id:");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellencek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS; initial catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update tbl_product set productName=@productName, productPrice=@productPrice where productId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");

            #endregion

            //Console.Read();
        }
    }
}
