using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SP3BLL
{
    public class ProjetoBLL
    {
        private SP3DAL.ProjetoRepository _projetoRepository = new SP3DAL.ProjetoRepository();

        public System.Collections.IList GetList()
        {
            return _projetoRepository.GetList();
        }

        public bool Add(SP3Model.Projeto projeto)
        {
            return this._projetoRepository.Add(projeto);
        }

        public bool Remove(SP3Model.Projeto projeto)
        {
            this._projetoRepository.Remove(projeto);
            return true;
        }

        public bool Filter(Predicate<SP3Model.Projeto> filtro)
        {
            _projetoRepository.ApplyFilter(filtro);
            return true;
        }

    }
}