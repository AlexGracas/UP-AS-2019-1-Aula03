using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos_Aula03
{
    /// <summary>
    /// Uma classe abstrata é uma classe que não tem o objetivo de ser instanciado.
    /// Este tipo de classe tem como foco ter algumas regras genéricas para serem utilizados 
    /// no seu código.
    /// As classes que herdarem de forma irão herdar a propriedade NomeForma e 
    /// deverão obrigatoriamente implementar a operação Propriedade.
    /// Para ler mais:
    ///  https://www.caelum.com.br/apostila-csharp-orientacao-objetos/classes-abstratas/
    ///  http://www.macoratti.net/12/06/c_caip1.htm
    /// </summary>
    abstract class Forma
    {
        public virtual String NomeForma { get; protected set; }

        public abstract String Propriedades();
    }
}
