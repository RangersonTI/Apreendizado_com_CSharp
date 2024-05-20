
namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = 5;
            int n2 = 2147483647;  // Tamanho maximo da variável int - 32 bit
            long l3 = 2147483648l;  // variavel int tammanho maior - 64 bit
            bool tf = n2 == n;
            char genero = 'M';
            char genero_codunicode = '\u0042'; // variavel recebendo caracter unico por cod. unicode

            float f = 4.5f;  // Variavel tipo float (ponto flutuante) deve-se adicionar um f após declaracão
                             // do valor. Possui um tamnho de 32 bit

            double d = 4.5;  // Variavel tipo double (ponto flutuante) Possui um tamnho de 64 bit

            string palavra = "Dennis";

            object obj = "paullo";  // Tipo objeto: tipo generico de variável...
                                    // Pode receber qualquer tipo, desde sbyte, até string e booleano
            object obj2 = 4.5;
            object obj3 = true;

            Console.WriteLine("Sbyte: "+n);
            Console.WriteLine("Inteiro: "+n2);
            Console.WriteLine("Long: "+l3);
            Console.WriteLine("Booleano: "+tf);
            Console.WriteLine("\nChar: "+genero);
            Console.WriteLine(""+genero_codunicode);
            Console.WriteLine("\nFloat: "+f);
            Console.WriteLine("Double: "+d);
            Console.WriteLine("String: "+palavra);
            Console.WriteLine("\nObjeto: "+obj);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);

            int minInt = int.MinValue;
            int maxInt = int.MaxValue;

            Console.WriteLine("Valor minimo Int: " + minInt);
            Console.WriteLine("Valor maximo Int: " + maxInt);
        }
    }
}

