using Buisness.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class AboutManager :IAboutService
    {
        private readonly IAboutDAL _context;

        public AboutManager(IAboutDAL context)
        {
            _context = context;
        }

        public List<About> GetAll()
        {
            return _context.GetAll();
        }

        public About GetWithId(int id)
        {
            return _context.Get(c => c.Id == id);
        }

        public void Add(About data)
        {
            _context.Add(data);
        }

        public void Delete(int id)
        {
            _context.Delete(new About { Id = id });
        }

        public void Update(About data)
        {
            _context.Update(data);
        }
    }
}
