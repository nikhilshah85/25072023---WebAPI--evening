using System.Globalization;

namespace shoppingAPI_inMemoryCollection.Entities
{
    public class Products
    {

        #region Properties
        public int pId { get; set; }

        public string pName { get; set; }
        public string pCategory { get; set; }
        public string pDescription { get; set; }
        public double pPrice { get; set; }

        public bool pIsInStock { get; set; }
        #endregion

        #region Data
        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pDescription="Chilled Black water to kill the thirst", pIsInStock=true, pPrice=80},
            new Products(){ pId=102, pName="IPhone", pCategory="Electronics", pDescription="Make Smart calls", pIsInStock=false, pPrice=80},
            new Products(){ pId=103, pName="Dell Lattitude", pCategory="Electronics", pDescription="Working Professionals", pIsInStock=true, pPrice=80},
            new Products(){ pId=104, pName="Fossil Q", pCategory="Electronics", pDescription="Check the time", pIsInStock=true, pPrice=80},
            new Products(){ pId=105, pName="Nike Air", pCategory="Sports", pDescription="Win the race - do it right", pIsInStock=false, pPrice=80},
            new Products(){ pId=106, pName="Adidas", pCategory="Sports", pDescription="Beat the race", pIsInStock=true, pPrice=80},
        };
        #endregion

        #region Methods
        public List<Products> GetAllProducts()
        {
            return pList;
        }

        public Products GetproductById(int id)
        {
            var prod = pList.Find(pr => pr.pId == id);
            if (prod != null)
            {
                return prod;
            }
            throw new Exception("Product Not Found");
        }

        public List<Products> GetProductByCategory(string category)
        {
            var products = pList.FindAll(pr => pr.pCategory == category);
            if (products.Count > 1)
            {
                return products;
            }
            throw new Exception("No Product under this category");
        }

        public int GetTotalProducts()
        {
            return pList.Count;
        }

        public string AddProduct(Products newProductDetails)
        {
            //do some data validation, calculation, formatting if needed
            pList.Add(newProductDetails);
            return "Product Added Successfully";
        }

        public string DeleteProduct(int pId)
        {
            var prod = pList.Find(pr => pr.pId == pId);
            if (prod != null)
            {
                pList.Remove(prod);
                return "Product Deleted Successfully";
            }
            throw new Exception("Product Not Found");
        }

        public string UpdateProduct(Products changes)
        {
            var prod = pList.Find(pr => pr.pId == changes.pId);
            if (prod != null)
            {
                prod.pName = changes.pName;
                prod.pPrice = changes.pPrice;
                prod.pCategory = changes.pCategory;
                prod.pIsInStock = changes.pIsInStock;
                prod.pDescription = changes.pDescription;

                return "Product Updated Successfully";
            }
            throw new Exception("Product Not Found");

        }

        #endregion
    }
}












