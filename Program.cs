using linq_training.Models;
using linq_training.Exercises.Level1_Basics;
using linq_training.Exercises.Level2_Intermediate;
using linq_training.Exercises.Level3_Advanced;

var products = SampleData.Products;
var employees = SampleData.Employees;
var customers = SampleData.Customers;
var orders = SampleData.Orders;

// ─────────────────────────────────────────────────────────────────────────────
// Run all exercises and show pass / not-yet / error for each.
// Implement the methods in Exercises/ to make them pass.
// ─────────────────────────────────────────────────────────────────────────────

var runner = new Runner();

Console.WriteLine("╔══════════════════════════════════════════════╗");
Console.WriteLine("║         LINQ Training Challenges             ║");
Console.WriteLine("╚══════════════════════════════════════════════╝\n");

// ── LEVEL 1 : Basics ──────────────────────────────────────────────────────────
runner.Section("LEVEL 1 — Filtering");

runner.Check("01 GetExpensiveProducts (>100)",
    () => Filtering.GetExpensiveProducts(products, 100m),
    r => r.All(p => p.Price > 100m) && r.Count() == 6);

runner.Check("02 GetInStockProducts",
    () => Filtering.GetInStockProducts(products),
    r => r.All(p => p.InStock) && r.Count() == 14);

runner.Check("03 GetEmployeesInDepartment (engineering)",
    () => Filtering.GetEmployeesInDepartment(employees, "engineering"),
    r => r.All(e => e.Department == "Engineering") && r.Count() == 5);

runner.Check("04 GetRecentOrders (>=2024-06-01)",
    () => Filtering.GetRecentOrders(orders, new DateOnly(2024, 6, 1)),
    r => r.All(o => o.Date >= new DateOnly(2024, 6, 1)) && r.Count() == 5);

runner.Check("05 GetHighRatedInStockProducts (>=4.5)",
    () => Filtering.GetHighRatedInStockProducts(products, 4.5),
    r => r.All(p => p.InStock && p.Rating >= 4.5) && r.Count() == 6);

runner.Check("06 GetSeniorHighEarners (<2020-01-01, >80k)",
    () => Filtering.GetSeniorHighEarners(employees, new DateOnly(2020, 1, 1), 80_000m),
    r => r.Count() == 3 && r.All(e => e.HireDate < new DateOnly(2020, 1, 1) && e.Salary > 80_000m));

runner.Section("LEVEL 1 — Projection");

runner.Check("01 GetProductNames",
    () => Projection.GetProductNames(products),
    r => r.Count() == 18 && r.Contains("Laptop Pro"));

runner.Check("02 GetProductNameAndPrice",
    () => Projection.GetProductNameAndPrice(products),
    r => r.Count() == 18 && r.Any(t => t.Name == "Laptop Pro" && t.Price == 1299.99m));

runner.Check("03 GetDiscountedPrices (10% off)",
    () => Projection.GetDiscountedPrices(products, 10m),
    r => r.Any(p => p == 1169.991m));

runner.Check("04 GetEmployeeSummaries",
    () => Projection.GetEmployeeSummaries(employees),
    r => r.Count() == 12 && r.Any(s => s.Contains("Alice Chen") && s.Contains("Engineering")));

runner.Check("05 GetOrderTotals",
    () => Projection.GetOrderTotals(orders, products),
    r => r.Count() == 15 && r.Any(t => t.ProductName == "Laptop Pro" && t.TotalCost == 2599.98m));

runner.Check("06 GetSortedCategories",
    () => Projection.GetSortedCategories(products),
    r => r.SequenceEqual(new[] { "Appliances", "Electronics", "Furniture", "Stationery" }));

runner.Section("LEVEL 1 — Aggregation");

runner.Check("01 CountProductsInCategory (Electronics)",
    () => Aggregation.CountProductsInCategory(products, "Electronics"),
    r => r == 6);

runner.Check("02 GetTotalInStockValue",
    () => Aggregation.GetTotalInStockValue(products),
    r => r == products.Where(p => p.InStock).Sum(p => p.Price));

runner.Check("03 GetAverageSalary",
    () => Aggregation.GetAverageSalary(employees),
    r => r == Math.Round(employees.Average(e => e.Salary), 2));

runner.Check("04 GetTopRatedProduct",
    () => Aggregation.GetTopRatedProduct(products),
    r => r.Name == "Laptop Pro");

runner.Check("05 GetTotalRevenue",
    () => Aggregation.GetTotalRevenue(orders, products),
    r => r > 0);

