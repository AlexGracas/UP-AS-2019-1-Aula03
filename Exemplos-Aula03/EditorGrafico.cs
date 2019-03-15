using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos_Aula03
{
    /// <summary>
    /// Classe responsável por desenhar as formas existentes.
    /// </summary>
    class EditorGrafico
    {
        /// <summary>
        /// Operação com três passos.
        /// Imprimir o nome da Forma.
        /// Desenhar a Forma.
        /// Imprimir as suas Propriedades.
        /// </summary>
        /// <param name="t">T.</param>
        public void DesenharTriangulo(Triangulo t)
        {
            //Imprime no console o nome da forma.
            Console.WriteLine($"Isto é um {t.NomeForma}");
            //Pula uma linha para garantir que irã imprimir a forma em uma linha em branco.
            Console.WriteLine();
            //Desenhar a forma em sí.
            for (int i = 0; i < t.Altura; i++)
            {
                for (int j = 0; j < i+1 && j < t.Largura; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            //Imprimir propriedades da forma como base, largura, altura, etc...
            Console.WriteLine(t.Propriedades());
        }


        /// <summary>
        /// Operação com três passos.
        /// Imprimir o nome da Forma.
        /// Desenhar a Forma.
        /// Imprimir as suas Propriedades.
        /// </summary>
        /// <param name="t">T.</param>
        public void DesenharQuadrado(Quadrado q)
        {
            //Imprime no console o nome da forma.
            Console.WriteLine($"Isto é um {q.NomeForma}");
            //Pula uma linha para garantir que irã imprimir a forma em uma linha em branco.
            Console.WriteLine();
            //Desenhar a forma em sí.
            for (int i = 0; i < q.Altura; i++)
            {
                for (int j = 0; j < q.Altura; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            //Imprimir propriedades da forma como base, largura, altura, etc...
            Console.WriteLine(q.Propriedades());
        }
    }
}
