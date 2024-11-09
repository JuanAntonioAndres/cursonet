using ejemplo1;
Foo foo1 = new Foo{Name = "Juan"};

Foo foo2 = new Foo{Name = "Juan Antonio Andres Hernandez"};

var foo3 = new Foo() {Name = "Francisco Andres Anton"};

Console.WriteLine(foo1.Name);
Console.WriteLine(foo2.Name);
Console.WriteLine(foo3.Name);

var boo = new Boo("Lucas");

