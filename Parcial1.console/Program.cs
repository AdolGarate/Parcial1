namespace Parcial1.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadCilindros = 0;

            while (true)
            {
                double radio = ObtenerValorNumericoPositivo("Ingrese el radio del cilindro: ");
                double altura = ObtenerValorNumericoPositivo("Ingrese la altura del cilindro: ");

                if (radio == 0 && altura == 0)
                    break;

                double area = CalcularArea(radio, altura);
                double volumen = CalcularVolumen(radio, altura);

                Console.WriteLine("area: " + area);
                Console.WriteLine("Volumen: " + volumen);

                CantidadCilindros++;

                Console.WriteLine("====");
            }
            Console.WriteLine("Se ingresaron " + CantidadCilindros + " cilindros.");
        }
        static double ObtenerValorNumericoPositivo(string Mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(Mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                    break;
                else
                    Console.WriteLine("Valor invalido. Ingrese un numero positivo.");
            }
            return valor;
        }
        static double CalcularArea(double radio, double altura)
        {
            double BaseCilindro = Math.PI * Math.Pow(radio, 2);
            double area = 2 * Math.PI * radio * (altura + radio);
            return area;

        }
        static double CalcularVolumen(double BaseCilindro, double altura)
        {
            double volumen = BaseCilindro * altura;
            return volumen;
        }
    }
}