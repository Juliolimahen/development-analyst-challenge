namespace CalculoQuadradoRaizQuadrada
{

    class Program
    {
        static void Main(string[] args)
        {
            CalculaQuadradoDoMenorEDoRaizMaior();
        }

        private static void CalculaQuadradoDoMenorEDoRaizMaior()
        {
            double n1, n2;

            Console.WriteLine("Informe um numero: ");
            n1 = LerNumero();

            Console.WriteLine("Informe outro numero: ");
            n2 = LerNumero();

            double maior, menor;

            MaiorEMenorValor(n1, n2, out maior, out menor);

            var quadradoDoMenor = Math.Pow(menor, 2);
            var raizQuadradaDoMenor = Math.Sqrt(maior);

            ImprimirResultado(n1, n2, quadradoDoMenor, raizQuadradaDoMenor);
        }

        private static void ImprimirResultado(double n1, double n2, double quadradoDoMenor, double raizQuadradaDoMenor)
        {
            Console.WriteLine("Valor 1: " + n1);
            Console.WriteLine("Valor 2: " + n2);
            Console.WriteLine("Quadrado do menor valor: " + quadradoDoMenor);
            Console.WriteLine("Raiz quadrada do maior valor: " + raizQuadradaDoMenor);
        }

        private static double LerNumero()
        {
            return double.Parse(Console.ReadLine());
        }

        private static void MaiorEMenorValor(double n1, double n2, out double maior, out double menor)
        {
            maior = Math.Max(n1, n2);
            menor = Math.Min(n1, n2);
        }
    }
}
