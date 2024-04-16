using _001Select;

var category = new List<Category>();
var category1 =new Category()
{
    Id = 1,
    Name = "Fruits",
};
var category2 =new Category()
{
    Id = 2,
    Name = "Vegetables",
};

category.Add(category1);
category.Add(category2);

var productions = new List<Product>
{
    new Product {Id = 1,Name = "Apple",  Quantity = 10,Price = 1200,Category = category1},
    new Product {Id = 2,Name = "Banana",  Quantity = 20 ,Price = 2100,Category =category1 },
    new Product {Id = 3,Name = "Broccoli",  Quantity = 30,Price = 2300,Category =category2 }
};




//1.
//Выбрать все продукты с ценой больше 1000
//Select all products with a price greater than 1000
var products = productions.Where(x => x.Price > 1000);
foreach (var item in products)
{
    Console.WriteLine($"{item.Name} {item.Quantity} {item.Price}");
}

//2.
//Выбрать все продукты, которые содержат слово "Apple" в названии
//Select all products that contain the word "Apple" in the name 

var selected = from p in productions where p.Name == "Apple" select p;
foreach (var item in selected)
{
    Console.WriteLine($"{item.Name} {item.Quantity} {item.Price}");
}

//3.
//Выбрать все продукты, которые не находятся в  категории "Fruits"
//Select all products that are not in "Fruits" categories: 
var selected1 = from p in productions where p.Category?.Name != "Fruits" select p;
foreach (var item in selected1)
{
    Console.WriteLine($"{item.Name} {item.Quantity} {item.Price}");
}