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
        return products
            .Where(p => p.Category.ToLower() == category.ToLower())
            .Count();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Return the total value of all in-stock products
    // (sum of Price for every product where InStock == true).
    // -------------------------------------------------------------------------
    public static decimal GetTotalInStockValue(List<Product> products)
    {
        return products
            .Where(p => p.InStock)
            .Sum(p => p.Price);
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Return the average salary across all employees.
    // Round the result to 2 decimal places.
    // -------------------------------------------------------------------------
    public static decimal GetAverageSalary(List<Employee> employees)
    {
        return Math.Round(
                employees.Average(e => e.Salary),
                2
        );
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Return the product with the highest Rating.
    // If multiple products tie, return the one with the lower Id.
    // -------------------------------------------------------------------------
    public static Product GetTopRatedProduct(List<Product> products)
    {
        return products
            .OrderByDescending(p => p.Rating)
            .ThenBy(p => p.Id)
            .First();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return the total revenue across all orders.
    // Revenue for an order = product Price * order Quantity.
    // -------------------------------------------------------------------------
    public static decimal GetTotalRevenue(List<Order> orders, List<Product> products)
    {
        return orders
            .Join(
                products,
                order => order.ProductId,
                product => product.Id,
                (order, product) => order.Quantity * product.Price)
        .Sum();
    }

    // -------------------------------------------------------------------------
    // Challenge 6
    // Return the difference between the highest and lowest salary in the list.
    // -------------------------------------------------------------------------
    public static decimal GetSalaryRange(List<Employee> employees)
    {
        return employees.Max(e => e.Salary) - employees.Min(e => e.Salary);
    }

    // -------------------------------------------------------------------------
    // Challenge 7  (Bonus — uses Aggregate)
    // Return a single comma-separated string of all product names, sorted alphabetically.
    // Example: "Air Purifier, Ballpoint Pens, Blender, ..."
    // Hint: you can use string.Join or Aggregate for this one.
    // -------------------------------------------------------------------------
    public static string GetProductNamesCsv(List<Product> products)
    {
        //     ", ",
        //     return string.Join(
        //     products
        //         .Select(p => p.Name)
        //         .OrderBy(name => name)
        //
        // );
        return products
            .Select(p => p.Name)
            .OrderBy(name => name)
            .Aggregate((a, b) => a + ", " + b);
    }
}
