using Supermarket.Model;
using Supermarket.Model;
using System;
using System.Collections.Generic;

namespace Supermarket.Bussines
{
    internal class ProductsDAO
    {
        private readonly Dictionary<int, Products> ProductsList;
        private static int ProductsSecuencial;

        public ProductsDAO()
        {
            ProductsList = new Dictionary<int, Products>();
            ProductsSecuencial = 0;
        }

        public bool AddProducts(Products products)
        {
            try
            {
                products.Id = ++ProductsSecuencial;
                ProductsList.Add((int)products.Id, products);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public bool RemoveProducts(int id)
        {
            bool IdsExists = ProductsList.ContainsKey(id);
            if (IdsExists)
            {
                ProductsList.Remove(id);
                return true;
            }
            return false;
        }

        public Products GetProducts(int id)
        {
            bool idExists = ProductsList.ContainsKey(id);
            if (idExists)
            {
                return ProductsList[id];
            }
            return null;
        }

        public bool UpdateProducts(int id, Products products)
        {
            bool idExists = ProductsList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    ProductsList[id] = products;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public Dictionary<int, Products> GetProductsList()
        {
            return ProductsList;
        }
    }
}

