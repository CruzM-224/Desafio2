using System;

class MainClass {
  public static void Main (string[] args) {
    string[] nombres = new string[5];
    Double[,] notas = new Double[5,5];
    Double[] promedios = new Double[5];
    string alumnopromMayor = "a", alumnopromMenor = "a";
    Double promMayor = 0, promMenor = 10, totaltemp = 0;

    for(int cont = 0; cont < 5; cont++){
      Console.WriteLine ("Ingrese el nombre del alumno y sus 5 notas");
      nombres[cont] = Console.ReadLine();
      totaltemp = 0;
      for(int cont2 = 0; cont2 < 5; cont2++){
        notas[cont,cont2] = Double.Parse(Console.ReadLine());
        if(notas[cont,cont2] < 0 || notas[cont,cont2] > 10){
          cont2--;
          Console.WriteLine("El numero no debe ser negativo ni mayor que 10, ingrese un numero valido");
        }else{
          totaltemp += notas[cont,cont2];
        }
      }

      if(totaltemp/5 > promMayor){
        alumnopromMayor = nombres[cont];
        promMayor = totaltemp/5;
      }
      if(totaltemp/5 < promMenor){
        alumnopromMenor = nombres[cont];
        promMenor = totaltemp/5;
      }
      promedios[cont] = totaltemp/5;
    }

    for(int cont = 0; cont< 5; cont++){
      if(promedios[cont] >= 7){
        Console.WriteLine("Alumno: " + nombres[cont] + " (Aprobado)");
      }else{
        if(promedios[cont] >= 4){
          Console.WriteLine("Alumno: " + nombres[cont] + " (Regular)");
        }else{
          Console.WriteLine("Alumno: " + nombres[cont] + " (Reprobado)");
        }
      }

      if(alumnopromMayor == nombres[cont]){
        Console.WriteLine("Promedio: " + promedios[cont] + " (Mayor promedio)");
      }else{
        if(alumnopromMenor == nombres[cont]){
          Console.WriteLine("Promedio: " + promedios[cont] + " (Menor promedio)");
        }else{
          Console.WriteLine("Promedio: " + promedios[cont]);
        }
      }
    }
  }
}