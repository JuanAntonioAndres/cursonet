using ejemplo1;
using aves;

Foo foo1 = new Foo{Name = "Juan"};

Foo foo2 = new Foo{Name = "Juan Antonio Andres Hernandez"};

var foo3 = new Foo() {Name = "Francisco Andres Anton"};

Console.WriteLine(foo1.Name);
Console.WriteLine(foo2.Name);
Console.WriteLine(foo3.Name);

var boo = new Boo("Lucas");

Console.WriteLine(boo.Name);

boo.Name = "Marcos";

Console.WriteLine(boo.Name);

var boo2 = new Boo2("Pedro");

// No es posible cambiar el valor de Name, ya que es privado
//boo2.Name = "Ismael";

Console.WriteLine(boo2.Name);

boo2.ChangeName("Ismael");

Console.WriteLine(boo2.Name);

//Comparar que dos objetos son iguales 

var objectsEquals1 = new ObjectsEquals(1,"Objeto 1");
var objectsEquals2 = new ObjectsEquals(1,"Objeto 1");

Console.WriteLine(objectsEquals1.Equals(objectsEquals2));
/*
// override object.Equals
public override bool Equals(object obj)
{
    //
    // See the full list of guidelines at
    //   http://go.microsoft.com/fwlink/?LinkID=85237
    // and also the guidance for operator== at
    //   http://go.microsoft.com/fwlink/?LinkId=85238
    //
    
    if (obj == null || GetType() != obj.GetType())
    {
        return false;
    }
    
    // TODO: write your implementation of Equals() here
    throw new System.NotImplementedException();
    return base.Equals (obj);
}

// override object.GetHashCode
public override int GetHashCode()
{
    // TODO: write your implementation of GetHashCode() here
    throw new System.NotImplementedException();
    return base.GetHashCode();
})

*/

// Uso de Record

var persona1 = new Persona ("Juan Antonio", "Andres Hernandez");
var persona2 = new Persona ("Juan Antonio", "Andres Hernandez");
var persona3 = new Persona ("Jose Antonio", "Andres Hernandez");

Console.WriteLine(persona1.Equals(persona2));
Console.WriteLine(persona1 == persona2);
Console.WriteLine(persona1.Equals(persona3));
Console.WriteLine(persona1 == persona3);

public readonly record struct Persona(string FirstName, string LastName);


// Ejemplo de Aves 


var aguila = new Aguila(10, 100);

Ave pinguino = new Pinguino(5);