runner.Check("06 GetSalaryRange",
    () => Aggregation.GetSalaryRange(employees),
    r => r == employees.Max(e => e.Salary) - employees.Min(e => e.Salary));

runner.Check("07 GetProductNamesCsv",
    () => Aggregation.GetProductNamesCsv(products),
    r => r.StartsWith("Air Purifier") && r.Contains(","));

// ── LEVEL 2 : Intermediate ────────────────────────────────────────────────────
runner.Section("LEVEL 2 — Sorting");

runner.Check("01 GetProductsByPriceAsc",
    () => Sorting.GetProductsByPriceAsc(products),
    r => { var l = r.ToList(); return l.First().Name == "Ballpoint Pens" && l.Last().Name == "Laptop Pro"; });

runner.Check("02 GetTopNByRating (3)",
    () => Sorting.GetTopNByRating(products, 3),
    r => r.Count() == 3 && r.First().Name == "Laptop Pro");

runner.Check("03 GetEmployeesSortedByDeptThenSalary",
    () => Sorting.GetEmployeesSortedByDeptThenSalary(employees),
    r => { var l = r.ToList(); return l.First().Department == "Engineering" && l.First().Name == "Alice Chen"; });

runner.Check("04 GetInStockSortedByCategoryThenPrice",
    () => Sorting.GetInStockSortedByCategoryThenPrice(products),
    r => r.All(p => p.InStock));

runner.Check("05 GetOrdersMostRecentFirst",
    () => Sorting.GetOrdersMostRecentFirst(orders),
    r => { var l = r.ToList(); return l.First().Date >= l.Last().Date; });

runner.Section("LEVEL 2 — Grouping");

runner.Check("01 GroupProductsByCategory",
    () => Grouping.GroupProductsByCategory(products),
    r => r.Count == 4 && r["Electronics"].Count == 6);

runner.Check("02 GetProductCountPerCategory",
    () => Grouping.GetProductCountPerCategory(products),
    r => r["Electronics"] == 6 && r["Furniture"] == 4);

runner.Check("03 GetAveragePricePerCategory",
    () => Grouping.GetAveragePricePerCategory(products),
    r => r.ContainsKey("Electronics") && r.ContainsKey("Furniture"));

runner.Check("04 GetTotalSalaryPerDepartment",
    () => Grouping.GetTotalSalaryPerDepartment(employees),
    r => r["Engineering"] == employees.Where(e => e.Department == "Engineering").Sum(e => e.Salary));

runner.Check("05 GetTopEarnerPerDepartment",
    () => Grouping.GetTopEarnerPerDepartment(employees),
    r => r["Engineering"].Name == "Alice Chen" && r["HR"].Name == "Grace Kim");

runner.Check("06 GetTotalSpendPerCustomer",
    () => Grouping.GetTotalSpendPerCustomer(orders, products),
    r => r.Count == orders.Select(o => o.CustomerId).Distinct().Count());

runner.Check("07 GetEmployeesByHireYear",
    () => Grouping.GetEmployeesByHireYear(employees),
    r => { var keys = r.Keys.ToList(); return keys.First() > keys.Last(); });

runner.Section("LEVEL 2 — Set Operations");

runner.Check("01 GetUniqueCategories",
    () => SetOperations.GetUniqueCategories(products),
    r => r.Count() == 4);

runner.Check("02 GetCommonProductNames",
    () => SetOperations.GetCommonProductNames(
        ["Laptop Pro", "Webcam HD", "Stapler"],
        ["LAPTOP PRO", "Blender", "Stapler"]),
    r => r.Count() == 2);

runner.Check("03 GetExclusiveToA",
    () => SetOperations.GetExclusiveToA(
        ["Laptop Pro", "Webcam HD", "Stapler"],
        ["LAPTOP PRO", "Blender", "Stapler"]),
    r => r.Count() == 1 && r.First() == "Webcam HD");

runner.Check("04 GetAllUniqueNames",
    () => SetOperations.GetAllUniqueNames(
        ["Laptop Pro", "Stapler"],
        ["Blender", "Stapler"]),
    r => r.Count() == 3 && r.First() == "Blender");

runner.Check("05 GetProductsExcludingCategories",
    () => SetOperations.GetProductsExcludingCategories(products, ["Stationery", "Appliances"]),
    r => r.All(p => p.Category == "Electronics" || p.Category == "Furniture"));

runner.Check("06 GetUsaCustomersWhoOrdered",
    () => SetOperations.GetUsaCustomersWhoOrdered(customers, orders),
    r => r.Count() == 3);

