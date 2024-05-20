namespace BlazinPizza;

/// <summary>
/// Represents a pre-configured template for a pizza a user can order
/// </summary>
public class PizzaSpecial{
    public int Id { get; set;}

    public string name { get; set;}

    public string description { get; set;}

    public decimal basePrice { get; set;}

    public string imageUrl { get; set;}

    public string GetFormatedBasePrice()=>basePrice.ToString("0.00");

}