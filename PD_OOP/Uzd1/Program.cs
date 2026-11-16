Console.OutputEncoding = System.Text.Encoding.UTF8;

var book = new Book("Zelta zirgs", "Rainis");
var printer = new BookPrinter();

Console.WriteLine(book.Borrow());   // True
Console.WriteLine(book.Borrow());   // False
printer.Print(book);
Console.WriteLine(book.Return());   // True
printer.Print(book);

// Paskaidrojums: IsBorrowed ir ar private set, lai stāvokli varētu mainīt tikai pati klase Book caur
// metodēm Borrow() un Return() (enkapsulācija). Book un BookPrinter ir atsevišķas klases, jo pēc
// Single Responsibility principa (S) katrai klasei ir tikai viens iemesls mainīties: dati vai izvade.
