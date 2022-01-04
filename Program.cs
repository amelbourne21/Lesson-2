// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
var name = Console.ReadLine()?.Trim();

Console.WriteLine("Pick one of the three words for each category");

Console.WriteLine("Mythical creature: unicorn, dragon or griffin");
var mythicalCreature = Console.ReadLine()?.Trim();

Console.WriteLine("Destination: France, Nepal or Japan");
var travelDestination = Console.ReadLine()?.Trim();

Console.WriteLine("Mode of transport: helicopter, jet or submarine");
var transport = Console.ReadLine()?.Trim();

Console.WriteLine("adjective: weird, funny or boring");
var adjective1 = Console.ReadLine()?.Trim();

Console.WriteLine("Plural noun: birds, flowers or pebbles");
var pluralNoun = Console.ReadLine()?.Trim();

Console.WriteLine("Superpower: being magnetic, partial invisibility or speaking backwards");
var superpower = Console.ReadLine()?.Trim();

Console.WriteLine($"{name} was the last person on earth to own a {mythicalCreature}. The only vet that existed for a {mythicalCreature} lived in {travelDestination} and the only way to get there was by {transport}. {name} decided to take Charlie the {mythicalCreature} to the vet today because he had developed a {adjective1} {superpower} and they were not sure if this was normal. Turns out this only happens if the {mythicalCreature} eats {pluralNoun} and that Charlie should lose this new ability the second he stops eating {pluralNoun}.");
