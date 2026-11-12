List<string> messages = new List<string> { "SOS", "ACK" };
// TODO: Oppdater kallet og legg til heltall og en tom liste.
List<int> numbers = new List<int>();
List<int> emptyNumbers = new List<int>();
SignalPrinter.PrintItems<string>(messages);
numbers.Add(44);
SignalPrinter.PrintItems(numbers);
SignalPrinter.PrintItems(emptyNumbers);
