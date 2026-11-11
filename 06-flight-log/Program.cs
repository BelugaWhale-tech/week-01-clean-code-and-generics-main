FlightLog log = new FlightLog();
Console.WriteLine(log.Count);
log.Add("Launch");
log.Add("Orbit");
Console.WriteLine(log.Count);
log.Clear();
Console.WriteLine(log.Count);

FlightLog logI = new FlightLog();
Console.WriteLine(logI.Count);
logI.Add("Orbit2");
logI.Add("launch2");
Console.WriteLine(logI.Count);
Console.WriteLine(log.Count);
logI.Clear();
logI.Clear();
Console.WriteLine(logI.Count);
logI.Add("");
Console.WriteLine(logI.Count);
logI.Add("Landing");
Console.WriteLine(logI.Count);

