using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SP3BLL.ViewBLL
{
    public sealed class ProjetosPessoasInformacoesCompletas : SP3Model.ProjetoPessoa
    {
        public string NomePessoa { get { return base.Pessoa.NOME; } }
    }
}