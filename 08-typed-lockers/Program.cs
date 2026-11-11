Console.WriteLine("Typed Lockers");
// TODO: Opprett, bruk og test to skap med ulike typeargumenter.
Locker<string> textLocker = new Locker<string>("Beacon");
Locker<int> intLocker = new Locker<int>(42);
Console.WriteLine(textLocker.Read());
Console.WriteLine(intLocker.Read());