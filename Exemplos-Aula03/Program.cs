using System;

namespace Exemplos_Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um array de Números.
            int[] a = { 8, 3, 4, 1, 10, 2, 7 };
            //Ordena os números
            Ordenar(a);
            //Imprime cada um dos números.
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            //Cria Pessoas
            var pessoas = CriarPessoas();
            //Ordena por Idade
            OrdenarPessoas(pessoas);
            //Imprime Pessoas
            for (int i = 0; i < pessoas.Length; i++)
            {
                 Console.WriteLine(pessoas[i]);
            }
            Console.ReadKey();

            //Desenhar Formas.

            DesenharFormas();
            Console.ReadKey();
        }

        private static void DesenharFormas()
        {
            EditorGrafico eG = new EditorGrafico();
            Triangulo t = new Triangulo() { Largura = 5, Altura = 6 };
            eG.DesenharTriangulo(t);
            Quadrado q = new Quadrado() { Altura = 6 };
            eG.DesenharQuadrado(q);
        }

        private static Pessoa[] CriarPessoas()
        {
            Pessoa[] pessoas = new Pessoa[]{
                new Pessoa() { Nome = "Alex",
                    Nascimento = new DateTime(1983, 12, 15) },
                new Pessoa() { Nome = "Rodrigo",
                    Nascimento = new DateTime(1987, 12, 24) }
                ,
                new Pessoa() { Nome = "Walter",
                    Nascimento = new DateTime(1954, 02, 08) }
            };
            return pessoas;
        }


        private static void OrdenarPessoas(Pessoa[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Pessoa menorNumero = a[i];
                int indexMenorNumero = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j].Nascimento < menorNumero.Nascimento)
                    {
                        menorNumero = a[j];
                        indexMenorNumero = j;
                    }
                }
                Pessoa aux = a[i];
                a[i] = menorNumero;
                a[indexMenorNumero] = aux;
            }
        }

        private static void Ordenar(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int menorNumero = a[i];
                int indexMenorNumero = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < menorNumero)
                    {
                        menorNumero = a[j];
                        indexMenorNumero = j;
                    }
                }
                int aux = a[i];
                a[i] = menorNumero;
                a[indexMenorNumero] = aux;
            }
        }
    }

}
