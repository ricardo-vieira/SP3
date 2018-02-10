using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace SP3BLL.ViewBLL
{
    public sealed class ProjetosInformacoesCompletas : SP3Model.Projeto
    {
        public IList<SP3BLL.ViewBLL.ProjetosPessoasInformacoesCompletas> ProjetosPessoas { get {
                new BindingList<SP3BLL.ViewBLL.ProjetosPessoasInformacoesCompletas>().
            } }
    }
}