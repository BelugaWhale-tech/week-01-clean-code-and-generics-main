Recorder<string> recorder = new Recorder<string>();
recorder.Add("Orbit");
Console.WriteLine(recorder.Count);
Console.WriteLine(recorder.Contains("Orbit"));
Console.WriteLine(recorder.Contains("orbit"));
// TODO: Oppdater kallene når klassen er generalisert, og test med int.
Recorder<int> intRecorder = new Recorder<int>();
Console.WriteLine(intRecorder.Count);
Console.WriteLine(intRecorder.Contains(7));
intRecorder.Add(7);
intRecorder.Add(7);
Console.WriteLine(intRecorder.Count);
Console.WriteLine(intRecorder.Contains(7));
intRecorder.Clear();
Console.WriteLine(recorder.Count);
Console.WriteLine(intRecorder.Count);