// ── LEVEL 3 : Advanced ────────────────────────────────────────────────────────
runner.Section("LEVEL 3 — Joining");

runner.Check("01 GetOrderDetails",
    () => Joining.GetOrderDetails(orders, customers, products),
    r => r.Count() == 15 && r.All(t => !string.IsNullOrEmpty(t.CustomerName)));

runner.Check("02 GetOrderCountPerCustomer",
    () => Joining.GetOrderCountPerCustomer(customers, orders),
    r => r.Count() == 6 && r.First().OrderCount >= r.Last().OrderCount);

runner.Check("03 GetEmployeeManagerPairs",
    () => Joining.GetEmployeeManagerPairs(employees),
    r => r.Count() == 9 && r.Any(p => p.EmployeeName == "Bob Smith" && p.ManagerName == "Alice Chen"));

runner.Check("04 GetCustomerSpendSummary",
    () => Joining.GetCustomerSpendSummary(customers, orders, products),
    r => r.Count() == 6 && r.First().TotalSpend >= r.Last().TotalSpend);

runner.Section("LEVEL 3 — Chaining");

runner.Check("01 GetAffordableTopRated (<200)",
    () => Chaining.GetAffordableTopRated(products, 200m),
    r => r.Count() == 3);

runner.Check("02 GetCheapestInStockPerCategory",
    () => Chaining.GetCheapestInStockPerCategory(products),
    r => r.Count == 4 && r["Stationery"].Name == "Ballpoint Pens");

runner.Check("03 GetAboveAverageDepartments",
    () => Chaining.GetAboveAverageDepartments(employees),
    r => r.Contains("Engineering") && !r.Contains("HR"));

runner.Check("04 GetBestSellingProduct",
    () => Chaining.GetBestSellingProduct(orders, products),
    r => !string.IsNullOrEmpty(r.ProductName) && r.TotalRevenue > 0);

runner.Check("05 GetMostRecentHiresPerDepartment (N=2)",
    () => Chaining.GetMostRecentHiresPerDepartment(employees, 2),
    r => r.Count == 3 && r.Values.All(v => v.Count <= 2));

runner.Check("06 GetPowerCustomers (>1000)",
    () => Chaining.GetPowerCustomers(customers, orders, products, 1000m),
    r => r.Any());

runner.Section("LEVEL 3 — Real World");

runner.Check("01 GetMonthlyRevenue",
    () => RealWorld.GetMonthlyRevenue(orders, products),
    r => r.Count() == 8 && r.All(t => t.Revenue > 0));

runner.Check("02 GetRestockPriority",
    () => RealWorld.GetRestockPriority(products),
    r => r.All(p => !p.InStock) && r.Count() == 4);

runner.Check("03 GetDepartmentSummary",
    () => RealWorld.GetDepartmentSummary(employees),
    r => r.Count() == 3 && r.First().TotalPayroll >= r.Last().TotalPayroll);

runner.Check("04 GetCustomerTiers",
    () => RealWorld.GetCustomerTiers(customers, orders, products),
    r => r.Count() == 6 && r.Any(t => t.Tier == "Gold"));

runner.Check("05 GetCategoryRatingVsAverage",
    () => RealWorld.GetCategoryRatingVsAverage(products),
    r => r.Count() == 4);

runner.Check("06 ClassifyCustomers",
    () => RealWorld.ClassifyCustomers(customers, orders),
    r => r.RepeatCustomers.Count + r.OneTimeCustomers.Count == 6);

// ─────────────────────────────────────────────────────────────────────────────
runner.PrintSummary();

// ─────────────────────────────────────────────────────────────────────────────
// Test Runner implementation
// ─────────────────────────────────────────────────────────────────────────────
class Runner
{
    private int _pass, _fail, _todo;

    public void Section(string title)
    {
        Console.WriteLine($"\n── {title} ──");
    }

    public void Check<T>(string name, Func<T> act, Func<T, bool> assert)
    {
        try
        {
            var result = act();
            if (assert(result))
            {
                Console.WriteLine($"  [PASS] {name}");
                _pass++;
            }
            else
            {
                Console.WriteLine($"  [FAIL] {name}");
                _fail++;
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine($"  [TODO] {name}");
            _todo++;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  [ERR ] {name}  ({ex.GetType().Name}: {ex.Message})");
            _fail++;
        }
    }

    public void PrintSummary()
    {
        int total = _pass + _fail + _todo;
        Console.WriteLine($"\n{'═',50}");
        Console.WriteLine($"  {_pass}/{total} passing   {_todo} todo   {_fail} failing");
        Console.WriteLine($"{'═',50}");
    }
}
