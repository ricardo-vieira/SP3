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

namespace SP3DAL
{
    public class EntityRepository<T> : EntityContext, IDisposable
    where T : class, new()
    {
        protected IList _bindingList;
        protected DbSet<T> _entityContext;
        protected IList<T> _detailEntityContext;
        protected object masterObject;

        private T _modifiedObject;
        public T ModifiedObject { get => _modifiedObject; }

        public EntityRepository()
        {
            PropertyInfo property = Context.GetType().GetProperty(typeof(T).Name, typeof(DbSet<T>));
            _entityContext = (DbSet<T>)property.GetValue(Context);
            _entityContext.Load();

            _bindingList = _entityContext.Local.ToBindingList();

        }

        /// <summary>
        /// Instancia o Repositório com a listagem dos objectos da classe T com base o registro mestre (mestre-detalhe)
        /// </summary>
        /// <param name="masterObject">Objeto master que contem a listagem de objetos da entidade da classe T</param>
        /// <param name="propertyDetailObject">Propriedade do objeto masterObject onde está contido a listagem do objectos da classe T</param>
        public EntityRepository(object masterObject, PropertyInfo propertyDetailObject = null)
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

        protected void InitializeMasterDetailEntity(object masterObject, PropertyInfo propertyDetailObject = null)
        {
            try
            {
                if (propertyDetailObject is null)
                {
                    int countPropertiesMasterObject = masterObject.GetType().GetProperties().Count(x => x.PropertyType.IsEquivalentTo(typeof(List<T>)));

                    if (countPropertiesMasterObject <= 0)
                        throw new Exception("Não foi encontrado nenhuma propriedade no objeto masterObject que corresponda a uma lista de objetos da classe T (" + typeof(List<T>).ToString() + "\").");

                    if (countPropertiesMasterObject > 1)
                    {
                        StringBuilder propertiesFinderMasterObject = new StringBuilder();

                        masterObject.GetType().GetProperties().Where(x => x.PropertyType.IsEquivalentTo(typeof(List<T>))).ToList().ForEach(x => { propertiesFinderMasterObject.AppendLine("Property Name: " + x.Name + " Property Type: " + x.PropertyType.ToString()); });

                        throw new Exception("Foram encontrados mais de uma propriedade no objecto masterObject que correspondem a uma lista de objectos da classe T (" + typeof(List<T>).ToString() + "\"). Caso necessário, especifique exatamente o nome da propriedade do objeto masterObject que corresponda a lista de objetos da classe T." +
                                            "\nProperties:\n" + propertiesFinderMasterObject.ToString());
                    }

                    propertyDetailObject = masterObject.GetType().GetProperties().First(x => x.PropertyType.IsEquivalentTo(typeof(List<T>)));
                }

                else
                {
                    if (propertyDetailObject.PropertyType.IsEquivalentTo(typeof(List<T>)))
                        throw new Exception("A propriedade indicada em propertyMasterObject não corresponde a uma lista do objeto T");

                    if (!masterObject.GetType().GetRuntimeProperties().Any(x => x.PropertyType.IsEquivalentTo(propertyDetailObject.PropertyType)))
                        throw new Exception("Não foi encontrado nenhuma propriedade no objecto masterObject que corresponda ao tipo indicado em propertyMasterObject");
                }

                this.masterObject = masterObject;
                this._detailEntityContext = (propertyDetailObject.GetValue(masterObject) as IList<T>);

                if (this._detailEntityContext.GetType().IsEquivalentTo(typeof(ObservableCollection<T>)))
                    _bindingList = (propertyDetailObject.GetValue(masterObject) as ObservableCollection<T>).ToBindingList();
                else
                    _bindingList = new BindingList<T>(this._detailEntityContext.ToList());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual IList GetList()
        {

            if (_bindingList is null)
            {
                BindingList<T> b = _entityContext.Local.ToBindingList();

                if (b.GetType() == typeof(BindingList<T>))
                {
                    (b as BindingList<T>).AllowEdit = false;
                    (b as BindingList<T>).AllowNew = false;
                    (b as BindingList<T>).AllowRemove = false;
                }

                _bindingList = new BindingListView<T>(b);
            }


            return _bindingList;
        }

        public virtual bool Remove(T entity)
        {
            if (_entityContext.Any(x => x.Equals(entity)))
            {
                _entityContext.Remove(entity);
                return true;
            }

            return false;
        }

        public virtual bool Add(T entity)
        {
            try
            {
                if (!_entityContext.AsEnumerable().Contains(entity) &&
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

        public virtual void ApplyFilter(Predicate<T> includeItem)
        {
            //_bindingList.ApplyFilter(includeItem);
        }

        public virtual void RemoveFilter()
        {
            //_bindingList.RemoveFilter();
        }

        public bool Commit()
        {
            if (!(_modifiedObject is null))
            {
                if (Context.Entry(_modifiedObject).State == EntityState.Added)
                {
                    _entityContext.Add(_modifiedObject);
                }

                Context.SaveChanges();
                Context.Entry(_modifiedObject).State = EntityState.Unchanged;
                return true;
            }

            return false;
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public virtual bool Change(T entity)
        {
            try
            {
                if (_entityContext.AsEnumerable().Any(x => x.Equals(entity)) &&
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

    }

    public sealed class EntityRepository<T, TViewBinding> : EntityRepository<T>
    where T : class, new()
    where TViewBinding : T, new()
    {
        private BindingSource _bindingSourceObject;
        private BindingSource BindingSourceObject { get => _bindingSourceObject; }


        public EntityRepository()
        {
            GetList();
        }

        public EntityRepository(BindingSource bindingSourceObject)
        {
            this._bindingSourceObject = bindingSourceObject;

            GetList();
        }

        public EntityRepository(BindingSource bindingSourceObject, object masterObject, PropertyInfo propertyDetailObject = null)
        {
            try
            {
                this._bindingSourceObject = bindingSourceObject;

                base.InitializeMasterDetailEntity(masterObject, propertyDetailObject);

                GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetList(BindingSource bindingSourceObject)
        {

            this._bindingSourceObject = bindingSourceObject;

            //this._entityContext.Local.Select<T, TViewBinding>(x => { return PropertyCopier<T, TViewBinding>.CopyToNewInstance(x); }).ToList();

            base._bindingList = new BindingListView<TViewBinding>(this._entityContext.Local.Select<T, TViewBinding>(x => { return PropertyCopier<T, TViewBinding>.CopyToNewInstanceChild(x); }).ToList());

            if (!(this._bindingSourceObject is null))
                this._bindingSourceObject.DataSource = base._bindingList;

            return true;
        }

        public override IList GetList()
        {
            this.GetList(_bindingSourceObject);
            return base._bindingList;
        }

        public override bool Add(T entity)
        {
            T entityOriginalType = PropertyCopier<T, TViewBinding>.CopyToNewInstanceParent((TViewBinding)entity);
            if (base.Add(entityOriginalType))
            {
                GetList();
                return true;
            }

            return false;
        }

        public override bool Remove(T entity)
        {
            T entityOriginalType = PropertyCopier<T, TViewBinding>.CopyToNewInstanceParent((TViewBinding)entity);
            if (base.Remove(entityOriginalType))
            {
                GetList();
                return true;
            }

            return false;
        }

        public override bool Change(T entity)
        {
            T entityOriginalType = PropertyCopier<T, TViewBinding>.CopyToNewInstanceParent((TViewBinding)entity);

            if (base.Change(entityOriginalType))
            {
                return true;
            }


            return false;
        }
    }

}
