# Refleksjon — Launch Rules

## Plan før koding
Planlegge for tidlig retur, endre parameterene til å returnere false.


- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|3, 50, true             |true                |true              |
|2, 50, true             |false               |false             |
|3, 49, true             |false               |false             |
|3, 50, false            |false               |false             |
|4, 80, true             |true                |true 

## Forklaring

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

Mitt svar: Må vel være fordi jeg ikke skriver ny men heller endrer parameterene i eksisterende kode, flytter sjekkene til de tidligeste returnene så metoden blir enklere å lese uten å endre oppførsel

## Hva endret jeg, og hvorfor?

jeg endret parameterene i denne oppgave, det for at koden skal melde tidlig return og avslutte programet

## Hva trenger jeg mer øving på?
