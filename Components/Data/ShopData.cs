namespace NewBalanceBlazor.Components.Data;

public record Product(int Id, string Name, string Category, string Size, string Color, decimal Price, string Description);

public static class ShopData
{
    public static readonly IReadOnlyList<Product> Products = new List<Product>
    {
        new(1, "New Balance 574", "Кросівки", "42", "Сірий", 3299m, "Класичні кросівки New Balance 574."),
        new(2, "New Balance 550", "Кросівки", "43", "Білий", 4199m, "Ретро-баскетбольні кросівки New Balance 550."),
        new(3, "NB Essentials Hoodie", "Одяг", "L", "Чорний", 1899m, "Худі з логотипом New Balance."),
        new(4, "New Balance 9060", "Кросівки", "44", "Бежевий", 5499m, "Футуристичний силует з масивною підошвою."),
        new(5, "NB Athletics Tee", "Одяг", "M", "Білий", 1199m, "Бавовняна футболка для щоденних тренувань."),
        new(6, "NB Running Socks", "Аксесуари", "40-45", "Чорний", 349m, "Шкарпетки для бігу з підтримкою стопи."),
    };

    public static string Money(decimal value) => $"{value:N0} ₴";
}
