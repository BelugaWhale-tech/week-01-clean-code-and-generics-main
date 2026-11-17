

Console.WriteLine("Paired Beacons");
// TODO: Planlegg, opprett Pair.cs og PairDisplay.cs, og skriv testkallene her.
Pair<string> beaconI = new Pair<string>("North", "South");
PairDisplay.ShowPair(beaconI);

Pair<int> beaconII = new Pair<int>(12, 24);
PairDisplay.ShowPair(beaconII);

Beacon beaconA = new Beacon("A");
Beacon beaconB = new Beacon("B");
Pair<Beacon> beaconPair = new Pair<Beacon>(beaconA,beaconB);
Console.WriteLine(beaconPair.First.Name + " " + beaconPair.Second.Name);
