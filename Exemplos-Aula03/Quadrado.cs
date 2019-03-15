using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos_Aula03
{
    /// <summary>
    /// Representa um quadrado. Um quadrado é um poligno de quatro lados iguais.
    /// </summary>
    class Quadrado: Forma
    {
        /// <summary>
        /// A propriedade representa quanto será o lado do quadrado. 
        /// Só existe uma propriedade, pois os quatro lados serão iguais.
        /// </summary>
        /// <value>The altura.</value>
        public int Altura { get; set; }
        
        /// <summary>
        /// Construtor. A propriedade NomeForma pertencente a classe Pai Forma é atribuída.
        /// </summary>
        public Quadrado()
        {
            NomeForma = "Quadrado";
        }
        /// <summary>
        /// Imprime propriedades como Base e Altura do Triângulo.
        /// </summary>
        /// <returns>The propriedades.</returns>
        public override string Propriedades()
        {
            return $"O quadrado tem a altura e largura com o tamanho {this.Altura}";
        }
    }
}
