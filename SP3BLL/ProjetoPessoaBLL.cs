using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP3BLL
{
    public class ProjetoPessoaBLL
    {
        private SP3DAL.EntityDetailRepository<SP3Model.ProjetoPessoa, SP3Model.Projeto, SP3Model.View.ProjetosPessoasInformacoesCompletas> _projetoPessoaRepository;

        public ProjetoPessoaBLL(BindingSource bindingSource, object masterObject)
        {
            _projetoPessoaRepository = new SP3DAL.EntityDetailRepository<SP3Model.ProjetoPessoa, SP3Model.Projeto, SP3Model.View.ProjetosPessoasInformacoesCompletas>(bindingSource, masterObject);
        }

        public System.Collections.IList GetList()
        {
            return this._projetoPessoaRepository.GetList();
        }

        public bool Add(SP3Model.ProjetoPessoa projetoPessoa)
        {
            return this._projetoPessoaRepository.Add(projetoPessoa);
        }

        public bool Remove(SP3Model.ProjetoPessoa projetoPessoa)
        {
            return this._projetoPessoaRepository.Remove(projetoPessoa);
        }

        public bool Filter(Predicate<SP3Model.ProjetoPessoa> filtro)
        {
            _projetoPessoaRepository.ApplyFilter(filtro);
            return true;
        }

    }
}
