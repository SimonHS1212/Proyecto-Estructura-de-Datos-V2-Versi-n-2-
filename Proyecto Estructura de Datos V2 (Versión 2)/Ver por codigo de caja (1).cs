
        public static void MostrarPagosPorCodigoCaja(int codigoCaja)
        {
            Console.WriteLine($"Mostrando pagos para el código de caja {codigoCaja}:");
            Console.WriteLine("-------------------------------------------------------");

            for (int i = 1; i < indice; i++)
            {
                if (numeroCaja[i] == codigoCaja)
                {
                    Console.WriteLine($"Número de Pago: {numeroPago[i]}");
                    Console.WriteLine($"Fecha: {fecha[i]}");
                    Console.WriteLine($"Hora: {hora[i]}");
                    Console.WriteLine($"Cédula: {cedula[i]}");
                    Console.WriteLine($"Nombre: {nombre[i]}");
                    Console.WriteLine($"Primer Apellido: {apellido1[i]}");
                    Console.WriteLine($"Segundo Apellido: {apellido2[i]}");
                    Console.WriteLine($"Número de Caja: {numeroCaja[i]}");
                    Console.WriteLine($"Tipo de Servicio: {tipoServicio[i]}");
                    Console.WriteLine($"Número de Factura: {numeroFactura[i]}");
                    Console.WriteLine($"Monto a Pagar: {montoPagar[i]:C}");
                    Console.WriteLine($"Comisión: {comision[i]:C}");
                    Console.WriteLine($"Monto Deducido: {montoDeducido[i]:C}");
                    Console.WriteLine($"Monto Paga Cliente: {pagoCliente[i]:C}");
                    Console.WriteLine($"Vuelto: {vuelto[i]:C}");
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
        }


