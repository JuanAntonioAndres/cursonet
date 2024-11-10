using ejemplo1;
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



