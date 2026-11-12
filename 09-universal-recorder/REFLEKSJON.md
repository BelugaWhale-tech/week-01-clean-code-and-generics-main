# Refleksjon — Universal Recorder

## Plan før koding
Gjøre recording class generic, oppdatere body deretter. 
- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|ny recorder<int>        |count 0, contains(7) false|count 0, contains (7) false|
|leggg til 7 to ganger   |count 2, contains (7) true |count 2, contains (7) true |
|clear                   |count 0, contains (7) false|count 0, contains (7) false|
Recorder<string>"Orbit"  |Contains("Orbit") true, Contains("orbit") false| Contains("Orbit") true, Contains("orbit") false|
To 'Containers"          |Endring i en påvirker ikke den andre| Endring i intRecorder() påvirker ikke innholdet i recorder()|

## Forklaring

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

Mitt svar: er ikke alle typer som trenger å være generisk? bool og int for count har satte verdier som ikke trenger å være generisk.

## Hva endret jeg, og hvorfor?
endret list<string> til list<T>, .Add og .Contains fikk T som parameter, .Count og bool resultatene ble beholdt. 

## Hva trenger jeg mer øving på?
Trenger mer øving på når typeparameter skal brukes, og når det ikke er nødvendig å bruke. 
