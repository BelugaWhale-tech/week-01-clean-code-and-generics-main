List<string> messages = new List<string> { "SOS", "ACK" };
SignalPrinter.PrintItems(messages);
// TODO: Oppdater kallet og legg til heltall og en tom liste.
List<int> numbers = new List<int>(67);
SignalPrinter.PrintItems(numbers);
numbers.Add(44);
SignalPrinter.PrintItems(numbers);
