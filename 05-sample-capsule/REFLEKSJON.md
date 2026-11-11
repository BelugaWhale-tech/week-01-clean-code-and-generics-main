# Refleksjon — Sample Capsule

## Plan før koding
fullfør stringcapsule slik at en instanse av objektet oppbevares. så retrunere inneholdet i objektet. gi replace funksjonalitet til å endre instansen men ikke selve objektet(?)
- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|public StringCapsule(string content) _content = content;|forventet at objektet oppbevares|---|
|opprett first med dust  |first read() er dust|first read() er dust|
|opprett secondt med""   | second.read() er emtpy| second.read() er empty|
opprett first.Replace med ""| first.replace er empty|first.Replace() er empty|

## Forklaring

Hvorfor skal _content være et instansfelt og ikke static?

Mitt svar:

en instan kan endres uavhengig av opphavet(?), det gjør også at alle metoder som kaller på objektet får sin egen instanse av objektet. om det var static ville alle objekten fått samme verdi.
så _content burde være instans fordi hver kapsel skal beholde sin egen tekst.

## Hva endret jeg, og hvorfor?


## Hva trenger jeg mer øving på?
