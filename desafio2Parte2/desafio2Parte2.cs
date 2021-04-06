using System;

class MainClass {
  public static void Main (string[] args) {
    int multiplos3 = 0, multiplos5 = 0, temp;

    Console.WriteLine ("Ingrese 10 numeros enteros");
    for(int cont = 0; cont < 10; cont++){
      temp = int.Parse(Console.ReadLine());

      if(temp < 0 || temp > 500){
        Console.WriteLine("No se pueden ingresar numeros negativos o mayores a 500, ingrese un valor valido");
        cont--;
      }else{
        if(temp % 3 == 0){
          multiplos3++;
        }
        if(temp % 5 == 0){
          multiplos5++;
        }
      }
    }

    Console.WriteLine("El numero de valores multiplos de 3 es de: " + multiplos3);
    Console.WriteLine("El numero de valores multiplos de 5 es de: " + multiplos5);
  }
}