# Refleksjon — Flight History

## Plan før koding
fullfør History<T>, sørge for at GetSnapShot returnerer liste med historikkens elementer, sørge for at History og SnapShot kan endres uavhengig av hverandre. Clear skal tømme historikk og la Snapshot forbli urørt. teste med string og int(?) samtidig sikre oss at snapshot ikke vokser når history får nytt element. 

- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
|_items.Count();         |leser antallet lagret i samling |leser antallet lagret i samling |
|_items.Add(item);        |oppbevare element i liste. |oppbevarer element i liste.|
list<T> snapshot = new List <T>(_items); return new List<T>(_items);| Lager ett "snapshot" av listen som er uavhengig av den orginale| lager ny liste som er uavhengig av den orginale| 
| _items.Clear();         | tømmer historikken i listen| tømmer historikken i listen.|


## Forklaring

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

Mitt svar: 

## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
