using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace testeWinForms
{
    public class Teste
    {
        public int primeirocampo =12;
    }

    public class TesteFilho : Teste
    {

        public string PrimeiroCampo { get => "Meu numero é 12"; }
    }
}