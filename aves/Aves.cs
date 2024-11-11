namespace aves;

public abstract class Ave (int peso) {
    public int Peso {get; init;} = peso;

}

public abstract class AveNoVoladora (int peso) : Ave(peso){

} 

public abstract class AveVoladora (int peso, int velocidad) : Ave(peso){

    public int Velocidad {get; init;} = velocidad;

}

 public class Pinguino (int peso) : AveNoVoladora(peso){

 }

 public class Aguila (int peso, int velocidad) : AveVoladora(peso, velocidad) {
    
 }