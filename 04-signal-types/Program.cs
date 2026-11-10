

string label = "READY";
var retries = 3;
List<string> messages = new List<string> { label };
string result = RepeatLabel(label);
Console.WriteLine(result);
//messages.Add(42);
//retries = "three";

messages.Add("second string added");
messages.Count();
Console.WriteLine(messages.Count);

static string RepeatLabel(string message)
{
    return $"Echo: {message}";

}
