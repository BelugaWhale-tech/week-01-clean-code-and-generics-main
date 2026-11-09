

var crewMembers = new List<string> { "Ada", "Bo", "Cy" };


Console.WriteLine($"Crew: {crewMembers.Count}");


if (crewMembers.Count >= 3)
    {
        Console.WriteLine("Ready");
    }
else
    {
        Console.WriteLine("Waiting");
    }