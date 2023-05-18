
// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/


/*float floatNum1 = 0;
float inverso = 0;
float aux = 0;
bool anda = false;
string? numString = "";
while(!anda){


    Console.WriteLine("Ingrese un numero: ");
    numString = Console.ReadLine();
    anda = float.TryParse(numString,out floatNum1);

    if(!anda){
        Console.WriteLine(numString + "no es un numero valido");
    } else if(floatNum1 == 0){
        Console.WriteLine("Ingrese un numero distinto de 0");

    }else{
        while(floatNum1 != 0){
        aux = floatNum1%10;
        inverso = (inverso*10)+aux;
        floatNum1 = floatNum1/10; 
        }
        Console.WriteLine("El numero inverso es:"+inverso);
    }
}
*/

int decision;
float n1;
float n2;
float solucion;

Console.WriteLine("Que operacion quiere realizar?\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n");
decision = int.Parse(Console.ReadLine());

if(decision == 1){
    Console.WriteLine("Ingrese los numeros a sumar");
    n1 = float.Parse(Console.ReadLine());
    n2 = float.Parse(Console.ReadLine());
    solucion = n1 + n2;
    Console.WriteLine(solucion);
}else if(decision == 2){
    Console.WriteLine("Ingrese el numero a restar");
    n1= float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el restando");
    n2= float.Parse(Console.ReadLine());
    solucion = n1 - n2;
    Console.WriteLine(solucion);
} else if(decision == 3){
    Console.WriteLine("Ingrese los numeros a multiplicar");
    n1= float.Parse(Console.ReadLine());
    n2 = float.Parse(Console.ReadLine());
    solucion = n1*n2;
    Console.WriteLine(solucion);
}else if(decision ==4){
    Console.WriteLine("Ingrese el dividendo");
    n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el divisor");
    n2 = float.Parse(Console.ReadLine());
    solucion = n1/n2;
    Console.WriteLine(solucion);
}





