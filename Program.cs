using System;

class DPRN_U2_A2_JOIT{//Declaración de la clase

public static void Main(){//metodo principal, el programa inicia aqui.

//Declaracion de todas las variables dentro del metodo Main, variables de uso global.
String ciudad1;
String ciudad2;
String ciudad3;
float numero1;
float numero2;
float numero3;

//Captura de los datos iniciales por parte del usuariop
 System.Console.Write("Favor de capturar el nombre de la primer ciudad: ");
 ciudad1=Console.ReadLine();//Captura de los datos que ha escrito el usuario
 System.Console.Write("Favor de capturar el nombre de la segunda ciudad: ");
 ciudad2=Console.ReadLine();//Captura de los datos que ha escrito el usuario
 System.Console.Write("Favor de capturar el nombre de la tercera ciudad: ");
 ciudad3=Console.ReadLine();//Captura de los datos que ha escrito el usuario
 System.Console.Write("Favor de capturar el primer numero: ");
 numero1 = float.Parse(Console.ReadLine());//captura de los datos que ha escrito el usuario
 System.Console.Write("Favor de capturar el segundo numero: ");
 numero2 = float.Parse(Console.ReadLine());//captura de los datos que ha capturado el usuario
 System.Console.Write("Favor de capturar el tercer numero: ");
 numero3 = float.Parse(Console.ReadLine()); //Captura de los datos que ha escrito el usuario
 System.Console.WriteLine(" ");
metodo1(ciudad1,ciudad2,ciudad3);//Invocacion del primer método en el metodo principal
metodo2(numero1,numero2,numero3);//invocacion del segundo método en el metodo principal

}
public static void metodo1(String ciudad1, String ciudad2, String ciudad3){//Creacion del primer metodo

System.Console.WriteLine("Salida del primer metodo");//impresion en pantalla
System.Console.WriteLine("1- " + ciudad1);//Impresion en pantalla del valor capturado por el usuario en la variable ciudad1
System.Console.WriteLine("2- " + ciudad2);//Impresion en pantalla del valor capturado por el usuario en la variable ciudad2
System.Console.WriteLine("3- " + ciudad3);//Impresion en pantalla del valor capturado por el usuario en la variable ciudad3
System.Console.WriteLine(" ");//Impresion en pantalla de un espacio para continuar con el método 2
}

public static void metodo2(float numero1, float numero2, float numero3){//Creación del segundo método

float reSuma;//Variable que contendrá el resultado de sumar los numeros dados por el usuario
float resRes;//Variable que contendrá el resultado de restar los numeros dados por el usuario
float resMulti;//Variable que contendrá el resultado de multiplicar los numeros dados por el usuario

reSuma=numero1+numero2+numero3;//Realizacion de la operación matemática de sumar los tres numeros dados por el usuario
resRes=numero1-numero2-numero3;//Realizacion de la operación matemática de restar los tres numeros dados por el usuario
resMulti=numero1*numero2*numero3;//Realizacion de la operación matemática de multiplicar los tres numeros dados por el usuario
System.Console.WriteLine("Salida del segundo metodo");//Impresión en pantalla de lanzamiento del segundo método
System.Console.WriteLine("Suma = " + reSuma);//Impresion en pantalla del resultado de la operación matemática de sumar los numeros dados por el usuario
System.Console.WriteLine("Resta = " + resRes);//Impresión en pantalla del resultado de la operación matemática de restar los numeros dados por el usuario
System.Console.WriteLine("Multiplicacion = " + resMulti);//Impresión en pantalla del resultado de la operación matemática de multiplicar los números dados por el usuario.

}//Fin del segundo método

}//Fin de la clase


