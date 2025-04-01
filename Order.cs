class Order {
    string guestName;
    List<MenuElem> orderedItems;
    
    public Order(string guestName_, List<MenuElem> orderedItems_) {
        guestName = guestName_;
        orderedItems = orderedItems_;
    }
    
    public string GuestName() {
        return guestName;
    }
    public List<MenuElem> OrderedItems() {
        return orderedItems;
    }
    
    public int CalculatePrice() {
        int sum = 0;

        foreach (var item in orderedItems)
        {
            sum += item.price;
        }
        
        return sum;
    }
}