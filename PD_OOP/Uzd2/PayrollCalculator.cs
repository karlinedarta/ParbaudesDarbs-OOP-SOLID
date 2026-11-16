public class PayrollCalculator
{
    public decimal TotalSalary(List<Employee> employees)
    {
        decimal total = 0m;
        foreach (Employee e in employees)
        {
            total += e.CalculateSalary();
        }
        return total;
    }
}
