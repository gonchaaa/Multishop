using Multishop.Core.DataAccess;
using Multishop.Core.DataAccess.EntityFramework;
using Multishop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Abstract
{
    public interface ICategoryDal : IRepostoryBase<Category>
    {
        void DeleteAll();
    }
}
