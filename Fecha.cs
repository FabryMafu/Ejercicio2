public class Fecha
{
    private int dia;
    private int mes;
    private int anio;

    public Fecha(int dia, int mes, int anio)
    {
        this.dia = dia;
        this.mes = mes;
        this.anio = anio;
    }

    public static Fecha obtenerFechaActual()
    {
        DateTime fechaActual = DateTime.Now;
        return new Fecha(fechaActual.Day, fechaActual.Month, fechaActual.Year);
    }

    public bool esIgual(Fecha otraFecha)
    {
        return this.dia == otraFecha.dia && this.mes == otraFecha.mes;
    }

    public void esTuCumpleaños()
    {
        Fecha fechaActual = Fecha.obtenerFechaActual();
        if (this.esIgual(fechaActual))
        {
            Console.WriteLine("¡Feliz cumpleaños!");
        }
        else
        {
            Console.WriteLine("Hoy no es tu cumpleaños.");
        }
    }
}