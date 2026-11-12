# Refleksjon — Signal Printer

## Plan før koding

- lag generisk PrintStrings metode, gi nytt navn som beskriver bedre at dette er en generisk metode. 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|list<int> numbers= new list<int>()|lager ny liste med int parameter|lager ny liste med int parameter|
|list<int>emptyNumbers = new list<int>()|lager ny liste med int|lager ny liste med int|
|SignalPrinter.PrintItems<string>(messages);|forventer at innholdet i messages skrives ut| innholdet i messages skrives ut|
|numbers.Add(44)         |44 legges til i numbers listen.|44 blir lagt til i numbers listen|
SignalPrinter.PrintItems(numbers);| skriver ut innholdet i numbers listen| innholdet skrives ut|
SignalPrinter.PrintItems(emptyNumbers);|forventes at emptyNumbers skrives ut, ingen innhold.| emptyNumbers skrives ut, ingen utskrift da listen er tom.

| | | |

## Forklaring

Hvor er T deklarert, og hvordan skiller dette seg fra Recorder<T>?

Mitt svar:Her er T deklarert i metoden, ikke klassen. det skiller seg vel ut ved at nå bruker ikke hele klassen generics, kun PrintItems metoden.

## Hva endret jeg, og hvorfor?

her endret jeg type parameteret i Print metoden. 

## Hva trenger jeg mer øving på?

