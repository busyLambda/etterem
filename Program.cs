class Program {
    public static void Main(string[] args) {
        Guest guest = new("Kiss Peter");
        
        MenuElem burger = new("cheeseburger", 1500, "food");
        MenuElem coke = new("coke", 500, "drink");

        Restaraunt restaraunt = new();

        restaraunt.AddMenuItem(burger);
        restaraunt.AddMenuItem(coke);
        
        restaraunt.OrderItem(guest, new([burger, coke]));
        
        restaraunt.Pay(guest);
    }
}