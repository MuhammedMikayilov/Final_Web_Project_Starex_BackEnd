using Buisness.Abstract;
using DataAccess.Abstract;
using Entity.Entities.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concret
{
    public class NewsDetailManager : INewsDetailService
    {
        private readonly INewsDetailDal _context;

        public NewsDetailManager(INewsDetailDal context)
        {
            _context = context;
        }
        public List<NewsDetail> GetAll()
        {
            return _context.GetAll();
        }

        public NewsDetail GetWithId(int id)
        {
            return _context.Get(nd=>nd.Id == id);
        }
        public void Add(NewsDetail data)
        {
            _context.Add(data);
        }

        public void Delete(int id)
        {
            _context.Delete(new NewsDetail { Id = id });
        }


        public void Update(NewsDetail data)
        {
            _context.Update(data);
        }
    }
}
