using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP3DAL
{
    public static class PropertyCopier<TParent, TChild> 
    where TParent : class, new()
    where TChild : TParent, new()
    {
        public static void Copy(TParent parent, TChild child)
        {
            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();
            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(child, parentProperty.GetValue(parent));
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Cria uma nova instância de objeto da classe filha e a retorna.
        /// </summary>
        /// <param name="parent">Objeto da classe pai no qual serão copiados as suas propriedades para o objeto da classe filho</param>
        /// <returns></returns>
        public static TChild CopyToNewInstanceChild(TParent parent)
        {
            var child = new TChild();

            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();
            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(child, parentProperty.GetValue(parent));
                        break;
                    }
                }
            }

            return child;
        }

        public static TParent CopyToNewInstanceParent(TChild child)
        {
            var parent = new TParent();

            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();

            foreach (var childProperty in childProperties)
            {
                foreach (var parentProperty in parentProperties)
                {
                    if (childProperty.Name == parentProperty.Name && childProperty.PropertyType == parentProperty.PropertyType)
                    {
                        parentProperty.SetValue(parent, childProperty.GetValue(child));
                        break;
                    }
                }
            }

            return parent;
        }
    }

}
