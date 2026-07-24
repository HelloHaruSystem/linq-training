using linq_training.Models;

namespace linq_training.Exercises.Level3_Advanced;

/// <summary>
/// LEVEL 3 — CHAINING COMPLEX QUERIES
/// These require combining multiple LINQ operators in a single pipeline.
/// Think carefully about the order of operations.
/// </summary>
public static class Chaining
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return the names of the top 3 highest-rated in-stock products
    // that cost less than `maxPrice`, sorted by Rating descending.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetAffordableTopRated(List<Product> products, decimal maxPrice)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // For each category, find the cheapest in-stock product.
    // Return a dictionary mapping Category → cheapest in-stock Product.
    // Exclude categories that have no in-stock products.
    // -------------------------------------------------------------------------
    public static Dictionary<string, Product> GetCheapestInStockPerCategory(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Return the department(s) whose average salary is above the company-wide average.
    // Sort the result alphabetically.
    // Example: if company avg = 80k and Engineering avg = 98k, Marketing avg = 71k,
    //          HR avg = 61k  →  ["Engineering"]
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetAboveAverageDepartments(List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Find the product that generated the most revenue across all orders
    // (revenue = product.Price * sum of Quantity for that product).
    // Return the product's Name and its total revenue as a tuple.
    // -------------------------------------------------------------------------
    public static (string ProductName, decimal TotalRevenue) GetBestSellingProduct(
        List<Order> orders, List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return the N most recently hired employees per department.
    // Result: dictionary mapping Department → list of employees (most recent first).
    // Example: N = 2, Engineering → [Carol (2021), Iris (2019)], ...
    // -------------------------------------------------------------------------
    public static Dictionary<string, List<Employee>> GetMostRecentHiresPerDepartment(
        List<Employee> employees, int n)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 6  (Hard)
    // A "power customer" has placed orders totalling more than `spendThreshold`.
    // Return their names sorted alphabetically.
    // TotalSpend = sum of (product.Price * order.Quantity) across all their orders.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetPowerCustomers(
        List<Customer> customers, List<Order> orders, List<Product> products, decimal spendThreshold)
    {
        throw new NotImplementedException();
    }
}
