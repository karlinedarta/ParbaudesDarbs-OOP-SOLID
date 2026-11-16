public class BookPrinter
{
    public void Print(Book book)
    {
        string state = book.IsBorrowed ? "izsniegta" : "brīva";
        Console.WriteLine($"{book.Title} ({book.Author}) - {state}");
    }
}
