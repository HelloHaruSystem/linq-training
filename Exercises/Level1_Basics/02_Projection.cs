using linq_training.Models;

namespace linq_training.Exercises.Level1_Basics;

/// <summary>
/// LEVEL 1 — PROJECTION
/// Use Select() to transform elements into new shapes.
/// </summary>
public static class Projection
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return just the Name of each product as a list of strings.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetProductNames(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Return a sequence of (Name, Price) tuples for every product.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string Name, decimal Price)> GetProductNameAndPrice(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Apply a discount to every price and return the discounted prices.
    // discountPercent is a value like 10 meaning 10% off.
    // Example: discountPercent = 10, price = 100  →  90
    // -------------------------------------------------------------------------
    public static IEnumerable<decimal> GetDiscountedPrices(List<Product> products, decimal discountPercent)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Return a sequence of strings in the format: "Alice Chen — Engineering ($110,000)"
    // Use the employee's Name, Department, and Salary.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetEmployeeSummaries(List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return a sequence of (ProductName, TotalCost) tuples for each order,
    // where TotalCost = product's Price * order Quantity.
    // You'll need to join orders and products by ProductId.
    // Hint: you can use a nested query or SelectMany — but a simple lookup works too.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string ProductName, decimal TotalCost)> GetOrderTotals(
        List<Order> orders, List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 6
    // Return only the distinct categories that exist in the product list.
    // Order them alphabetically.
    // Expected: ["Appliances", "Electronics", "Furniture", "Stationery"]
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetSortedCategories(List<Product> products)
    {
        throw new NotImplementedException();
    }
}
