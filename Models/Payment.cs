namespace BananaEcommerceApp.Models;

public class Payment{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string CardNumber { get; set; }
    public string ExpirationDate { get; set; }
    public string Cvv { get; set; }
    public string CardHolderName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentType { get; set; }
    public string PaymentStatus { get; set; }
    public string PaymentDate { get; set; }
    public string PaymentAmount { get; set; }
    public string PaymentCurrency { get; set; }
    public string PaymentDescription { get; set; }
    public string PaymentResponse { get; set; }
    public string PaymentResponseCode { get; set; }
    public string PaymentResponseMessage { get; set; }
    
}