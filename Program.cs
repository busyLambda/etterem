class Program {
    public static void Main(string[] args) {
        Guest guest = new("Guest");
        
        Restaraunt restaraunt = new();

        MenuElem langos = new("langos", 1550, "traditional");

        restaraunt.AddMenuItem(langos);
        
        restaraunt.OrderItem(guest, new([langos]));
        
        restaraunt.Pay(guest);
    }
}