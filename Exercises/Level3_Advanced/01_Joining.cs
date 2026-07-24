using linq_training.Models;

namespace linq_training.Exercises.Level3_Advanced;

/// <summary>
/// LEVEL 3 — JOINING
/// Use Join and GroupJoin to correlate data across multiple collections.
/// </summary>
public static class Joining
{
    // -------------------------------------------------------------------------
    // Challenge 1  (Inner Join)
    // For each order, return a (CustomerName, ProductName, Quantity) tuple.
    // Only include orders where both the customer and product are found.
    // Sort the result by CustomerName ascending.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string CustomerName, string ProductName, int Quantity)> GetOrderDetails(
        List<Order> orders, List<Customer> customers, List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2  (Group Join — left outer)
    // For each customer, return a (CustomerName, OrderCount) tuple.
    // Customers with zero orders should appear with OrderCount = 0.
    // Sort by OrderCount descending.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string CustomerName, int OrderCount)> GetOrderCountPerCustomer(
        List<Customer> customers, List<Order> orders)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3  (Self Join)
    // For each employee who has a manager (ManagerId != null),
    // return a (EmployeeName, ManagerName) tuple.
    // Sort by EmployeeName.
    // Hint: join the employees list with itself on Id == ManagerId.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string EmployeeName, string ManagerName)> GetEmployeeManagerPairs(
        List<Employee> employees)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4  (Multi-join + aggregation)
    // For each customer, return a (CustomerName, TotalSpend) tuple
    // where TotalSpend = sum of (product.Price * order.Quantity) across all their orders.
    // Include customers with no orders (TotalSpend = 0).
    // Sort by TotalSpend descending.
    // -------------------------------------------------------------------------
    public static IEnumerable<(string CustomerName, decimal TotalSpend)> GetCustomerSpendSummary(
        List<Customer> customers, List<Order> orders, List<Product> products)
    {
        throw new NotImplementedException();
    }
}
