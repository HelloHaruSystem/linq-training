using linq_training.Models;

namespace linq_training.Exercises.Level2_Intermediate;

/// <summary>
/// LEVEL 2 — GROUPING
/// Use GroupBy to partition collections and compute per-group aggregates.
/// </summary>
public static class Grouping
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return a dictionary mapping each Category to the list of products in it.
    // Example: { "Electronics" → [Laptop Pro, Wireless Mouse, ...], "Furniture" → [...], ... }
    // -------------------------------------------------------------------------
    public static Dictionary<string, List<Product>> GroupProductsByCategory(List<Product> products)
    {
        return products
            .GroupBy(p => p.Category)
            .ToDictionary(
                g => g.Key,
                g => g.ToList()
            );
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Return a dictionary mapping each Category to the number of products in it.
    // Example: { "Electronics" → 6, "Furniture" → 3, "Stationery" → 3, "Appliances" → 4 }
    // -------------------------------------------------------------------------
    public static Dictionary<string, int> GetProductCountPerCategory(List<Product> products)
    {
        return products
            .GroupBy(p => p.Category)
            .ToDictionary(
                 g => g.Key,
                 g => g.Count()
            );
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Return a dictionary mapping each Category to the average Price of products in it.
    // Round each average to 2 decimal places.
    // -------------------------------------------------------------------------
    public static Dictionary<string, decimal> GetAveragePricePerCategory(List<Product> products)
    {
        return products
            .GroupBy(p => p.Category)
            .ToDictionary(
                g => g.Key,
                g => Math.Round(g.Average(p => p.Price), 2)
            );
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Return a dictionary mapping each Department to the total salary bill (sum of salaries).
    // -------------------------------------------------------------------------
    public static Dictionary<string, decimal> GetTotalSalaryPerDepartment(List<Employee> employees)
    {
        return employees
            .GroupBy(e => e.Department)
            .ToDictionary(
                g => g.Key,
                g => g.Sum(e => e.Salary)
            );
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return a dictionary mapping each Department to its highest-paid employee.
    // -------------------------------------------------------------------------
    public static Dictionary<string, Employee> GetTopEarnerPerDepartment(List<Employee> employees)
    {
        return employees
            .GroupBy(e => e.Department)
            .ToDictionary(
                g => g.Key,
                g => g.OrderByDescending(e => e.Salary).First()
            );
    }

    // -------------------------------------------------------------------------
    // Challenge 6
    // Group orders by CustomerId and return a dictionary mapping each CustomerId
    // to the total amount they have spent (sum of product Price * order Quantity).
    // -------------------------------------------------------------------------
    public static Dictionary<int, decimal> GetTotalSpendPerCustomer(List<Order> orders, List<Product> products)
    {
        return orders
            .Join(
                products,
                order => order.ProductId,
                product => product.Id,
                (order, product) => new
                {
                    order.CustomerId,
                    Total = order.Quantity * product.Price
                })
            .GroupBy(x => x.CustomerId)
            .ToDictionary(
                g => g.Key,
                g => g.Sum(x => x.Total)
            );
    }

    // -------------------------------------------------------------------------
    // Challenge 7  (Bonus)
    // Return a dictionary mapping the hire year (int) to the list of employees
    // hired in that year, sorted so the most recent year comes first.
    // Example: { 2023 → [Henry], 2022 → [Eve, Leo], 2021 → [Carol, Jack], ... }
    // -------------------------------------------------------------------------
    public static Dictionary<int, List<Employee>> GetEmployeesByHireYear(List<Employee> employees)
    {
        return employees
            .GroupBy(e => e.HireDate.Year)
            .OrderByDescending(g => g.Key)
            .ToDictionary(
                g => g.Key,
                g => g.OrderBy(e => e.Name).ToList()
            );
    }
}
