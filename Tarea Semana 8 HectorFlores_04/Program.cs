// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

string bin = " ";


Console.WriteLine("Ingrese el numero a convertir a binario");
 int num = int.Parse(Console.ReadLine());

while (true)
{
  
    
        if ((num % 2) == 0)
        {

            bin = ( (num%2) + bin);


        }
        else if((num % 2) == 1)
        {
            bin = ((num % 2) + bin);
        }

        num /= 2;

    
    if(num <= 0) { 

        break;


    }

}
Console.Write("El numero binario es " + bin);
Console.ReadKey();
Console.Clear();


Console.WriteLine("Ingrese el numero a convertir en el sistema hexadecimal");
int n1 = int.Parse(Console.ReadLine());

string hex = " ";

while (true)
{


    if ((n1 % 16) != 0)
    {
        if ((n1 % 16) > 9)
        {
            switch (n1 % 16)
            {
                case 10:
                    hex = "A" + hex;
                    break;
                case 11:
                    hex = "B" + hex;
                    break;
                case 12:
                    hex = "C" + hex;
                    break;
                case 13:
                    hex = "D" + hex;
                    break;
                case 14:
                    hex = "E" + hex;
                    break;
                case 15:
                    hex = "F" + hex;
                    break;

            }
        }
        else
        {
            hex = (n1 % 16) + hex;

        }






    }
    else
    {
        hex = "0" + hex;
    }
    n1 /= 16;
    if(n1 <= 0)
    {
        break;
    }

        
}

Console.Write("el numero es: " + hex);       
Console.ReadKey();
Console.Clear();
  