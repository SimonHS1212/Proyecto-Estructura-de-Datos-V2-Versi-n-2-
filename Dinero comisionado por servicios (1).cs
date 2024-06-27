public static void MostrarDineroComisionadoPorServicios()
{
    double comisionElectricidad = 0;
    double comisionTelefono = 0;
    double comisionAgua = 0;
    int countElectricidad = 0;
    int countTelefono = 0;
    int countAgua = 0;


    for (int i = 1; i < indice; i++)
    {
        switch (tipoServicio[i])
        {
            case 1: // Recibo de Luz
                comisionElectricidad += comision[i];
                countElectricidad++;
                break;
            case 2: // Recibo Telefónico
                comisionTelefono += comision[i];
                countTelefono++;
                break;
            case 3: // Recibo de Agua
                comisionAgua += comision[i];
                countAgua++;
                break;
            default:
                break;
        }
    }

    // Mostrar el reporte
    Console.WriteLine("Dinero Comisionado por Servicios:");
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Recibo de Luz: {comisionElectricidad:C} - Transacciones: {countElectricidad}");
    Console.WriteLine($"Recibo Telefónico: {comisionTelefono:C} - Transacciones: {countTelefono}");
    Console.WriteLine($"Recibo de Agua: {comisionAgua:C} - Transacciones: {countAgua}");
    Console.WriteLine("---------------------------------");