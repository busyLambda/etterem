using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

class Restaraunt {
    List<MenuElem> menu;
    List<Order> orders;
    FileManager fileManager;
    
    public void ListMenu() {
        foreach (var item in menu)
        {
            Console.WriteLine(item.ToString());
        }
    }
    
    public Restaraunt() {
        fileManager = new();

        menu = fileManager.ReadMenu();
        orders = fileManager.ReadOrders();
    }
    
    public void AddMenuItem(MenuElem elem) {
        menu.Add(elem);
        
        fileManager.WriteMenu(menu);
    }
    
    public void OrderItem(Guest guest, List<MenuElem> items) {
        Order order = new(guest.Name(), items);
        
        orders.Add(order);
        
        fileManager.WriteOrders(orders);
    }
    
    public int Pay(Guest guest) {
        int price = 0;

        int i = 0;
        foreach (var item in orders)
        {
            if (item.GuestName() == guest.Name()) {
                price = item.CalculatePrice();
                
                orders.RemoveAt(i);
                break;   
            }

            i++;
        }
        
        fileManager.WriteOrders(orders);
        
        return price;
    }
}