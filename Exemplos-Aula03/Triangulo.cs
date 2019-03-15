using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos_Aula03
{
    /// <summary>
    /// Representa um Triangulo Reto.
    /// </summary>
    class Triangulo : Forma
    {
        //Altura do Triangulo
        public int Altura { get; set; }
        //Base do Triangulo.
        public int Largura { get; set; }

        //Construtor. A propriedade NomeForma pertencente a classe Pai Forma é atribuída.
        public Triangulo()
        {
            NomeForma = "Triângulo";
        }

        //Imprime propriedades como Base e Altura do Triângulo.
        public override string Propriedades()
        {
            return $"Este é um triângulo reto cuja base tem o valor {this.Largura} e cuja altura é {this.Altura}";
        }
    }
}
