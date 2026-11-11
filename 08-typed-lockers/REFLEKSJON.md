# Refleksjon — Typed Lockers

## Plan før koding
opprett to lockers, ett med innhold "beacon" og ett med innhold (42), les av innhold. erstatt innhold med "relay" og (99), les innhold for å bekrefte endring.  

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|textLocker = new Locker<string>(beacon)|textLocker.Read viser Beacon.|Textlocker.Read viser beacon.|
|intLocker = new Locker<int>(42)| intLocker.Read viser 42.|intLocker.Read viser 42|
|textLocker.Read         | skriver ut Beacon  | skriver ut Beacon.
|intLocker.Read           |skriver ut 42       |skriver ut 42.
|textLocker.replace("relay")| erstatter beacon med relay| erstatter beacon med relay|
intLocker.repalce(99)       |erstatter 42 med 99| erstatter 42 med 99|
|intlocker.replace ("jasså")| feilmelding   | errorcs1503 cannot convert from string to int
| | | |

## Forklaring

Hva er forskjellen mellom typeargumentet int og konstruktørargumentet 42?

Mitt svar: type argumentet bestemmer typen mens konstruktur argumentet er ett bestemt argument? mener da at som type kan selve argumentet være hva som helst sålenge det er riktig type(int i dette tilfellet(sålenge deter helttall, tekstverider kan ikke være innholdet)) mens konstruktør argumentet bestemer hva som sendes inn når skapet opprettes. 
T angir hvilken type innhold skapet har. T brukes flere steder i Locker.cs, som typen til feltet _content, som typen konstruktøren tar imot, som typen read() returnerer og som typen replace() tar imot. 
## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
