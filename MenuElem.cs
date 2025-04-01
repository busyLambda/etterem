class MenuElem {
    string name;
    public int price;
    string category;
    
    
    public string Name() {
        return name;
    }
    public int Price() {
        return price;
    }
    public string Category() {
        return category;
    }

    public MenuElem(string name_, int price_, string category_) {
        name = name_;
        price = price_;
        category = category_;
    }
}