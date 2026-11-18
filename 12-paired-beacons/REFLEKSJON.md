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
|Pair<Beacon> beaconPairII = new Pair<Beacon> (beaconC, beaconD);| at eldre pair beacon data ikke overskrives.| eldre par beholder og nytt par skriver ut "C" og "D" 
|prøve å tilordne first fra program.cs| kompileringsfeil, ikke mulig å tilordne fra program.cs | kompileringsfeil, fjern feilkallet.


## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir? 


Mitt svar:det Pair<T> trenger ikke kjenne beacon egenskapen Name fordi den bare lagrer verdier av typen T. her gir generics oss gjenbrukbar kode, koden brukes til både tekst, tall og Beacon i stedet for å lage en egen pair-class for hver av typene så har vi en. 

## Hva endret jeg, og hvorfor? 
det var vel ikke mye endring her? 

## Hva trenger jeg mer øving på? 
her trenger jeg mer øving på hvordan jeg skal bruke det jeg har lært, denne oppgaven tok tid.
