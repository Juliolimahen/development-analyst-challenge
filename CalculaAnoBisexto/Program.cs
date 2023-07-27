namespace CalculaAnoBisexto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculaBisexto();
        }

        public static void CalculaBisexto()
        {
            Console.WriteLine("Digite o ano em nasceu: ");
            int ano = LerAno();
            bool bissexto = VerificaSeEhBisexto(ano);
            ImprimirResultado(ano, bissexto);
        }

        private static void ImprimirResultado(int ano, bool bissexto)
        {
            Console.WriteLine("{0} {1} um ano bissexto!", ano, bissexto ? "é" : "não é");
        }

        private static bool VerificaSeEhBisexto(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
        }

        private static int LerAno()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
