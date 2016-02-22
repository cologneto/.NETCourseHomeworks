using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication2
{
    public class FileOperation
    {
        public const string FilePath = @"C:\Users\colog_000\Desktop\Expenses.txt";

        public static List<Product> ReadProductsFromDataBase()
        {
            var listOfProducts = new List<Product>();

            using (var reader = new StreamReader(FileOperation.FilePath))
            {
                
                var CurrentProduct = reader.ReadLine();

                while (CurrentProduct != null)
                {
                    var currentProduct = CurrentProduct.Split('|');
                    var product = new Product(
                        DateTime.Parse(currentProduct[0].Trim()),
                        currentProduct[1].Trim(),
                        double.Parse(currentProduct[2].Trim()));

                    listOfProducts.Add(product);

                    CurrentProduct = reader.ReadLine();
                }
            }

            return listOfProducts;
        }

        public static bool AddProductToDataBase(Product productToAdd)
        {
            try
            {
                using (var writer = new StreamWriter(FileOperation.FilePath, true))
                {
                    writer.WriteLine(productToAdd);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}