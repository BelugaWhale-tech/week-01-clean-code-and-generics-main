# Refleksjon — Paired Beacons

## Plan før koding
planlegg dataen, konstruktøren og de offentlige medlemmene Pair.cs og PairDisplay.cs

paret skal huske to verdier, en i First og en i Second.

Pair display skal vise par. 

verdiene gies når paret opprettes og skal ikke kunne endres utenifra etterpå
- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
|North, South            |first er North, Second er South. begge skrives ut. |PairDisplay.Showpair(beaconI); skriver begge |
|12, 24.                 | first er 12, second er 24. begge skrives ut.|PairDisplay.Showpair(beaconII); skriver ut begge.|
|to ny beacon objekter med navn "A" og "B" lagt i beaconPair| console.writeline(beaconpair.first.name + beaconpair.second.name); skriver ut navnet på begge objektene.| skriver ut "A" og "B"|


## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?


Mitt svar:

## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
