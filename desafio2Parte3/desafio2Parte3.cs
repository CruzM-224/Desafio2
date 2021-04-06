using System;

class MainClass {
  public static void Main (string[] args) {
    string[] sucursales = new string[5];
    Double[] ganancias = new Double[5];
    int[] empleados = new int[5];
    int menores25mil = 0, mayores25mil = 0;
    Double gananciastotales = 0;

    for(int cont = 0; cont < 5; cont++){
      Console.WriteLine ("Ingrese el nombre de la sucursal, sus ganancias y el numero de empleados");

      sucursales[cont] = Console.ReadLine();

      ganancias[cont] = Double.Parse(Console.ReadLine());
      
      while(ganancias[cont] < 1000){
        Console.WriteLine("No puede ingresar ganancias menores a 1000, ingrese nuevamente las ganancias");
        ganancias[cont] = Double.Parse(Console.ReadLine());
        if(ganancias[cont] <= 25000){
          menores25mil++;
        }else{
          mayores25mil++;
        }
      }

      gananciastotales += ganancias[cont];

      if(ganancias[cont] <= 25000){
        menores25mil++;
      }else{
        mayores25mil++;
      }

      empleados[cont] = int.Parse(Console.ReadLine());
      
       while(empleados[cont] < 10){
        Console.WriteLine("No puede ingresar un numero de empleados menor a 10, ingrese nuevamente los empleados");
        empleados[cont] = int.Parse(Console.ReadLine());
      }
    }

    if(menores25mil != 0){
      Console.WriteLine("Sucursales que obtienen ganancias entre $1,000 y $25,000 son: " + menores25mil);
    }
    for(int cont = 0; cont < 5; cont++){
      if(ganancias[cont] <= 25000){
        Console.WriteLine("Nombre: " + sucursales[cont] + " (Regular)");
        Console.WriteLine("Ganancias: $" + ganancias[cont]);
        Console.WriteLine("Empleados: " + empleados[cont]);
      }
    }

    if(mayores25mil != 0){
      Console.WriteLine("Sucursales que obtienen ganancias mayores de $25,000 son: " + mayores25mil);
    }
    for(int cont = 0; cont < 5; cont++){
      if(ganancias[cont] >= 30000){
        Console.WriteLine("Nombre: " + sucursales[cont] + " (Bien hecho)");
        Console.WriteLine("Ganancias: $" + ganancias[cont]);
        Console.WriteLine("Empleados: " + empleados[cont]);
      }else{
        if(ganancias[cont] > 25000){
          Console.WriteLine("Nombre: " + sucursales[cont] + " (Regular)");
          Console.WriteLine("Ganancias: $" + ganancias[cont]);
          Console.WriteLine("Empleados: " + empleados[cont]);
        }
      }
    }

    Console.WriteLine("Ganancia Total de la Empresa: $" + gananciastotales);
  }
}