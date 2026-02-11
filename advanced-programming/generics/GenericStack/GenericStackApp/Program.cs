

GenericStack<Person> stack = new GenericStack<Person>(new Person[5]);
stack.Push(new Person { FirstName = "John", LastName = "Doe", Age = 30 }, 0);
stack.Push(new Person { FirstName = "Jane", LastName = "Smith", Age = 25 }, 1);
Person person1 = stack.Pop(0);
Person person2 = stack.Pop(1);
System.Console.WriteLine(person1.GetData());
System.Console.WriteLine(person2.GetData());

interface IHasData
{
    string GetData();
}

class Person : IHasData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public string GetData()
    {
        return $"{FirstName} {LastName}, Age: {Age}";
    }
}

class GenericStack<T> where T : IHasData
{
    public T[] Items { get; set; }

    public GenericStack(T[] items)
    {
        Items = items;
    }

    public void Push(T item, int position)
    {
        if (position < 0 || position >= Items.Length)
        {
            throw new System.IndexOutOfRangeException("Position is out of bounds.");
        }
        Items[position] = item;
    }

    public T Pop(int position)
    {
        if (position < 0 || position >= Items.Length)
        {
            throw new System.IndexOutOfRangeException("Position is out of bounds.");
        }
        T item = Items[position];
        Items[position] = default(T);
        return item;
    }
}