using linq_training.Models;

namespace linq_training.Exercises.Level1_Basics;

/// <summary>
/// LEVEL 1 — FILTERING
/// Use Where() and related methods to filter collections.
/// Each method receives the full sample data and should return a filtered subset.
/// </summary>
public static class Filtering
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return all products whose Price is strictly greater than `minPrice`.
    // Example: minPrice = 100  →  Laptop Pro (1299.99), Standing Desk (499.99), ...
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetExpensiveProducts(List<Product> products, decimal minPrice)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Return all products that are currently in stock (InStock == true).
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetInStockProducts(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Return all employees who work in the given department (case-insensitive).
    // Example: department = "engineering"  →  Alice, Bob, Carol, Iris, Karen
    // -------------------------------------------------------------------------
    public static IEnumerable<Employee> GetEmployeesInDepartment(List<Employee> employees, string department)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Return all orders placed on or after `fromDate`.
    // Example: fromDate = 2024-06-01  →  orders 11, 12, 13, 14, 15
    // -------------------------------------------------------------------------
    public static IEnumerable<Order> GetRecentOrders(List<Order> orders, DateOnly fromDate)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return all products that are in stock AND have a Rating >= minRating.
    // Example: minRating = 4.5  →  Laptop Pro, Standing Desk, Ergonomic Chair, Air Purifier
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetHighRatedInStockProducts(List<Product> products, double minRating)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 6
    // Return all employees who were hired before `beforeDate` and earn more than `minSalary`.
    // Example: beforeDate = 2020-01-01, minSalary = 80_000
    //          →  Alice Chen (2019, 110k), Karen Taylor (2018, 105k)
    // -------------------------------------------------------------------------
    public static IEnumerable<Employee> GetSeniorHighEarners(
        List<Employee> employees, DateOnly beforeDate, decimal minSalary)
    {
        throw new NotImplementedException();
    }
}
