class Program
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void greet()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
    static void Main()
    {
        Person person = new Person("John", 30);
        Person person2 = new Person("a", 0);
        person2.Name = "Jane";
        person2.Age = 25;
        Console.WriteLine("Hello World!");
        person.greet();
        person2.greet();
    }
}
