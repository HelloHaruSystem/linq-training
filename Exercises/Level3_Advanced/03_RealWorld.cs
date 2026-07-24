using linq_training.Models;

namespace linq_training.Exercises.Level3_Advanced;

/// <summary>
/// LEVEL 3 — REAL-WORLD SCENARIOS
/// Larger, open-ended problems that mirror what you'd actually write in production.
/// No hand-holding — read the spec, figure out the approach.
/// </summary>
public static class RealWorld
{
    // -------------------------------------------------------------------------
    // Challenge 1 — Monthly Revenue Report
    // Return a list of (Year, Month, Revenue) tuples sorted chronologically.
    // Revenue for a month = sum of (product.Price * order.Quantity) for all orders in that month.
    // Example: (2024, 1, 2679.97), (2024, 2, 1199.92), ...
    // -------------------------------------------------------------------------
    public static IEnumerable<(int Year, int Month, decimal Revenue)> GetMonthlyRevenue(
        List<Order> orders, List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2 — Product Restock List
    // Return all out-of-stock products (InStock == false) sorted by Rating descending.
    // These are the items most worth restocking first.
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetRestockPriority(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3 — Department Headcount and Payroll Summary
    // Return a list of (Department, HeadCount, TotalPayroll, AverageSalary) tuples.
    // Sort by TotalPayroll descending.
    // Round AverageSalary to 2 decimal places.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string Department, int HeadCount, decimal TotalPayroll, decimal AverageSalary)>
        GetDepartmentSummary(List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4 — Customer Loyalty Tiers
    // Assign each customer a tier based on their total spend:
    //   Bronze  : spend < 500
    //   Silver  : 500 <= spend < 2000
    //   Gold    : spend >= 2000
    // Return a list of (CustomerName, Tier, TotalSpend) tuples sorted by TotalSpend descending.
    // Customers with no orders have TotalSpend = 0 (Bronze).
    // -------------------------------------------------------------------------
    public static IEnumerable<(string CustomerName, string Tier, decimal TotalSpend)> GetCustomerTiers(
        List<Customer> customers, List<Order> orders, List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5 — Category Performance vs. Average
    // For each category, compute how its average product rating compares to the
    // overall average rating across ALL products. Return a list of
    // (Category, CategoryAvgRating, Difference) tuples sorted by Difference descending.
    // A positive Difference means the category rates above average.
    // Round both averages to 2 decimal places.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string Category, double CategoryAvgRating, double Difference)>
        GetCategoryRatingVsAverage(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 6 — Repeat vs. One-Time Customers  (Hard)
    // A "repeat customer" has placed orders for 2 or more DISTINCT products.
    // Return two lists: (RepeatCustomers, OneTimeCustomers) — each a list of customer Names.
    // Customers with no orders go into OneTimeCustomers.
    // Both lists should be sorted alphabetically.
    // -------------------------------------------------------------------------
    public static (List<string> RepeatCustomers, List<string> OneTimeCustomers) ClassifyCustomers(
        List<Customer> customers, List<Order> orders)
    {
        throw new NotImplementedException();
    }
}
