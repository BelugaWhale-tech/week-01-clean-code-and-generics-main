Recorder<string> recorder = new Recorder<string>();
recorder.Add("Orbit");
Console.WriteLine(recorder.Count);
Console.WriteLine(recorder.Contains("Orbit"));
// TODO: Oppdater kallene når klassen er generalisert, og test med int.
