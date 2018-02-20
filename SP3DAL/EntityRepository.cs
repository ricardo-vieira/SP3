using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using Equin.ApplicationFramework;
using System.Windows.Forms;
using SP3Model;
using System.Data.Entity.Core.Objects;

namespace SP3DAL
{

    public class EntityRepository<T> : EntityContext, IDisposable
    where T : class, new()
    {
        private BindingList<T> _bindingList;
        protected BindingListView<T> _bindingListResult;
        protected DbSet<T> _entityContext;

        private T _modifiedObject;
        public T ModifiedObject { get => _modifiedObject; }


        public EntityRepository()
        {
            try
            {
                PropertyInfo property = Context.GetType().GetProperty(typeof(T).Name, typeof(DbSet<T>));
                _entityContext = (DbSet<T>)property.GetValue(Context);
                _entityContext.Load();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Executa uma listagem de todas as informações presentes na entitidade
        /// </summary>
        /// <returns>Retorna um bindingList para ser atribuído a um componente de visualização de dados</returns>
        public virtual IList GetList()
        {
            try
            {
                if (_bindingList is null)
                {
                     _bindingList = _entityContext.Local.ToBindingList();

                    _bindingList.AllowEdit = false;
                    _bindingList.AllowNew = false;
                    _bindingList.AllowRemove = false;

                    _bindingListResult = new BindingListView<T>(_bindingList);
                }

                return _bindingList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Remove um objeto da entidade caso o mesmo exista na lista
        /// </summary>
        /// <param name="entity">Objeto a ser excluído</param>
        /// <returns>Verdadeiro caso o mesmo exista na listagem</returns>
        public virtual bool Remove(T entity)
        {
            try
            {
                if (_bindingList.Any(x => x.Equals(entity)))
                {
                    _bindingList.AllowRemove = true;
                    _bindingList.Remove(entity);
                    return true;
                }

                _bindingList.AllowRemove = false;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adiciona um novo objeto a lista
        /// </summary>
        /// <param name="entity">Objeto a ser incluído.</param>
        /// <returns>Verdadeiro caso o mesmo não exista na listagem</returns>
        public virtual bool Add(T entity)
        {
            try
            {
                if (!_bindingList.Contains(entity) &&
                        (!(entity is null) || Context.Entry(entity).State.Equals(EntityState.Unchanged)))
                {
                    _modifiedObject = entity;

                    Context.Entry(entity).State = EntityState.Added;
                    return true;
                }
                else
                {
                    throw new Exception("Já existe um objeto do tipo " + typeof(T).ToString() + " sendo modificado." +
                                        "Informações: " +
                                        "\n-Object: " + entity.ToString() +
                                        "\n-EntityState: " + Context.Entry(entity).State.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Concluí as modificações feitas na entidade com esta instância de Repositorio
        /// </summary>
        /// <returns>Verdadeiro se as modificações forem bem sucedidas.</returns>
        public bool Commit()
        {
            try
            {
                if (!(_modifiedObject is null))
                    GetList();

                if (Context.Entry(_modifiedObject).State == EntityState.Added)
                {
                    _bindingList.AllowNew = true;
                    _bindingList.Add(_modifiedObject);
                    _bindingList.AllowNew = false;
                }

                Context.SaveChanges();
                Context.Entry(_modifiedObject).State = EntityState.Unchanged;
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza modificações no objeto informado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Change(T entity)
        {
            try
            {
                if (_bindingList.Any(x => x.Equals(entity)) &&
                        (!(entity is null) || Context.Entry(entity).State.Equals(EntityState.Unchanged)))
                {
                    _modifiedObject = entity;
                    Context.Entry(entity).State = EntityState.Modified;
                    return true;
                }
                else
                    throw new Exception("Já existe um objeto do tipo " + typeof(T).ToString() + " sendo modificado." +
                    "Informações: " +
                    "\n-Object: " + entity.ToString() +
                    "\n-EntityState: " + Context.Entry(entity).State.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public virtual void ApplyFilter(Predicate<T> predicate)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void RemoveFilter()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }

    public sealed class EntityRepository<T, TView> : EntityRepository<T>
    where T : class, new()
    where TView : T, new()
    {
        private BindingSource _bindingSourceObject;
        private BindingSource BindingSourceObject { get => _bindingSourceObject; }

        private IList _bindingListView;

        public EntityRepository(BindingSource bindingSourceObject)
        {
            this._bindingSourceObject = bindingSourceObject;
        }

        public IList GetList(BindingSource bindingSourceObject)
        {
            try
            {
                this._bindingSourceObject = bindingSourceObject;
                return GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override IList GetList()
        {
            try
            {
                //bindingListView = new BindingListView<TView>(this._entityContext.Local.Select<T, TViewBinding>(x => { return PropertyCopier<T, TViewBinding>.CopyToNewInstanceChild(x); }).ToList());
                this._bindingListView = new BindingListView<TView>(base._bindingListResult.Select<T, TView>(x => { return PropertyCopier<T, TView>.CopyToNewInstanceChild(x); }).ToList());

                if (!(this._bindingSourceObject is null))
                    this._bindingSourceObject.DataSource = this._bindingListView;

                return this._bindingListView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Add(T entity)
        {
            try
            {
                if (base.Add(ConvertChildToParent(entity)))
                {
                    GetList();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Remove(T entity)
        {
            try
            {
                if (base.Remove(ConvertChildToParent(entity)))
                {
                    GetList();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Change(T entity)
        {
            try
            {

                if (base.Change(ConvertChildToParent(entity)))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Converte um objeto herdado para o tipo original
        /// </summary>
        /// <param name="entity">child object </param>
        /// <returns>parentObject</returns>
        private T ConvertChildToParent(T entity)
        {
            try
            {
                T entityOriginalType;

                if (entity.GetType() == typeof(T))
                    entityOriginalType = entity;
                else
                    entityOriginalType = PropertyCopier<T, TView>.CopyToNewInstanceParent((TView)entity);

                return entityOriginalType;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    public class EntityDetailRepository<T, TMaster> : EntityRepository<T>
    where T : class, new()
    where TMaster : class, new()
    {
        protected IList<T> _detailEntityContext;
        private PropertyInfo propertyDetailObject;

        protected TMaster masterObject;

        /// <summary>
        /// Instancia o Repositório com a listagem dos objectos da classe T com base o registro mestre (mestre-detalhe)
        /// </summary>
        /// <param name="masterObject">Objeto master que contem a listagem de objetos da entidade da classe T</param>
        /// <param name="propertyDetailObject">Propriedade do objeto masterObject onde está contido a listagem do objectos da classe T</param>
        public EntityDetailRepository(object masterObject, PropertyInfo propertyDetailObject = null)
        {
            try
            {
                InitializeMasterDetailEntity(masterObject, propertyDetailObject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitializeMasterDetailEntity(object masterObject, PropertyInfo propertyDetailObject = null)
        {
            try
            {
                if (masterObject.GetType() == typeof(TMaster))
                {
                    this.masterObject = (masterObject as TMaster);
                }
                else if (masterObject.GetType() == typeof(ObjectView<TMaster>))
                {
                    this.masterObject = (masterObject as ObjectView<TMaster>).Object;
                }
                else if (ObjectContext.GetObjectType(masterObject.GetType()) == typeof(TMaster))
                {
                    this.masterObject = (masterObject as TMaster);
                }
                else
                {
                    throw new Exception("O objecto informado no parâmetro masterObject não corresponde com os tipos compativeis: " + typeof(TMaster).ToString() + ", " + typeof(ObjectView<TMaster>).ToString());
                }


                if (propertyDetailObject is null)
                {

                    int countPropertiesMasterObject = this.masterObject.GetType().GetProperties().Count(x => x.PropertyType.GetInterfaces().Contains(typeof(IList<T>)));

                    if (countPropertiesMasterObject <= 0)
                        throw new Exception("Não foi encontrado nenhuma propriedade no objeto masterObject que corresponda a uma lista de objetos da classe T (" + typeof(IList<T>).ToString() + "\").");

                    if (countPropertiesMasterObject > 1)
                    {
                        StringBuilder propertiesFinderMasterObject = new StringBuilder();

                        this.masterObject.GetType().GetProperties().Where(x => x.PropertyType.IsEquivalentTo(typeof(List<T>))).ToList().ForEach(x => { propertiesFinderMasterObject.AppendLine("Property Name: " + x.Name + " Property Type: " + x.PropertyType.ToString()); });

                        throw new Exception("Foram encontrados mais de uma propriedade no objecto masterObject que correspondem a uma lista de objectos da classe T (" + typeof(List<T>).ToString() + "\"). Caso necessário, especifique exatamente o nome da propriedade do objeto masterObject que corresponda a lista de objetos da classe T." +
                                            "\nProperties:\n" + propertiesFinderMasterObject.ToString());
                    }
                    this.propertyDetailObject = propertyDetailObject;

                    this.propertyDetailObject = this.masterObject.GetType().GetProperties().First(x => x.PropertyType.GetInterfaces().Contains(typeof(IList<T>)));
                }

                else
                {
                    if (this.propertyDetailObject.PropertyType.GetInterfaces().Contains(typeof(IList<T>)))
                        throw new Exception("A propriedade indicada em propertyMasterObject não corresponde a uma lista do objeto T");

                    if (!this.masterObject.GetType().GetRuntimeProperties().Any(x => x.PropertyType.IsEquivalentTo(this.propertyDetailObject.PropertyType)))
                        throw new Exception("Não foi encontrado nenhuma propriedade no objecto masterObject que corresponda ao tipo indicado em propertyMasterObject");
                }

                this._detailEntityContext = (IList<T>)propertyDetailObject.GetValue(this.masterObject);

                if (this._detailEntityContext.GetType().BaseType.Equals(typeof(ObservableCollection<T>)))
                    _bindingListResult = new BindingListView<T>((propertyDetailObject.GetValue(this.masterObject) as ObservableCollection<T>).ToBindingList());
                else
                    _bindingListResult = new BindingListView<T>(this._detailEntityContext.ToList());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  override IList GetList()
        {
            try
            {
                this._detailEntityContext = (IList<T>)propertyDetailObject.GetValue(this.masterObject);

                if (this._detailEntityContext.GetType().BaseType.Equals(typeof(ObservableCollection<T>)))
                    base._bindingListResult = new BindingListView<T>((propertyDetailObject.GetValue(this.masterObject) as ObservableCollection<T>).ToBindingList());
                else
                    base._bindingListResult = new BindingListView<T>(this._detailEntityContext.ToList());

                return base._bindingListResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Add(T entity)
        {
            try
            {
                if (!(entity is null))
                {
                    if (getValueMasterObject(entity) is null)
                        setValueMasterObject(entity, masterObject);

                    return base.Add(entity);
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TMaster getValueMasterObject(T entity)
        {
            try
            {
                PropertyInfo propertyMasterValue = entity.GetType().GetProperties().First(x => x.GetType() == typeof(TMaster));

                if (propertyMasterValue is null)
                    throw new Exception("Não foi encontrado a propriedade correspondente a informação do registro pai no objeto.");

                return (TMaster) propertyMasterValue.GetValue(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool setValueMasterObject(T entity, TMaster masterEntity)
        {
            try
            {
                PropertyInfo propertyMasterValue = entity.GetType().GetProperties().First(x => x.GetType() == typeof(TMaster));

                if (propertyMasterValue is null)
                    throw new Exception("Não foi encontrado a propriedade correspondente a informação do registro pai no objeto.");

                propertyMasterValue.SetValue(masterObject, masterEntity);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public sealed class EntityDetailRepository<T, TMaster, TView> : EntityDetailRepository<T, TMaster>
    where T : class, new()
    where TMaster : class, new()
    where TView : T, new()
    {
        private BindingSource _bindingSourceObject;
        private BindingSource BindingSourceObject { get => _bindingSourceObject; }

        private IList _bindingListView;

        public EntityDetailRepository(object masterObject, PropertyInfo propertyDetailObject = null) : base(masterObject, propertyDetailObject)
        {
        }

        public IList GetList(BindingSource bindingSourceObject)
        {
            try
            {
                this._bindingSourceObject = bindingSourceObject;
                return GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override IList GetList()
        {
            try
            {
                base.GetList();

                //bindingListView = new BindingListView<TView>(this._entityContext.Local.Select<T, TViewBinding>(x => { return PropertyCopier<T, TViewBinding>.CopyToNewInstanceChild(x); }).ToList());
                this._bindingListView = new BindingListView<TView>(base._bindingListResult.Select<T, TView>(x => { return PropertyCopier<T, TView>.CopyToNewInstanceChild(x); }).ToList());

                if (!(this._bindingSourceObject is null))
                    this._bindingSourceObject.DataSource = this._bindingListView;

                return this._bindingListView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Add(T entity)
        {
            try
            {
                if (base.Add(ConvertChildToParent(entity)))
                {
                    GetList();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Remove(T entity)
        {
            try
            {
                if (base.Remove(ConvertChildToParent(entity)))
                {
                    GetList();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Change(T entity)
        {
            try
            {

                if (base.Change(ConvertChildToParent(entity)))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Converte um objeto herdado para o tipo original
        /// </summary>
        /// <param name="entity">child object </param>
        /// <returns>parentObject</returns>
        private T ConvertChildToParent(T entity)
        {
            try
            {
                T entityOriginalType;

                if (entity.GetType() == typeof(T))
                    entityOriginalType = entity;
                else
                    entityOriginalType = PropertyCopier<T, TView>.CopyToNewInstanceParent((TView)entity);

                return entityOriginalType;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
