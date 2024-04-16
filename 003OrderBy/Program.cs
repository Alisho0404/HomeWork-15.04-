using _001Select;

var category = new List<Category>();
var category1 = new Category()
{
    Id = 1,
    Name = "Fruits",
};
var category2 = new Category()
{
    Id = 2,
    Name = "Vegetables",
};

category.Add(category1);
category.Add(category2);

var productions = new List<Product>
{
    new Product { Id = 1, Name = "Apple", Quantity = 10, Price = 1200, Category = category1 },
    new Product { Id = 2, Name = "Banana", Quantity = 20, Price = 2100, Category = category1 },
    new Product { Id = 3, Name = "Broccoli", Quantity = 30, Price = 2300, Category = category2 },

    new Product { Id = 4, Name = "Cucumber", Quantity = 1130, Price = 1921, Category = category2 },
    new Product { Id = 5, Name = "Watermelon", Quantity = 4100, Price = 2200, Category = category1 },
    new Product { Id = 6, Name = "Carrot", Quantity = 1005, Price = 1202, Category = category2 }
};


//1.
//Выбрать все продукты, отсортированные по наименованию по возрастанию
//Select all products sorted by name in ascending order
var prodAsc = from p in productions orderby p.Name select p;
foreach (var item in prodAsc)
{
    Console.WriteLine($"{item.Name} {item.Price}");
}
Console.WriteLine();
//2.
//Выбрать все продукты, отсортированные по категории по возрастанию, а затем по цене по убыванию
//Select all products sorted by category in ascending order and then by price in descending order
var productAsc = productions.OrderBy(p => p.Category?.Name).ThenByDescending(p => p.Price);
foreach (var item in productAsc)
{
    Console.WriteLine($"{item.Name}:{item.Price}");
}
Console.WriteLine();
//3.
//Выбрать все продукты, отсортированные по цене по возрастанию
//Select all products sorted by price in ascending order 
var product = productions.OrderBy(p => p.Price);
foreach (var item in product)
{
    Console.WriteLine($"{item.Name}:{item.Price}");
}