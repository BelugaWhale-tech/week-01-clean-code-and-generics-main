# Refleksjon — Flight Log

## Plan før koding
skriv fungerende count, add og clear.

- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|ny log()=ny log 0     |---|
|log.add ("launch"), log.add ("orbit") | log.count 2| log.count 2|
|log.clear()           |log.count = 0         |log count er 0 

|ny logI()=ny logI()   |lager ny log          |ny log laget
|logI.Count            |logI count er 0       |logI er 0 
|logI.Add("orbit2)     |logI count er 1       |logI count er 1

## Forklaring

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?

Mitt svar:
dataen blir lagret dobbelt, overskriver allerede eksisterende data. 
Refleksjonsendring: dataen vil ikke automatisk bli overskrivd, men kan komme ut av takt med listen hvis en endring oppdaterer listen uten å oppdatere telleren.


## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
her brukte jeg mye tid på count, må se på det så jeg får litt mer forståelse på hvordan det fungerer.

