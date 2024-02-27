Console.WriteLine("Welcome to StandupBOT!");
Console.WriteLine("Please enter the file path to the jokes file: ");

var filePath = Console.ReadLine();
filePath = filePath.Replace("\"", "");

var jokes = new Dictionary<string, string>();

using (StreamReader sr = new StreamReader(filePath))
{
	while (!sr.EndOfStream)
	{
		string joke = sr.ReadLine();
		string punchline = sr.ReadLine();
		jokes.Add(joke, punchline);
	}
}

Console.WriteLine($"Read {jokes.Count} jokes");

var rand = new Random();

Console.WriteLine("Press enter to get a joke or type 'exit' to quit");
while (true)
{
	string input = Console.ReadLine();
	if (input == "exit")
	{
		break;
	}
	else
	{
		var index = rand.Next(jokes.Count);
		var joke = jokes.ElementAt(index).Key;
		var punchline = jokes.ElementAt(index).Value;
		Console.WriteLine(joke);
		Console.WriteLine($"{punchline}\n");
	}
}