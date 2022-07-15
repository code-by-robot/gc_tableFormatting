using JoiningData1;

List<Order> orders = new List<Order>()
{
    new Order("Acme Hardware", "Mouse", 25m,3 ),
    new Order("Acme Hardware", "Keyboard", 45m,2 ),
    new Order("Falls Realty", "MacBook", 800m,2 ),
    new Order("Joe's Chicago Pizza", null, null, null),
    new Order("Julie's Morning Diner", "iPad", 525m,1 ),
    new Order("Julie's Morning Diner", "Credit Card Reader", 45m,1 ),
};


//Exercise 1 Logic
//decimal totals = 0m;
List<string> customers = new List<string>();


//for (int i = 0; i < Orders.Count; i++)
//{
//    if (customers.Contains(Orders[i].CustomerName) == false)
//    {
//        customers.Add(Orders[i].CustomerName);
//        Console.WriteLine();
//        Console.WriteLine(Orders[i].CustomerName);

//    }
//    decimal total = Orders[i].Price * Orders[i].Quantity;
//    Console.WriteLine(String.Format("{0,-30}{1,-10}{2,-10}{3,-10}", Orders[i].Item, Orders[i].Price, Orders[i].Quantity, total));
//}


//Exercise 2
//decimal grandTotal = 0m;
//for (int i = 0; i < Orders.Count; i++)
//{
//    if (customers.Contains(Orders[i].CustomerName) == false)
//    {
//        if(customers.Count() != 0)
//        {
//            Console.WriteLine("{0,-50}{1,-10}", "Total", grandTotal);
//            Console.WriteLine();
//            grandTotal = 0m;
//        }
//        customers.Add(Orders[i].CustomerName);
//        Console.WriteLine(Orders[i].CustomerName);

//    }
//    decimal total = Orders[i].Price * Orders[i].Quantity;
//    grandTotal += total;
//    Console.WriteLine(String.Format("{0,-30}{1,-10}{2,-10}{3,-10}", Orders[i].Item, Orders[i].Price, Orders[i].Quantity, total));
//}
//Console.WriteLine("{0,-50}{1,-10}", "Total", grandTotal);



//Justin's Solution to Exercise 1
//Make a distinct list of orders using customer names
//List<Order> distinctCustomerOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First()).ToList();

//foreach (Order distinctCustomer in distinctCustomerOrders)
//{
//    //Display customer name on first line
//    Console.WriteLine(distinctCustomer.CustomerName);

//    //Grab all orders that belong to current customer
//    List<Order> CustomerOrders = orders.Where(o => o.CustomerName == distinctCustomer.CustomerName).ToList();

//    //Display Header
//    Console.WriteLine("Item\tPrice\tQuantity\tTotal");

//    //Loop through all orders that belong to current customer
//    foreach (Order o in CustomerOrders)
//    {
//        Console.WriteLine($"{o.Item}\t{o.Price}\t{o.Quantity}\t{o.Price * o.Quantity}");
//    }
//}

//Exercise 3
List<Order> distinctCustomerOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First()).ToList();

//Display Header
Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-10}{4,-10}", "Customer Name", "Item", "Price", "Quantity", "Total");

foreach (Order distinctCustomer in distinctCustomerOrders)
{
    //Display customer name on first line
    //Console.WriteLine(distinctCustomer.CustomerName);

    //Grab all orders that belong to current customer
    List<Order> CustomerOrders = orders.Where(o => o.CustomerName == distinctCustomer.CustomerName).ToList();

    //Loop through all orders that belong to current customer
    if (distinctCustomer.Item == null && CustomerOrders.Count == 1)
    {
        Console.WriteLine(String.Format("{0,-30}{1,-30}",distinctCustomer.CustomerName, "*No Orders At This Time*"));
        continue;
    }
    for (int i =0; i <CustomerOrders.Count(); i++)
    {
        if (i == 0)
        {
            Console.WriteLine(String.Format("{0,-30}{1,-30}{2,-10}{3,-10}{4,-10}", CustomerOrders[i].CustomerName, CustomerOrders[i].Item, CustomerOrders[i].Price, CustomerOrders[i].Quantity, CustomerOrders[i].Price * CustomerOrders[i].Quantity));
        }
        else
        {
            Console.WriteLine(String.Format("{0,-30}{1,-30}{2,-10}{3,-10}{4,-10}",null, CustomerOrders[i].Item, CustomerOrders[i].Price, CustomerOrders[i].Quantity, CustomerOrders[i].Price * CustomerOrders[i].Quantity));
        }
        
    }
}