using linq_training.Models;

namespace linq_training.Exercises.Level2_Intermediate;

/// <summary>
/// LEVEL 2 — SORTING
/// Use OrderBy, OrderByDescending, ThenBy, and ThenByDescending.
/// </summary>
public static class Sorting
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return all products sorted by Price ascending.
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetProductsByPriceAsc(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Return the top N products by Rating (highest first).
    // If N > products.Count, return all products.
    // Example: N = 3  →  Laptop Pro (4.8), Ergonomic Chair (4.7), Standing Desk (4.5) [tie-break by Id]
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetTopNByRating(List<Product> products, int n)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Sort employees first by Department (A→Z), then within each department
    // by Salary descending (highest earner first).
    // -------------------------------------------------------------------------
    public static IEnumerable<Employee> GetEmployeesSortedByDeptThenSalary(List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Return all in-stock products sorted by Category ascending,
    // then by Price descending within each category.
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetInStockSortedByCategoryThenPrice(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return orders sorted by Date descending (most recent first),
    // then by Quantity descending for orders on the same date.
    // -------------------------------------------------------------------------
    public static IEnumerable<Order> GetOrdersMostRecentFirst(List<Order> orders)
    {
        throw new NotImplementedException();
    }
}
