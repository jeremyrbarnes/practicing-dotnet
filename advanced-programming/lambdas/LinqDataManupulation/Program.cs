List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 30, Salary = 50000 },
    new Person { Name = "Bob", Age = 25, Salary = 45000 },
    new Person { Name = "Charlie", Age = 35, Salary = 60000 },
    new Person { Name = "David", Age = 28, Salary = 48000 },
    new Person { Name = "Eve", Age = 32, Salary = 55000 }
}; 

Console.WriteLine("Please enter a name to find: ");
string nameToFind = Console.ReadLine();

var person = people.FirstOrDefault(p => p.Name.Equals(nameToFind, StringComparison.OrdinalIgnoreCase));
if (person != null)
{
    Console.WriteLine($"Found: {person.Name}, Age: {person.Age}, Salary: {person.Salary}");
}
else
{
    Console.WriteLine("Person not found.");
}

Console.WriteLine("The total age for all people in the list is: " + people.Sum(p => p.Age));

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
}

