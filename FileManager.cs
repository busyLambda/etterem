using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class FileManager
{
    public FileManager()
    {
        if (!File.Exists("menu.txt"))
        {
            File.Create("menu.txt");
        }

        if (!File.Exists("orders.txt"))
        {
            File.Create("orders.txt");
        }
    }

    public void WriteOrders(List<Order> orders)
    {
        string orderstr = "";

        string itemsstr = "";

        bool f = true;
        foreach (var order in orders)
        {
            bool first = true;
            foreach (var item in order.OrderedItems())
            {
                if (!first)
                {
                    itemsstr += "|";
                }

                itemsstr += $"{item.Name()}:{item.Price()}:{item.Category()}";
                first = false;
            }
            if (!f) {
                orderstr += "\n";
            }
            orderstr += $"{order.GuestName()};{itemsstr}";
            
            f = false;
        }

        File.WriteAllText("orders.txt", orderstr);
    }

    public List<Order> ReadOrders()
    {
        List<Order> orders = new([]);

        string contents = File.ReadAllText("orders.txt");

        foreach (var line in contents.Split("\n"))
        {
            string[] fields = line.Split(";");

            string name = fields[0];

            List<MenuElem> orderedItems = new([]);

            foreach (var item in fields[1].Split("|"))
            {
                string[] itemFields = item.Split(":");

                string itemName = itemFields[0];
                int price = Convert.ToInt32(itemFields[1]);
                string category = itemFields[2];

                MenuElem menuElem = new(itemName, price, category);

                orderedItems.Add(menuElem);
            }

            Order order = new(name, orderedItems);

            orders.Add(order);
        }

        return orders;
    }

    public void WriteMenu(List<MenuElem> menu)
    {
        string menustr = "";

        bool first = true;
        foreach (var item in menu)
        {
            if (!first) {
                menustr += "\n";
            }
            menustr += $"{item.Name()};{item.Price()};{item.Category()}";
            first = false;
        }

        File.WriteAllText("menu.txt", menustr);
    }

    public List<MenuElem> ReadMenu()
    {
        List<MenuElem> menu = new([]);

        string contents = File.ReadAllText("menu.txt");

        foreach (var line in contents.Split("\n"))
        {
            string[] fields = line.Split(";");

            int price = Convert.ToInt32(fields[1]);
            MenuElem menuElem = new(fields[0], price, fields[2]);

            menu.Add(menuElem);
        }

        return menu;
    }
}