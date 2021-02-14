using Core.Repository;
using Entity.Entities.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface INewsDetailDal: IEntityRepository<NewsDetail>
    {
    }
}
