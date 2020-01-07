using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.website.DAL;
using com.website.Model;

namespace com.website.BLL
{
    public static class ProductManager
    {
        static ProductService PS = new ProductService();
        static OrderService OS = new OrderService();

        public static IList<ProductInfo> GetProductList()
        {
            return PS.GetProducts();
        }

        public static IList<ProductInfo> GetProductList(int topNumber)
        {
            return PS.GetProducts(0, topNumber);
        }

        public static ProductInfo GetProductById(int id)
        {
            return PS.GetById(id);
        }

        public static void AppendProduct(ProductInfo product)
        {
            PS.Append(product);
        }

        public static void DeleteById(int id)
        {
            OS.DeleteByProductID(id);
            PS.DeleteById(id);
        }

        public static void ModifyProduct(ProductInfo product)
        {
            PS.Update(product);
        }

        public static void ModifyProductNoPicture(ProductInfo product)
        {
            ProductInfo oldProduct = PS.GetById(product.ID);
            product.Picture = oldProduct.Picture;
            PS.Update(product);
        }

    }
}
