using linq_training.Models;

namespace linq_training.Exercises.Level2_Intermediate;

/// <summary>
/// LEVEL 2 — SET OPERATIONS
/// Practice Distinct, Union, Intersect, Except, and Contains.
/// </summary>
public static class SetOperations
{
    // -------------------------------------------------------------------------
    // Challenge 1
    // Return the distinct categories present in the product list.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetUniqueCategories(List<Product> products)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 2
    // Given two lists of product names, return the names that appear in BOTH lists.
    // The comparison should be case-insensitive.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetCommonProductNames(List<string> listA, List<string> listB)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 3
    // Given two lists of product names, return names that appear in listA but NOT in listB.
    // Case-insensitive comparison.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetExclusiveToA(List<string> listA, List<string> listB)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 4
    // Given two lists of product names, return all unique names from both lists combined
    // (no duplicates). Sort the result alphabetically.
    // -------------------------------------------------------------------------
    public static IEnumerable<string> GetAllUniqueNames(List<string> listA, List<string> listB)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 5
    // Return all products whose category is NOT in the given exclusion list.
    // Example: excluded = ["Stationery", "Appliances"]
    //          →  only Electronics and Furniture products returned
    // -------------------------------------------------------------------------
    public static IEnumerable<Product> GetProductsExcludingCategories(
        List<Product> products, List<string> excludedCategories)
    {
        throw new NotImplementedException();
    }

    // -------------------------------------------------------------------------
    // Challenge 6
    // Return the customer IDs that have placed at least one order AND are from the USA.
    // Hint: build a set of customerIds that ordered, then intersect with USA customer IDs.
    // -------------------------------------------------------------------------
    public static IEnumerable<int> GetUsaCustomersWhoOrdered(List<Customer> customers, List<Order> orders)
    {
        throw new NotImplementedException();
    }
}
