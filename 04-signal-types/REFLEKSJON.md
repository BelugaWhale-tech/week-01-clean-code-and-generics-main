# Refleksjon — Signal Types

## Plan før koding
label er string 
retries er merket som var men er int
result er string 
messages er List<string> 

- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|        |---|---|
|Aktivert: messages.Add(42);| listen krever string, ikke int, forventer kompileringsfeil |kan ikke konvertere fra int til string. det blir ikke lagt til en melding, kompileringsfeil |
|Aktivert: retries = "three"| her forventer jeg også en kompileringsfeil, string kan ikke tilordnes til int. |cannot implicity convert type 'string' to 'int'.|




## Forklaring

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

Mitt svar:
string i List<string> er en type, var retries kan ikke bli tekst da den ble deklarert som int tidligere i koden. derfor kan ikke retries få tekstverdi. i metodehodet RepeatLabel(string message) er message parameteren, i kallet RepeatLabel(label) er label argumentet. 


## Hva endret jeg, og hvorfor?

her endret jeg ingenting. testet med de utkommenterte linjene og fikk type feil(?) 42 kan ikke legge til da 'messages' har typen List<string> ikke int. jeg legger til en ny string på en linje under og resultatet kommer i messages.Count.

## Hva trenger jeg mer øving på?
her trenger jeg nok mer øving på argumenter og parametere, forkjellen på dem og hva som beholder hvor. 

