Console.OutputEncoding = System.Text.Encoding.UTF8;

var employees = new List<Employee>
{
    new FullTimeEmployee("Anna", 1200m),
    new HourlyEmployee("Jānis", 8m, 100)
};
foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}
var payroll = new PayrollCalculator();
Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");

// OCP: pievienojam jaunu darbinieka veidu, nemainot PayrollCalculator un iepriekšējās klases.
employees.Add(new SalesEmployee("Marta", 500m, 4000m));

Console.WriteLine("--- pēc Marta pievienošanas ---");
foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}
Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");

// Paskaidrojums: Polimorfisms redzams izsaukumā e.CalculateSalary() (gan foreach ciklā šeit, gan
// PayrollCalculator.TotalSalary), jo katrs darbinieka veids šo metodi izpilda savādāk. PayrollCalculator
// nebija jāmaina, jo tas strādā ar abstrakto klasi Employee, tāpēc jaunu veidu var pievienot kā jaunu
// pēcteci (Open/Closed princips), un jebkurš pēctecis der visur, kur gaidīts Employee (Liskov princips).
