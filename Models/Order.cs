namespace BananaEcommerceApp.Models;

public class Order{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string OrderDate { get; set; }
    public string OrderAmount { get; set; }
    public string OrderCurrency { get; set; }
    public string OrderDescription { get; set; }
    public string OrderResponse { get; set; }
    public string OrderResponseCode { get; set; }
    public string OrderResponseMessage { get; set; }
    public Custommer Custommer { get; set; }
    public Payment Payment { get; set; }
    public Delivery Delivery { get; set; }
    public List<Product> Products { get; set; }
}