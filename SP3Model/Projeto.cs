//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP3Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projeto()
        {
            this.ProjetoPessoa = new ObservableListSource<ProjetoPessoa>();
        }
    
        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public string OBSERVACAO { get; set; }
        public Nullable<long> IDGERENTE { get; set; }
        public Nullable<System.DateTime> DATACRIACAO { get; set; }
        public Nullable<decimal> INVESTIMENTOPREVISTO { get; set; }
        public Nullable<decimal> RECEITACONSTANTE { get; set; }
        public Nullable<decimal> RAZAORECEITAVALOR { get; set; }
        public Nullable<decimal> RAZAORECEITAPERCENTUAL { get; set; }
        public Nullable<long> TEMPOPREVISTOCONCLUSAODIAS { get; set; }
        public Nullable<byte> STATUS { get; set; }
        public Nullable<int> CAPACIDADEENTREGAEQUIPE { get; set; }
        public Nullable<int> APOIOALTAGESTAO { get; set; }
        public Nullable<int> APOIOSTEAKHOLDERS { get; set; }
        public Nullable<int> ESFORCOADICIONAL { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ProjetoPessoa> ProjetoPessoa { get; set; }
    }
}
