namespace ejemplo1;

class Boo{
    public int Id {get; set;}

    public string Name {get; set;}

    public Boo(string name){
        Name = name;
        Console.WriteLine(Name);
    }
}