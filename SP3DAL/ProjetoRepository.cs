using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP3DAL
{
    public class ProjetoRepository: EntityRepository<SP3Model.Projeto>
    {
        private ProjetoPessoaRepository _projetoPessoaContext = new ProjetoPessoaRepository();
    }
}
