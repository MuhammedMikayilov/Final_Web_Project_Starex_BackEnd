using Entity.Entities.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface INewsService
    {
        News GetWithId(int id);
        List<News> GetAll();
        void Add(News data);
        void Update(News data);
        void Delete(int id);
    }
}
