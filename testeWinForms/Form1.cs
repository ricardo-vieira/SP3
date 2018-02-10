using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeWinForms
{

    public partial class Form1 : Form
    {
        SP3DAL.EntityRepository<SP3Model.Pessoa, SP3BLL.ViewBLL.PessoasInformacoesCompletas> entity = new SP3DAL.EntityRepository<SP3Model.Pessoa, SP3BLL.ViewBLL.PessoasInformacoesCompletas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entity.GetList(this.pessoaBindingSource);

            //Teste a = new Teste();

            //ref Teste z = ref mudanca(ref a);
            //z.primeirocampo = 122;

            //a.primeirocampo.ToString();

        }

        private ref Teste mudanca(ref Teste b)
        {
            b = new Teste() { primeirocampo = 6 };

            return ref b;
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        { 
            //if (!pessoaBindingSource.IsBindingSuspended)
            //{
            //    pessoaBindingSource.SuspendBinding();
            //}
            //else
            //{
            //    pessoaBindingSource.ResumeBinding();
            //} {
          ////  entity.SaveChanges(


            entity.Add(new SP3BLL.ViewBLL.PessoasInformacoesCompletas { NOME = "primeiro teste com view" });
            entity.Commit();

            //entity.ApplyFilter(delegate (SP3DAL.Pessoa pessoa)
            //{
            //    return !(pessoa.NOME is null) && pessoa.NOME.Contains("t");
            //});

        } 

    private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
    {
        //pessoaBindingSource.RemoveAt(pessoaDataGridView.CurrentRow.Visible)
    }


        private void pessoaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void pessoaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void pessoaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
