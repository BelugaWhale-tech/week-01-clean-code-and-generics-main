
int firstCapacity = 12;
int firstUsedCapacity = 5;

int secondCapacity = 20;
int secondUsedCapacity = 8;

// TODO: Trekk ut beregningen i en statisk metode.

 static int CalculatedRemainingCapacity(int capacity, int usedCapacity)
{
    int calculatedRemainingCapacity = capacity - usedCapacity;
    return calculatedRemainingCapacity;
    
}
    
    Console.WriteLine($"Remaining: {CalculatedRemainingCapacity(firstCapacity, firstUsedCapacity)}");
    Console.WriteLine($"Remaining: {CalculatedRemainingCapacity(secondCapacity, secondUsedCapacity)}");