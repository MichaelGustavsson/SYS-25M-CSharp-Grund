namespace Domain;

public static class Products
{
    private static readonly IList<Product> _productList = [
        new Product{ItemNumber="AA1111-1",Name="Bosch Skruvdragare (GRS 12V-15)",Price=1567},
        new Product{ItemNumber="AA2222-3",Name="Dewalt Skruvdragare (DCD708D2T-QW)",Price=1567},
        new Product{ItemNumber="BB3666-9",Name="Dewalt Cirkelsåg (DCS565NT-XJ)",Price=3201},
        new Product{ItemNumber="BB5777-1",Name="Makita Cirkelsåg (DSS501Z)",Price=2283},
    ];
    public static Product FindProduct(string itemNumber)
    {
        foreach (var product in _productList)
        {
            if (product.ItemNumber == itemNumber)
            {
                return product;
            }
        }

        return new Product();
    }


}
