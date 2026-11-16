var calc1 = new Calculator(new ConsoleLogger());
calc1.Add(2, 3);

var memory = new MemoryLogger();
var calc2 = new Calculator(memory);
calc2.Add(10, 5);
calc2.Add(1, 1);

foreach (string line in memory.GetMessages())
{
    Console.WriteLine(line);
}

// Paskaidrojums: (a) Calculator balstās uz interfeisu ILogger, nevis uz konkrēto ConsoleLogger, lai
// žurnāla veidu varētu nomainīt, nemainot kalkulatora kodu - to prasa Dependency Inversion princips (D).
// (b) Lasīšana ir atsevišķā interfeisā ILogReader, lai klasēm, kas ziņas tikai izvada (ConsoleLogger),
// nebūtu jāīsteno nevajadzīga metode GetMessages() - to prasa Interface Segregation princips (I).
