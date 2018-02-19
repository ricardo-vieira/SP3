using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SP3View.Cadastro
{
    public partial class FrmCadastroProjeto : Form
    {
        SP3BLL.ProjetoBLL projetoBLL;
        SP3BLL.ProjetoPessoaBLL projetoPessoaBLL;
        public SP3Model.Projeto projetoFilter;

        public FrmCadastroProjeto()
        {
            InitializeComponent();
        }

        private void FrmCadastroProjeto_Load(object sender, EventArgs e)
        {
            projetoBLL = new SP3BLL.ProjetoBLL();
            bsProjeto.DataSource = projetoBLL.GetList();

            projetoPessoaBLL = new SP3BLL.ProjetoPessoaBLL(this.bsProjetoPessoa, bsProjeto.Current);
        }


        private void CarregarInformacoes(int position = -1)
        {
            if (position >= 0)
                bsProjeto.Position = position;

            projetoPessoaBLL = new SP3BLL.ProjetoPessoaBLL(bsProjetoPessoa, bsProjeto.Current);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strCodigo = Interaction.InputBox("Informe o código do projeto", "Código", "");
            Int64 codigo = 0;

            if (Int64.TryParse(strCodigo,out codigo))
            {
                int position = bsProjeto.Find("ID", codigo);

                if (position >= 0)
                {
                    CarregarInformacoes(position);
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum elemento com o código informado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
