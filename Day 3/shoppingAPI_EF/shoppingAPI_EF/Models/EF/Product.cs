using System;
using System.Collections.Generic;

namespace shoppingAPI_EF.Models.EF;

public partial class Product
{
    public int Productid { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCategory { get; set; }

    public int? ProductPrice { get; set; }

    public bool? ProductIsInStock { get; set; }

    public string? ProductDescription { get; set; }
}
