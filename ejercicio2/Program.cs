
namespace ejercicio3
{ 
  public class program
    {  

       static void Main(string[] args)
        { 
          //declaracion de variables
          decimal sueldoBase, venta1, venta2, venta3, totalComision, totalSalario, suma;
          const decimal COMISION = 10/100;

          //pedir datos
          Console.Write("ingrese su sueldo base: ");
          sueldoBase = Convert.ToDecimal(Console.ReadLine());

          Console.Write("ingrese su venta #1: ");
          venta1 = Convert.ToDecimal(Console.ReadLine());

          Console.Write("ingrese su venta #2: ");
          venta2 = Convert.ToDecimal(Console.ReadLine());

          Console.Write("ingrese su venta #3: ");
          venta3 = Convert.ToDecimal(Console.ReadLine());

            //calculos 
            suma = venta1 + venta2 + venta3;
            totalComision = suma * COMISION;
            totalSalario = sueldoBase + totalComision;

            //mostar 
            Console.WriteLine($"El total de comisiones ganadas fue de: ${totalComision}");
            Console.WriteLine($"El total de salario a liquidares es de: ${totalSalario}");
       }   
            
         
  } 
}