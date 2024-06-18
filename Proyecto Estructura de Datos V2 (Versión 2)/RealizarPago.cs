using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estructura_de_Datos_V2__Versión_2_
{
    internal class RealizarPago
    {

        public static int[] numeroPago { get; set; } = new int[10];
        public static int[] numeroFactura { get; set; } = new int[10];
        public static int[] numeroCaja { get; set; } = new int[10];
        public static float[] montoPagar { get; set; } = new float[10];
        public static double [] comision { get; set; } = new double [10];
        public static double[] montoDeducido { get; set; } = new double[10];
        public static float[] pagoCliente { get; set; } = new float[10];
        public static float[] vuelto { get; set; } = new float[10];
        public static int[] tipoServicio { get; set; } = new int[10];

        public static string[] cedula { get; set; } = new string[10];
        public static string[] nombre { get; set; } = new string[10];
        public static string[] apellido1 { get; set; } = new string[10];
        public static string[] apellido2 { get; set; } = new string[10];
        public static string[] fecha { get; set; } = new string[10];
        public static string[] hora { get; set; } = new string[10];

        public static int indice = 1;



        public static void InicializarVectores()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                numeroPago[i] = 0;
                numeroFactura[i] = 0;
                montoPagar[i] = 0;
                comision[i] = 0;
                montoDeducido[i] = 0;
                pagoCliente[i] = 0;
                vuelto[i] = 0;
                numeroCaja[i] = 0;
                tipoServicio[i] = 0;


                cedula[i] = String.Empty;
                nombre[i] = String.Empty;
                apellido1[i] = String.Empty;
                apellido2[i] = String.Empty;
                fecha[i] = String.Empty;
                hora[i] = String.Empty;

            }//Fin del for


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vectores inicializados correctamente");
            Console.Read();
        }//Fin de Inicializar vectores



        public static void HacerPago()
        {
            char op = 'n';

            do
            {
                Console.WriteLine("Número de pago: " + indice);
                Console.WriteLine("Ingrese la fecha : ");
                fecha[indice] = Console.ReadLine();
                Console.WriteLine("Ingrese la hora: ");
                hora[indice] = Console.ReadLine();
                Console.WriteLine("Digite su cédula: ");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("Digite su nombre: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite su Primer Apellido: ");
                apellido1[indice] = Console.ReadLine();
                Console.WriteLine("Digite su Segundo Apellido: ");
                apellido2[indice] = Console.ReadLine();
                NumCaja();         
                Console.WriteLine("Digite el tipo de servicio: 1 - Recibo de Luz, 2 - Recibo Telefónico, " +
                    "3 - Recibo de Agua");
                int.TryParse(Console.ReadLine(), out tipoServicio[indice]);
                Console.WriteLine("Digite el número de Factura: ");
                int.TryParse(Console.ReadLine(), out numeroFactura[indice]);
                Console.WriteLine("Digite el monto a pagar");
                float.TryParse(Console.ReadLine(), out montoPagar[indice]);
                Comi();
                Deducido();
                Pago();
                Vuel();
                indice++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El pago ha sido agregado correctamente");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¿Desea agregar otro pago?  (s/n)");
                Console.ForegroundColor = ConsoleColor.White;
                op = Convert.ToChar(Console.ReadLine());



            } while (!op.Equals('n'));
        }

        private static void NumCaja()
        {
            int numero = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número de caja: " + numero);
                numero = (numero % 3) + 1;
                break;
            }
        }



        private static void Comi()
        {
            if (tipoServicio[indice] == 1)
            {
                comision[indice] = montoPagar[indice] *0.04;
                Console.WriteLine("Comisión autorizada: " + comision[indice]);
            }
           else if (tipoServicio[indice] == 2)
             {
                comision[indice] = montoPagar[indice] * 0.055;
                Console.WriteLine("Comisión autorizada: " + comision[indice]);
            }
            else if (tipoServicio[indice] == 3)
            {
                comision[indice] = montoPagar[indice] * 0.065;
                Console.WriteLine("Comisión autorizada: " + comision[indice]);
            }
        }


        private static void Deducido()
        {
            montoDeducido[indice]= montoPagar[indice] - comision[indice];
            Console.WriteLine("El monto deducido es: " + montoDeducido[indice]);
        }

        
        private static void Pago()
        {
            Console.WriteLine("Ingrese la cantidad con la que paga: ");
            float.TryParse(Console.ReadLine(), out pagoCliente[indice]);

            if (pagoCliente[indice] < montoPagar[indice])
            {
                Console.WriteLine("El pago no puede ser procesado, saldo insuficiente");
            }
            else
            {
                Console.WriteLine("Paga con: " + pagoCliente[indice]);
            }
        }


        private static void Vuel()
        {
            vuelto[indice] = pagoCliente[indice] - montoPagar[indice]  ;
            Console.WriteLine("Vuelto: " + vuelto[indice]);
            
        }



}//Fin del Internal class
}//Fin del namespace
