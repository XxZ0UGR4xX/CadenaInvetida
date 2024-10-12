namespace InvertirCadena
{
    internal class Program
    {

        class Programa
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Programa para invertir una cadena");
                Console.WriteLine("Ingresa una cadena de texto");
                String cadena = Console.ReadLine();

                string cadenaInvertida = InvertirCadena(cadena);

                Console.WriteLine("Cadena Invertida {0}", cadenaInvertida);
            }

            private static string InvertirCadena(string cadena)
            {
                char[] caracteres = cadena.ToCharArray();
                string cadenaConvertida = "";
                for (int i = cadena.Length - 1; i >= 0; i--)
                {
                    cadenaConvertida += caracteres[i];
                }
                return cadenaConvertida;
            }

        }

    }
}