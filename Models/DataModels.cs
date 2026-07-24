namespace linq_training.Models;

public record Product(int Id, string Name, string Category, decimal Price, bool InStock, double Rating);

public record Employee(int Id, string Name, string Department, decimal Salary, DateOnly HireDate, int? ManagerId);

public record Customer(int Id, string Name, string City, string Country);

public record Order(int Id, int CustomerId, int ProductId, int Quantity, DateOnly Date);

public static class SampleData
{
    public static List<Product> Products =>
    [
        new(1,  "Laptop Pro",        "Electronics", 1299.99m, true,  4.8),
        new(2,  "Wireless Mouse",    "Electronics",   29.99m, true,  4.3),
        new(3,  "Mechanical Keyboard","Electronics",  89.99m, true,  4.6),
        new(4,  "USB-C Hub",         "Electronics",   49.99m, false, 3.9),
        new(5,  "Standing Desk",     "Furniture",    499.99m, true,  4.5),
        new(6,  "Ergonomic Chair",   "Furniture",    799.99m, true,  4.7),
        new(7,  "Desk Lamp",         "Furniture",     39.99m, true,  4.1),
        new(8,  "Notebook Pack",     "Stationery",    12.99m, true,  4.0),
        new(9,  "Ballpoint Pens",    "Stationery",    8.99m,  true,  3.8),
        new(10, "Whiteboard",        "Stationery",   59.99m,  false, 4.2),
        new(11, "Monitor 27\"",      "Electronics",  349.99m, true,  4.6),
        new(12, "Webcam HD",         "Electronics",   79.99m, false, 4.0),
        new(13, "Bookshelf",         "Furniture",    129.99m, true,  4.3),
        new(14, "Stapler",           "Stationery",    14.99m, true,  3.5),
        new(15, "Coffee Maker",      "Appliances",    89.99m, true,  4.4),
        new(16, "Air Purifier",      "Appliances",   199.99m, true,  4.6),
        new(17, "Blender",           "Appliances",    59.99m, false, 4.1),
        new(18, "Toaster",           "Appliances",    34.99m, true,  3.9),
    ];

    public static List<Employee> Employees =>
    [
        new(1,  "Alice Chen",    "Engineering", 110_000m, new DateOnly(2019, 3, 15),  null),
        new(2,  "Bob Smith",     "Engineering",  95_000m, new DateOnly(2020, 7, 1),   1),
        new(3,  "Carol White",   "Engineering",  88_000m, new DateOnly(2021, 11, 20), 1),
        new(4,  "Dave Brown",    "Marketing",    75_000m, new DateOnly(2018, 5, 10),  null),
        new(5,  "Eve Johnson",   "Marketing",    68_000m, new DateOnly(2022, 1, 8),   4),
        new(6,  "Frank Lee",     "Marketing",    72_000m, new DateOnly(2020, 9, 14),  4),
        new(7,  "Grace Kim",     "HR",           65_000m, new DateOnly(2017, 6, 3),   null),
        new(8,  "Henry Davis",   "HR",           58_000m, new DateOnly(2023, 2, 28),  7),
        new(9,  "Iris Wilson",   "Engineering",  92_000m, new DateOnly(2019, 8, 22),  1),
        new(10, "Jack Miller",   "Marketing",    70_000m, new DateOnly(2021, 4, 17),  4),
        new(11, "Karen Taylor",  "Engineering",  105_000m,new DateOnly(2018, 12, 5),  1),
        new(12, "Leo Anderson",  "HR",           61_000m, new DateOnly(2022, 7, 19),  7),
    ];

    public static List<Customer> Customers =>
    [
        new(1, "Acme Corp",      "New York",   "USA"),
        new(2, "Globex",         "Springfield","USA"),
        new(3, "Initech",        "Austin",     "USA"),
        new(4, "Umbrella Ltd",   "London",     "UK"),
        new(5, "Cyberdyne",      "Tokyo",      "Japan"),
        new(6, "Soylent Corp",   "Berlin",     "Germany"),
    ];

    public static List<Order> Orders =>
    [
        new(1,  1, 1,  2, new DateOnly(2024, 1, 10)),
        new(2,  1, 3,  1, new DateOnly(2024, 1, 15)),
        new(3,  2, 2,  5, new DateOnly(2024, 2, 3)),
        new(4,  2, 11, 3, new DateOnly(2024, 2, 20)),
        new(5,  3, 5,  1, new DateOnly(2024, 3, 7)),
        new(6,  3, 6,  2, new DateOnly(2024, 3, 12)),
        new(7,  4, 15, 4, new DateOnly(2024, 4, 1)),
        new(8,  4, 16, 1, new DateOnly(2024, 4, 18)),
        new(9,  5, 1,  1, new DateOnly(2024, 5, 5)),
        new(10, 5, 3,  2, new DateOnly(2024, 5, 22)),
        new(11, 6, 8,  10,new DateOnly(2024, 6, 3)),
        new(12, 1, 11, 1, new DateOnly(2024, 6, 15)),
        new(13, 2, 16, 2, new DateOnly(2024, 7, 8)),
        new(14, 3, 2,  3, new DateOnly(2024, 7, 20)),
        new(15, 4, 5,  1, new DateOnly(2024, 8, 1)),
    ];
}
