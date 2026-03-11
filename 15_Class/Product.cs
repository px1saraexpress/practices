 
class products
{
    public static string Discount = "10%"; 
    public int productId;
    public string productName;
    public int productPrice;


    public void productsDegtails()
    {
        Console.WriteLine
            ($"Product Id = {productId}\n" +
            $"Product Name = {productName}\n" +
            $"Product price = {productPrice}\n" +
            $"Net Discount on this product is = {Discount}\n\a"
            );

    }
}

