namespace di_demo.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }

        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=80 },
            new Products(){ pId=102, pName="IPhone", pCategory="Electronics", pIsInStock=false, pPrice=80 },
            new Products(){ pId=103, pName="Latte", pCategory="Coffee", pIsInStock=true, pPrice=80 },
            new Products(){ pId=104, pName="Maggie", pCategory="FastFood", pIsInStock=false, pPrice=80 },
            new Products(){ pId=105, pName="Fossil Q", pCategory="Electronics", pIsInStock=true, pPrice=80 },
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }


    }
}
