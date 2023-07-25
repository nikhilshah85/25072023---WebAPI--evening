namespace greetingsAPI.Models
{
    public class ProductDetails
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
         public string pDescription { get; set; }
        public double pPrice { get; set; }

        public bool pIsInStock { get; set; }
        #endregion


        #region Methods
        public ProductDetails Getproductinfo()
        {
            ProductDetails pObj = new ProductDetails()
            {
                pId = 101,
                pName = "Pepsi",
                pDescription = "Cold Drink",
                pIsInStock = true,
                pPrice = 70
            };
            return pObj;
        }
        #endregion


    }
}
