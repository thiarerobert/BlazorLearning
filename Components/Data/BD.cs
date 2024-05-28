namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
    // Call your data access technology here
    }

    private Pizza[] todayPizzas;

    protected override async Task OnIntializedAsync(){
        todayPizzas = await GetPizzasAsync();
    }
}