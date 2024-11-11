namespace ejemplo1;

class Boo{
    public int Id {get; set;}

    public string Name {get; set;}

    public Boo(string name){
        Name = name;
        Console.WriteLine(Name);
    }
}

class Boo2 {
        public int Id {get; set;}

    public string Name {get; private set;}

    public Boo2(string name){
        Name = name;
        Console.WriteLine(Name);
    }
    public void ChangeName(string name) {
        Name = name;

    }

 class Boot {
        public int Id {get; set;}

    public string Name {get; init;}

    public Boot(string name){
        Name = name;
        Console.WriteLine(Name);
    }
    public void ChangeName(string name) {
    // No se puede asignar valor a una propiedad si el atributo es init, ya que solo permite inicializar 
    //    Name = name;

    }   

    class ObjectCompare {

    }

}
}