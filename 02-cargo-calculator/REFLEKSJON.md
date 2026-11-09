# Refleksjon — Cargo Calculator

## Plan før koding
skriv egen metode for beregning av gjennverende kapasitet

- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|12, 5                   |Remaining: 7        |Remaining: 7      |
|20, 8                   |Remaining: 12       |Remaining: 12     |
|5, 5                    |Remaining: 0        |Remaining: 0      |


## Forklaring

Hva er parameterne, argumentene og returverdien i ett av kallene dine?

Mitt svar: i ett kall som CalculatedRemainingCapacity(firstCapacity, firstUsedCapacity), er capacity og usedCapacity parameterene. Argumentene er firstCapacity og firstUsedCapacity. Returverdien er resultatet av beregningen, for eksempel 7 når kapasitet er 12 og brukt kapasitet er 5

## Hva endret jeg, og hvorfor?
Jeg flyttet beregningen til egen metode siden samme regnestykket ble brukt to ganger. Nå har koden ett ansvar, beregne ledig kapasitet. Det gjør koden enklere å lese og lettere å vedlikeholde.

## Hva trenger jeg mer øving på?
argumenter og parametere
