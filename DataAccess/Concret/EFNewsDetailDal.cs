using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entity.Entities.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concret
{
    public class EFNewsDetailDal: EFEntityRepositoryBase<NewsDetail, AppDbContext>, INewsDetailDal
    {
    }
}
