using linq_training.Models;

namespace linq_training.Exercises.Level1_Basics;

/// <summary>
/// LEVEL 1 — AGGREGATION
/// Use Count, Sum, Min, Max, Average, and Aggregate to reduce collections to scalar values.
/// </summary>
public static class Aggregation
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return the number of products in the given category (case-insensitive).
    // Example: "Electronics"  →  6
    // -------------------------------------------------------------------------
    public static int CountProductsInCategory(List<Product> products, string category)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Return the total value of all in-stock products
    // (sum of Price for every product where InStock == true).
    // -------------------------------------------------------------------------
    public static decimal GetTotalInStockValue(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Return the average salary across all employees.
    // Round the result to 2 decimal places.
    // -------------------------------------------------------------------------
    public static decimal GetAverageSalary(List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Return the product with the highest Rating.
    // If multiple products tie, return the one with the lower Id.
    // -------------------------------------------------------------------------
    public static Product GetTopRatedProduct(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return the total revenue across all orders.
    // Revenue for an order = product Price * order Quantity.
    // -------------------------------------------------------------------------
    public static decimal GetTotalRevenue(List<Order> orders, List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 6
    // Return the difference between the highest and lowest salary in the list.
    // -------------------------------------------------------------------------
    public static decimal GetSalaryRange(List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 7  (Bonus — uses Aggregate)
    // Return a single comma-separated string of all product names, sorted alphabetically.
    // Example: "Air Purifier, Ballpoint Pens, Blender, ..."
    // Hint: you can use string.Join or Aggregate for this one.
    // -------------------------------------------------------------------------
    public static string GetProductNamesCsv(List<Product> products)
    {
        throw new NotImplementedException();
    }
}
