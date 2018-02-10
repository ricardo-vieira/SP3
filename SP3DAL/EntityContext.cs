using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP3DAL
{
    public abstract class EntityContext
    {
        protected static SP3DBEntities Context = new SP3DBEntities();


    }
}
