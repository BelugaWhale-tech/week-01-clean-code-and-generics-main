History<string> history = new History<string>();
history.Add("Launch");
history.Add("Orbit");
List<string> snapshot = history.GetSnapshot();
Console.WriteLine(history.Count);
Console.WriteLine(snapshot.Count);
snapshot.Clear();
Console.WriteLine(history.Count);
// TODO: Legg til resten av testene, også med int.
Console.WriteLine(snapshot.Count);
List<string> snapshot2 = history.GetSnapshot();
snapshot2.Add("Landing");
history.Clear();
Console.WriteLine(history.Count);
Console.WriteLine(snapshot2.Count);
